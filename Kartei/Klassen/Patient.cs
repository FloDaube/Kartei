using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteien.Klassen
{
    public class Patient
    {
        int _iD;
        DateTime _geborenAm;
        string _vorname;
        string _nachname;
        string _geschlecht;
        private List<P_Kartei> _karteien = new List<P_Kartei>();
        
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Nachname { get => _nachname; set => _nachname = value; }
        public int Alter { get => DateTime.Today.Year - _geborenAm.Year; }
        public int ID { get => _iD; set => _iD = value; }
        public string Geschlecht { get => _geschlecht; set => _geschlecht = value; }
        public DateTime GeborenAm { get => _geborenAm; set => _geborenAm = value; }
        public List<P_Kartei> Karteien()
        {
            List<P_Kartei> res = new List<P_Kartei>();



            return res;
        }

        public Patient(string Vorname,string Nachname, string Geschlecht, DateTime GeborenAm)
        {
            this.ID = -1;
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Geschlecht = Geschlecht;
            this.GeborenAm = GeborenAm;
        }
        public Patient()
        {
            this.ID = -1;
            this.Vorname = "";
            this.Nachname = "";
            this.Geschlecht = "";
            this.GeborenAm = DateTime.Today;
        }

    }
}
