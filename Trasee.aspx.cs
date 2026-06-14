using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Atestat___Spirit_de_Sprieni
{
    public partial class Trasee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.Visible = true;
            string[] v = { "Lacul Albastru", "Crapatura Zorilor", "Putul Francisc", "Lacului Bodi", "Creasta Cocosului", "Flotatie" };
            string[] v1 = { "Pentru a ajunge la Lacul Albastru, pornești din centrul orașului Baia Sprie, chiar din spatele Bisericii Romano-Catolice. De acolo urmezi drumul în pantă spre Dealul Minei și mergi prin pădure pe poteca marcată cu cruce albastră sau cruce galbenă. Urcușul durează aproximativ 35-45 de minute, fiind de dificultate ușoară spre medie, și te scoate direct pe malul lacului renumit pentru apele sale turcoaz.",
                "Traseul către Crăpătura Zorilor continuă chiar din zona Lacului Albastru, cele două obiective fiind situate pe același Deal al Minei. Din spatele lacului, urmezi marcajul turistic cruce galbenă pe o potecă îngustă care urcă prin pădure pe versantul abrupt. După circa 15-20 de minute de urcat de la lac, vei ajunge la spectaculoasa prăbușire tectonică și minieră, vizibilă direct de pe marginea potecii."
                , "Pentru a vizita monumentul istoric Puțul Francisc, trebuie să mergi pe Valea Borcutului din Baia Sprie. Din zona microraionului de vest al orașului, intri pe strada Crișan, treci de Parcul Minelor și mergi pe drumul forestier. Traseul trece un pod și continuă pe o potecă din partea stângă, marcată cu cruce roșie, care te conduce în doar câteva minute direct la ruinele vechiului puț minier.",
                "La Lacul Bodi (situat în Complexul Mogoșa) ajungi cel mai simplu cu mașina, conducând pe drumul național DN18 dinspre Baia Mare spre Sighetu Marmației. Înainte de a începe urcarea spre Pasul Gutâi, virezi la dreapta în dreptul indicatorului mare către Complexul Mogoșa. De la șoseaua principală urmezi drumul secundar asfaltat timp de aproximativ 3 kilometri, care te lasă direct în parcarea de lângă lac."
                , "Traseul clasic și cel mai accesibil către Creasta Cocoșului începe din cea mai înaltă zonă a drumului DN18, numită Pasul Gutâi (lângă Hanul lui Pintea). Din parcarea amenajată acolo, intri în pădure pe poteca marcată cu bandă roșie. Mergi pe jos pe un drum forestier relativ lin, care apoi se transformă într-o cărare printre pășuni alpine și te scoate la baza stâncilor vulcanice după aproximativ 2 ore de mers."
                , "La vechea Flotație din Baia Sprie ajungi direct cu mașina sau folosind transportul în comun din Baia Mare. Trebuie doar să iei autobuzul linia 8 operat de societatea URBIS și să mergi până la capătul liniei din Baia Sprie. Clădirile industriale ale fostei uzine de preparare minieră se află chiar la strada principală, fiind extrem de ușor de reperat vizual" };
            Random rand = new Random();
            int random = rand.Next(v.Length);
            H1.InnerHtml = v[random];
            Image1.ImageUrl = "~/imagine/" + "p" + random + ".jpg";
            p1.InnerText = v1[random];
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Image1.Visible = true;
            string [] v = { "Lacul Albastru", "Crapatura Zorilor", "Putul Francisc", "Lacului Bodi", "Creasta Cocosului", "Flotatie" };
            string[] v1 = { "Pentru a ajunge la Lacul Albastru, pornești din centrul orașului Baia Sprie, chiar din spatele Bisericii Romano-Catolice. De acolo urmezi drumul în pantă spre Dealul Minei și mergi prin pădure pe poteca marcată cu cruce albastră sau cruce galbenă. Urcușul durează aproximativ 35-45 de minute, fiind de dificultate ușoară spre medie, și te scoate direct pe malul lacului renumit pentru apele sale turcoaz.",
                "Traseul către Crăpătura Zorilor continuă chiar din zona Lacului Albastru, cele două obiective fiind situate pe același Deal al Minei. Din spatele lacului, urmezi marcajul turistic cruce galbenă pe o potecă îngustă care urcă prin pădure pe versantul abrupt. După circa 15-20 de minute de urcat de la lac, vei ajunge la spectaculoasa prăbușire tectonică și minieră, vizibilă direct de pe marginea potecii."
                , "Pentru a vizita monumentul istoric Puțul Francisc, trebuie să mergi pe Valea Borcutului din Baia Sprie. Din zona microraionului de vest al orașului, intri pe strada Crișan, treci de Parcul Minelor și mergi pe drumul forestier. Traseul trece un pod și continuă pe o potecă din partea stângă, marcată cu cruce roșie, care te conduce în doar câteva minute direct la ruinele vechiului puț minier.",
                "La Lacul Bodi (situat în Complexul Mogoșa) ajungi cel mai simplu cu mașina, conducând pe drumul național DN18 dinspre Baia Mare spre Sighetu Marmației. Înainte de a începe urcarea spre Pasul Gutâi, virezi la dreapta în dreptul indicatorului mare către Complexul Mogoșa. De la șoseaua principală urmezi drumul secundar asfaltat timp de aproximativ 3 kilometri, care te lasă direct în parcarea de lângă lac."
                , "Traseul clasic și cel mai accesibil către Creasta Cocoșului începe din cea mai înaltă zonă a drumului DN18, numită Pasul Gutâi (lângă Hanul lui Pintea). Din parcarea amenajată acolo, intri în pădure pe poteca marcată cu bandă roșie. Mergi pe jos pe un drum forestier relativ lin, care apoi se transformă într-o cărare printre pășuni alpine și te scoate la baza stâncilor vulcanice după aproximativ 2 ore de mers."
                , "La vechea Flotație din Baia Sprie ajungi direct cu mașina sau folosind transportul în comun din Baia Mare. Trebuie doar să iei autobuzul linia 8 operat de societatea URBIS și să mergi până la capătul liniei din Baia Sprie. Clădirile industriale ale fostei uzine de preparare minieră se află chiar la strada principală, fiind extrem de ușor de reperat vizual" };
            Random rand = new Random();
            int random = rand.Next(v.Length);
            H1.InnerHtml = v[random];
            Image1.ImageUrl = "~/imagine/" + "p" + random + ".jpg";
            p1.InnerText = v1[random];
        }
    }
}