using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kartei.Service;

namespace Kartei.Klassen
{
    public class User
    {
        int _iD;
        string _userID;
        string _vorname;
        string _nachname;
        string _kennwort;

        public User(string User, string Kennwort)
        {
            UserID = User;
            this.Kennwort = Kennwort;
            Vorname = "";
            Nachname = "";

        }

        public User()
        {
            UserID = "";
            Kennwort = "";
            Vorname = "";
            Nachname = "";
        }

        public string Anmelden()
        {
            string res = "";

            AnmeldeService anmeldeService = new AnmeldeService(new User(_userID, _kennwort));
            anmeldeService.Anmelden();

            return res;
        }

        public int ID { get => _iD; }
        public string UserID { get => _userID; set => _userID = value; }
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Nachname { get => _nachname; set => _nachname = value; }
        public string Kennwort { get => _kennwort; set => _kennwort = value; }
    }
}
