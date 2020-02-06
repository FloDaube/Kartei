using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kartei.Klassen;
using Kartei.SQLDataHandler;

namespace Kartei.Service
{
    public class AnmeldeService
    {
        string Connetionstring = "Data Source='localhost';Initial Catalog = 'SAEL_KarteiProjekt'; User ID = 'SAEL_DB_User'; Password='KdycUvcYfzYXdJ1YVBPi'";
        User _user;
        SQLData _SQLData = new SQLData();
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
                    SqlCommand command = new SqlCommand(_SQLData.getAnmeldung_Select(_user.UserID,_user.Kennwort), connection);
                    
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            res = _SQLData.ReadUser(reader);
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
        private static void ReadSingleRow(IDataRecord record)
        {
            MessageBox.Show(String.Format("{0}, {1}", record[0], record[1]));
        }
    }
}
