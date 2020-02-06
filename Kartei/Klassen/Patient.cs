using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartei.Klassen
{
    public class Patient : Kartei
    {
        int _iD;
        DateTime _geborenAm;
        string _vorname;
        string _nachname;
        string _geschlecht;

        
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Nachname { get => _nachname; set => _nachname = value; }
        public int Alter { get => DateTime.Today.Year - _geborenAm.Year; }
        public int ID { get => _iD; set => _iD = value; }
        public string Geschlecht { get => _geschlecht; set => _geschlecht = value; }
        public DateTime GeborenAm { get => _geborenAm; set => _geborenAm = value; }

        public Patient(string Vorname,string Nachname, string Geschlecht, DateTime GeborenAm)
        {
            this.ID = -1;
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Geschlecht = Geschlecht;
            this.GeborenAm = GeborenAm;
        }
    }
}
