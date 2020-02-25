//Name          Marvin Zichner
//Datum         06.02.2020
//Datei         Spieler.cs
//Aenderungen   Initales Erzeugen und erste Eigenschaften

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public abstract class Spieler : Person
    {
        #region Eigenschaften
        private int _spielerNummer;
        private SportArt _sportArt;
        private SpielerRolle _spielerRolle;
        #endregion

        #region Accessoren / Modifier
        public int SpielerNummer { get => _spielerNummer; set => _spielerNummer = value; }
        public SportArt SportArt { get => _sportArt; set => _sportArt = value; }
        public SpielerRolle SpielerRolle { get => _spielerRolle; set => _spielerRolle = value; }
        #endregion

        #region Konstruktoren
        public Spieler()
            :base()
        {
            SpielerNummer = -9999;
            SportArt = SportArt.UNDEFINED;
            SpielerRolle = SpielerRolle.UNDEFINED;
        }

        public Spieler(string name, int number, SportArt sportArt, SpielerRolle spielerRolle)
            :base(name)
        {
            SpielerNummer = number;
            SportArt = sportArt;
            SpielerRolle = spielerRolle;
        }

        public Spieler(Spieler s)
            :base(s)
        {
            SpielerNummer = s.SpielerNummer;
            SportArt = s.SportArt;
            SpielerRolle = s.SpielerRolle;
        }
        #endregion

        #region Worker
        public Spieler spielerNummer(int i)
        {
            this.SpielerNummer = i;
            return this;
        }
        public Spieler sportArt(SportArt sa)
        {
            this.SportArt = sa;
            return this;
        }
        public Spieler spielerRolle(SpielerRolle sr)
        {
            this.SpielerRolle = sr;
            return this;
        }
        public SportArt getSportArt()
        {
            return this.SportArt;
        }

        public SpielerRolle getSpielerRolle()
        {
            return this.SpielerRolle;
        }
        #endregion
    }
}
