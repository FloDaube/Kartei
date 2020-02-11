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
            timer_LadePatienten.Enabled = true;
        }

        private void SuchePartient(object sender, EventArgs e)
        {
            patienten = _patientenService.GetPatienten(textBox_PatientenSuche.Text);
            UpdatePetientenViewe();
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
            else
            {
                _loginDialog.Visible = true;
            }
            base.OnClosing(e);
        }

        private void UpdatePetientenViewe()
        {
            listView_Patienten.Items.Clear();
            foreach (Patient p in patienten)
            {
                ListViewItem lv = new ListViewItem();
                lv.Tag = p.ID;
                lv.Text = p.Nachname;
                lv.SubItems.Add(p.Vorname);
                lv.SubItems.Add(p.Alter.ToString());
                listView_Patienten.Items.Add(lv);
            }
        }

        private void Timer_LadePatienten_Tick(object sender, EventArgs e)
        {
            timer_LadePatienten.Enabled = false;
            patienten = _patientenService.GetPatienten();
            UpdatePetientenViewe();
        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AbmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _abmelden = true;
            Close();
        }

        private void TextBox_PatientenSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                object s = new object();
                EventArgs ea = new EventArgs();
                SuchePartient(s,ea);
            }
        }

        private void ListView_Patienten_Click(object sender, EventArgs e)
        {
            int lv = Convert.ToInt32(listView_Patienten.SelectedItems[0].Tag);
            foreach(Patient p in patienten)
            {
                if(p.ID == lv)
                {
                    textBox_Vorname.Text = p.Vorname;
                    textBox_Nachname.Text = p.Nachname;
                    textBox_Geschlecht.Text = p.Geschlecht;
                    dateTimePicker_Geburtstag.Value = p.GeborenAm;
                    label_Alter.Text = p.Alter.ToString();
                }
            }
        }

    }
}
