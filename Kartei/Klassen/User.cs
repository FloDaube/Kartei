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
            _iD = -1;
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
            User u = anmeldeService.Anmelden();
            UserID = u.UserID;
            _iD = u.ID;
            Vorname = u.Vorname;
            Nachname = u.Nachname;

            return res;
        }

        /// <summary>
        /// Gibt ID des Nutzers an.
        /// </summary>
        public int ID { get => _iD; set => _iD = value; }
        /// <summary>
        /// Anmelde ID des Nutzers.
        /// </summary>
        public string UserID { get => _userID; set => _userID = value; }
        /// <summary>
        /// Vorname des Nutzers.
        /// Im Fehlerfall Error Meldung.
        /// </summary>
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Nachname { get => _nachname; set => _nachname = value; }
        /// <summary>
        /// Kennwort des Nutzers.
        /// </summary>
        public string Kennwort { get => _kennwort; set => _kennwort = value; }
    }
}
