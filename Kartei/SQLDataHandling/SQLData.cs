﻿using Karteien.Klassen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karteien.SQLDataHandler
{
    public class SQLData
    {
        public SQLData()
        {

        }

        public string getConnectioString()
        {
            return $"Data Source = '{Einstellungen.Host}'; Initial Catalog = '{Einstellungen.DataBase}'; User ID = '{Einstellungen.SQLUser}'; Password = '{Einstellungen.Passwort}';";
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
                return $"SELECT U_ID, U_User_ID,U_Kennwort, U_Vorname, U_Nachname, U_Role FROM[User]";
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
        /// <summary>
        /// Patienten Insert String
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public string GetPatientenInsert(Patient patient)
        {
            string res = "";

            res = $"Insert INTO [Patienten]([P_Vorname],[P_Nachname],[P_Geschlecht],[P_GeborenAm],[P_LetzterKartei])VALUES('{patient.Vorname}','{patient.Nachname}','{patient.Geschlecht}','{patient.GeborenAm}',NULL)";

            return res;

        }
        /// <summary>
        /// User Update String
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string UpdateUser(User user)
        {
            string res = "";
            res = $"Update [User] Set U_User_ID = '{user.UserID}', U_Kennwort = '{user.Kennwort}', U_Vorname = '{user.Vorname}', U_Nachname = '{user.Nachname}', U_Role = '{user.Role}' where U_ID = {user.ID}";
            return res;
        }
        /// <summary>
        /// Insert User String
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string InsertUser(User user)
        {
            string res = "";

            res = $"Insert INTO [User](U_User_ID,U_Kennwort,U_Vorname,U_Nachname,U_Role) VALUES('{user.UserID}','{user.Kennwort}','{user.Vorname}','{user.Nachname}','{user.Role}')";

            return res;
        }

        /// <summary>
        /// Delete User String
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string DeleteUser(User user)
        {
            string res = "";

            res = $"Delete From [User] Where U_ID = {user.ID}";

            return res;
        }

        /// <summary>
        /// Read User Methode
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public List<User> ReadUserList(SqlDataReader reader)
        {
            List<User> res = new List<User>();
            while (reader.Read())
            {
                User _user = new User();
                IDataRecord record = reader;
                _user.ID = Convert.ToInt32(String.Format("{0}", record[0]));
                _user.UserID = String.Format("{0}", record[1]);
                _user.Kennwort = String.Format("{0}", record[2]);
                _user.Vorname = String.Format("{0}", record[3]);
                _user.Nachname = String.Format("{0}", record[4]);
                _user.Role = String.Format("{0}", record[5]);
                res.Add(_user);
            }
            return res;
        }
        #endregion
        #region Patienten
        /// <summary>
        /// Get PatientenList String
        /// </summary>
        /// <param name="Suche"></param>
        /// <returns></returns>
        public string getPatientenList_Select(string Suche)
        {
            string res = "";
            if (Suche == "")
            {
                res =  $"SELECT * From [Patienten] Order by P_Nachname, P_Vorname";
            }
            else
            {
                res = $"SELECT * From [Patienten] WHERE (P_Nachname >= '{Suche}') Order by P_Nachname, P_Vorname";
            }

            return res;
        }
        /// <summary>
        /// Inster Patient string
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public string InsertPatient(Patient patient)
        {
            string res = "";

            res = "Insert INTO [dbo].[Patienten]([P_Vorname],[P_Nachname],[P_Geschlecht],[P_GeborenAm])VALUES" +
                $"('{patient.Vorname}','{patient.Nachname}','{patient.Geschlecht}','{patient.GeborenAm.Date}')";

            return res;
        }
        /// <summary>
        /// Update Patient String
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public string UpdatePatient(Patient patient)
        {
            string res = "";
            res = $"UPDATE [dbo].[Patienten] SET [P_Vorname] = '{patient.Vorname}',[P_Nachname] = '{patient.Nachname}',[P_Geschlecht] = '{patient.Geschlecht}',[P_GeborenAm] = '{patient.GeborenAm}'" +
                $"Where P_ID = '{patient.ID}'";
            return res;
        }
        /// <summary>
        /// Read Patienten Liste
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public List<Patient> ReadPatientList(SqlDataReader reader)
        {
            List<Patient> res = new List<Patient>();
            while (reader.Read())
            {
                //P_ID, P_Vorname, P_Nachname, P_Geschlecht, P_GeborenAm, P_LetzterKartei
                try
                {
                    Patient _Patient = new Patient();
                    IDataRecord record = reader;
                    _Patient.ID = Convert.ToInt32(String.Format("{0}", record[0]));
                    _Patient.Vorname = String.Format("{0}", record[1]);
                    _Patient.Nachname = String.Format("{0}", record[2]);
                    _Patient.Geschlecht = String.Format("{0}", record[3]);
                    string[] date = String.Format("{0}", record[4]).Split('.');
                    string[] d = date[2].Split(' ');
                    date[2] = d[0];
                    _Patient.GeborenAm = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]));
                    res.Add(_Patient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Fehler beim Patienten Laden!");
                    return res;
                }
            }
            return res;
        }
        /// <summary>
        /// Kartei Liste String
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string getKarteiList_Select(int ID)
        {
            string res = "";

            res = $"SELECT * From [Karteien] Where K_Patient_ID = {ID} Order by K_Datum DESC";

            return res;
        }
        /// <summary>
        /// Inster Kartei string
        /// </summary>
        /// <param name="kartei"></param>
        /// <returns></returns>
        public string InsertKartei(P_Kartei kartei)
        {
            string res = "";

            res = $"INSERT INTO [dbo].[Karteien]([K_Patient_ID],[K_Arzt],[K_VorhaerigeID],[K_Kurzbeschreibung],[K_Datum],[K_Beschwerden],[K_Krankmeldung]" +
           ",[K_KrankmeldungVon],[K_KrankmeldungBis],[K_Diagnose])VALUES(" +
           $"'{kartei.Patient_ID}','{kartei.Arzt}','{kartei.VorherigeID}','{kartei.Kurzbeschreibung1}','{kartei.Datum}','{kartei.Beschwerde}','{kartei.Krankmeldung}','{kartei.KrankmeldungVon}','{kartei.KrankmeldungBis}','{kartei.Diagnose}')";

            return res;
        }
        /// <summary>
        /// Update Kartei string
        /// </summary>
        /// <param name="kartei"></param>
        /// <returns></returns>
        public string UpdateKartei(P_Kartei kartei)
        {
            string res = "";

            res = $"Update [dbo].[Karteien] SET K_Patient_ID = {kartei.Patient_ID},K_VorhaerigeID = {kartei.VorherigeID},K_Kurzbeschreibung = '{kartei.Kurzbeschreibung1}',K_Datum = '{kartei.Datum.Date}'," +
                $"K_Beschwerden = '{kartei.Beschwerde}',K_Krankmeldung = '{kartei.Krankmeldung}',K_KrankmeldungVon = '{kartei.KrankmeldungVon}',K_KrankmeldungBis = '{kartei.KrankmeldungBis}',K_Diagnose = '{kartei.Diagnose}'" +
                $"Where K_ID = {kartei.ID}";

            return res;
        }
        /// <summary>
        /// Read Kartei Liste
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public List<P_Kartei> ReadKarteiList(SqlDataReader reader)
        {
            List<P_Kartei> res = new List<P_Kartei>();

            while (reader.Read())
            {
                //P_ID, P_Vorname, P_Nachname, P_Geschlecht, P_GeborenAm, P_LetzterKartei
                try
                {
                    P_Kartei kartei = new P_Kartei();
                    IDataRecord record = reader;
                    kartei.ID = Convert.ToInt32(String.Format("{0}", record[0]));
                    kartei.Patient_ID = Convert.ToInt32(String.Format("{0}", record[1]));
                    kartei.Arzt = String.Format("{0}", record[2]);
                    kartei.VorherigeID = Convert.ToInt32(String.Format("{0}", record[3]));
                    //kartei.Kurzbeschreibung1 = String.Format("{0}", record[2]);
                    kartei.Kurzbeschreibung1 = String.Format("{0}", record[4]);
                    string[] date = String.Format("{0}", record[5]).Split('.');
                    string[] time = date[2].Split(' ');
                    date[2] = time[0];
                    kartei.Datum = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]));
                    kartei.Beschwerde = String.Format("{0}", record[6]);
                    kartei.Krankmeldung = Convert.ToBoolean(String.Format("{0}", record[7]));
                    if (kartei.Krankmeldung)
                    {
                        date = String.Format("{0}", record[8]).Split('.');
                        time = date[2].Split(' ');
                        date[2] = time[0];
                        kartei.KrankmeldungVon = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]));
                        date = String.Format("{0}", record[9]).Split('.');
                        time = date[2].Split(' ');
                        date[2] = time[0];
                        kartei.KrankmeldungBis = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]));

                    }
                    kartei.Diagnose = String.Format("{0}",record[10]);
                    res.Add(kartei);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler beim Patienten Laden!");
                    return res;
                }
            }
            return res;
        }
        
        #endregion
    }
}
