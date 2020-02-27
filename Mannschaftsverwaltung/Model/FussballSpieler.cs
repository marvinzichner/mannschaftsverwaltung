//Name          Marvin Zichner
//Datum         06.02.2020
//Datei         FussballSpieler.cs
//Aenderungen   Initales Erzeugen und erste Eigenschaften

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class FussballSpieler : Spieler
    {
        #region Eigenschaften
        bool _isLeftFeet;
        int _SpielSiege;
        #endregion

        #region Accessoren / Modifier
        public bool IsLeftFeet { get => _isLeftFeet; set => _isLeftFeet = value; }
        public int SpielSiege { get => _SpielSiege; set => _SpielSiege = value; }
        #endregion

        #region Konstruktoren
        public FussballSpieler():base()
        {
            IsLeftFeet = true;
            SpielSiege = 0;
        }
        public FussballSpieler(string name, int number, bool isLeftFeet, SpielerRolle spielerRolle, int siege) 
            : base(name, number, SportArt.FUSSBALL, spielerRolle, siege)
        {
            IsLeftFeet = isLeftFeet;
            SpielSiege = siege;
        }

        public FussballSpieler(FussballSpieler fs)
            :base(fs)
        {
            IsLeftFeet = fs.IsLeftFeet;
            SpielSiege = fs.SpielSiege;
        }
        #endregion

        #region Worker
        public FussballSpieler spielerNummer(int i)
        {
            this.SpielerNummer = i;
            return this;
        }
        public FussballSpieler spielerRolle(SpielerRolle sr)
        {
            this.SpielerRolle = sr;
            return this;
        }
        public FussballSpieler isLeftFeet(bool b)
        {
            this.IsLeftFeet = b;
            return this;
        }
        public FussballSpieler spielSiege(int i)
        {
            this.SpielSiege = i;
            return this;
        }

        public override void sayHello()
        {
            base.sayHello();
            Console.WriteLine("    Ich habe auf dem Feld die Position " + this.SpielerRolle);
            Console.WriteLine("    Mein starker Fuss ist Links? " + this.IsLeftFeet);
        }

        public override int compareByErfolg(Spieler s)
        {
            int compareResult = -9999;

            if (this.SpielSiege < s.toFussballSpieler().SpielSiege)
            {
                compareResult = -1;
            }
            else if (this.SpielSiege == s.toFussballSpieler().SpielSiege)
            {
                compareResult = 0;
            }
            else if (this.SpielSiege < s.toFussballSpieler().SpielSiege)
            {
                compareResult = 1;
            }

            return compareResult;
        }

        public override int getSpielSiege()
        {
            return this.SpielSiege;
        }
        #endregion
    }
}
