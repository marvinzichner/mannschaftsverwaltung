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

        #endregion
    }
}