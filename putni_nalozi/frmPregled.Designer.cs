namespace putni_nalozi
{
    partial class frmPregled
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
            this.putniizvjestajidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalogidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemepolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemedolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duljinaputaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvjestajkreiraoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datzadizmjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapzadizmjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putniizvjestajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniizvjestajiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.putniizvjestajidDataGridViewTextBoxColumn,
            this.nalogidDataGridViewTextBoxColumn,
            this.vrijemepolaskaDataGridViewTextBoxColumn,
            this.vrijemedolaskaDataGridViewTextBoxColumn,
            this.duljinaputaDataGridViewTextBoxColumn,
            this.izvjestajkreiraoDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn,
            this.datzadizmjeneDataGridViewTextBoxColumn,
            this.zapzadizmjeneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.putniizvjestajiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(903, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // putniizvjestajidDataGridViewTextBoxColumn
            // 
            this.putniizvjestajidDataGridViewTextBoxColumn.DataPropertyName = "putni_izvjestaj_id";
            this.putniizvjestajidDataGridViewTextBoxColumn.HeaderText = "putni_izvjestaj_id";
            this.putniizvjestajidDataGridViewTextBoxColumn.Name = "putniizvjestajidDataGridViewTextBoxColumn";
            this.putniizvjestajidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nalogidDataGridViewTextBoxColumn
            // 
            this.nalogidDataGridViewTextBoxColumn.DataPropertyName = "nalog_id";
            this.nalogidDataGridViewTextBoxColumn.HeaderText = "nalog_id";
            this.nalogidDataGridViewTextBoxColumn.Name = "nalogidDataGridViewTextBoxColumn";
            this.nalogidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // duljinaputaDataGridViewTextBoxColumn
            // 
            this.duljinaputaDataGridViewTextBoxColumn.DataPropertyName = "duljina_puta";
            this.duljinaputaDataGridViewTextBoxColumn.HeaderText = "duljina_puta";
            this.duljinaputaDataGridViewTextBoxColumn.Name = "duljinaputaDataGridViewTextBoxColumn";
            this.duljinaputaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izvjestajkreiraoDataGridViewTextBoxColumn
            // 
            this.izvjestajkreiraoDataGridViewTextBoxColumn.DataPropertyName = "izvjestaj_kreirao";
            this.izvjestajkreiraoDataGridViewTextBoxColumn.HeaderText = "izvjestaj_kreirao";
            this.izvjestajkreiraoDataGridViewTextBoxColumn.Name = "izvjestajkreiraoDataGridViewTextBoxColumn";
            this.izvjestajkreiraoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // putniizvjestajiBindingSource
            // 
            this.putniizvjestajiBindingSource.DataSource = typeof(putni_nalozi.putni_izvjestaji);
            // 
            // frmPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 283);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPregled";
            this.Text = "Pregled izvještaja";
            this.Load += new System.EventHandler(this.frmPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putniizvjestajiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource putniizvjestajiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn putniizvjestajidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nalogidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemepolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemedolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duljinaputaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvjestajkreiraoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datzadizmjeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zapzadizmjeneDataGridViewTextBoxColumn;
    }
}