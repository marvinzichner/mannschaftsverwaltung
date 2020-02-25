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

            Marvin
                .name("Marvin Fussball")
                .toFussballSpieler()
                .isLeftFeet(true)
                .spielerNummer(12)
                .spielerRolle(SpielerRolle.STUERMER);

            Henry
                .name("Henry Handball")
                .toHandballSpieler()
                .isLeftHand(false)
                .spielerNummer(2)
                .spielerRolle(SpielerRolle.UNDEFINED);

            Lars
                .name("Lars Tennis")
                .toTennisSpieler()
                .isLeftHand(true)
                .spielerNummer(1)
                .spielerRolle(SpielerRolle.UNDEFINED);

            John
                .name("John Reginald Trainer")
                .toTrainer()
                .hasLicense(true)
                .sportArt(SportArt.FUSSBALL);

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
                .add(Thomas);

            Console.WriteLine("Mannschaft " + Koeln.Name);
            foreach(Person p in Koeln.find(Koeln.pattern(SearchTerm.FUSSBALLSPIELER)))
            {
                p.toFussballSpieler().sayHello();
            }

            Console.WriteLine("");
            foreach (Person p in Koeln.find(Koeln.pattern(SearchTerm.HANDBALLSPIELER)))
            {
                p.toHandballSpieler().sayHello();
            }

            Console.WriteLine("");
            foreach (Person p in Koeln.find(Koeln.pattern(SearchTerm.TENNISSPIELER)))
            {
                p.toTennisSpieler().sayHello();
            }

            Console.ReadKey();
        }
    }
}
