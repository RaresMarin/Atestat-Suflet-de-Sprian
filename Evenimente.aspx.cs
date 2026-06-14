using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Atestat___Spirit_de_Sprieni
{
    public partial class Evenimente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime acum = DateTime.Now; ///Data curenta 
            int an = DateTime.Now.Year;///An curent
            DateTime ev1 = new DateTime (an, 5, 1);///Data primului eveniment in anul curent
            DateTime ev2 = new DateTime(an, 8, 15);///Data eveniment al doilea in anul curent
            DateTime ev3 = new DateTime(an, 12, 7);///Data eveniment al treilea in anul curent
            DateTime ev4 = new DateTime(an, 5, 18);///Data eveniment al paturlea in anul curent
            DateTime ev5 = new DateTime(an, 6, 7);///Data eveniment al cincilea in anul curent
            DateTime ev6 = new DateTime(an, 7, 13);///Data eveniment al saselea in anul curent

            int zile =1,zile1=1,zile2=1, zile3 =1, zile4 =1, zile5 = 1;///Zile ramase
            if (acum > ev1)///Verificam daca evenimentul de anul acesta a avut loc
            {
                ev1 = new DateTime(an + 1, 5, 1);///Actualizam data evenimentului urmator 
                zile = (ev1 - acum).Days;
            }
            else
            {
                zile = Math.Abs((acum - ev1).Days);/*In cazul in care evenimentul de anul acesta nu a avut loc
                                                    * Scadem din data curenta data evenimentul si folosim functia
                                                    * modul din clasa math pentru a avea valori pozitive
                                                    */
            }
            ///Analog pentru celelalte doua evenimente din Baia Sprie 
            if (acum > ev2)
            {
                ev2 = new DateTime(an + 1, 8, 15);
                zile1 += (ev2 - acum).Days;
            } else
            {
                zile1 += Math.Abs((acum - ev2).Days);
            }
            if (acum > ev3)
            {
                ev3 = new DateTime(an + 1, 12, 7);
                zile2 += (ev3 - acum).Days;
            }
            else
            {
                zile2 += Math.Abs((acum - ev3).Days);
            }
            if (acum > ev4)
            {
                ev4 = new DateTime(an + 1, 5, 18);
                zile3 += (ev4 - acum).Days;
            }
            else
            {
                zile3 += Math.Abs((acum - ev4).Days);
            }
            if (acum > ev5)
            {
                ev5 = new DateTime(an + 1, 6, 7);
                zile4 += (ev5 - acum).Days;
            }
            else
            {
                zile4 += Math.Abs((acum - ev5).Days);
            }
            if (acum > ev6)
            {
                ev6 = new DateTime(an + 1, 8, 13);
                zile5 += (ev6 - acum).Days;
            }
            else
            {
                zile5 += Math.Abs((acum - ev6).Days);
            }
            data1.InnerText = zile.ToString();
            data2.InnerText = zile1.ToString();
            data3.InnerText = zile2.ToString();
            Span1.InnerText = zile3.ToString();
            Span2.InnerText = zile4.ToString();
            Span3.InnerText = zile5.ToString();
        }
        protected void Button(object sender, EventArgs e)
        {

            if (p1.InnerText == "")
            {
                b1.Text = "Arată mai puțin";
                p1.InnerText = "O tradiție locală istorică în care fanfara defilează în marș pornind din Piațeta din Centrul Vechi pe Aleea Minerilor. Evenimentul marchează Ziua Muncii prin recitaluri de muzică de promenadă și de fanfară în aer liber în Parcul Civic.";
            }
            else
            {
                b1.Text = "Află mai multe";
                p1.InnerText = "";
            }
        }
        protected void Button1(object sender, EventArgs e)
        {
            if (p2.InnerText == "")
            {
                b2.Text = "Arată mai puțin";
                p2.InnerText = "Sărbătoarea de căpătâi a orașului care onorează istoria extractivă de peste 600 de ani a zonei. Cuprinde parade oficiale în costume de mineri, depuneri de coroane, lansări de cărți de istorie locală și conferințe științifice la Casa de Cultură.";
            }
            else
            {
                b2.Text = "Află mai multe";
                p2.InnerText = "";
            }
        }
        protected void Button2(object sender, EventArgs e)
        {
            if (p3.InnerText == "")
            {
                b3.Text = "Arată mai puțin";
                p3.InnerText = "Concert și paradă religios-culturală organizată în colaborare cu bisericile locale și cetele tradiționale din satele aparținătoare (precum Chiuzbaia). Se concentrează pe păstrarea portului autentic de iarnă și oferirea de produse tradiționale (cozonaci, ceai, vin fiert).";
            } else
            {
                b3.Text = "Află mai multe";
                p3.InnerText = "";
            }
    }
        protected void Button3(object sender, EventArgs e)
        {
            if (p4.InnerText == "")
            {
                b4.Text = "Arată mai puțin";
                p4.InnerText = "O expoziție anuală de artă plastică organizată la Casa de Cultură Baia Sprie în colaborare cu Asociația Artiștilor Plastici „Alexandru Șainelic”. Evenimentul aduce în fața publicului lucrări originale (picturi, sculpturi și grafică) realizate de copii și tineri artiști din oraș, vernisajul fiind marcat de premieri oficiale și recitaluri artistice.";
            }
            else
            {
                b4.Text = "Află mai multe";
                p4.InnerText = "";
            }
        }
        protected void Button4(object sender, EventArgs e)
        {
            if (p5.InnerText == "")
            {
                b5.Text = "Arată mai puțin";
                p5.InnerText = "Un festival ecoturistic spectaculos desfășurat pe Dealul Minei, chiar pe malul unicului lac cu ape schimbătoare. Agenda zilei cuprinde legendarul Cros al Lacului Albastru (cu trasee speciale pentru copii și adulți), coborâri cu tiroliana peste luciul apei, ateliere creative organizate de meșteri populari și ghidaje de speologie organizate în galeriile miniere inundate din zonă.";
            }
            else
            {
                b5.Text = "Află mai multe";
                p5.InnerText = "";
            }
        }
        protected void Button5(object sender, EventArgs e)
        {
            if (p6.InnerText == "")
            {
                b6.Text = "Arată mai puțin";
                p6.InnerText = "O experiență culturală de șase zile desfășurată în cadrul complexului de artă tradițională Casa Olarului din Baia Sprie. Sub îndrumarea directă a meșterului Daniel Leș, turiști din țară și din străinătate locuiesc în case vechi restaurate și învață de la zero secretele modelării lutului pe roata olarului, arderea ceramicii în cuptoare tradiționale și tehnicile vechi de decorare dacică.7. Zilele Orașului Baia Sprie";
            }
            else
            {
                b6.Text = "Află mai multe";
                p6.InnerText = "";
            }
        }
    }
}