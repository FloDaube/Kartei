namespace Kartei
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Kennwort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Anmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kennwort";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(73, 60);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 20);
            this.textBox_Username.TabIndex = 2;
            // 
            // textBox_Kennwort
            // 
            this.textBox_Kennwort.Location = new System.Drawing.Point(73, 86);
            this.textBox_Kennwort.Name = "textBox_Kennwort";
            this.textBox_Kennwort.PasswordChar = '*';
            this.textBox_Kennwort.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kennwort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Praxis Manager";
            // 
            // button_Anmelden
            // 
            this.button_Anmelden.Location = new System.Drawing.Point(179, 79);
            this.button_Anmelden.Name = "button_Anmelden";
            this.button_Anmelden.Size = new System.Drawing.Size(75, 23);
            this.button_Anmelden.TabIndex = 5;
            this.button_Anmelden.Text = "Anmelden";
            this.button_Anmelden.UseVisualStyleBackColor = true;
            this.button_Anmelden.Click += new System.EventHandler(this.Button_Anmelden_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 139);
            this.Controls.Add(this.button_Anmelden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Kennwort);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmeldung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Kennwort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Anmelden;
    }
}