namespace putni_nalozi
{
    partial class frmVozilaPregled
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voziloidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojsasijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosivostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojsjedalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datzadizmjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapzadizmjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voziloidDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.brojsasijeDataGridViewTextBoxColumn,
            this.kategorijaDataGridViewTextBoxColumn,
            this.nosivostDataGridViewTextBoxColumn,
            this.brojsjedalaDataGridViewTextBoxColumn,
            this.regoznakaDataGridViewTextBoxColumn,
            this.datumregDataGridViewTextBoxColumn,
            this.datzadizmjeneDataGridViewTextBoxColumn,
            this.zapzadizmjeneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vozilaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(284, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // voziloidDataGridViewTextBoxColumn
            // 
            this.voziloidDataGridViewTextBoxColumn.DataPropertyName = "vozilo_id";
            this.voziloidDataGridViewTextBoxColumn.HeaderText = "Id Vozila";
            this.voziloidDataGridViewTextBoxColumn.Name = "voziloidDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka ";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // brojsasijeDataGridViewTextBoxColumn
            // 
            this.brojsasijeDataGridViewTextBoxColumn.DataPropertyName = "broj_sasije";
            this.brojsasijeDataGridViewTextBoxColumn.HeaderText = "Broj šasije ";
            this.brojsasijeDataGridViewTextBoxColumn.Name = "brojsasijeDataGridViewTextBoxColumn";
            // 
            // kategorijaDataGridViewTextBoxColumn
            // 
            this.kategorijaDataGridViewTextBoxColumn.DataPropertyName = "kategorija";
            this.kategorijaDataGridViewTextBoxColumn.HeaderText = "Kategorija ";
            this.kategorijaDataGridViewTextBoxColumn.Name = "kategorijaDataGridViewTextBoxColumn";
            // 
            // nosivostDataGridViewTextBoxColumn
            // 
            this.nosivostDataGridViewTextBoxColumn.DataPropertyName = "nosivost";
            this.nosivostDataGridViewTextBoxColumn.HeaderText = "Nosivost ";
            this.nosivostDataGridViewTextBoxColumn.Name = "nosivostDataGridViewTextBoxColumn";
            // 
            // brojsjedalaDataGridViewTextBoxColumn
            // 
            this.brojsjedalaDataGridViewTextBoxColumn.DataPropertyName = "broj_sjedala";
            this.brojsjedalaDataGridViewTextBoxColumn.HeaderText = "Broj sjedala";
            this.brojsjedalaDataGridViewTextBoxColumn.Name = "brojsjedalaDataGridViewTextBoxColumn";
            // 
            // regoznakaDataGridViewTextBoxColumn
            // 
            this.regoznakaDataGridViewTextBoxColumn.DataPropertyName = "reg_oznaka";
            this.regoznakaDataGridViewTextBoxColumn.HeaderText = "Registracijska oznaka";
            this.regoznakaDataGridViewTextBoxColumn.Name = "regoznakaDataGridViewTextBoxColumn";
            // 
            // datumregDataGridViewTextBoxColumn
            // 
            this.datumregDataGridViewTextBoxColumn.DataPropertyName = "datum_reg";
            this.datumregDataGridViewTextBoxColumn.HeaderText = "Datum registracije";
            this.datumregDataGridViewTextBoxColumn.Name = "datumregDataGridViewTextBoxColumn";
            // 
            // datzadizmjeneDataGridViewTextBoxColumn
            // 
            this.datzadizmjeneDataGridViewTextBoxColumn.DataPropertyName = "dat_zad_izmjene";
            this.datzadizmjeneDataGridViewTextBoxColumn.HeaderText = "Datum zadnje izmjene";
            this.datzadizmjeneDataGridViewTextBoxColumn.Name = "datzadizmjeneDataGridViewTextBoxColumn";
            // 
            // zapzadizmjeneDataGridViewTextBoxColumn
            // 
            this.zapzadizmjeneDataGridViewTextBoxColumn.DataPropertyName = "zap_zad_izmjene";
            this.zapzadizmjeneDataGridViewTextBoxColumn.HeaderText = "Zaposlenik koji je zadnji izmjenio";
            this.zapzadizmjeneDataGridViewTextBoxColumn.Name = "zapzadizmjeneDataGridViewTextBoxColumn";
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataSource = typeof(putni_nalozi.vozila);
            // 
            // frmVozilaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVozilaPregled";
            this.Text = "Pregled vozila";
            this.Load += new System.EventHandler(this.frmVozilaPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojsasijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosivostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojsjedalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumregDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datzadizmjeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zapzadizmjeneDataGridViewTextBoxColumn;
    }
}