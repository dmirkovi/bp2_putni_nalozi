namespace putni_nalozi
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naloziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledNalogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KreiranjeIzvještajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledIzvještajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.vozilaToolStripMenuItem,
            this.naloziToolStripMenuItem,
            this.izvještajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fileToolStripMenuItem.Text = "Datoteka";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosZaposlenikaToolStripMenuItem,
            this.pregledZaposlenikaToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // unosZaposlenikaToolStripMenuItem
            // 
            this.unosZaposlenikaToolStripMenuItem.Name = "unosZaposlenikaToolStripMenuItem";
            this.unosZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.unosZaposlenikaToolStripMenuItem.Text = "Unos zaposlenika";
            this.unosZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.unosZaposlenikaToolStripMenuItem_Click);
            // 
            // pregledZaposlenikaToolStripMenuItem
            // 
            this.pregledZaposlenikaToolStripMenuItem.Name = "pregledZaposlenikaToolStripMenuItem";
            this.pregledZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pregledZaposlenikaToolStripMenuItem.Text = "Pregled zaposlenika";
            this.pregledZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.pregledZaposlenikaToolStripMenuItem_Click);
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosVozilaToolStripMenuItem,
            this.pregledVozilaToolStripMenuItem});
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            // 
            // unosVozilaToolStripMenuItem
            // 
            this.unosVozilaToolStripMenuItem.Name = "unosVozilaToolStripMenuItem";
            this.unosVozilaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.unosVozilaToolStripMenuItem.Text = "Unos vozila";
            this.unosVozilaToolStripMenuItem.Click += new System.EventHandler(this.unosVozilaToolStripMenuItem_Click);
            // 
            // pregledVozilaToolStripMenuItem
            // 
            this.pregledVozilaToolStripMenuItem.Name = "pregledVozilaToolStripMenuItem";
            this.pregledVozilaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.pregledVozilaToolStripMenuItem.Text = "Pregled vozila";
            this.pregledVozilaToolStripMenuItem.Click += new System.EventHandler(this.pregledVozilaToolStripMenuItem_Click);
            // 
            // naloziToolStripMenuItem
            // 
            this.naloziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNalogToolStripMenuItem,
            this.pregledNalogaToolStripMenuItem});
            this.naloziToolStripMenuItem.Name = "naloziToolStripMenuItem";
            this.naloziToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.naloziToolStripMenuItem.Text = "Nalozi";
            // 
            // dodajNalogToolStripMenuItem
            // 
            this.dodajNalogToolStripMenuItem.Name = "dodajNalogToolStripMenuItem";
            this.dodajNalogToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dodajNalogToolStripMenuItem.Text = "Dodaj nalog";
            this.dodajNalogToolStripMenuItem.Click += new System.EventHandler(this.dodajNalogToolStripMenuItem_Click);
            // 
            // pregledNalogaToolStripMenuItem
            // 
            this.pregledNalogaToolStripMenuItem.Name = "pregledNalogaToolStripMenuItem";
            this.pregledNalogaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pregledNalogaToolStripMenuItem.Text = "Pregled naloga";
            this.pregledNalogaToolStripMenuItem.Click += new System.EventHandler(this.pregledNalogaToolStripMenuItem_Click);
            // 
            // izvještajToolStripMenuItem
            // 
            this.izvještajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KreiranjeIzvještajaToolStripMenuItem,
            this.pregledIzvještajaToolStripMenuItem});
            this.izvještajToolStripMenuItem.Name = "izvještajToolStripMenuItem";
            this.izvještajToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvještajToolStripMenuItem.Text = "Izvještaj";
            // 
            // KreiranjeIzvještajaToolStripMenuItem
            // 
            this.KreiranjeIzvještajaToolStripMenuItem.Name = "KreiranjeIzvještajaToolStripMenuItem";
            this.KreiranjeIzvještajaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.KreiranjeIzvještajaToolStripMenuItem.Text = "Kreiranje izvještaja";
            this.KreiranjeIzvještajaToolStripMenuItem.Click += new System.EventHandler(this.KreiranjeIzvještajaToolStripMenuItem_Click);
            // 
            // pregledIzvještajaToolStripMenuItem
            // 
            this.pregledIzvještajaToolStripMenuItem.Name = "pregledIzvještajaToolStripMenuItem";
            this.pregledIzvještajaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pregledIzvještajaToolStripMenuItem.Text = "Pregled izvještaja";
            this.pregledIzvještajaToolStripMenuItem.Click += new System.EventHandler(this.pregledIzvještajaToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 591);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Putni nalozi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naloziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledNalogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KreiranjeIzvještajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledIzvještajaToolStripMenuItem;
    }
}

