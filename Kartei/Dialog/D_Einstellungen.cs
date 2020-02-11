using Kartei.Klassen;
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

namespace Kartei.Dialog
{
    public partial class D_Einstellungen : Form
    {
        private TabPage adminPage;
        private User _User = new User();
        public D_Einstellungen(User user)
        {
            InitializeComponent();
            _User = user;
        }

        private void Einstellungen_Load(object sender, EventArgs e)
        {
            adminPage = tabControl1.TabPages[2];
            tabControl1.TabPages.Remove(adminPage);
            if (_User.Role == "Admin")
            {
                tabControl1.TabPages.Add(adminPage);
                textBox_Server.Enabled = true;
                textBox_Database.Enabled = true;
                textBox_SQLUser.Enabled = true;
                textBox_Kennwort1.Enabled = true;
                textBox_Kennwort2.Enabled = true;
                button_Speichern_Database.Enabled = true;
            }
            label_ID.Text = _User.ID.ToString();
            label_UserID.Text = _User.UserID;
            label_Vorname.Text = _User.Vorname;
            label_Nachname.Text = _User.Nachname;
            label_Role.Text = _User.Role;
        }

        private void Speicher_DatenabnkEinstellung(object sender, EventArgs e)
        {
            Einstellungen.Host = textBox_Server.Text;
            Einstellungen.DataBase = textBox_Database.Text;
            Einstellungen.SQLUser = textBox_SQLUser.Text;
            //Settings Laden
            var appSettings = ConfigurationManager.AppSettings;
            appSettings.Set("Server", Einstellungen.Host);
            appSettings.Set("Database", Einstellungen.DataBase);
            appSettings.Set("User", Einstellungen.SQLUser);
            appSettings.Set("Kennwort", Einstellungen.Passwort);

        }
    }
}
