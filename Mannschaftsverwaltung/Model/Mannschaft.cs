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

        public List<Person> searchPattern(SearchTerm s, OrderBy ob)
        {
            List<Person> persons = new List<Person>();
            Mannschaft mannschaft = new Mannschaft(this);

            foreach(Person p in mannschaft.Personen) {
                if (s == SearchTerm.ALL)
                {
                    persons.Add(p);
                }
                else if (s == SearchTerm.FUSSBALLSPIELER
                    && p.isFussballSpieler())
                {
                    persons.Add(p);
                }
                else if (s == SearchTerm.HANDBALLSPIELER
                    && p.isHandballSpieler())
                {
                    persons.Add(p);
                }
                else if (s == SearchTerm.TENNISSPIELER
                    && p.isTennisSpieler())
                {
                    persons.Add(p);
                }
            }

            for(int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count; j++)
                {
                    Person p1 = persons[i];
                    Person p2 = persons[j];

                    if(ob == OrderBy.ERFOLG_ASC && p1.getSpielSiege() < p2.getSpielSiege() ||
                        ob == OrderBy.NAME_ASC && p1.compareByName(p2) < 0) {
                        int idx1 = persons.IndexOf(p1);
                        int idx2 = persons.IndexOf(p2);
                        persons[idx1] = p2;
                        persons[idx2] = p1;
                    }
                }
            }

            mannschaft.Personen = persons;
            return mannschaft.Personen;
        }
        #endregion
    }
}