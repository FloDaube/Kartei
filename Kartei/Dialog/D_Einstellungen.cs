using Kartei.Dialog;
using Karteien.Klassen;
using Karteien.Service;
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

namespace Karteien.Dialog
{
    public partial class D_Einstellungen : Form
    {
        private TabPage adminPage;
        private User _User = new User();
        private List<User> Users = new List<User>();
        AnmeldeService service = new AnmeldeService(new User());
        public D_Einstellungen(User user)
        {
            InitializeComponent();
            _User = user;
            service = new AnmeldeService(_User);
        }

        private void Einstellungen_Load(object sender, EventArgs e)
        {
            adminPage = tabControl1.TabPages[2];
            tabControl1.TabPages.Remove(adminPage);
            if (_User.Role == "Admin")
            {
                tabControl1.TabPages.Add(adminPage);
                //textBox_Server.Enabled = true;
                //textBox_Database.Enabled = true;
                //textBox_SQLUser.Enabled = true;
                //textBox_Kennwort1.Enabled = true;
                //textBox_Kennwort2.Enabled = true;
                //button_Speichern_Database.Enabled = true;
                UserListviewLaden();
            }
            label_ID.Text = _User.ID.ToString();
            label_UserID.Text = _User.UserID;
            label_Vorname.Text = _User.Vorname;
            label_Nachname.Text = _User.Nachname;
            label_Role.Text = _User.Role;
        }

        private void UserListviewLaden()
        {
            listView_Users.Items.Clear();
            Users = service.GetUserList();
            foreach(User u in Users)
            {
                ListViewItem itm = new ListViewItem();
                itm.Text = u.ID.ToString();
                itm.SubItems.Add(u.UserID);
                itm.SubItems.Add(u.Vorname);
                itm.SubItems.Add(u.Nachname);
                //itm.SubItems.Add(u.Role);
                listView_Users.Items.Add(itm);
            }
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

        private void button_Speichern_Benutzer_Click(object sender, EventArgs e)
        {
            if (textBox_UserKennwort1.Text == textBox_UserKennwort2.Text)
            {
                _User.Kennwort = textBox_UserKennwort1.Text;
                AnmeldeService service = new AnmeldeService(_User);
                if (service.UpdateUser())
                {
                    MessageBox.Show("Kennwort Aktualiesiert!");
                }
            }
            else
            {
                MessageBox.Show("Kennworter müssen übereinstimmen!","Kennwort");
            }
        }

        private void textBox_UserKennwort1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox_Kennwort2.Focus();
            }

        }

        private void textBox_UserKennwort2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                object s = new object();
                EventArgs ea = new EventArgs();
                button_Speichern_Benutzer_Click(s,ea);
            }
        }

        private void button_NeuerUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            D_Benutzer benutzer = new D_Benutzer(user);
            if (benutzer.ShowDialog() == DialogResult.OK)
            {
                UserListviewLaden();
            }
        }

        private void UserAugewahlt(object sender, MouseEventArgs e)
        {
            int lv = Convert.ToInt32(listView_Users.SelectedItems[0].Text);
            foreach (User u in Users)
            {
                if (u.ID == lv)
                {
                    D_Benutzer benutzer = new D_Benutzer(u);
                    if (benutzer.ShowDialog() == DialogResult.OK)
                    {
                        UserListviewLaden();
                    }
                }
            }
        }
    }
}
