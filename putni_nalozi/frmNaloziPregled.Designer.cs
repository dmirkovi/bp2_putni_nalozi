namespace putni_nalozi
{
    partial class frmNaloziPregled
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
            this.dgvNaloziPregled = new System.Windows.Forms.DataGridView();
            this.nalogidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemepolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemedolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svrhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trosakputaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalogkreiraoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datzadizmjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapzadizmjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naloziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaloziPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naloziBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNaloziPregled
            // 
            this.dgvNaloziPregled.AllowUserToAddRows = false;
            this.dgvNaloziPregled.AllowUserToDeleteRows = false;
            this.dgvNaloziPregled.AutoGenerateColumns = false;
            this.dgvNaloziPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaloziPregled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nalogidDataGridViewTextBoxColumn,
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.voziloidDataGridViewTextBoxColumn,
            this.vrijemepolaskaDataGridViewTextBoxColumn,
            this.vrijemedolaskaDataGridViewTextBoxColumn,
            this.svrhaDataGridViewTextBoxColumn,
            this.trosakputaDataGridViewTextBoxColumn,
            this.nalogkreiraoDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn,
            this.datzadizmjeneDataGridViewTextBoxColumn,
            this.zapzadizmjeneDataGridViewTextBoxColumn});
            this.dgvNaloziPregled.DataSource = this.naloziBindingSource;
            this.dgvNaloziPregled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNaloziPregled.Location = new System.Drawing.Point(0, 0);
            this.dgvNaloziPregled.Name = "dgvNaloziPregled";
            this.dgvNaloziPregled.ReadOnly = true;
            this.dgvNaloziPregled.RowHeadersVisible = false;
            this.dgvNaloziPregled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNaloziPregled.Size = new System.Drawing.Size(813, 277);
            this.dgvNaloziPregled.TabIndex = 0;
            this.dgvNaloziPregled.Click += new System.EventHandler(this.dgvNaloziPregled_Click);
            // 
            // nalogidDataGridViewTextBoxColumn
            // 
            this.nalogidDataGridViewTextBoxColumn.DataPropertyName = "nalog_id";
            this.nalogidDataGridViewTextBoxColumn.HeaderText = "nalog_id";
            this.nalogidDataGridViewTextBoxColumn.Name = "nalogidDataGridViewTextBoxColumn";
            this.nalogidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            this.zaposlenikidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voziloidDataGridViewTextBoxColumn
            // 
            this.voziloidDataGridViewTextBoxColumn.DataPropertyName = "vozilo_id";
            this.voziloidDataGridViewTextBoxColumn.HeaderText = "vozilo_id";
            this.voziloidDataGridViewTextBoxColumn.Name = "voziloidDataGridViewTextBoxColumn";
            this.voziloidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemepolaskaDataGridViewTextBoxColumn
            // 
            this.vrijemepolaskaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_polaska";
            this.vrijemepolaskaDataGridViewTextBoxColumn.HeaderText = "vrijeme_polaska";
            this.vrijemepolaskaDataGridViewTextBoxColumn.Name = "vrijemepolaskaDataGridViewTextBoxColumn";
            this.vrijemepolaskaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemedolaskaDataGridViewTextBoxColumn
            // 
            this.vrijemedolaskaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_dolaska";
            this.vrijemedolaskaDataGridViewTextBoxColumn.HeaderText = "vrijeme_dolaska";
            this.vrijemedolaskaDataGridViewTextBoxColumn.Name = "vrijemedolaskaDataGridViewTextBoxColumn";
            this.vrijemedolaskaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svrhaDataGridViewTextBoxColumn
            // 
            this.svrhaDataGridViewTextBoxColumn.DataPropertyName = "svrha";
            this.svrhaDataGridViewTextBoxColumn.HeaderText = "svrha";
            this.svrhaDataGridViewTextBoxColumn.Name = "svrhaDataGridViewTextBoxColumn";
            this.svrhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trosakputaDataGridViewTextBoxColumn
            // 
            this.trosakputaDataGridViewTextBoxColumn.DataPropertyName = "trosak_puta";
            this.trosakputaDataGridViewTextBoxColumn.HeaderText = "trosak_puta";
            this.trosakputaDataGridViewTextBoxColumn.Name = "trosakputaDataGridViewTextBoxColumn";
            this.trosakputaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nalogkreiraoDataGridViewTextBoxColumn
            // 
            this.nalogkreiraoDataGridViewTextBoxColumn.DataPropertyName = "nalog_kreirao";
            this.nalogkreiraoDataGridViewTextBoxColumn.HeaderText = "nalog_kreirao";
            this.nalogkreiraoDataGridViewTextBoxColumn.Name = "nalogkreiraoDataGridViewTextBoxColumn";
            this.nalogkreiraoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumkreiranjaDataGridViewTextBoxColumn
            // 
            this.datumkreiranjaDataGridViewTextBoxColumn.DataPropertyName = "datum_kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.HeaderText = "datum_kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.Name = "datumkreiranjaDataGridViewTextBoxColumn";
            this.datumkreiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datzadizmjeneDataGridViewTextBoxColumn
            // 
            this.datzadizmjeneDataGridViewTextBoxColumn.DataPropertyName = "dat_zad_izmjene";
            this.datzadizmjeneDataGridViewTextBoxColumn.HeaderText = "dat_zad_izmjene";
            this.datzadizmjeneDataGridViewTextBoxColumn.Name = "datzadizmjeneDataGridViewTextBoxColumn";
            this.datzadizmjeneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zapzadizmjeneDataGridViewTextBoxColumn
            // 
            this.zapzadizmjeneDataGridViewTextBoxColumn.DataPropertyName = "zap_zad_izmjene";
            this.zapzadizmjeneDataGridViewTextBoxColumn.HeaderText = "zap_zad_izmjene";
            this.zapzadizmjeneDataGridViewTextBoxColumn.Name = "zapzadizmjeneDataGridViewTextBoxColumn";
            this.zapzadizmjeneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naloziBindingSource
            // 
            this.naloziBindingSource.DataSource = typeof(putni_nalozi.nalozi);
            // 
            // frmNaloziPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 277);
            this.Controls.Add(this.dgvNaloziPregled);
            this.Name = "frmNaloziPregled";
            this.Text = "Pregled naloga";
            this.Load += new System.EventHandler(this.frmNaloziPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaloziPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naloziBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNaloziPregled;
        private System.Windows.Forms.BindingSource naloziBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nalogidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemepolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemedolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svrhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trosakputaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nalogkreiraoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datzadizmjeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zapzadizmjeneDataGridViewTextBoxColumn;
    }
}