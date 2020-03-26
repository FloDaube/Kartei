namespace Karteien.Dialog
{
    partial class D_Einstellungen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Benutzer = new System.Windows.Forms.TabPage();
            this.button_Speichern_Benutzer = new System.Windows.Forms.Button();
            this.label_Role = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_Nachname = new System.Windows.Forms.Label();
            this.label_Vorname = new System.Windows.Forms.Label();
            this.label_UserID = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_UserKennwort2 = new System.Windows.Forms.TextBox();
            this.textBox_UserKennwort1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage_SQLDatabase = new System.Windows.Forms.TabPage();
            this.button_Speichern_Database = new System.Windows.Forms.Button();
            this.textBox_Kennwort2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Kennwort1 = new System.Windows.Forms.TextBox();
            this.textBox_SQLUser = new System.Windows.Forms.TextBox();
            this.textBox_Database = new System.Windows.Forms.TextBox();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.tabPage_Admin = new System.Windows.Forms.TabPage();
            this.listView_Users = new System.Windows.Forms.ListView();
            this.columnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Nachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_NeuerUser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_Benutzer.SuspendLayout();
            this.tabPage_SQLDatabase.SuspendLayout();
            this.tabPage_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Benutzer);
            this.tabControl1.Controls.Add(this.tabPage_SQLDatabase);
            this.tabControl1.Controls.Add(this.tabPage_Admin);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 322);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Benutzer
            // 
            this.tabPage_Benutzer.Controls.Add(this.button_Speichern_Benutzer);
            this.tabPage_Benutzer.Controls.Add(this.label_Role);
            this.tabPage_Benutzer.Controls.Add(this.label14);
            this.tabPage_Benutzer.Controls.Add(this.label_Nachname);
            this.tabPage_Benutzer.Controls.Add(this.label_Vorname);
            this.tabPage_Benutzer.Controls.Add(this.label_UserID);
            this.tabPage_Benutzer.Controls.Add(this.label_ID);
            this.tabPage_Benutzer.Controls.Add(this.textBox_UserKennwort2);
            this.tabPage_Benutzer.Controls.Add(this.textBox_UserKennwort1);
            this.tabPage_Benutzer.Controls.Add(this.label9);
            this.tabPage_Benutzer.Controls.Add(this.label8);
            this.tabPage_Benutzer.Controls.Add(this.label7);
            this.tabPage_Benutzer.Controls.Add(this.label6);
            this.tabPage_Benutzer.Controls.Add(this.label5);
            this.tabPage_Benutzer.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Benutzer.Name = "tabPage_Benutzer";
            this.tabPage_Benutzer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Benutzer.Size = new System.Drawing.Size(712, 296);
            this.tabPage_Benutzer.TabIndex = 0;
            this.tabPage_Benutzer.Text = "Benutzer";
            this.tabPage_Benutzer.UseVisualStyleBackColor = true;
            // 
            // button_Speichern_Benutzer
            // 
            this.button_Speichern_Benutzer.Location = new System.Drawing.Point(82, 186);
            this.button_Speichern_Benutzer.Name = "button_Speichern_Benutzer";
            this.button_Speichern_Benutzer.Size = new System.Drawing.Size(75, 23);
            this.button_Speichern_Benutzer.TabIndex = 13;
            this.button_Speichern_Benutzer.Text = "Speichern";
            this.button_Speichern_Benutzer.UseVisualStyleBackColor = true;
            this.button_Speichern_Benutzer.Click += new System.EventHandler(this.button_Speichern_Benutzer_Click);
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(79, 160);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(63, 13);
            this.label_Role.TabIndex = 12;
            this.label_Role.Text = "Placeholder";
            this.label_Role.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Role";
            this.label14.Visible = false;
            // 
            // label_Nachname
            // 
            this.label_Nachname.AutoSize = true;
            this.label_Nachname.Location = new System.Drawing.Point(79, 136);
            this.label_Nachname.Name = "label_Nachname";
            this.label_Nachname.Size = new System.Drawing.Size(63, 13);
            this.label_Nachname.TabIndex = 10;
            this.label_Nachname.Text = "Placeholder";
            // 
            // label_Vorname
            // 
            this.label_Vorname.AutoSize = true;
            this.label_Vorname.Location = new System.Drawing.Point(79, 112);
            this.label_Vorname.Name = "label_Vorname";
            this.label_Vorname.Size = new System.Drawing.Size(63, 13);
            this.label_Vorname.TabIndex = 9;
            this.label_Vorname.Text = "Placeholder";
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(79, 47);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(63, 13);
            this.label_UserID.TabIndex = 8;
            this.label_UserID.Text = "Placeholder";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(79, 25);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(63, 13);
            this.label_ID.TabIndex = 7;
            this.label_ID.Text = "Placeholder";
            // 
            // textBox_UserKennwort2
            // 
            this.textBox_UserKennwort2.Location = new System.Drawing.Point(82, 89);
            this.textBox_UserKennwort2.Name = "textBox_UserKennwort2";
            this.textBox_UserKennwort2.PasswordChar = '*';
            this.textBox_UserKennwort2.Size = new System.Drawing.Size(171, 20);
            this.textBox_UserKennwort2.TabIndex = 6;
            this.textBox_UserKennwort2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_UserKennwort2_PreviewKeyDown);
            // 
            // textBox_UserKennwort1
            // 
            this.textBox_UserKennwort1.Location = new System.Drawing.Point(82, 63);
            this.textBox_UserKennwort1.Name = "textBox_UserKennwort1";
            this.textBox_UserKennwort1.PasswordChar = '*';
            this.textBox_UserKennwort1.Size = new System.Drawing.Size(171, 20);
            this.textBox_UserKennwort1.TabIndex = 5;
            this.textBox_UserKennwort1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_UserKennwort1_PreviewKeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Kennwort";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nachname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vorname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // tabPage_SQLDatabase
            // 
            this.tabPage_SQLDatabase.Controls.Add(this.button_Speichern_Database);
            this.tabPage_SQLDatabase.Controls.Add(this.textBox_Kennwort2);
            this.tabPage_SQLDatabase.Controls.Add(this.label4);
            this.tabPage_SQLDatabase.Controls.Add(this.label3);
            this.tabPage_SQLDatabase.Controls.Add(this.label2);
            this.tabPage_SQLDatabase.Controls.Add(this.label1);
            this.tabPage_SQLDatabase.Controls.Add(this.textBox_Kennwort1);
            this.tabPage_SQLDatabase.Controls.Add(this.textBox_SQLUser);
            this.tabPage_SQLDatabase.Controls.Add(this.textBox_Database);
            this.tabPage_SQLDatabase.Controls.Add(this.textBox_Server);
            this.tabPage_SQLDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SQLDatabase.Name = "tabPage_SQLDatabase";
            this.tabPage_SQLDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SQLDatabase.Size = new System.Drawing.Size(712, 296);
            this.tabPage_SQLDatabase.TabIndex = 1;
            this.tabPage_SQLDatabase.Text = "Database";
            this.tabPage_SQLDatabase.UseVisualStyleBackColor = true;
            // 
            // button_Speichern_Database
            // 
            this.button_Speichern_Database.Enabled = false;
            this.button_Speichern_Database.Location = new System.Drawing.Point(75, 133);
            this.button_Speichern_Database.Name = "button_Speichern_Database";
            this.button_Speichern_Database.Size = new System.Drawing.Size(75, 23);
            this.button_Speichern_Database.TabIndex = 17;
            this.button_Speichern_Database.Text = "Speichern";
            this.button_Speichern_Database.UseVisualStyleBackColor = true;
            this.button_Speichern_Database.Visible = false;
            this.button_Speichern_Database.Click += new System.EventHandler(this.Speicher_DatenabnkEinstellung);
            // 
            // textBox_Kennwort2
            // 
            this.textBox_Kennwort2.Enabled = false;
            this.textBox_Kennwort2.Location = new System.Drawing.Point(290, 98);
            this.textBox_Kennwort2.Name = "textBox_Kennwort2";
            this.textBox_Kennwort2.Size = new System.Drawing.Size(209, 20);
            this.textBox_Kennwort2.TabIndex = 16;
            this.textBox_Kennwort2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kennwort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "SQL User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server";
            // 
            // textBox_Kennwort1
            // 
            this.textBox_Kennwort1.Enabled = false;
            this.textBox_Kennwort1.Location = new System.Drawing.Point(75, 98);
            this.textBox_Kennwort1.Name = "textBox_Kennwort1";
            this.textBox_Kennwort1.ReadOnly = true;
            this.textBox_Kennwort1.Size = new System.Drawing.Size(209, 20);
            this.textBox_Kennwort1.TabIndex = 11;
            // 
            // textBox_SQLUser
            // 
            this.textBox_SQLUser.Enabled = false;
            this.textBox_SQLUser.Location = new System.Drawing.Point(75, 72);
            this.textBox_SQLUser.Name = "textBox_SQLUser";
            this.textBox_SQLUser.ReadOnly = true;
            this.textBox_SQLUser.Size = new System.Drawing.Size(209, 20);
            this.textBox_SQLUser.TabIndex = 10;
            // 
            // textBox_Database
            // 
            this.textBox_Database.Enabled = false;
            this.textBox_Database.Location = new System.Drawing.Point(75, 46);
            this.textBox_Database.Name = "textBox_Database";
            this.textBox_Database.ReadOnly = true;
            this.textBox_Database.Size = new System.Drawing.Size(209, 20);
            this.textBox_Database.TabIndex = 9;
            // 
            // textBox_Server
            // 
            this.textBox_Server.Enabled = false;
            this.textBox_Server.Location = new System.Drawing.Point(75, 20);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.ReadOnly = true;
            this.textBox_Server.Size = new System.Drawing.Size(209, 20);
            this.textBox_Server.TabIndex = 8;
            // 
            // tabPage_Admin
            // 
            this.tabPage_Admin.Controls.Add(this.button_NeuerUser);
            this.tabPage_Admin.Controls.Add(this.listView_Users);
            this.tabPage_Admin.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Admin.Name = "tabPage_Admin";
            this.tabPage_Admin.Size = new System.Drawing.Size(712, 296);
            this.tabPage_Admin.TabIndex = 2;
            this.tabPage_Admin.Text = "Benutzer Verwaltung";
            this.tabPage_Admin.UseVisualStyleBackColor = true;
            // 
            // listView_Users
            // 
            this.listView_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ID,
            this.columnHeader_User,
            this.columnHeader_Vorname,
            this.columnHeader_Nachname});
            this.listView_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Users.FullRowSelect = true;
            this.listView_Users.HideSelection = false;
            this.listView_Users.Location = new System.Drawing.Point(0, 0);
            this.listView_Users.Name = "listView_Users";
            this.listView_Users.Size = new System.Drawing.Size(712, 296);
            this.listView_Users.TabIndex = 0;
            this.listView_Users.UseCompatibleStateImageBehavior = false;
            this.listView_Users.View = System.Windows.Forms.View.Details;
            this.listView_Users.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserAugewahlt);
            // 
            // columnHeader_ID
            // 
            this.columnHeader_ID.Text = "ID";
            this.columnHeader_ID.Width = 50;
            // 
            // columnHeader_User
            // 
            this.columnHeader_User.Text = "User";
            this.columnHeader_User.Width = 113;
            // 
            // columnHeader_Vorname
            // 
            this.columnHeader_Vorname.Text = "Vorname";
            this.columnHeader_Vorname.Width = 114;
            // 
            // columnHeader_Nachname
            // 
            this.columnHeader_Nachname.Text = "Nachname";
            this.columnHeader_Nachname.Width = 209;
            // 
            // button_NeuerUser
            // 
            this.button_NeuerUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_NeuerUser.Location = new System.Drawing.Point(0, 273);
            this.button_NeuerUser.Name = "button_NeuerUser";
            this.button_NeuerUser.Size = new System.Drawing.Size(712, 23);
            this.button_NeuerUser.TabIndex = 1;
            this.button_NeuerUser.Text = "Neuer User";
            this.button_NeuerUser.UseVisualStyleBackColor = true;
            this.button_NeuerUser.Click += new System.EventHandler(this.button_NeuerUser_Click);
            // 
            // D_Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "D_Einstellungen";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Einstellungen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Benutzer.ResumeLayout(false);
            this.tabPage_Benutzer.PerformLayout();
            this.tabPage_SQLDatabase.ResumeLayout(false);
            this.tabPage_SQLDatabase.PerformLayout();
            this.tabPage_Admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Benutzer;
        private System.Windows.Forms.TabPage tabPage_SQLDatabase;
        private System.Windows.Forms.TabPage tabPage_Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Kennwort1;
        private System.Windows.Forms.TextBox textBox_SQLUser;
        private System.Windows.Forms.TextBox textBox_Database;
        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Kennwort2;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_Nachname;
        private System.Windows.Forms.Label label_Vorname;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_UserKennwort2;
        private System.Windows.Forms.TextBox textBox_UserKennwort1;
        private System.Windows.Forms.Button button_Speichern_Benutzer;
        private System.Windows.Forms.Button button_Speichern_Database;
        private System.Windows.Forms.ListView listView_Users;
        private System.Windows.Forms.ColumnHeader columnHeader_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_User;
        private System.Windows.Forms.ColumnHeader columnHeader_Vorname;
        private System.Windows.Forms.ColumnHeader columnHeader_Nachname;
        private System.Windows.Forms.Button button_NeuerUser;
    }
}