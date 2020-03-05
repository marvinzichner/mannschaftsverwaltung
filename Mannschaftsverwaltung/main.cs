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
            FussballSpieler Zili = new FussballSpieler();
            TennisSpieler Jeff = new TennisSpieler();

            Marvin
                .name("Marvin Zichner")
                .sportArt(SportArt.FUSSBALL)
                .toFussballSpieler()
                .isLeftFeet(true)
                .spielerNummer(12)
                .spielSiege(12)
                .spielerRolle(SpielerRolle.STUERMER);

            Henry
                .name("Henry C. Johnson")
                .sportArt(SportArt.HANDBALL)
                .toHandballSpieler()
                .isLeftHand(false)
                .spielerNummer(2)
                .spielSiege(6)
                .spielerRolle(SpielerRolle.KEINE);

            Lars
                .name("Lars T.-J. Smith")
                .sportArt(SportArt.TENNIS)
                .toTennisSpieler()
                .isLeftHand(true)
                .spielerNummer(1)
                .spielSiege(11)
                .spielerRolle(SpielerRolle.KEINE);

            Jeff
                .name("Jeff Miller")
                .sportArt(SportArt.TENNIS)
                .toTennisSpieler()
                .isLeftHand(true)
                .spielerNummer(2)
                .spielSiege(2)
                .spielerRolle(SpielerRolle.KEINE);

            John
                .name("John de Reginald")
                .sportArt(SportArt.KEINE)
                .toTrainer()
                .hasLicense(true)
                .sportArt(SportArt.FUSSBALL);

            Zili
                .name("Zili Huang")
                .sportArt(SportArt.FUSSBALL)
                .toFussballSpieler()
                .isLeftFeet(true)
                .spielerNummer(12)
                .spielSiege(23)
                .spielerRolle(SpielerRolle.STUERMER);

            Thomas
                .name("Thomas Britt")
                .sportArt(SportArt.KEINE)
                .toPhysiotherapeut()
                .hasLicense(true);

            Koeln
                .sportArt(SportArt.FUSSBALL)
                .add(Marvin)
                .add(Henry)
                .add(Lars)
                .add(John)
                .add(Zili)
                .add(Thomas)
                .add(Jeff);


            Utils.generatePersonTable(
                Koeln
                    .rule(Mannschaft.OrderBy.ERFOLG_ASC)
                    .rule(Mannschaft.SearchTerm.ALL)
                    .enableGroupSort()
                    .searchPattern());
           
            Console.ReadKey();
        }
    }
}
