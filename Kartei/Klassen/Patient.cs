using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartei.Klassen
{
    public class Patient : Kartei
    {
        DateTime _geboren;
        string _vorname;
        string _nachname;

        public DateTime Geboren { get => _geboren; set => _geboren = value; }
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Nachname { get => _nachname; set => _nachname = value; }

        public int Alter { get => DateTime.Today.Year - _geboren.Year; }

        public Patient(int Alter, string _vorname, string _nachname, string _beschwerde, string _diagnose, DateTime _datum, int Krankheitsdauer, string _arzt, int _id)
        {

        }
    }
}
