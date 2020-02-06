using Kartei.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            User _user = new User(textBox_Username.Text,textBox_Kennwort.Text);
            _user.Anmelden();
            textBox_Kennwort.Text = "";
            if (_user.ID > 0)
            {
                MainKartei mainKartei = new MainKartei(_user,this);
                mainKartei.Show();
            }
            else
            {

            }
        }

        private void TextBox_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox_Kennwort.Focus();
            }
        }

        private void TextBox_Kennwort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                object s = new object();
                EventArgs ea = new EventArgs();
                Button_Anmelden_Click(s,ea);
            }
        }
    }
}
