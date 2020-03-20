using Karteien.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartei
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Anmelden_Click(object sender, EventArgs e)
        {
            try
            {
                //Settings Laden
                var appSettings = ConfigurationManager.AppSettings;
                string Host = appSettings[0] ?? "Not Found";
                if(Host != "")
                {
                    Einstellungen.Host = Host;
                }
                string DB = appSettings[1] ?? "Not Found";
                if (DB != "")
                {
                    Einstellungen.DataBase = DB;
                }
                string User = appSettings[2] ?? "Not Found";
                if(User != "")
                {
                    Einstellungen.SQLUser = User;
                }
                string Kennwort = appSettings[3] ?? "Not Found";
                if(Kennwort != "")
                {
                    Einstellungen.Passwort = Kennwort;
                }
            }
            catch { }
            User _user = new User(textBox_Username.Text,textBox_Kennwort.Text);
            _user.Anmelden();
            textBox_Kennwort.Text = "";
            if (_user.ID > 0)
            {
                MainKartei mainKartei = new MainKartei(_user,this);
                mainKartei.Show();
            }
            else if(_user.ID == -2)
            {

            }
            else
            {
                MessageBox.Show("Es konnte keine Passende Anmeldung gefunden. \nBitte überpüfen Sie ihre Eingaben", "Konnte nicht Anmelden!");
            }
        }

        private void AnmeldungsInfos_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Username.Text.Length > 0)
            {
                if(textBox_Kennwort.Text.Length > 0)
                {
                    button_Anmelden.Enabled = true;
                }
            }
        }


        private void textBox_Username_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_Kennwort.Focus();
            }
        }

        private void textBox_Kennwort_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                object s = new object();
                EventArgs ea = new EventArgs();
                Button_Anmelden_Click(s, ea);
            }
        }
    }
}
