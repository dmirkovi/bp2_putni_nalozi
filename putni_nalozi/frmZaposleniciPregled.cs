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
    public partial class frmZaposleniciPregled : Form
    {
        public frmZaposleniciPregled()
        {
            InitializeComponent();
        }

        private void frmZaposleniciPregled_Load(object sender, EventArgs e)
        {
            BindingList<zaposlenici> PregledZaposlenika = null;
            using(var db = new putni_naloziEntities()){
                PregledZaposlenika = new BindingList<zaposlenici>(db.zaposlenici.ToList());
            }
            zaposleniciBindingSource.DataSource = PregledZaposlenika;
            
        }

        private void dgvPregledZaposlenika_Click(object sender, EventArgs e)
        {
            zaposlenici zap = (zaposlenici)zaposleniciBindingSource.Current;
            frmZaposleniciUnos ZaposleniciUnos = new frmZaposleniciUnos(zap);
            ZaposleniciUnos.MdiParent = this.MdiParent;
            ZaposleniciUnos.Show();
            this.Close();
        }
    }
}
