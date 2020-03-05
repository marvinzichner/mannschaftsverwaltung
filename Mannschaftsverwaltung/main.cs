//Name          Marvin Zichner
//Datum         06.02.2020
//Datei         main.cs
//Aenderungen   Initales Erzeugen und erste Eigenschaften

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    class main
    {
        static void Main(string[] args)
        {
            Mannschaft Koeln = new Mannschaft("Koeln");

            FussballSpieler Marvin = new FussballSpieler();
            HandballSpieler Henry = new HandballSpieler();
            TennisSpieler Lars = new TennisSpieler();
            Trainer John = new Trainer();
            Physiotherapeut Thomas = new Physiotherapeut();
            Trainer Zili = new Trainer();

            Marvin
                .name("Marvin Zichner")
                .toFussballSpieler()
                .isLeftFeet(true)
                .spielerNummer(12)
                .spielSiege(12)
                .sportArt(SportArt.FUSSBALL)
                .spielerRolle(SpielerRolle.STUERMER);

            Henry
                .name("Henry C. Johnson")
                .toHandballSpieler()
                .isLeftHand(false)
                .spielerNummer(2)
                .spielSiege(6)
                .sportArt(SportArt.HANDBALL)
                .spielerRolle(SpielerRolle.KEINE);

            Lars
                .name("Lars T.-J. Smith")
                .toTennisSpieler()
                .isLeftHand(true)
                .spielerNummer(1)
                .spielSiege(11)
                .sportArt(SportArt.TENNIS)
                .spielerRolle(SpielerRolle.KEINE);

            John
                .name("John de Reginald")
                .toTrainer()
                .hasLicense(true)
                .sportArt(SportArt.FUSSBALL);

            Zili
                .name("Zili Huang")
                .toTrainer()
                .hasLicense(false)
                .sportArt(SportArt.KEINE);

            Thomas
                .name("Thomas Britt")
                .toPhysiotherapeut()
                .hasLicense(true)
                .sportArt(SportArt.FUSSBALL);

            Koeln
                .add(Marvin)
                .add(Henry)
                .add(Lars)
                .add(John)
                .add(Zili)
                .add(Thomas);


            Utils.generatePersonTable(
                Koeln.sortRule(Mannschaft.OrderBy.NAME_ASC)
                    .searchPattern(Mannschaft.SearchTerm.ALL));
           
            Console.ReadKey();
        }
    }
}
