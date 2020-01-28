using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string Anmelden()
        {
            string res = "";

            //using (SqlConnection connection = new SqlConnection($"Server=localhost;Database=SAEL_KarteiProjekt;User Id=SAEL_DB_User;Password=KdycUvcYfzYXdJ1YVBPi;"))
            //{
            //    connection.Open();
            //    // Do work here; connection closed on following line.  
            //}
            //SQL ANMELDUNG
            using (SqlConnection connection = new SqlConnection(Connetionstring))
            {
                if(connection.State == ConnectionState.Open)
                {
                    //Lade Anmelde Daten
                }
                
            }

            return res;
        }
    }
}
