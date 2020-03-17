using Karteien.Dialog;
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

namespace Kartei
{
    public partial class MainKartei : Form
    {
        private PatientenService _patientenService = new PatientenService();
        private Form _loginDialog;
        private User _user;
        private bool _abmelden;
        private bool AenderungSpeichern = false;
        private int OpenKarteiID = 0;
        private int OpenPatientID = -1;

        private List<Patient> patienten = new List<Patient>();
        private List<P_Kartei> karteien = new List<P_Kartei>();

        public MainKartei(User User, Form form)
        {
            InitializeComponent();
            _user = User;
            _loginDialog = form;
            timer_AnmeldungScreen.Enabled = true;
            timer_LadePatienten.Enabled = true;
            timer_SpeicherButtonAkktualiesieren.Enabled = true;
        }

        private void SuchePartient(object sender, EventArgs e)
        {
            
            patienten = _patientenService.GetPatienten(textBox_PatientenSuche.Text);
            UpdatePetientenViewe();
             
        }

        private void Neuer_Patient(object sender, EventArgs e)
        {
            OpenPatientID = -1;
            textBox_Vorname.Text = "";
            textBox_Nachname.Text = "";
            textBox_Geschlecht.Text = "";
            dateTimePicker_Geburtstag.Value = DateTime.Today;
            label_Alter.Text = "";

            karteien = _patientenService.getKarteiOfPatient(OpenPatientID);
            UpdateKarteiView();
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
            if (AenderungSpeichern)
            {
                if(MessageBox.Show("Speichern?","Speichern",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ///Updatebefehlt
                    ///
                    AenderungSpeichern = false;
                    int lv = Convert.ToInt32(listView_Patienten.SelectedItems[0].Tag);
                    foreach (Patient p in patienten)
                    {
                        if (p.ID == lv)
                        {
                            OpenPatientID = lv;
                            textBox_Vorname.Text = p.Vorname;
                            textBox_Nachname.Text = p.Nachname;
                            textBox_Geschlecht.Text = p.Geschlecht;
                            dateTimePicker_Geburtstag.Value = p.GeborenAm;
                            label_Alter.Text = p.Alter.ToString();
                        }
                    }
                    karteien = _patientenService.getKarteiOfPatient(lv);
                    UpdateKarteiView();
                }
                else
                {
                    AenderungSpeichern = false;
                    int lv = Convert.ToInt32(listView_Patienten.SelectedItems[0].Tag);
                    foreach (Patient p in patienten)
                    {
                        if (p.ID == lv)
                        {
                            textBox_Vorname.Text = p.Vorname;
                            textBox_Nachname.Text = p.Nachname;
                            textBox_Geschlecht.Text = p.Geschlecht;
                            dateTimePicker_Geburtstag.Value = p.GeborenAm;
                            label_Alter.Text = p.Alter.ToString();
                        }
                    }
                    karteien = _patientenService.getKarteiOfPatient(lv);
                    UpdateKarteiView();
                }
            }
            else
            {
                int lv = Convert.ToInt32(listView_Patienten.SelectedItems[0].Tag);
                foreach (Patient p in patienten)
                {
                    if (p.ID == lv)
                    {
                        OpenPatientID = lv;
                        textBox_Vorname.Text = p.Vorname;
                        textBox_Nachname.Text = p.Nachname;
                        textBox_Geschlecht.Text = p.Geschlecht;
                        dateTimePicker_Geburtstag.Value = p.GeborenAm;
                        label_Alter.Text = p.Alter.ToString();
                    }
                }
                karteien = _patientenService.getKarteiOfPatient(lv);
                UpdateKarteiView();
            }
        }

        private void UpdateKarteiView()
        {
            textBox_Arzt.Text = "";
            dateTimePicker_Datum.Value = DateTime.Today;
            checkBox_WiederholVorgang.Checked = false;
            textBox_WiderholungsKarteiID.Text = "";
            richTextBox_Beschwerde.Text = "";
            checkBox_Krankmeldung.Checked = false;
            dateTimePicker_KMVon.Value = DateTime.Today;
            dateTimePicker_KMBis.Value = DateTime.Today;
            richTextBox_Diagnose.Text = "";

            listView_Kartei.Items.Clear();
            foreach (P_Kartei k in karteien)
            {
                ListViewItem lv = new ListViewItem();
                lv.Tag = k.ID;
                lv.Text = k.Kurzbeschreibung1;
                lv.SubItems.Add(Convert.ToString(k.Datum));
                listView_Kartei.Items.Add(lv);
            }
            
        }
        private void SortiereByColumm(object sender, ColumnClickEventArgs e)
        {

        }

        private void Kartei_Click(object sender, EventArgs e)
        {
            int lv = Convert.ToInt32(listView_Kartei.SelectedItems[0].Tag);
            OpenKarteiID = lv;
            foreach (P_Kartei k in karteien)
            {
                if (lv == k.ID && AenderungSpeichern == false)
                {
                    textBox_Arzt.Text = k.Arzt;
                    dateTimePicker_Datum.Value = k.Datum;
                    if (k.VorherigeID == -1)
                    {
                        checkBox_WiederholVorgang.Checked = false;
                    }
                    else
                    {
                        checkBox_WiederholVorgang.Checked = true;
                        textBox_WiderholungsKarteiID.Text = k.VorherigeID.ToString();
                    }
                    richTextBox_Beschwerde.Text = k.Beschwerde;
                    checkBox_Krankmeldung.Checked = k.Krankmeldung;
                    if (k.Krankmeldung)
                    {
                        dateTimePicker_KMVon.Value = k.KrankmeldungVon;
                        dateTimePicker_KMBis.Value = k.KrankmeldungBis;
                    }
                    richTextBox_Diagnose.Text = k.Diagnose;
                }
                else if (lv == k.ID && AenderungSpeichern)
                {

                }
            }
        }

        private void OeffneVorherigeKartei(object sender, EventArgs e)
        {
            int lv = Convert.ToInt32(textBox_WiderholungsKarteiID.Text);
            OpenKarteiID = lv;
            foreach (P_Kartei k in karteien)
            {
                if (lv == k.ID /*&& AenderungSpeichern == false*/)
                {
                    textBox_Arzt.Text = k.Arzt;
                    dateTimePicker_Datum.Value = k.Datum;
                    if (k.VorherigeID == -1)
                    {
                        checkBox_WiederholVorgang.Checked = false;
                        textBox_WiderholungsKarteiID.Text = "";
                    }
                    else
                    {
                        checkBox_WiederholVorgang.Checked = true;
                        textBox_WiderholungsKarteiID.Text = k.VorherigeID.ToString();
                    }
                    richTextBox_Beschwerde.Text = k.Beschwerde;
                    checkBox_Krankmeldung.Checked = k.Krankmeldung;
                    if (k.Krankmeldung)
                    {
                        dateTimePicker_KMVon.Value = k.KrankmeldungVon;
                        dateTimePicker_KMBis.Value = k.KrankmeldungBis;
                    }
                    richTextBox_Diagnose.Text = k.Diagnose;
                }
                else if (AenderungSpeichern)
                {

                }
            }
        }

        private void timer_SpeicherButtonAkktualiesieren_Tick(object sender, EventArgs e)
        {
            /*if (OpenKarteiID > 0)
            {
                //Überprüfe ob etwas verändert wurde
                foreach (P_Kartei k in karteien)
                {
                    if (k.ID == OpenKarteiID)
                    {
                        if (textBox_Arzt.Text == k.Arzt && dateTimePicker_Datum.Value == k.Datum && richTextBox_Beschwerde.Text == k.Beschwerde && checkBox_Krankmeldung.Checked == k.Krankmeldung && richTextBox_Diagnose.Text == k.Diagnose)
                        {
                            if (k.Krankmeldung)
                            {
                                if (dateTimePicker_KMVon.Value == k.KrankmeldungVon && dateTimePicker_KMBis.Value == k.KrankmeldungBis && textBox_WiderholungsKarteiID.Text == k.VorherigeID.ToString())
                                {
                                    AenderungSpeichern = false;
                                }
                                else
                                {
                                    AenderungSpeichern = true;
                                }
                            }
                            else
                            {
                                AenderungSpeichern = false;
                            }
                        }
                        else
                        {
                            AenderungSpeichern = true;
                        }
                    }
                }
                //Button Aktievieren oder Deaktivieren
                if (AenderungSpeichern)
                {
                    button_Speichern.Visible = true;
                    Button_Abbrechen.Visible = true;
                }
                else
                {
                    button_Speichern.Visible = false;
                    Button_Abbrechen.Visible = false;
                }
            }*/
            
        }

        private void dateTimePicker_Geburtstag_ValueChanged(object sender, EventArgs e)
        {
            label_Alter.Text = Alter_Berechner(dateTimePicker_Geburtstag.Value).ToString();
        }

        private int Alter_Berechner(DateTime Bday)
        {
            var now = DateTime.Today;
            int alter = now.Year - Bday.Year;
            if (now.Month < Bday.Month && now.Day < Bday.Day)
            {
                --alter;
            }
            return alter;
        }

        private void button_PatientSpeichern_Click(object sender, EventArgs e)
        {
            if (OpenPatientID == -1)
            {
                //Insert
                Patient p = new Patient();
                p.Vorname = textBox_Vorname.Text;
                p.Nachname = textBox_Nachname.Text;
                p.Geschlecht = textBox_Geschlecht.Text;
                p.GeborenAm = dateTimePicker_Geburtstag.Value;
                _patientenService.InsertPatient(p);
                textBox_Arzt.Text = "";
                dateTimePicker_Datum.Value = DateTime.Today;
                checkBox_WiederholVorgang.Checked = false;
                textBox_WiderholungsKarteiID.Text = "";
                richTextBox_Beschwerde.Text = "";
                checkBox_Krankmeldung.Checked = false;
                dateTimePicker_KMVon.Value = DateTime.Today;
                dateTimePicker_KMBis.Value = DateTime.Today;
                richTextBox_Diagnose.Text = "";
                patienten = _patientenService.GetPatienten(textBox_PatientenSuche.Text);
                UpdatePetientenViewe();
            }
            else
            {
                //Update
                Patient p = new Patient();
                p.ID = OpenPatientID;
                p.Vorname = textBox_Vorname.Text;
                p.Nachname = textBox_Nachname.Text;
                p.Geschlecht = textBox_Geschlecht.Text;
                p.GeborenAm = dateTimePicker_Geburtstag.Value;
                _patientenService.UpdatePatient(p);
                patienten = _patientenService.GetPatienten(textBox_PatientenSuche.Text);
                UpdatePetientenViewe();

            }
        }

        private void button_KarteiSpeichern_Click(object sender, EventArgs e)
        {
            if(OpenKarteiID == -1)
            {
                //Insert
            }
            else
            {
                //Update
            }
        }
    }
}
