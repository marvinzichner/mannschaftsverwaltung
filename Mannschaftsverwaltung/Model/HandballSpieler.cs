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
    public class HandballSpieler : Spieler
    {
        #region Eigenschaften
        bool _isLeftHand;
        #endregion

        #region Accessoren / Modifier
        public bool IsLeftHand { get => _isLeftHand; set => _isLeftHand = value; }
        #endregion

        #region Konstruktoren
        public HandballSpieler():base()
        {
            IsLeftHand = true;
        }
        public HandballSpieler(string name, int number, bool isLeftHand) 
            : base(name, number, SportArt.HANDBALL, SpielerRolle.UNDEFINED)
        {
            IsLeftHand = isLeftHand;
        }

        public HandballSpieler(HandballSpieler hs) 
            : base(hs)
        {
            IsLeftHand = hs.IsLeftHand;
        }
        #endregion

        #region Worker
        public HandballSpieler spielerNummer(int i)
        {
            this.SpielerNummer = i;
            return this;
        }
        public HandballSpieler spielerRolle(SpielerRolle sr)
        {
            this.SpielerRolle = sr;
            return this;
        }
        public HandballSpieler isLeftHand(bool b)
        {
            this.IsLeftHand = b;
            return this;
        }

        public override void sayHello()
        {
            base.sayHello();
            Console.WriteLine("    Ich habe auf dem Feld die Position " + this.SpielerRolle);
            Console.WriteLine("    Verwende ich beim Werfen die linke Hand? " + this.IsLeftHand);
        }
        #endregion
    }
}
