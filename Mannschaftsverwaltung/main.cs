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

            for(int i = 0; i <= 3; i++) { 
                FussballSpieler Marvin = new FussballSpieler();
                HandballSpieler Henry = new HandballSpieler();
                TennisSpieler Lars = new TennisSpieler();
                Trainer John = new Trainer();
                Physiotherapeut Thomas = new Physiotherapeut();

                Marvin
                    .name("Marvin Zichner" + i)
                    .toFussballSpieler()
                    .isLeftFeet(true)
                    .spielerNummer(12 + i)
                    .spielSiege(12 + i)
                    .sportArt(SportArt.FUSSBALL)
                    .spielerRolle(SpielerRolle.STUERMER);

                Henry
                    .name("Henry C. Johnson" + i)
                    .toHandballSpieler()
                    .isLeftHand(false)
                    .spielerNummer(2 + i)
                    .spielSiege(6 + i)
                    .sportArt(SportArt.HANDBALL)
                    .spielerRolle(SpielerRolle.KEINE);

                Lars
                    .name("Lars T.-J. Smith" + i)
                    .toTennisSpieler()
                    .isLeftHand(true)
                    .spielerNummer(1 + i)
                    .spielSiege(11 + i)
                    .sportArt(SportArt.TENNIS)
                    .spielerRolle(SpielerRolle.KEINE);

                John
                    .name("John de Reginald" + i)
                    .toTrainer()
                    .hasLicense(true)
                    .sportArt(SportArt.FUSSBALL);

                Thomas
                    .name("Thomas Britt" + i)
                    .toPhysiotherapeut()
                    .hasLicense(true)
                    .sportArt(SportArt.FUSSBALL);

                Koeln
                    .add(Marvin)
                    .add(Henry)
                    .add(Lars)
                    .add(John)
                    .add(Thomas);

            }

            string PATTERN = "|{0,22}|{1,6}|{2,10}|{3,10}|{4,6}|{5,6}";
            Console.WriteLine(String.Format(PATTERN, "Name", "Nr", "Art", "Rolle", "XP", "Lic."));
            Console.WriteLine("--------------------------------------------------------------");

            foreach(Person p in Koeln.find(Koeln.pattern(SearchTerm.ALL, OrderBy.NAME_ASC)))
            {
                if (p.isFussballSpieler())
                {
                    FussballSpieler fs = p.toFussballSpieler();
                    Console.WriteLine(
                        String.Format(
                            PATTERN,
                            fs.Name,
                            fs.SpielerNummer, 
                            fs.getSportArt(), 
                            fs.getSpielerRolle(), 
                            fs.SpielSiege,
                            "?"
                        )
                    );
                }
                else if (p.isHandballSpieler())
                {
                    HandballSpieler fs = p.toHandballSpieler();
                    Console.WriteLine(
                        String.Format(
                            PATTERN,
                            fs.Name,
                            fs.SpielerNummer,
                            fs.getSportArt(),
                            fs.getSpielerRolle(),
                            fs.SpielSiege,
                            "?"
                        )
                    );
                }
                else if (p.isTennisSpieler())
                {
                    TennisSpieler fs = p.toTennisSpieler();
                    Console.WriteLine(
                        String.Format(
                            PATTERN,
                            fs.Name,
                            fs.SpielerNummer,
                            fs.getSportArt(),
                            fs.getSpielerRolle(),
                            fs.SpielSiege,
                            "?"
                        )
                    );
                }
                else if (p.isTrainer())
                {
                    Trainer fs = p.toTrainer();
                    Console.WriteLine(
                        String.Format(
                            PATTERN,
                            fs.Name,
                            "?",
                            fs.getSportArt(),
                            "TRAINER",
                            "?",
                            fs.HasLicense
                        )
                    );
                }
            }

           
            Console.ReadKey();
        }
    }
}
