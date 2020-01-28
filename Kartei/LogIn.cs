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
        }
    }
}
