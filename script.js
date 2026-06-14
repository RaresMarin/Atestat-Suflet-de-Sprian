let index = 0;
let imaginii = ['/imagine/a2.jpeg', '/imagine/a3.jpeg', '/imagine/a4.jpeg', '/imagine/a5.jpeg', '/imagine/a6.jpeg', '/imagine/a7.jpeg'];
let text = ['Fostul cinematograf din Baia Sprie a fost reabilitat și transformat într-un centru multifuncțional ce include spații publice, culturale, sportive și de reintegrare socială. Această inițiativă urmărește revitalizarea infrastructurii locale, oferind comunității un spațiu modern pentru activități recreative și educaționale.',
'Capela „Calvaria” este un monument istoric și religios unic în județul Maramureș, amplasat simbolic pe versantul Dealului Minei, de unde veghează de la înălțime orașul Baia Sprie. Construită în forma sa actuală în anul 1848, această capelă romano-catolică se remarcă prin arhitectura sa deosebită, având un altar cu o structură cilindrică rară.',
'Fântâna lui Stoll, cunoscută local și sub numele de „Frumoasa Spria”, este o fântână arteziană istorică emblematică pentru orașul Baia Sprie, situată chiar în inima Centrului Vechi, în Piața Libertății. Monumentul se remarcă prin statuia centrală a unei zeițe antice care poartă cu eleganță un vas pe umăr, fiind amplasată simbolic în vecinătatea Bisericii Romano-Catolice. ',
'Lacul Albastru este o rezervație naturală de o frumusețe unică în Europa, situată pe versantul sudic al Dealului Minei, deasupra orașului Baia Sprie. Acest lac s-a format prăbușirea unei vechi galerii miniere de exploatare în perioada anilor 1919-1920, fiind recunoscut la nivel internațional datorită proprietății sale spectaculoase de a-și schimba culoarea.'  ,
'Lacul Bodi (Mogoșa) este un lac artificial de o frumusețe aparte, situat pe raza administrativă a orașului Baia Sprie, la poalele Vârfului Mogoșa din Munții Gutâi. Amenajat inițial în secolul al XIX-lea pentru a asigura necesarul de apă al exploatărilor miniere din zonă, lacul a fost reconfigurat prin lucrări hidrotehnice în anii 1961-1962, primind forma sa actuală.',
'Biserica Romano-Catolică „Sfânta Maria” este un monument arhitectural impunător ce domină piața centrală din Baia Sprie, fiind situată chiar în vecinătatea Fântânii lui Stoll. Edificată între anii 1847 și 1858 pe fundația unui lăcaș de cult mult mai vechi, atestat încă din secolul al XIV-lea, biserica impresionează prin fațada sa monumentală, decorată cu statuile sfinților regi Ștefan și Ladislau, respectiv ale apostolilor Petru și Pavel. '];
let galerie = document.getElementById('Galerie');
let p = document.getElementById('text');
Arata();
function Inainte(n) {
    index += n;
    Arata()
}
function Arata() {
    if (index < 0) index = imaginii.length-1;
    if (index >= imaginii.length) index = 0;
    galerie.src = imaginii[index];
    p.textContent = text[index];
}
