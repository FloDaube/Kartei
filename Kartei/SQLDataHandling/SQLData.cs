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

        }

        #region Login Daten
        /// <summary>
        /// Gibt den Select String zurück für Anmeldung des User.
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Kennwort"></param>
        /// <returns></returns>
        public string getAnmeldung_Select(string UserID,string Kennwort)
        {
            return $"SELECT U_ID, U_User_ID, U_Vorname, U_Nachname FROM[User] Where U_User_ID = '{UserID}' AND U_Kennwort = '{Kennwort}'";
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
            }
            return res;
        }
        #endregion

        public string getPatientenList_Select()
        {
            return $"SELECT * From [Patienten] Order by P_Nachname"; 
        }
    }
}
