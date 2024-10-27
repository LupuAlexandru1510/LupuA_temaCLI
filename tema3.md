1)Care este ordinea de desenare a vârfurilor pentru metodele din OpenGL (în sens orar sau anti-orar)?
În OpenGL, ordinea de desenare a vârfurilor este anti-orară pentru triunghiuri, TriangleFan și TriangleStrip.
Pentru a desena axele de coordonate folosind un singur apel GL.Begin(), aceasta se poate realiza specificând coordonatele punctelor de început și sfârșit pentru fiecare axă într-un singur bloc de cod.

2)Ce este anti-aliasingul?
Anti-aliasingul este o tehnică folosită pentru a face marginile obiectelor mai netede în grafică. În loc de o singură culoare, tehnica folosește un amestec de culori la margini, ceea ce dă impresia de netezime. Acest lucru face ca marginile obiectelor să arate mai puțin zimțate și mult mai naturale.

3)Care este efectul rulării comenzii GL.LineWidth(float)? Dar pentru GL.PointSize(float)? Funcționează în interiorul unei zone GL.Begin()?

GL.LineWidth(float) modifică grosimea liniilor, făcându-le mai subțiri sau mai groase în funcție de valoarea specificată.
GL.PointSize(float) ajustează dimensiunea punctelor desenate, permițându-le să fie mai mari sau mai mici.
Ambele comenzi trebuie apelate înainte de GL.Begin(), dar efectul lor va fi aplicat elementelor desenate între GL.Begin() și GL.End().
4)Care este efectul utilizării directivei LineLoop atunci când desenate segmente de dreaptă multiple în OpenGL?
Directiva LineLoop conectează toate punctele desenate, iar la final leagă ultimul punct de primul, creând astfel o formă închisă.

Efectul directivei LineStrip
LineStrip conectează punctele desenate prin linii, dar nu închide forma - deci, punctele de început și de sfârșit rămân neconectate.
Efectul directivei TriangleFan
TriangleFan începe cu un punct central și leagă fiecare punct suplimentar cu acesta, creând o structură de triunghiuri care se extind din centru, ideal pentru desenarea formelor circulare.
Efectul directivei TriangleStrip
TriangleStrip folosește un set de puncte pentru a desena triunghiuri adiacente, unde fiecare triunghi împarte două vârfuri cu triunghiul anterior. Acest lucru permite crearea unor forme complexe folosind mai puține vârfuri.
De ce sunt importante culorile diferite (în gradient sau per suprafață) în desenarea obiectelor 3D?
Culorile variate dau impresia de profunzime și structură, făcând obiectele să arate mai reale. Folosind gradientele și culori diferite pe suprafețe, putem simula efectele de lumină și umbră, ceea ce face ca obiectele să pară voluminoase și captivante. Aceste detalii vizuale ajută utilizatorul să înțeleagă mai bine forma și materialul obiectului, aducând un plus de realism.

7)Ce reprezintă un gradient de culoare? Cum se obține acesta în OpenGL?
Gradientul de culoare este o trecere graduală între două sau mai multe culori.Pentru a intelege mai bine fenomenulde gradient putem da ca exemplu suprafața unui ocean sau lac. Cu cat ne scufundam mai adanc cu atat al bastrul apei devine mai profund. În OpenGL, poți crea un gradient prin setarea culorilor diferite la colțurile unui obiect, cum ar fi un pătrat sau un triunghi. OpenGL va interpola automat culorile între aceste puncte, rezultând un efect de gradient.
Folosirea culorilor diferite și a efectelor de gradient în desenarea obiectelor 3D este importantă pentru a le face să pară mai reale. Aceste culori ajută la evidențierea formelor și la crearea efectului de adâncime, astfel încât obiectele să pară că au volum și detalii. În plus, prin folosirea culorilor potrivite, putem sugera lumina și umbra, ceea ce face ca obiectul să arate mai natural și mai atrăgător.
6)Urmăriți aplicația „shapes.exe” din tutorii OpenGL Nate Robbins.
De ce este importantă utilizarea de culori diferite (în gradient sau culori selectate per suprafață) în desenarea obiectelor 3D? Care este avantajul?
Folosirea culorilor diferite și a efectelor de gradient în desenarea obiectelor 3D este importantă pentru a le face să pară mai reale. Aceste culori ajută la evidențierea formelor și la crearea efectului de adâncime, astfel încât obiectele să pară că au volum și detalii. În plus, prin folosirea culorilor potrivite, putem sugera lumina și umbra, ceea ce face ca obiectul să arate mai natural și mai atrăgător.
10)Ce efect are utilizarea unei culori diferite pentru fiecare vertex atunci când desenați o linie sau un triunghi în modul strip?
Când se folosește o culoare diferită pentru fiecare vârf în desenarea unei linii sau a unui triunghi în modul strip (cum sunt GL_LINE_STRIP sau GL_TRIANGLE_STRIP în OpenGL), se obține un efect de gradient între vârfurile conectate. Practic, OpenGL creează o tranziție lină între culorile vârfurilor, care apare de-a lungul liniei sau pe suprafața triunghiului.




