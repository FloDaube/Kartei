using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karteien.Klassen;
using Karteien.SQLDataHandler;

namespace Karteien.Service
{
    public class AnmeldeService
    {
        private SQLData _SQLData = new SQLData();
        private string Connetionstring = "";
        User _user;
        public AnmeldeService(User user)
        {
            this.User = user;
            Connetionstring = _SQLData.getConnectioString();
            //Connetionstring = @"Data Source=THINKPADT440S;" + "Initial Catalog=SEAL_KarteiProjekt;" + "User id=Test;" + "Password=123;";
        }

        public User User { get => _user; set => _user = value; }

        public User Anmelden()
        {
            User res = new User {ID = -2 };

            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand command = new SqlCommand(_SQLData.getAnmeldung_Select(_user.UserID, _user.Kennwort), connection);

                        try
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                res = _SQLData.ReadUser(reader);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Feheler Bei der Anmeldung!");
                        }
                        //Lade Anmelde Daten
                    }
                    else
                    {
                        MessageBox.Show("Keine Verbinndung zu Server möglich!", "Verbinndung");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler");
                }
                
            }

            return res;
        }

        public bool UpdateUser()
        {
            bool res = false;
            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand command = new SqlCommand(_SQLData.UpdateUser(_user), connection);

                        try
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.RecordsAffected > 0)
                            {
                                res = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Feheler Bei der Anmeldung!");
                        }
                        //Lade Anmelde Daten
                    }
                    else
                    {
                        MessageBox.Show("Keine Verbinndung zu Server möglich!", "Verbinndung");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler");
                }
            }
            return res;
        }

        public List<User> GetUserList()
        {
            List<User> res = new List<User>();
            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand command = new SqlCommand(_SQLData.getAnmeldung_Select("","",true), connection);

                        try
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                res = _SQLData.ReadUserList(reader);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Feheler Bei der Anmeldung!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Keine Verbinndung zu Server möglich!", "Verbinndung");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler");
                }
            }
            return res;
        }
    }
}
