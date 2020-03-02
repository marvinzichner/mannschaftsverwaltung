//Name          Marvin Zichner
//Datum         06.02.2020
//Datei         Person.cs
//Aenderungen   Initales Erzeugen und erste Eigenschaften

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public abstract class Person
    {
        #region Eigenschaften
        private string _name;
        #endregion

        #region Accessoren / Modifier
        public string Name { get => _name; set => _name = value; }
        #endregion

        #region Konstruktoren
        public Person()
        {
            Name = "Max Mustermann";
        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(Person p)
        {
            Name = p.Name;
        }

        #endregion

        #region Worker
        
        public bool isFussballSpieler()
        {
            return ReferenceEquals(typeof(FussballSpieler), this.GetType());
        }
        public FussballSpieler toFussballSpieler()
        {
            return (FussballSpieler) this;
        }

        public bool isTennisSpieler()
        {
            return ReferenceEquals(typeof(TennisSpieler), this.GetType());
        }
        public TennisSpieler toTennisSpieler()
        {
            return (TennisSpieler)this;
        }
        public bool isHandballSpieler()
        {
            return ReferenceEquals(typeof(HandballSpieler), this.GetType());
        }
        public HandballSpieler toHandballSpieler()
        {
            return (HandballSpieler)this;
        }
        public bool isTrainer()
        {
            return ReferenceEquals(typeof(Trainer), this.GetType());
        }
        public Trainer toTrainer()
        {
            return (Trainer)this;
        }
        public bool isPhysiotherapeut()
        {
            return ReferenceEquals(typeof(Physiotherapeut), this.GetType());
        }
        public Physiotherapeut toPhysiotherapeut()
        {
            return (Physiotherapeut)this;
        }
        public Spieler toGenericSpieler()
        {
            return (Spieler)this;
        }

        public int compareByName(Person p)
        {
            int result = -2;

            string thisName = this.Name.Substring(0, 1);
            string otherName = p.Name.Substring(0, 1);

            if (getLetterCode(thisName) < getLetterCode(otherName))
            {
                result = -1;
            }
            else if (getLetterCode(thisName) == getLetterCode(otherName))
            {
                result = 0;
            }
            else if (getLetterCode(thisName) > getLetterCode(otherName))
            {
                result = 1;
            }

            return result;
        }

        private int getLetterCode(string s)
        {
            char[] c = s.ToCharArray();
            return char.ToUpper(c[0]) - 64;
        }

        public abstract int getSpielSiege();

        public virtual Person name(string s)
        {
            this.Name = s;
            return this;
        }
        #endregion
    }
}
