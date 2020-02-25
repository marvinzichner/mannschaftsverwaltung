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
        #endregion

        #region Accessoren / Modifier
        public bool IsLeftFeet { get => _isLeftFeet; set => _isLeftFeet = value; }
        #endregion

        #region Konstruktoren
        public FussballSpieler():base()
        {
            IsLeftFeet = true;
        }
        public FussballSpieler(string name, int number, bool isLeftFeet, SpielerRolle spielerRolle) 
            : base(name, number, SportArt.FUSSBALL, spielerRolle)
        {
            IsLeftFeet = isLeftFeet;
        }

        public FussballSpieler(FussballSpieler fs)
            :base(fs)
        {
            IsLeftFeet = fs.IsLeftFeet;
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

        public override void sayHello()
        {
            base.sayHello();
            Console.WriteLine("    Ich habe auf dem Feld die Position " + this.SpielerRolle);
            Console.WriteLine("    Mein starker Fuss ist Links? " + this.IsLeftFeet);
        }
        #endregion
    }
}
