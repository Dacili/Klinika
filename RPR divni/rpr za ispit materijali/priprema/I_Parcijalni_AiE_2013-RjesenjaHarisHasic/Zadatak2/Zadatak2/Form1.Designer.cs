namespace Zadatak2
{
    partial class Form1
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
            this.textBox_ime = new System.Windows.Forms.TextBox();
            this.textBox_prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_godine = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_Ispravno = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_godinaRodenja = new System.Windows.Forms.TextBox();
            this.comboBox_StrucnaSprema = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_godine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime :";
            // 
            // textBox_ime
            // 
            this.textBox_ime.Location = new System.Drawing.Point(117, 30);
            this.textBox_ime.Name = "textBox_ime";
            this.textBox_ime.Size = new System.Drawing.Size(145, 20);
            this.textBox_ime.TabIndex = 1;
            // 
            // textBox_prezime
            // 
            this.textBox_prezime.Location = new System.Drawing.Point(117, 62);
            this.textBox_prezime.Name = "textBox_prezime";
            this.textBox_prezime.Size = new System.Drawing.Size(145, 20);
            this.textBox_prezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Godine starosti :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stručna sprema :";
            // 
            // numericUpDown_godine
            // 
            this.numericUpDown_godine.Location = new System.Drawing.Point(117, 93);
            this.numericUpDown_godine.Name = "numericUpDown_godine";
            this.numericUpDown_godine.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown_godine.TabIndex = 6;
            this.numericUpDown_godine.ValueChanged += new System.EventHandler(this.numericUpDown_godine_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Datum Rođenja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_Ispravno
            // 
            this.checkBox_Ispravno.AutoSize = true;
            this.checkBox_Ispravno.Location = new System.Drawing.Point(281, 95);
            this.checkBox_Ispravno.Name = "checkBox_Ispravno";
            this.checkBox_Ispravno.Size = new System.Drawing.Size(67, 17);
            this.checkBox_Ispravno.TabIndex = 8;
            this.checkBox_Ispravno.Text = "Ispravno";
            this.checkBox_Ispravno.UseVisualStyleBackColor = true;
            this.checkBox_Ispravno.Visible = false;
            this.checkBox_Ispravno.CheckedChanged += new System.EventHandler(this.checkBox_Ispravno_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Godina rođenja :";
            // 
            // textBox_godinaRodenja
            // 
            this.textBox_godinaRodenja.Location = new System.Drawing.Point(114, 161);
            this.textBox_godinaRodenja.Name = "textBox_godinaRodenja";
            this.textBox_godinaRodenja.ReadOnly = true;
            this.textBox_godinaRodenja.Size = new System.Drawing.Size(148, 20);
            this.textBox_godinaRodenja.TabIndex = 10;
            // 
            // comboBox_StrucnaSprema
            // 
            this.comboBox_StrucnaSprema.FormattingEnabled = true;
            this.comboBox_StrucnaSprema.Items.AddRange(new object[] {
            "VSS",
            "SS",
            "OS",
            "MS"});
            this.comboBox_StrucnaSprema.Location = new System.Drawing.Point(114, 127);
            this.comboBox_StrucnaSprema.Name = "comboBox_StrucnaSprema";
            this.comboBox_StrucnaSprema.Size = new System.Drawing.Size(148, 21);
            this.comboBox_StrucnaSprema.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 243);
            this.Controls.Add(this.comboBox_StrucnaSprema);
            this.Controls.Add(this.textBox_godinaRodenja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_Ispravno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_godine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_prezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_godine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ime;
        private System.Windows.Forms.TextBox textBox_prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_godine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_Ispravno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_godinaRodenja;
        private System.Windows.Forms.ComboBox comboBox_StrucnaSprema;
    }
}

