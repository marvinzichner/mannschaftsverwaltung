﻿//Name          Marvin Zichner
//Datum         16.02.2020
//Datei         Trainer.cs
//Aenderungen   Initales Erzeugen und erste Eigenschaften

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Trainer : Person
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
        public Trainer()
            :base()
        {
            HasLicense = false;
        }

        public Trainer(string name, SportArt sportArt)
            :base(name)
        {
            SportArt = sportArt;
        }

        public Trainer(Trainer t)
            :base(t)
        {
            SportArt = t.SportArt;
        }
        #endregion

        #region Worker
        public Trainer hasLicense(bool b)
        {
            this.HasLicense = b;
            return this;
        }
        public Trainer sportArt(SportArt sa)
        {
            this.SportArt = sa;
            return this;
        }

        public SportArt getSportArt()
        {
            return this.SportArt;
        }

        public override int getSpielSiege()
        {
            return -1;
        }

        public override int compareBySpielSiege(Person p)
        {
            return -1;
        }

        public override int compareByName(Person p)
        {
            int result = -2;

            string thisName = this.Name.Substring(0, 1);
            string otherName = p.Name.Substring(0, 1);

            if (Utils.getLetterCode(thisName) < Utils.getLetterCode(otherName))
            {
                result = -1;
            }
            else if (Utils.getLetterCode(thisName) == Utils.getLetterCode(otherName))
            {
                result = 0;
            }
            else if (Utils.getLetterCode(thisName) > Utils.getLetterCode(otherName))
            {
                result = 1;
            }

            return result;
        }

        #endregion
    }
}
