namespace PripremaRPR_Z2
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
            this.textBoxBroj1 = new System.Windows.Forms.TextBox();
            this.textBoxBroj2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxMnozenje = new System.Windows.Forms.CheckBox();
            this.checkBoxDijeljenje = new System.Windows.Forms.CheckBox();
            this.buttonRezultat = new System.Windows.Forms.Button();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj 1:";
            // 
            // textBoxBroj1
            // 
            this.textBoxBroj1.Location = new System.Drawing.Point(75, 46);
            this.textBoxBroj1.Name = "textBoxBroj1";
            this.textBoxBroj1.Size = new System.Drawing.Size(169, 20);
            this.textBoxBroj1.TabIndex = 1;
            // 
            // textBoxBroj2
            // 
            this.textBoxBroj2.Location = new System.Drawing.Point(75, 72);
            this.textBoxBroj2.Name = "textBoxBroj2";
            this.textBoxBroj2.Size = new System.Drawing.Size(169, 20);
            this.textBoxBroj2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj 2:";
            // 
            // checkBoxMnozenje
            // 
            this.checkBoxMnozenje.AutoSize = true;
            this.checkBoxMnozenje.Location = new System.Drawing.Point(75, 111);
            this.checkBoxMnozenje.Name = "checkBoxMnozenje";
            this.checkBoxMnozenje.Size = new System.Drawing.Size(30, 17);
            this.checkBoxMnozenje.TabIndex = 4;
            this.checkBoxMnozenje.Text = "*";
            this.checkBoxMnozenje.UseVisualStyleBackColor = true;
            this.checkBoxMnozenje.CheckedChanged += new System.EventHandler(this.checkBoxMnozenje_CheckedChanged);
            // 
            // checkBoxDijeljenje
            // 
            this.checkBoxDijeljenje.AutoSize = true;
            this.checkBoxDijeljenje.Location = new System.Drawing.Point(75, 134);
            this.checkBoxDijeljenje.Name = "checkBoxDijeljenje";
            this.checkBoxDijeljenje.Size = new System.Drawing.Size(31, 17);
            this.checkBoxDijeljenje.TabIndex = 5;
            this.checkBoxDijeljenje.Text = "/";
            this.checkBoxDijeljenje.UseVisualStyleBackColor = true;
            this.checkBoxDijeljenje.CheckedChanged += new System.EventHandler(this.Dijeljenje_CheckedChanged);
            // 
            // buttonRezultat
            // 
            this.buttonRezultat.Location = new System.Drawing.Point(169, 252);
            this.buttonRezultat.Name = "buttonRezultat";
            this.buttonRezultat.Size = new System.Drawing.Size(75, 23);
            this.buttonRezultat.TabIndex = 6;
            this.buttonRezultat.Text = "Rezultat";
            this.buttonRezultat.UseVisualStyleBackColor = true;
            this.buttonRezultat.Click += new System.EventHandler(this.buttonRezultat_Click);
            // 
            // labelRezultat
            // 
            this.labelRezultat.AutoSize = true;
            this.labelRezultat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRezultat.ForeColor = System.Drawing.Color.Red;
            this.labelRezultat.Location = new System.Drawing.Point(101, 215);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(70, 21);
            this.labelRezultat.TabIndex = 7;
            this.labelRezultat.Text = "Rezultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.labelRezultat);
            this.Controls.Add(this.buttonRezultat);
            this.Controls.Add(this.checkBoxDijeljenje);
            this.Controls.Add(this.checkBoxMnozenje);
            this.Controls.Add(this.textBoxBroj2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBroj1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mnozenje i Dijeljenje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBroj1;
        private System.Windows.Forms.TextBox textBoxBroj2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxMnozenje;
        private System.Windows.Forms.CheckBox checkBoxDijeljenje;
        private System.Windows.Forms.Button buttonRezultat;
        private System.Windows.Forms.Label labelRezultat;
    }
}

