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
            }
            label_ID.Text = _User.ID.ToString();
            label_UserID.Text = _User.UserID;
            label_Vorname.Text = _User.Vorname;
            label_Nachname.Text = _User.Nachname;
            
        }
    }
}
