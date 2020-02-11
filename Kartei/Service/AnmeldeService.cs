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
        private SQLData _SQLData = new SQLData();
        private string Connetionstring = "";
        User _user;
        public AnmeldeService(User user)
        {
            this.User = user;
            Connetionstring = _SQLData.getConnectioString();
        }

        public User User { get => _user; set => _user = value; }

        public User Anmelden()
        {
            User res = new User();

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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Feheler Bei der Anmeldung!");
                    }
                    //Lade Anmelde Daten
                }
                
            }

            return res;
        }
    }
}
