Excercitiul1:
 GL.Ortho(-8.0, 4.0, -4.0, 1.0, 0.0, 4.0);
 Am modificat urmatoarele coordonate si dupa ce am dat run triunghiul s a translatat si s-a inversat pe axa oy.
Exercitiul3:
1)Un viewport reprezintă zona vizibilă a unei pagini web pe ecranul unui dispozitiv, fiind fereastra prin care utilizatorul poate vizualiza conținutul site-ului.
2)Conceptul de frames per second (FPS) în contextul bibliotecii OpenGL se referă la numărul de cadre (imagini) pe care o aplicație grafică le afișează pe ecran în fiecare secundă. FPS-ul este un indicator al performanței aplicației și arată cât de fluid este redat conținutul grafic în timp real.O randare mai bună a cadrelor este obținută dacă creștem numărul de FPS-uri(numărul de cadre pe secundă).
3)Metoda OnUpdateFrame() este apelată în cadrul fiecărui ciclu al unei aplicații înainte ca un nou cadru (imagine) să fie afișat pe ecran. Scopul acestei metode este să actualizeze toate aspectele logice ale jocului sau aplicației, adică să pregătească tot ce se întâmplă "în spatele scenei" înainte ca utilizatorul să vadă schimbările.
4)Modul imediat de randare (în engleză Immediate Mode Rendering) este o metodă folosită în versiunile timpurii ale bibliotecii OpenGL pentru a desena obiecte pe ecran. În acest mod, aplicația furnizează direct informațiile geometrice (cum ar fi vârfurile unui triunghi sau pătrat), iar fiecare apel de funcție OpenGL trimite imediat aceste date către unitatea de procesare grafică (GPU), care le procesează și le redă pe ecran.
5)Ultima versiune de OpenGL care acceptă complet modul imediat de randare (Immediate Mode Rendering) este OpenGL 3.2, dar numai în profilul compatibilitate (compatibility profile).
6)Metoda OnRenderFrame() este folosită într-o aplicație grafică care folosește OpenGL pentru a desena un nou cadru pe ecran. Aceasta este apelată după ce s-au făcut actualizările necesare ale jocului sau aplicației în metoda OnUpdateFrame(). Practic, OnRenderFrame() are rolul de a trimite informațiile către placa grafică (GPU) pentru a arăta ce trebuie să vedem pe ecran.
7)Metoda OnResize() este foarte importantă într-o aplicație grafică care folosește OpenGL, deoarece se ocupă cu ajustarea dimensiunii ferestrei prin care vedem conținutul grafic. Este necesar ca această metodă să fie apelată cel puțin o dată din mai multe motive cum ar fi ajustarea dimensiunii ferestrei de vizualizare,corectarea raportului de aspect precum si actualizarea proiectiei.
8)Metoda CreatePerspectiveFieldOfView() este utilizată în cadrul aplicațiilor grafice, în special în OpenGL, pentru a crea o matrice de proiecție în perspectivă. Această matrice determină modul în care scena 3D este redată pe ecran, influențând aspectul adâncimii și perspectivei. Parametrii acestei metode sunt esențiali pentru definirea caracteristicilor proiecției.
Parametrii metodei CreatePerspectiveFieldOfView()
FOV (Field of View):
Descriere: Acesta este un unghi (în radiani sau grade) care determină cât de multă scenă este vizibilă. Un FOV mai mare oferă un unghi de vedere mai larg, ceea ce poate face scena să pară mai vastă, dar poate duce la distorsionarea imaginilor. Un FOV mai mic concentrează scena, dar poate face obiectele să pară mai apropiate.
Domeniu de valori: De obicei, FOV este specificat în grade și are o valoare comună între 30 și 90 de grade, dar poate fi ajustat în funcție de necesități. Totuși, valori extrem de mari sau foarte mici (de exemplu, sub 1 grad sau peste 120 de grade) pot duce la distorsiuni.
Aspect Ratio:
Descriere: Acesta reprezintă raportul dintre lățimea și înălțimea ferestrei de vizualizare. Este esențial pentru a evita distorsiunile imaginii; de exemplu, un raport de aspect de 16:9 este comun pentru ecranele widescreen.
Domeniu de valori: Valorile tipice sunt de 1.0 (pentru un pătrat) până la valori de aproximativ 2.39 (pentru ecrane ultrawide). Un raport de aspect 0 sau negativ nu este valid.
Distanța de aproape (Near Plane):
Descriere: Acesta este distanța de la camera (sau ochiul) la planul cel mai apropiat în care obiectele vor fi vizibile. Orice obiect mai aproape decât această distanță nu va fi redat.
Domeniu de valori: Această valoare trebuie să fie pozitivă și mai mare decât 0. Valorile tipice variază între 0.1 și 1000.0, dar trebuie să fie mai mici decât distanța de depărtare.
Distanța de depărtare (Far Plane):
Descriere: Aceasta este distanța de la camera la planul cel mai îndepărtat în care obiectele vor fi vizibile. Orice obiect mai departe decât această distanță nu va fi redat.
Domeniu de valori: De asemenea, aceasta trebuie să fie pozitivă și mai mare decât 0. Aceasta trebuie să fie mai mare decât distanța de aproape și valorile tipice pot varia de la 100.0 până la 10000.0, în funcție de scenă.