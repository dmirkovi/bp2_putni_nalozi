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
        public frmZaposleniciUnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db=new putni_naloziEntities()) {
                zaposlenici zap = new zaposlenici();
                zap.prezime = tbPrezimeZaposlenika.Text;
                zap.ime = tbImeZaposlenika.Text;
                zap.kat_a = Convert.ToInt32(cbKatA.Checked);
                zap.kat_b = Convert.ToInt32(cbKatB.Checked);
                zap.kat_c = Convert.ToInt32(cbKatC.Checked);
                zap.kat_d = Convert.ToInt32(cbKatD.Checked);
                zap.kat_e = Convert.ToInt32(cbKatE.Checked);
                zap.dat_zad_izmjene = DateTime.Now;
                db.zaposlenici.Add(zap);
                db.SaveChanges();

            }
            this.Close();
        }
    }
}
