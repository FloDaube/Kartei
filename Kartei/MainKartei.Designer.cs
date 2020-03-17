namespace Kartei
{
    partial class MainKartei
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Patienten = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PatientenSuche = new System.Windows.Forms.TextBox();
            this.listView_Patienten = new System.Windows.Forms.ListView();
            this.columnHeader_Nachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Alter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Kartei = new System.Windows.Forms.ListView();
            this.columnHeader_Kurzbeschreibung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker_Datum = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_WiderholungsKarteiID = new System.Windows.Forms.TextBox();
            this.checkBox_WiederholVorgang = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_KMBis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_KMVon = new System.Windows.Forms.DateTimePicker();
            this.checkBox_Rezept = new System.Windows.Forms.CheckBox();
            this.checkBox_Krankmeldung = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox_Beschwerde = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Arzt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_Diagnose = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_Geburtstag = new System.Windows.Forms.DateTimePicker();
            this.label_Alter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Nachname = new System.Windows.Forms.TextBox();
            this.textBox_Vorname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer_AnmeldungScreen = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Speichern = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Abbrechen = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_LadePatienten = new System.Windows.Forms.Timer(this.components);
            this.timer_SpeicherButtonAkktualiesieren = new System.Windows.Forms.Timer(this.components);
            this.button_PatientSpeichern = new System.Windows.Forms.Button();
            this.textBox_Geschlecht = new System.Windows.Forms.ComboBox();
            this.richTextBox_Kurzbeschreibung = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_NeueKartei = new System.Windows.Forms.Button();
            this.button_NachfolgeKartei = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_PatientenSuche);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patienten Suche";
            // 
            // button_Patienten
            // 
            this.button_Patienten.Location = new System.Drawing.Point(254, 96);
            this.button_Patienten.Name = "button_Patienten";
            this.button_Patienten.Size = new System.Drawing.Size(99, 23);
            this.button_Patienten.TabIndex = 6;
            this.button_Patienten.Text = "Neuer Patient";
            this.button_Patienten.UseVisualStyleBackColor = true;
            this.button_Patienten.Click += new System.EventHandler(this.Neuer_Patient);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBox_PatientenSuche
            // 
            this.textBox_PatientenSuche.Location = new System.Drawing.Point(6, 32);
            this.textBox_PatientenSuche.Name = "textBox_PatientenSuche";
            this.textBox_PatientenSuche.Size = new System.Drawing.Size(244, 20);
            this.textBox_PatientenSuche.TabIndex = 0;
            this.textBox_PatientenSuche.TextChanged += new System.EventHandler(this.SuchePartient);
            this.textBox_PatientenSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_PatientenSuche_KeyDown);
            // 
            // listView_Patienten
            // 
            this.listView_Patienten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_Patienten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Nachname,
            this.columnHeader_Name,
            this.columnHeader_Alter});
            this.listView_Patienten.FullRowSelect = true;
            this.listView_Patienten.HideSelection = false;
            this.listView_Patienten.Location = new System.Drawing.Point(12, 89);
            this.listView_Patienten.Name = "listView_Patienten";
            this.listView_Patienten.Size = new System.Drawing.Size(256, 740);
            this.listView_Patienten.TabIndex = 1;
            this.listView_Patienten.UseCompatibleStateImageBehavior = false;
            this.listView_Patienten.View = System.Windows.Forms.View.Details;
            this.listView_Patienten.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortiereByColumm);
            this.listView_Patienten.Click += new System.EventHandler(this.ListView_Patienten_Click);
            // 
            // columnHeader_Nachname
            // 
            this.columnHeader_Nachname.Text = "Nachname";
            this.columnHeader_Nachname.Width = 109;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 90;
            // 
            // columnHeader_Alter
            // 
            this.columnHeader_Alter.Text = "Alter";
            this.columnHeader_Alter.Width = 50;
            // 
            // listView_Kartei
            // 
            this.listView_Kartei.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_Kartei.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Kurzbeschreibung,
            this.columnHeader_Datum});
            this.listView_Kartei.FullRowSelect = true;
            this.listView_Kartei.HideSelection = false;
            this.listView_Kartei.Location = new System.Drawing.Point(274, 209);
            this.listView_Kartei.Name = "listView_Kartei";
            this.listView_Kartei.Size = new System.Drawing.Size(359, 620);
            this.listView_Kartei.TabIndex = 2;
            this.listView_Kartei.UseCompatibleStateImageBehavior = false;
            this.listView_Kartei.View = System.Windows.Forms.View.Details;
            this.listView_Kartei.Click += new System.EventHandler(this.Kartei_Click);
            // 
            // columnHeader_Kurzbeschreibung
            // 
            this.columnHeader_Kurzbeschreibung.Text = "Kurbeschreibung";
            this.columnHeader_Kurzbeschreibung.Width = 250;
            // 
            // columnHeader_Datum
            // 
            this.columnHeader_Datum.Text = "Datum";
            this.columnHeader_Datum.Width = 100;
            // 
            // dateTimePicker_Datum
            // 
            this.dateTimePicker_Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Datum.Location = new System.Drawing.Point(504, 28);
            this.dateTimePicker_Datum.Name = "dateTimePicker_Datum";
            this.dateTimePicker_Datum.Size = new System.Drawing.Size(76, 20);
            this.dateTimePicker_Datum.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.richTextBox_Kurzbeschreibung);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_WiderholungsKarteiID);
            this.groupBox2.Controls.Add(this.checkBox_WiederholVorgang);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePicker_KMBis);
            this.groupBox2.Controls.Add(this.dateTimePicker_KMVon);
            this.groupBox2.Controls.Add(this.checkBox_Rezept);
            this.groupBox2.Controls.Add(this.checkBox_Krankmeldung);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.richTextBox_Beschwerde);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_Arzt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.richTextBox_Diagnose);
            this.groupBox2.Controls.Add(this.dateTimePicker_Datum);
            this.groupBox2.Location = new System.Drawing.Point(639, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 804);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kartei";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Vorgänger ID";
            // 
            // textBox_WiderholungsKarteiID
            // 
            this.textBox_WiderholungsKarteiID.Enabled = false;
            this.textBox_WiderholungsKarteiID.Location = new System.Drawing.Point(82, 84);
            this.textBox_WiderholungsKarteiID.Name = "textBox_WiderholungsKarteiID";
            this.textBox_WiderholungsKarteiID.Size = new System.Drawing.Size(100, 20);
            this.textBox_WiderholungsKarteiID.TabIndex = 13;
            this.textBox_WiderholungsKarteiID.DoubleClick += new System.EventHandler(this.OeffneVorherigeKartei);
            // 
            // checkBox_WiederholVorgang
            // 
            this.checkBox_WiederholVorgang.AutoSize = true;
            this.checkBox_WiederholVorgang.Location = new System.Drawing.Point(4, 61);
            this.checkBox_WiederholVorgang.Name = "checkBox_WiederholVorgang";
            this.checkBox_WiederholVorgang.Size = new System.Drawing.Size(121, 17);
            this.checkBox_WiederholVorgang.TabIndex = 12;
            this.checkBox_WiederholVorgang.Text = "Widerholungs Kartei";
            this.checkBox_WiederholVorgang.UseVisualStyleBackColor = true;
            this.checkBox_WiederholVorgang.CheckedChanged += new System.EventHandler(this.checkBox_WiederholVorgang_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "bis";
            // 
            // dateTimePicker_KMBis
            // 
            this.dateTimePicker_KMBis.Enabled = false;
            this.dateTimePicker_KMBis.Location = new System.Drawing.Point(338, 415);
            this.dateTimePicker_KMBis.Name = "dateTimePicker_KMBis";
            this.dateTimePicker_KMBis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_KMBis.TabIndex = 17;
            // 
            // dateTimePicker_KMVon
            // 
            this.dateTimePicker_KMVon.Enabled = false;
            this.dateTimePicker_KMVon.Location = new System.Drawing.Point(106, 415);
            this.dateTimePicker_KMVon.Name = "dateTimePicker_KMVon";
            this.dateTimePicker_KMVon.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_KMVon.TabIndex = 16;
            // 
            // checkBox_Rezept
            // 
            this.checkBox_Rezept.AutoSize = true;
            this.checkBox_Rezept.Location = new System.Drawing.Point(6, 441);
            this.checkBox_Rezept.Name = "checkBox_Rezept";
            this.checkBox_Rezept.Size = new System.Drawing.Size(60, 17);
            this.checkBox_Rezept.TabIndex = 18;
            this.checkBox_Rezept.Text = "Rezept";
            this.checkBox_Rezept.UseVisualStyleBackColor = true;
            this.checkBox_Rezept.Visible = false;
            // 
            // checkBox_Krankmeldung
            // 
            this.checkBox_Krankmeldung.AutoSize = true;
            this.checkBox_Krankmeldung.Location = new System.Drawing.Point(6, 418);
            this.checkBox_Krankmeldung.Name = "checkBox_Krankmeldung";
            this.checkBox_Krankmeldung.Size = new System.Drawing.Size(94, 17);
            this.checkBox_Krankmeldung.TabIndex = 15;
            this.checkBox_Krankmeldung.Text = "Krankmeldung";
            this.checkBox_Krankmeldung.UseVisualStyleBackColor = true;
            this.checkBox_Krankmeldung.CheckedChanged += new System.EventHandler(this.Krankmeldung);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Beschwerde";
            // 
            // richTextBox_Beschwerde
            // 
            this.richTextBox_Beschwerde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Beschwerde.Location = new System.Drawing.Point(6, 241);
            this.richTextBox_Beschwerde.Name = "richTextBox_Beschwerde";
            this.richTextBox_Beschwerde.Size = new System.Drawing.Size(574, 171);
            this.richTextBox_Beschwerde.TabIndex = 14;
            this.richTextBox_Beschwerde.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Arzt:";
            // 
            // textBox_Arzt
            // 
            this.textBox_Arzt.Location = new System.Drawing.Point(4, 35);
            this.textBox_Arzt.Name = "textBox_Arzt";
            this.textBox_Arzt.Size = new System.Drawing.Size(178, 20);
            this.textBox_Arzt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diagnose";
            // 
            // richTextBox_Diagnose
            // 
            this.richTextBox_Diagnose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Diagnose.Location = new System.Drawing.Point(6, 479);
            this.richTextBox_Diagnose.Name = "richTextBox_Diagnose";
            this.richTextBox_Diagnose.Size = new System.Drawing.Size(574, 313);
            this.richTextBox_Diagnose.TabIndex = 19;
            this.richTextBox_Diagnose.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Geschlecht);
            this.groupBox3.Controls.Add(this.button_PatientSpeichern);
            this.groupBox3.Controls.Add(this.button_Patienten);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dateTimePicker_Geburtstag);
            this.groupBox3.Controls.Add(this.label_Alter);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_Nachname);
            this.groupBox3.Controls.Add(this.textBox_Vorname);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(274, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 127);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patient";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Geschlecht";
            // 
            // dateTimePicker_Geburtstag
            // 
            this.dateTimePicker_Geburtstag.Location = new System.Drawing.Point(164, 65);
            this.dateTimePicker_Geburtstag.Name = "dateTimePicker_Geburtstag";
            this.dateTimePicker_Geburtstag.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker_Geburtstag.TabIndex = 5;
            this.dateTimePicker_Geburtstag.ValueChanged += new System.EventHandler(this.dateTimePicker_Geburtstag_ValueChanged);
            // 
            // label_Alter
            // 
            this.label_Alter.AutoSize = true;
            this.label_Alter.Location = new System.Drawing.Point(68, 101);
            this.label_Alter.Name = "label_Alter";
            this.label_Alter.Size = new System.Drawing.Size(0, 13);
            this.label_Alter.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Alter";
            // 
            // textBox_Nachname
            // 
            this.textBox_Nachname.Location = new System.Drawing.Point(71, 42);
            this.textBox_Nachname.Name = "textBox_Nachname";
            this.textBox_Nachname.Size = new System.Drawing.Size(282, 20);
            this.textBox_Nachname.TabIndex = 3;
            // 
            // textBox_Vorname
            // 
            this.textBox_Vorname.Location = new System.Drawing.Point(71, 16);
            this.textBox_Vorname.Name = "textBox_Vorname";
            this.textBox_Vorname.Size = new System.Drawing.Size(282, 20);
            this.textBox_Vorname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nachname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vorname";
            // 
            // timer_AnmeldungScreen
            // 
            this.timer_AnmeldungScreen.Interval = 2000;
            this.timer_AnmeldungScreen.Tick += new System.EventHandler(this.Timer_AnmeldungScreen_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.button_Speichern,
            this.Button_Abbrechen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.abmeldenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.EinstellungenToolStripMenuItem_Click);
            // 
            // abmeldenToolStripMenuItem
            // 
            this.abmeldenToolStripMenuItem.Name = "abmeldenToolStripMenuItem";
            this.abmeldenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.abmeldenToolStripMenuItem.Text = "Abmelden";
            this.abmeldenToolStripMenuItem.Click += new System.EventHandler(this.AbmeldenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // button_Speichern
            // 
            this.button_Speichern.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.button_Speichern.Name = "button_Speichern";
            this.button_Speichern.Size = new System.Drawing.Size(71, 20);
            this.button_Speichern.Text = "Speichern";
            this.button_Speichern.Click += new System.EventHandler(this.button_KarteiSpeichern_Click);
            // 
            // Button_Abbrechen
            // 
            this.Button_Abbrechen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Button_Abbrechen.Name = "Button_Abbrechen";
            this.Button_Abbrechen.Size = new System.Drawing.Size(77, 20);
            this.Button_Abbrechen.Text = "Abbrechen";
            this.Button_Abbrechen.Visible = false;
            // 
            // timer_LadePatienten
            // 
            this.timer_LadePatienten.Tick += new System.EventHandler(this.Timer_LadePatienten_Tick);
            // 
            // timer_SpeicherButtonAkktualiesieren
            // 
            this.timer_SpeicherButtonAkktualiesieren.Tick += new System.EventHandler(this.timer_SpeicherButtonAkktualiesieren_Tick);
            // 
            // button_PatientSpeichern
            // 
            this.button_PatientSpeichern.Location = new System.Drawing.Point(149, 96);
            this.button_PatientSpeichern.Name = "button_PatientSpeichern";
            this.button_PatientSpeichern.Size = new System.Drawing.Size(99, 23);
            this.button_PatientSpeichern.TabIndex = 7;
            this.button_PatientSpeichern.Text = "Speichern";
            this.button_PatientSpeichern.UseVisualStyleBackColor = true;
            this.button_PatientSpeichern.Click += new System.EventHandler(this.button_PatientSpeichern_Click);
            // 
            // textBox_Geschlecht
            // 
            this.textBox_Geschlecht.FormattingEnabled = true;
            this.textBox_Geschlecht.Items.AddRange(new object[] {
            "Weiblich",
            "Männlich",
            "Divers"});
            this.textBox_Geschlecht.Location = new System.Drawing.Point(73, 65);
            this.textBox_Geschlecht.Name = "textBox_Geschlecht";
            this.textBox_Geschlecht.Size = new System.Drawing.Size(85, 21);
            this.textBox_Geschlecht.TabIndex = 4;
            // 
            // richTextBox_Kurzbeschreibung
            // 
            this.richTextBox_Kurzbeschreibung.Location = new System.Drawing.Point(6, 133);
            this.richTextBox_Kurzbeschreibung.Name = "richTextBox_Kurzbeschreibung";
            this.richTextBox_Kurzbeschreibung.Size = new System.Drawing.Size(574, 89);
            this.richTextBox_Kurzbeschreibung.TabIndex = 20;
            this.richTextBox_Kurzbeschreibung.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Kurzbeschreibung";
            // 
            // button_NeueKartei
            // 
            this.button_NeueKartei.Location = new System.Drawing.Point(274, 153);
            this.button_NeueKartei.Name = "button_NeueKartei";
            this.button_NeueKartei.Size = new System.Drawing.Size(359, 23);
            this.button_NeueKartei.TabIndex = 7;
            this.button_NeueKartei.Text = "Neue Kartei";
            this.button_NeueKartei.UseVisualStyleBackColor = true;
            this.button_NeueKartei.Click += new System.EventHandler(this.button_NeueKartei_Click);
            // 
            // button_NachfolgeKartei
            // 
            this.button_NachfolgeKartei.Location = new System.Drawing.Point(274, 180);
            this.button_NachfolgeKartei.Name = "button_NachfolgeKartei";
            this.button_NachfolgeKartei.Size = new System.Drawing.Size(359, 23);
            this.button_NachfolgeKartei.TabIndex = 8;
            this.button_NachfolgeKartei.Text = "Nachfolge Kartei";
            this.button_NachfolgeKartei.UseVisualStyleBackColor = true;
            this.button_NachfolgeKartei.Click += new System.EventHandler(this.button_NachfolgeKartei_Click);
            // 
            // MainKartei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1237, 841);
            this.Controls.Add(this.button_NachfolgeKartei);
            this.Controls.Add(this.button_NeueKartei);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView_Kartei);
            this.Controls.Add(this.listView_Patienten);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainKartei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kartei";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PatientenSuche;
        private System.Windows.Forms.ListView listView_Patienten;
        private System.Windows.Forms.ListView listView_Kartei;
        private System.Windows.Forms.Button button_Patienten;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Datum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader_Nachname;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Arzt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_Diagnose;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Geburtstag;
        private System.Windows.Forms.Label label_Alter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Nachname;
        private System.Windows.Forms.TextBox textBox_Vorname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_Beschwerde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_KMBis;
        private System.Windows.Forms.DateTimePicker dateTimePicker_KMVon;
        private System.Windows.Forms.CheckBox checkBox_Rezept;
        private System.Windows.Forms.CheckBox checkBox_Krankmeldung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_WiderholungsKarteiID;
        private System.Windows.Forms.CheckBox checkBox_WiederholVorgang;
        private System.Windows.Forms.Timer timer_AnmeldungScreen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmeldenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader_Alter;
        private System.Windows.Forms.Timer timer_LadePatienten;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader columnHeader_Kurzbeschreibung;
        private System.Windows.Forms.ColumnHeader columnHeader_Datum;
        private System.Windows.Forms.ToolStripMenuItem button_Speichern;
        private System.Windows.Forms.ToolStripMenuItem Button_Abbrechen;
        private System.Windows.Forms.Timer timer_SpeicherButtonAkktualiesieren;
        private System.Windows.Forms.Button button_PatientSpeichern;
        private System.Windows.Forms.ComboBox textBox_Geschlecht;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox_Kurzbeschreibung;
        private System.Windows.Forms.Button button_NeueKartei;
        private System.Windows.Forms.Button button_NachfolgeKartei;
    }
}

