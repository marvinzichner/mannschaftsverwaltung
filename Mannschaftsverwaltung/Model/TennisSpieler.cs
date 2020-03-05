﻿//Name          Marvin Zichner
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
        int _SpielSiege;
        #endregion

        #region Accessoren / Modifier
        public bool IsLeftHand { get => _isLeftHand; set => _isLeftHand = value; }
        public int SpielSiege { get => _SpielSiege; set => _SpielSiege = value; }
        #endregion

        #region Konstruktoren
        public TennisSpieler():base()
        {
            IsLeftHand = true;
            SpielSiege = 0;
        }
        public TennisSpieler(string name, int number, bool isLeftHand) 
            : base(name, number, SportArt.HANDBALL, SpielerRolle.KEINE, 0)
        {
            IsLeftHand = isLeftHand;
            SpielSiege = 0;
        }

        public TennisSpieler(HandballSpieler hs) 
            : base(hs)
        {
            IsLeftHand = hs.IsLeftHand;
            SpielSiege = hs.SpielSiege;
        }
        #endregion

        #region Worker
        public TennisSpieler spielerNummer(int i)
        {
            this.SpielerNummer = i;
            return this;
        }
        public TennisSpieler spielSiege(int i)
        {
            this.SpielSiege = i;
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

        public override void sayHello()
        {
            base.sayHello();
            Console.WriteLine("    Als Tennisspieler habe ich keine klare definierte Rolle");
            Console.WriteLine("    Zum Schlagen verwende ich die linke Hand? " + this.IsLeftHand);
            Console.WriteLine("    Tennis ist meine Leidenschaft");
        }

        public override int compareBySpielSiege(Person p)
        {
            int compareResult = -1;

            if (p.isTennisSpieler() 
                && this.SpielSiege < p.toTennisSpieler().SpielSiege)
            {
                compareResult = -1;
            }
            else if (p.isTennisSpieler() 
                && this.SpielSiege == p.toTennisSpieler().SpielSiege)
            {
                compareResult = 0;
            }
            else if (p.isTennisSpieler() 
                && this.SpielSiege < p.toTennisSpieler().SpielSiege)
            {
                compareResult = 1;
            }

            return compareResult;
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
