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
                .isLeftFeet(true)
                .spielerNummer(12)
                .spielerRolle(SpielerRolle.STUERMER);

            Henry
                .name("Henry Handball")
                .isLeftHand(false)
                .spielerNummer(2)
                .spielerRolle(SpielerRolle.UNDEFINED);

            Lars
                .name("Lars Tennis")
                .isLeftHand(true)
                .spielerNummer(1)
                .spielerRolle(SpielerRolle.UNDEFINED);

            John
                .name("John Reginald Trainer")
                .hasLicense(true)
                .sportArt(SportArt.FUSSBALL);

            Thomas
                .name("Thomas Britt")
                .hasLicense(true)
                .sportArt(SportArt.FUSSBALL);

            Koeln.Personen.Add(Marvin);
            Koeln.Personen.Add(Henry);
            Koeln.Personen.Add(Lars);
            Koeln.Personen.Add(John);
            Koeln.Personen.Add(Thomas);

            Console.WriteLine("Mannschaft " + Koeln.Name);
            foreach (Person person in Koeln.Personen)
            {
                if (person.isFussballSpieler())
                {
                    Console.WriteLine( "  - " +
                        person.toFussballSpieler().Name 
                        + " hat die Feldposition " 
                        + person.toFussballSpieler().SpielerRolle);
                }
                else if (person.isTennisSpieler())
                {
                    Console.WriteLine("  - " +
                        person.toTennisSpieler().Name
                        + " - Linker Arm? "
                        + person.toTennisSpieler().IsLeftHand);
                }
                else if (person.isHandballSpieler())
                {
                    Console.WriteLine("  - " +
                        person.toHandballSpieler().Name
                        + " - Linker Arm? "
                        + person.toHandballSpieler().IsLeftHand);
                }
                else
                {
                    Console.WriteLine("  - anderes Mitglied: " +
                        person.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
