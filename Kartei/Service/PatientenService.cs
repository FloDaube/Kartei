using Karteien.Klassen;
using Karteien.SQLDataHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karteien.Service
{
    public class PatientenService
    {
        private SQLData _SQLData = new SQLData();
        private string Connetionstring = "";
        private Patient _patient= new Patient();
        public PatientenService(Patient Patient)
        {
            this._patient = Patient;
            Connetionstring = _SQLData.getConnectioString();
        }
        public PatientenService()
        {
            Connetionstring = _SQLData.getConnectioString();
        }

        public List<Patient> GetPatienten(string Suche = "")
        {
            List<Patient> res = new List<Patient>();

            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //SqlCommand command = new SqlCommand(_SQLData.getAnmeldung_Select(_user.UserID, _user.Kennwort), connection);
                    SqlCommand command = new SqlCommand(_SQLData.getPatientenList_Select(Suche), connection);

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            //res = _SQLData.ReadUser(reader);
                            res = _SQLData.ReadPatientList(reader);
                        }
                        else
                        {
                            MessageBox.Show("Kein Patient gefunden.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //Lade Anmelde Daten
                }

            }

            return res;
        }
        public bool InsertPatient(Patient patient)
        {
            bool res = false;

            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //SqlCommand command = new SqlCommand(_SQLData.getAnmeldung_Select(_user.UserID, _user.Kennwort), connection);
                    SqlCommand command = new SqlCommand(_SQLData.InsertPatient(patient), connection);

                    try
                    {
                        var t = command.ExecuteReader();
                        if (t.RecordsAffected > 0)
                        {
                            res = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //Lade Anmelde Daten
                }
            }
            return res;
        }
        public bool UpdatePatient(Patient patient)
        {
            bool res = false;

            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //SqlCommand command = new SqlCommand(_SQLData.getAnmeldung_Select(_user.UserID, _user.Kennwort), connection);
                    SqlCommand command = new SqlCommand(_SQLData.UpdatePatient(patient), connection);

                    try
                    {
                        var t = command.ExecuteReader();
                        if (t.RecordsAffected > 0)
                        {
                            res = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //Lade Anmelde Daten
                }
            }
            return res;
        }
        public List<P_Kartei> getKarteiOfPatient(int patient_ID)
        {
            var res = new List<P_Kartei>();

            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //SqlCommand command = new SqlCommand(_SQLData.getAnmeldung_Select(_user.UserID, _user.Kennwort), connection);
                    SqlCommand command = new SqlCommand(_SQLData.getKarteiList_Select(patient_ID), connection);

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            //res = _SQLData.ReadUser(reader);
                            res = _SQLData.ReadKarteiList(reader);
                        }
                        else
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //Lade Anmelde Daten
                }

            }

            return res;
        }
        public bool InsertKartei(P_Kartei kartei)
        {
            bool res = false;

            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //SqlCommand command = new SqlCommand(_SQLData.getAnmeldung_Select(_user.UserID, _user.Kennwort), connection);
                    SqlCommand command = new SqlCommand(_SQLData.InsertKartei(kartei), connection);
                    try
                    {
                        var t = command.ExecuteReader();
                        if (t.RecordsAffected > 0)
                        {
                            res = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //Lade Anmelde Daten
                }
            }
            return res;
        }
        public bool UpdateKartei(P_Kartei kartei)
        {
            bool res = false;

            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //SqlCommand command = new SqlCommand(_SQLData.getAnmeldung_Select(_user.UserID, _user.Kennwort), connection);
                    SqlCommand command = new SqlCommand(_SQLData.UpdateKartei(kartei), connection);
                    try
                    {
                        var t = command.ExecuteReader();
                        if (t.RecordsAffected > 0)
                        {
                            res = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //Lade Anmelde Daten
                }
            }
            return res;
        }
    }
}
