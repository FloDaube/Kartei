using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteien.Klassen
{
    public class P_Kartei
    {
        private int iD;
        private int patient_ID;
        private string arzt;
        private int vorherigeID;
        private string Kurzbeschreibung;
        private DateTime datum;
        private string beschwerde;
        private bool krankmeldung;
        private DateTime krankmeldungVon;
        private DateTime krankmeldungBis;
        private string diagnose;

        public P_Kartei()
        {
            
        }

        public int ID { get => iD; set => iD = value; }
        public int Patient_ID { get => patient_ID; set => patient_ID = value; }
        public string Arzt { get => arzt; set => arzt = value; }
        public int VorherigeID { get => vorherigeID; set => vorherigeID = value; }
        public string Kurzbeschreibung1 { get => Kurzbeschreibung; set => Kurzbeschreibung = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Beschwerde { get => beschwerde; set => beschwerde = value; }
        public bool Krankmeldung { get => krankmeldung; set => krankmeldung = value; }
    }
}
