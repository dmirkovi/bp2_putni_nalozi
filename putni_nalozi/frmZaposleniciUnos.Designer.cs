namespace putni_nalozi
{
    partial class frmZaposleniciUnos
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
            this.tbPrezimeZaposlenika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbImeZaposlenika = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKatA = new System.Windows.Forms.CheckBox();
            this.cbKatB = new System.Windows.Forms.CheckBox();
            this.cbKatC = new System.Windows.Forms.CheckBox();
            this.cbKatD = new System.Windows.Forms.CheckBox();
            this.cbKatE = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrezimeZaposlenika
            // 
            this.tbPrezimeZaposlenika.Location = new System.Drawing.Point(143, 18);
            this.tbPrezimeZaposlenika.Name = "tbPrezimeZaposlenika";
            this.tbPrezimeZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbPrezimeZaposlenika.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime";
            // 
            // tbImeZaposlenika
            // 
            this.tbImeZaposlenika.Location = new System.Drawing.Point(143, 59);
            this.tbImeZaposlenika.Name = "tbImeZaposlenika";
            this.tbImeZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbImeZaposlenika.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbImeZaposlenika);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPrezimeZaposlenika);
            this.groupBox1.Location = new System.Drawing.Point(55, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaposlenik";
            // 
            // cbKatA
            // 
            this.cbKatA.AutoSize = true;
            this.cbKatA.Location = new System.Drawing.Point(80, 21);
            this.cbKatA.Name = "cbKatA";
            this.cbKatA.Size = new System.Drawing.Size(83, 17);
            this.cbKatA.TabIndex = 3;
            this.cbKatA.Text = "Kategorija A";
            this.cbKatA.UseVisualStyleBackColor = true;
            // 
            // cbKatB
            // 
            this.cbKatB.AutoSize = true;
            this.cbKatB.Location = new System.Drawing.Point(80, 69);
            this.cbKatB.Name = "cbKatB";
            this.cbKatB.Size = new System.Drawing.Size(83, 17);
            this.cbKatB.TabIndex = 4;
            this.cbKatB.Text = "Kategorija B";
            this.cbKatB.UseVisualStyleBackColor = true;
            // 
            // cbKatC
            // 
            this.cbKatC.AutoSize = true;
            this.cbKatC.Location = new System.Drawing.Point(80, 115);
            this.cbKatC.Name = "cbKatC";
            this.cbKatC.Size = new System.Drawing.Size(82, 17);
            this.cbKatC.TabIndex = 5;
            this.cbKatC.Text = "kategorija C";
            this.cbKatC.UseVisualStyleBackColor = true;
            // 
            // cbKatD
            // 
            this.cbKatD.AutoSize = true;
            this.cbKatD.Location = new System.Drawing.Point(80, 161);
            this.cbKatD.Name = "cbKatD";
            this.cbKatD.Size = new System.Drawing.Size(84, 17);
            this.cbKatD.TabIndex = 6;
            this.cbKatD.Text = "Kategorija D";
            this.cbKatD.UseVisualStyleBackColor = true;
            // 
            // cbKatE
            // 
            this.cbKatE.AutoSize = true;
            this.cbKatE.Location = new System.Drawing.Point(80, 207);
            this.cbKatE.Name = "cbKatE";
            this.cbKatE.Size = new System.Drawing.Size(83, 17);
            this.cbKatE.TabIndex = 7;
            this.cbKatE.Text = "Kategorija E";
            this.cbKatE.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbKatE);
            this.groupBox2.Controls.Add(this.cbKatD);
            this.groupBox2.Controls.Add(this.cbKatC);
            this.groupBox2.Controls.Add(this.cbKatB);
            this.groupBox2.Controls.Add(this.cbKatA);
            this.groupBox2.Location = new System.Drawing.Point(431, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Posjeduje kategoriju";
            // 
            // frmZaposleniciUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmZaposleniciUnos";
            this.Text = "Unos zaposlenika";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrezimeZaposlenika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbImeZaposlenika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbKatA;
        private System.Windows.Forms.CheckBox cbKatB;
        private System.Windows.Forms.CheckBox cbKatC;
        private System.Windows.Forms.CheckBox cbKatD;
        private System.Windows.Forms.CheckBox cbKatE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}