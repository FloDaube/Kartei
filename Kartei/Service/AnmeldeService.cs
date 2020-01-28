using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kartei.Klassen;

namespace Kartei.Service
{
    public class AnmeldeService
    {
        string Connetionstring = "Data Source='localhost';Initial Catalog = 'SAEL_KarteiProjekt'; User ID = 'SAEL_DB_User'; Password='KdycUvcYfzYXdJ1YVBPi'";
        User _user;

        public AnmeldeService(User user)
        {
            this.User = user;
        }

        public User User { get => _user; set => _user = value; }

        public User Anmelden()
        {
            User res = new User();

            //using (SqlConnection connection = new SqlConnection($"Server=localhost;Database=SAEL_KarteiProjekt;User Id=SAEL_DB_User;Password=KdycUvcYfzYXdJ1YVBPi;"))
            //{
            //    connection.Open();
            //    // Do work here; connection closed on following line.  
            //}
            //SQL ANMELDUNG
            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                connection.Open();
                if(connection.State == ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand($"SELECT U_ID, U_User_ID, U_Vorname, U_Nachname FROM [User] Where U_User_ID = @U_User_ID", connection);
                    command.Parameters.Add("@U_User_ID", SqlDbType.NVarChar);
                    command.Parameters.Add("@U_Kennwort", SqlDbType.NVarChar);
                    command.Parameters["@U_User_ID"].Value = _user.UserID;
                    command.Parameters["@U_Kennwort"].Value = _user.Kennwort;

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                            }
                        }
                        else
                        {
                            MessageBox.Show("No rows found.");
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
