namespace Start_forma
{
    partial class PACIJENT_2
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonkarton = new System.Windows.Forms.Button();
            this.buttoninfo = new System.Windows.Forms.Button();
            this.buttonred = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonkarton
            // 
            this.buttonkarton.Location = new System.Drawing.Point(176, 109);
            this.buttonkarton.Name = "buttonkarton";
            this.buttonkarton.Size = new System.Drawing.Size(190, 29);
            this.buttonkarton.TabIndex = 16;
            this.buttonkarton.Text = "Moj karton";
            this.buttonkarton.UseVisualStyleBackColor = true;
            this.buttonkarton.Click += new System.EventHandler(this.buttonkarton_Click);
            // 
            // buttoninfo
            // 
            this.buttoninfo.Location = new System.Drawing.Point(6, 38);
            this.buttoninfo.Name = "buttoninfo";
            this.buttoninfo.Size = new System.Drawing.Size(190, 31);
            this.buttoninfo.TabIndex = 17;
            this.buttoninfo.Text = "Moje lične informacije";
            this.buttoninfo.UseVisualStyleBackColor = true;
            this.buttoninfo.Click += new System.EventHandler(this.buttoninfo_Click);
            // 
            // buttonred
            // 
            this.buttonred.Location = new System.Drawing.Point(353, 170);
            this.buttonred.Name = "buttonred";
            this.buttonred.Size = new System.Drawing.Size(190, 31);
            this.buttonred.TabIndex = 18;
            this.buttonred.Text = "Red čekanja";
            this.buttonred.UseVisualStyleBackColor = true;
            this.buttonred.Click += new System.EventHandler(this.buttonred_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttoninfo);
            this.groupBox1.Controls.Add(this.buttonred);
            this.groupBox1.Controls.Add(this.buttonkarton);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 226);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dobrodošli!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "_________";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(18, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(10, 10);
            this.treeView1.TabIndex = 21;
            // 
            // PACIJENT_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "PACIJENT_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KLINIKA-PACIJENT";
            this.Load += new System.EventHandler(this.PACIJENT_2_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonkarton;
        private System.Windows.Forms.Button buttoninfo;
        private System.Windows.Forms.Button buttonred;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
    }
}