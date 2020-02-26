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
            : base(name, number, SportArt.HANDBALL, SpielerRolle.UNDEFINED)
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

        public override int compareByErfolg(Spieler s)
        {
            int compareResult = -9999;

            if (this.SpielSiege < s.toTennisSpieler().SpielSiege)
            {
                compareResult = -1;
            }
            else if (this.SpielSiege == s.toTennisSpieler().SpielSiege)
            {
                compareResult = 0;
            }
            else if (this.SpielSiege < s.toTennisSpieler().SpielSiege)
            {
                compareResult = 1;
            }

            return compareResult;
        }
        #endregion
    }
}
