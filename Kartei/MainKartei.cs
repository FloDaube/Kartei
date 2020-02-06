using Kartei.Dialog;
using Kartei.Klassen;
using Kartei.Service;
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
        private PatientenService _patientenService = new PatientenService();
        private Form _loginDialog;
        private User _user;
        private bool _abmelden;

        private List<Patient> patienten = new List<Patient>();

        public MainKartei(User User, Form form)
        {
            InitializeComponent();
            _user = User;
            _loginDialog = form;
            timer_AnmeldungScreen.Enabled = true;
        }

        private void SuchePartient(object sender, EventArgs e)
        {
            _patientenService.GetPatienten();
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
            _loginDialog.Visible = false;

            patienten = _patientenService.GetPatienten();
            UpdatePetientenViewe();
        }

        private void EinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            D_Einstellungen einstellungen = new D_Einstellungen(_user);
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

        private void UpdatePetientenViewe()
        {
            foreach (Patient p in patienten)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = p.Nachname;
                lv.SubItems.Add(p.Vorname);
                listView_Patienten.Items.Add(lv);
            }
        }
    }
}
