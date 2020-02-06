using Kartei.Klassen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartei.SQLDataHandler
{
    public class SQLData
    {
        public SQLData()
        {

        }

        public string getConnectioString()
        {
            return $"Data Source = '{Einstellungen.Host}'; Initial Catalog = '{Einstellungen.DataBase}'; User ID = '{Einstellungen.SQLUser}'; Password = '{Einstellungen.Passwort}'";
        }

        #region Login Daten
        /// <summary>
        /// Gibt den Select String zurück für Anmeldung des User.
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Kennwort"></param>
        /// <returns></returns>
        public string getAnmeldung_Select(string UserID, string Kennwort, bool AllAsList = false)
        {
            if (AllAsList)
            {
                return $"SELECT U_ID, U_User_ID, U_Vorname, U_Nachname FROM[User]";
            }
            else
            {
                return $"SELECT U_ID, U_User_ID, U_Vorname, U_Nachname, U_Role FROM[User] Where U_User_ID = '{UserID}' AND U_Kennwort = '{Kennwort}'";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public User ReadUser(SqlDataReader reader)
        {
            User res = new User();
            while (reader.Read())
            {
                IDataRecord record = reader;
                res.ID = Convert.ToInt32(String.Format("{0}", record[0]));
                res.UserID = String.Format("{0}", record[1]);
                res.Vorname = String.Format("{0}", record[2]);
                res.Nachname = String.Format("{0}", record[3]);
                res.Role = String.Format("{0}", record[4]);
            }
            return res;
        }

        public List<User> ReadUserList(SqlDataReader reader)
        {
            List<User> res = new List<User>();
            while (reader.Read())
            {
                User _user = new User();
                IDataRecord record = reader;
                _user.ID = Convert.ToInt32(String.Format("{0}", record[0]));
                _user.UserID = String.Format("{0}", record[1]);
                _user.Vorname = String.Format("{0}", record[2]);
                _user.Nachname = String.Format("{0}", record[3]);
                _user.Role = String.Format("{0}", record[4]);
                res.Add(_user);
            }
            return res;
        }
        #endregion
        #region Patienten
        public string getPatientenList_Select(string Suche)
        {
            string res = "";
            if (Suche == "")
            {
                res =  $"SELECT * From [Patienten] Order by P_Nachname";
            }
            else
            {
                res = $"SELECT * From [Patienten] Order by P_Nachname WHERE (P_Nachname >= '{Suche}')";
            }

            return res;
        }

        public List<Patient> ReadPatientList(SqlDataReader reader)
        {
            List<Patient> res = new List<Patient>();
            while (reader.Read())
            {
                //P_ID, P_Vorname, P_Nachname, P_Geschlecht, P_GeborenAm, P_LetzterKartei

                Patient _Patient = new Patient();
                IDataRecord record = reader;
                _Patient.ID = Convert.ToInt32(String.Format("{0}", record[0]));
                _Patient.Vorname = String.Format("{0}", record[1]);
                _Patient.Nachname = String.Format("{0}", record[2]);
                _Patient.Geschlecht = String.Format("{0}", record[3]);
                //_Patient.GeborenAm = new DateTime(Convert.ToInt32(String.Format("{0}", record[4]))); // Format Fehler
                res.Add(_Patient);
            }
            return res;
        }

        #endregion
    }
}
