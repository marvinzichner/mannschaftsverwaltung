//Name          Marvin Zichner
//Datum         06.02.2020
//Datei         TennisSpieler.cs
//Aenderungen   Initales Erzeugen und erste Eigenschaften

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class TennisSpieler : Spieler
    {
        #region Eigenschaften
        bool _isLeftHand;
        #endregion

        #region Accessoren / Modifier
        public bool IsLeftHand { get => _isLeftHand; set => _isLeftHand = value; }
        #endregion

        #region Konstruktoren
        public TennisSpieler():base()
        {
            IsLeftHand = true;
        }
        public TennisSpieler(string name, int number, bool isLeftHand) 
            : base(name, number, SportArt.HANDBALL, SpielerRolle.UNDEFINED)
        {
            IsLeftHand = isLeftHand;
        }

        public TennisSpieler(HandballSpieler hs) 
            : base(hs)
        {
            IsLeftHand = hs.IsLeftHand;
        }
        #endregion

        #region Worker
        public TennisSpieler spielerNummer(int i)
        {
            this.SpielerNummer = i;
            return this;
        }
        public TennisSpieler spielerRolle(SpielerRolle sr)
        {
            this.SpielerRolle = sr;
            return this;
        }
        public TennisSpieler isLeftHand(bool b)
        {
            this.IsLeftHand = b;
            return this;
        }
        #endregion
    }
}
