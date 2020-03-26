using Karteien.Klassen;
using Karteien.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartei.Dialog
{
    public partial class D_Benutzer : Form
    {
        private User _user = new User();
        public D_Benutzer(User User)
        {
            InitializeComponent();
            _user = User;
            if(_user.ID < 0)
            {
                button_Löschen.Visible = false;
            }
            textBox_User.Text = _user.UserID;
            textBox_Vorname.Text = _user.Vorname;
            textBox_Nachname.Text = _user.Nachname;
        }

        private void button_Speichern_Click(object sender, EventArgs e)
        {
            if (textBox_Kennwort1.Text == textBox_Kennwort2.Text && textBox_Kennwort1.Text.Length > 0)
            {
                _user.UserID = textBox_User.Text;
                _user.Vorname = textBox_Vorname.Text;
                _user.Nachname = textBox_Nachname.Text;
                _user.Kennwort = textBox_Kennwort1.Text;
                AnmeldeService service = new AnmeldeService(_user);
                if (_user.ID >= 0)
                {
                    if (service.UpdateUser())
                    {
                        MessageBox.Show("Benutzer Aktualiesiert!");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    if (service.InsertUser())
                    {
                        MessageBox.Show("Benutzer Gespeichert");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Das Kennwort stimmt nicht überein","Kennwort");
            }
            
        }

        private void button_Abbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Löschen_Click(object sender, EventArgs e)
        {
            AnmeldeService service = new AnmeldeService(_user);
            service.DeleteUser();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
