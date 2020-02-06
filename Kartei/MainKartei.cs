using Kartei.Dialog;
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
    public partial class MainKartei : Form
    {
        private Form _loginDialog;
        private User _user;
        private bool _abmelden;
        public MainKartei(User User, Form form)
        {
            InitializeComponent();
            _user = User;
            _loginDialog = form;
            timer_AnmeldungScreen.Enabled = true;
        }

        private void SuchePartient(object sender, EventArgs e)
        {

        }

        private void Neuer_Patient(object sender, EventArgs e)
        {

        }

        private void Krankmeldung(object sender, EventArgs e)
        {
            dateTimePicker_KMBis.Enabled = checkBox_Krankmeldung.Checked;
            dateTimePicker_KMVon.Enabled = checkBox_Krankmeldung.Checked;
        }

        private void checkBox_WiederholVorgang_CheckedChanged(object sender, EventArgs e)
        {
            textBox_WiderholungsKarteiID.Enabled = checkBox_WiederholVorgang.Checked;
        }

        private void Timer_AnmeldungScreen_Tick(object sender, EventArgs e)
        {
            timer_AnmeldungScreen.Enabled = false;
            //_loginDialog.Close();
            _loginDialog.Visible = false;
        }

        private void EinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            D_Einstellungen einstellungen = new D_Einstellungen();
            einstellungen.ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!_abmelden)
            {
                _loginDialog.Close();
            }
            base.OnClosing(e);
        }
    }
}
