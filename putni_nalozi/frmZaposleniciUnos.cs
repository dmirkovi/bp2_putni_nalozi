using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace putni_nalozi
{
    public partial class frmZaposleniciUnos : Form
    {
        private zaposlenici zaposlenik_za_uredivanje=null;
        
        public frmZaposleniciUnos(zaposlenici _zaposlenik_za_uredivanje = null)
        {
            InitializeComponent();
            zaposlenik_za_uredivanje = _zaposlenik_za_uredivanje;
            if (zaposlenik_za_uredivanje != null) 
            {
                tbPrezimeZaposlenika.Text = zaposlenik_za_uredivanje.prezime;
                tbImeZaposlenika.Text = zaposlenik_za_uredivanje.ime;
                if (zaposlenik_za_uredivanje.kat_a == 1) cbKatA.Checked = true;
                if (zaposlenik_za_uredivanje.kat_b == 1) cbKatB.Checked = true;
                if (zaposlenik_za_uredivanje.kat_c == 1) cbKatC.Checked = true;
                if (zaposlenik_za_uredivanje.kat_d == 1) cbKatD.Checked = true;
                if (zaposlenik_za_uredivanje.kat_e == 1) cbKatE.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db=new putni_naloziEntities()) {
                if (zaposlenik_za_uredivanje == null)
                {
                    zaposlenici zap = new zaposlenici();
                    zap.prezime = tbPrezimeZaposlenika.Text;
                    zap.ime = tbImeZaposlenika.Text;
                    zap.kat_a = Convert.ToInt32(cbKatA.Checked);
                    zap.kat_b = Convert.ToInt32(cbKatB.Checked);
                    zap.kat_c = Convert.ToInt32(cbKatC.Checked);
                    zap.kat_d = Convert.ToInt32(cbKatD.Checked);
                    zap.kat_e = Convert.ToInt32(cbKatE.Checked);
                    zap.dat_zad_izmjene = DateTime.Now;
                    zap.zap_zad_izmjene = 2;
                    db.zaposlenici.Add(zap);
                    db.SaveChanges();
                }
                else
                {
                    db.zaposlenici.Attach(zaposlenik_za_uredivanje);
                    zaposlenik_za_uredivanje.prezime = tbPrezimeZaposlenika.Text;
                    zaposlenik_za_uredivanje.ime = tbImeZaposlenika.Text;
                    zaposlenik_za_uredivanje.kat_a = Convert.ToInt32(cbKatA.Checked);
                    zaposlenik_za_uredivanje.kat_b = Convert.ToInt32(cbKatB.Checked);
                    zaposlenik_za_uredivanje.kat_c = Convert.ToInt32(cbKatC.Checked);
                    zaposlenik_za_uredivanje.kat_d = Convert.ToInt32(cbKatD.Checked);
                    zaposlenik_za_uredivanje.kat_e = Convert.ToInt32(cbKatE.Checked);
                    zaposlenik_za_uredivanje.dat_zad_izmjene = DateTime.Now;
                    zaposlenik_za_uredivanje.zap_zad_izmjene = 2;
                    db.SaveChanges();
                }
            }
            frmZaposleniciPregled ZaposleniciPregled = new frmZaposleniciPregled();
            ZaposleniciPregled.MdiParent = this.MdiParent;
            ZaposleniciPregled.Show();
            this.Close();
        }
    }
}
