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
        public MainKartei()
        {
            InitializeComponent();
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
    }
}
