//Name          Marvin Zichner
//Datum         16.02.2020
//Datei         Physiotherapeut.cs
//Aenderungen   Initales Erzeugen und erste Eigenschaften

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Physiotherapeut : Person
    {
        #region Eigenschaften
        private bool _hasLicense;
        private SportArt _sportArt;
        #endregion

        #region Accessoren / Modifier
        public bool HasLicense { get => _hasLicense; set => _hasLicense = value; }
        public SportArt SportArt { get => _sportArt; set => _sportArt = value; }
        #endregion

        #region Konstruktoren
        public Physiotherapeut()
            :base()
        {
            HasLicense = false;
        }

        public Physiotherapeut(string name, SportArt sportArt)
            :base(name)
        {
            SportArt = sportArt;
        }

        public Physiotherapeut(Trainer t)
            :base(t)
        {
            SportArt = t.SportArt;
        }
        #endregion

        #region Worker
        public Physiotherapeut name(string s)
        {
            this.Name = s;
            return this;
        }
        public Physiotherapeut hasLicense(bool b)
        {
            this.HasLicense = b;
            return this;
        }
        public Physiotherapeut sportArt(SportArt sa)
        {
            this.SportArt = sa;
            return this;
        }

        public SportArt getSportArt()
        {
            return this.SportArt;
        }

        #endregion
    }
}
