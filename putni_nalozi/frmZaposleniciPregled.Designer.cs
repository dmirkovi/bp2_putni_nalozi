namespace putni_nalozi
{
    partial class frmZaposleniciPregled
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
            this.dgvPregledZaposlenika = new System.Windows.Forms.DataGridView();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datzadizmjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledZaposlenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledZaposlenika
            // 
            this.dgvPregledZaposlenika.AutoGenerateColumns = false;
            this.dgvPregledZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledZaposlenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.kataDataGridViewTextBoxColumn,
            this.katbDataGridViewTextBoxColumn,
            this.katcDataGridViewTextBoxColumn,
            this.katdDataGridViewTextBoxColumn,
            this.kateDataGridViewTextBoxColumn,
            this.datzadizmjeneDataGridViewTextBoxColumn});
            this.dgvPregledZaposlenika.DataSource = this.zaposleniciBindingSource;
            this.dgvPregledZaposlenika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregledZaposlenika.Location = new System.Drawing.Point(0, 0);
            this.dgvPregledZaposlenika.Name = "dgvPregledZaposlenika";
            this.dgvPregledZaposlenika.Size = new System.Drawing.Size(615, 364);
            this.dgvPregledZaposlenika.TabIndex = 0;
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataSource = typeof(putni_nalozi.zaposlenici);
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // kataDataGridViewTextBoxColumn
            // 
            this.kataDataGridViewTextBoxColumn.DataPropertyName = "kat_a";
            this.kataDataGridViewTextBoxColumn.HeaderText = "kat_a";
            this.kataDataGridViewTextBoxColumn.Name = "kataDataGridViewTextBoxColumn";
            // 
            // katbDataGridViewTextBoxColumn
            // 
            this.katbDataGridViewTextBoxColumn.DataPropertyName = "kat_b";
            this.katbDataGridViewTextBoxColumn.HeaderText = "kat_b";
            this.katbDataGridViewTextBoxColumn.Name = "katbDataGridViewTextBoxColumn";
            // 
            // katcDataGridViewTextBoxColumn
            // 
            this.katcDataGridViewTextBoxColumn.DataPropertyName = "kat_c";
            this.katcDataGridViewTextBoxColumn.HeaderText = "kat_c";
            this.katcDataGridViewTextBoxColumn.Name = "katcDataGridViewTextBoxColumn";
            // 
            // katdDataGridViewTextBoxColumn
            // 
            this.katdDataGridViewTextBoxColumn.DataPropertyName = "kat_d";
            this.katdDataGridViewTextBoxColumn.HeaderText = "kat_d";
            this.katdDataGridViewTextBoxColumn.Name = "katdDataGridViewTextBoxColumn";
            // 
            // kateDataGridViewTextBoxColumn
            // 
            this.kateDataGridViewTextBoxColumn.DataPropertyName = "kat_e";
            this.kateDataGridViewTextBoxColumn.HeaderText = "kat_e";
            this.kateDataGridViewTextBoxColumn.Name = "kateDataGridViewTextBoxColumn";
            // 
            // datzadizmjeneDataGridViewTextBoxColumn
            // 
            this.datzadizmjeneDataGridViewTextBoxColumn.DataPropertyName = "dat_zad_izmjene";
            this.datzadizmjeneDataGridViewTextBoxColumn.HeaderText = "dat_zad_izmjene";
            this.datzadizmjeneDataGridViewTextBoxColumn.Name = "datzadizmjeneDataGridViewTextBoxColumn";
            // 
            // frmZaposleniciPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 364);
            this.Controls.Add(this.dgvPregledZaposlenika);
            this.Name = "frmZaposleniciPregled";
            this.Text = "Pregled zaposlenika";
            this.Load += new System.EventHandler(this.frmZaposleniciPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledZaposlenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledZaposlenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datzadizmjeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;

    }
}