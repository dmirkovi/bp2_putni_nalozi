namespace putni_nalozi
{
    partial class frmNaloziUnos
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
            this.cbZaposlenici = new System.Windows.Forms.ComboBox();
            this.gpIzvrsitelj = new System.Windows.Forms.GroupBox();
            this.tbZapKategorija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbVozila = new System.Windows.Forms.GroupBox();
            this.tbRegistracijskaOznaka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDatumRegistracije = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbBrojSjedala = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBrojSasije = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNosivost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVozKategorija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVozila = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPlaniranoVrijemePuta = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSvrha = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTrosak = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpIzvrsitelj.SuspendLayout();
            this.gbVozila.SuspendLayout();
            this.gbPlaniranoVrijemePuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zaposlenik:";
            // 
            // cbZaposlenici
            // 
            this.cbZaposlenici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZaposlenici.FormattingEnabled = true;
            this.cbZaposlenici.Location = new System.Drawing.Point(103, 27);
            this.cbZaposlenici.Name = "cbZaposlenici";
            this.cbZaposlenici.Size = new System.Drawing.Size(173, 21);
            this.cbZaposlenici.TabIndex = 1;
            this.cbZaposlenici.SelectedIndexChanged += new System.EventHandler(this.cbZaposlenici_SelectedIndexChanged);
            // 
            // gpIzvrsitelj
            // 
            this.gpIzvrsitelj.Controls.Add(this.tbZapKategorija);
            this.gpIzvrsitelj.Controls.Add(this.label2);
            this.gpIzvrsitelj.Controls.Add(this.cbZaposlenici);
            this.gpIzvrsitelj.Controls.Add(this.label1);
            this.gpIzvrsitelj.Location = new System.Drawing.Point(44, 17);
            this.gpIzvrsitelj.Name = "gpIzvrsitelj";
            this.gpIzvrsitelj.Size = new System.Drawing.Size(298, 106);
            this.gpIzvrsitelj.TabIndex = 1;
            this.gpIzvrsitelj.TabStop = false;
            this.gpIzvrsitelj.Text = "Izvršitelj";
            // 
            // tbZapKategorija
            // 
            this.tbZapKategorija.Location = new System.Drawing.Point(103, 61);
            this.tbZapKategorija.Name = "tbZapKategorija";
            this.tbZapKategorija.ReadOnly = true;
            this.tbZapKategorija.Size = new System.Drawing.Size(99, 20);
            this.tbZapKategorija.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategorije:";
            // 
            // gbVozila
            // 
            this.gbVozila.Controls.Add(this.tbRegistracijskaOznaka);
            this.gbVozila.Controls.Add(this.label10);
            this.gbVozila.Controls.Add(this.tbDatumRegistracije);
            this.gbVozila.Controls.Add(this.label9);
            this.gbVozila.Controls.Add(this.tbBrojSjedala);
            this.gbVozila.Controls.Add(this.label8);
            this.gbVozila.Controls.Add(this.tbBrojSasije);
            this.gbVozila.Controls.Add(this.label7);
            this.gbVozila.Controls.Add(this.tbMarka);
            this.gbVozila.Controls.Add(this.label6);
            this.gbVozila.Controls.Add(this.tbNosivost);
            this.gbVozila.Controls.Add(this.label5);
            this.gbVozila.Controls.Add(this.tbVozKategorija);
            this.gbVozila.Controls.Add(this.label3);
            this.gbVozila.Controls.Add(this.cbVozila);
            this.gbVozila.Controls.Add(this.label4);
            this.gbVozila.Location = new System.Drawing.Point(44, 153);
            this.gbVozila.Name = "gbVozila";
            this.gbVozila.Size = new System.Drawing.Size(639, 159);
            this.gbVozila.TabIndex = 3;
            this.gbVozila.TabStop = false;
            this.gbVozila.Text = "Vozilo";
            // 
            // tbRegistracijskaOznaka
            // 
            this.tbRegistracijskaOznaka.Location = new System.Drawing.Point(119, 61);
            this.tbRegistracijskaOznaka.Name = "tbRegistracijskaOznaka";
            this.tbRegistracijskaOznaka.ReadOnly = true;
            this.tbRegistracijskaOznaka.Size = new System.Drawing.Size(93, 20);
            this.tbRegistracijskaOznaka.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Registracijska oznaka:";
            // 
            // tbDatumRegistracije
            // 
            this.tbDatumRegistracije.Location = new System.Drawing.Point(119, 97);
            this.tbDatumRegistracije.Name = "tbDatumRegistracije";
            this.tbDatumRegistracije.ReadOnly = true;
            this.tbDatumRegistracije.Size = new System.Drawing.Size(93, 20);
            this.tbDatumRegistracije.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Datum registracije:";
            // 
            // tbBrojSjedala
            // 
            this.tbBrojSjedala.Location = new System.Drawing.Point(456, 97);
            this.tbBrojSjedala.Name = "tbBrojSjedala";
            this.tbBrojSjedala.ReadOnly = true;
            this.tbBrojSjedala.Size = new System.Drawing.Size(93, 20);
            this.tbBrojSjedala.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Broj sjedala:";
            // 
            // tbBrojSasije
            // 
            this.tbBrojSasije.Location = new System.Drawing.Point(282, 97);
            this.tbBrojSasije.Name = "tbBrojSasije";
            this.tbBrojSasije.ReadOnly = true;
            this.tbBrojSasije.Size = new System.Drawing.Size(93, 20);
            this.tbBrojSasije.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Broj šasije:";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(282, 60);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.ReadOnly = true;
            this.tbMarka.Size = new System.Drawing.Size(93, 20);
            this.tbMarka.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Marka:";
            // 
            // tbNosivost
            // 
            this.tbNosivost.Location = new System.Drawing.Point(456, 61);
            this.tbNosivost.Name = "tbNosivost";
            this.tbNosivost.ReadOnly = true;
            this.tbNosivost.Size = new System.Drawing.Size(93, 20);
            this.tbNosivost.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nosivost:";
            // 
            // tbVozKategorija
            // 
            this.tbVozKategorija.Location = new System.Drawing.Point(321, 29);
            this.tbVozKategorija.Name = "tbVozKategorija";
            this.tbVozKategorija.ReadOnly = true;
            this.tbVozKategorija.Size = new System.Drawing.Size(54, 20);
            this.tbVozKategorija.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategorija:";
            // 
            // cbVozila
            // 
            this.cbVozila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVozila.FormattingEnabled = true;
            this.cbVozila.Location = new System.Drawing.Point(119, 26);
            this.cbVozila.Name = "cbVozila";
            this.cbVozila.Size = new System.Drawing.Size(99, 21);
            this.cbVozila.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vozilo:";
            // 
            // gbPlaniranoVrijemePuta
            // 
            this.gbPlaniranoVrijemePuta.Controls.Add(this.dateTimePicker2);
            this.gbPlaniranoVrijemePuta.Controls.Add(this.dateTimePicker1);
            this.gbPlaniranoVrijemePuta.Controls.Add(this.label12);
            this.gbPlaniranoVrijemePuta.Controls.Add(this.label11);
            this.gbPlaniranoVrijemePuta.Location = new System.Drawing.Point(348, 17);
            this.gbPlaniranoVrijemePuta.Name = "gbPlaniranoVrijemePuta";
            this.gbPlaniranoVrijemePuta.Size = new System.Drawing.Size(290, 106);
            this.gbPlaniranoVrijemePuta.TabIndex = 2;
            this.gbPlaniranoVrijemePuta.TabStop = false;
            this.gbPlaniranoVrijemePuta.Text = "Planirano vrijeme putovanja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Vrijeme polaska:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Vrijeme dolaska:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Svrha putovanja:";
            // 
            // tbSvrha
            // 
            this.tbSvrha.Location = new System.Drawing.Point(135, 338);
            this.tbSvrha.Multiline = true;
            this.tbSvrha.Name = "tbSvrha";
            this.tbSvrha.Size = new System.Drawing.Size(478, 57);
            this.tbSvrha.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Planirani trošak puta:";
            // 
            // tbTrosak
            // 
            this.tbTrosak.Location = new System.Drawing.Point(153, 421);
            this.tbTrosak.Name = "tbTrosak";
            this.tbTrosak.Size = new System.Drawing.Size(121, 20);
            this.tbTrosak.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mjesta});
            this.dataGridView1.Location = new System.Drawing.Point(448, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(235, 109);
            this.dataGridView1.TabIndex = 7;
            // 
            // mjesta
            // 
            this.mjesta.HeaderText = "Mjesta stajanja";
            this.mjesta.Name = "mjesta";
            this.mjesta.Width = 200;
            // 
            // frmNaloziUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbTrosak);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbSvrha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbPlaniranoVrijemePuta);
            this.Controls.Add(this.gbVozila);
            this.Controls.Add(this.gpIzvrsitelj);
            this.Name = "frmNaloziUnos";
            this.Text = "Unos naloga";
            this.Load += new System.EventHandler(this.frmNaloziUnos_Load);
            this.gpIzvrsitelj.ResumeLayout(false);
            this.gpIzvrsitelj.PerformLayout();
            this.gbVozila.ResumeLayout(false);
            this.gbVozila.PerformLayout();
            this.gbPlaniranoVrijemePuta.ResumeLayout(false);
            this.gbPlaniranoVrijemePuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbZaposlenici;
        private System.Windows.Forms.GroupBox gpIzvrsitelj;
        private System.Windows.Forms.TextBox tbZapKategorija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbVozila;
        private System.Windows.Forms.TextBox tbRegistracijskaOznaka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDatumRegistracije;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBrojSjedala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBrojSasije;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNosivost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVozKategorija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVozila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPlaniranoVrijemePuta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSvrha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTrosak;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjesta;
    }
}