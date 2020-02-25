//Name          Marvin Zichner
//Datum         12.02.2020
//Datei         Mannschaft.cs
//Aenderungen   Initales Erzeugen und erste Eigenschaften

using System;
using System.Collections.Generic;

namespace Mannschaftsverwaltung
{
    public class Mannschaft
    {
        #region Eigenschaften
        private List<Person> _personen;
        private string _name;
        #endregion

        #region Accessoren / Modifier
        
        public string Name { get => _name; set => _name = value; }
        public List<Person> Personen { get => _personen; set => _personen = value; }
        #endregion

        #region Konstruktoren
        public Mannschaft()
        {
            Name = "Musterverein";
            Personen = new List<Person>();
        }
        public Mannschaft(string name)
        {
            Name = name;
            Personen = new List<Person>();
        }

        public Mannschaft(string name, List<Person> personen) 
        {
            Name = name;
            Personen = personen;
        }

        public Mannschaft(Mannschaft c) 
        {
            Name = c.Name;
            Personen = c.Personen;
        }
        #endregion

        #region Worker
        public Mannschaft add(Person p)
        {
            this.Personen.Add(p);
            return this;
        }
        public Mannschaft addRange(List<Person> ps)
        {
            foreach(Person p in ps) { 
                this.Personen.Add(p);
            }
            return this;
        }

        public Mannschaft pattern(SearchTerm s)
        {
            List<Person> persons = new List<Person>();
            Mannschaft mannschaft = new Mannschaft(this);

            foreach(Person p in mannschaft.Personen) {
                if (s == SearchTerm.ALL)
                {
                    persons.Add(p);
                }
                else if (s == SearchTerm.FUSSBALLSPIELER)
                {
                    if (p.isFussballSpieler())
                    {
                        persons.Add(p);
                    }
                }
                else if (s == SearchTerm.HANDBALLSPIELER)
                {
                    if (p.isHandballSpieler())
                    {
                        persons.Add(p);
                    }
                }
                else if (s == SearchTerm.TENNISSPIELER)
                {
                    if (p.isTennisSpieler())
                    {
                        persons.Add(p);
                    }
                }
            }

            mannschaft.Personen = persons;
            return mannschaft;
        }

        public List<Person> find(Mannschaft m)
        {
            return m.Personen;
        }
        #endregion
    }
}