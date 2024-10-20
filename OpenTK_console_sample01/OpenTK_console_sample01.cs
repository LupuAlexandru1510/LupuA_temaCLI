using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Platform;

namespace OpenTK_console_sample01
{
    class SimpleWindow : GameWindow
    {

        private float posX = 0.0f; // Poziția pe axa X a triunghiului
        private float posY = 0.0f; // Poziția pe axa Y a triunghiului

        public SimpleWindow() : base(800, 600)
        {
            KeyDown += Keyboard_KeyDown;
            MouseMove += Mouse_Move;
        }

        // Tratează evenimentul generat de apăsarea unei taste.
        void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Exit();

            // Comutarea între fullscreen și normal
            if (e.Key == Key.F11)
                if (this.WindowState == WindowState.Fullscreen)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Fullscreen;

            // Controlul pe axa Y
            if (e.Key == Key.W)
                posY += 0.1f; // Mută triunghiul în sus
            if (e.Key == Key.S)
                posY -= 0.1f; // Mută triunghiul în jos

            // Controlul pe axa X
            if (e.Key == Key.A)
                posX -= 0.1f; // Mută triunghiul la stânga
            if (e.Key == Key.D)
                posX += 0.1f; // Mută triunghiul la dreapta
        }

        // Tratează mișcarea mouse-ului pentru a controla poziția triunghiului
        void Mouse_Move(object sender, MouseMoveEventArgs e)
        {
            // Coordonatele mouse-ului sunt transformate pentru a se potrivi cu spațiul [-1, 1] din OpenGL
            posX = (float)e.X / Width * 2.0f - 1.0f;
            posY = -((float)e.Y / Height * 2.0f - 1.0f); // Inversăm Y-ul pentru că în OpenGL, Y crește în sus
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            // Logică de actualizare a poziției poate fi adăugată aici
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            // Selectăm matricea Modelview pentru a aplica transformări pe triunghi
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            // Translația triunghiului pe baza poziției calculate (din taste și mouse)
            GL.Translate(posX, posY, 0.0f);

            // Începem desenarea triunghiului
            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(Color.MidnightBlue);
            GL.Vertex2(-0.1f, 0.1f); // Colțul stânga sus
            GL.Color3(Color.SpringGreen);
            GL.Vertex2(0.0f, -0.1f); // Colțul jos mijloc
            GL.Color3(Color.Ivory);
            GL.Vertex2(0.1f, 0.1f); // Colțul dreapta sus

            GL.End();
            // Sfârșitul modului imediat!

            this.SwapBuffers();
        }

        [STAThread]
        static void Main(string[] args)
        {
            using (SimpleWindow example = new SimpleWindow())
            {
                example.Run(30.0, 0.0);
            }
        }
    }
}