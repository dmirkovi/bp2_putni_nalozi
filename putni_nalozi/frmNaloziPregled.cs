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
    public partial class frmNaloziPregled : Form
    {
        public frmNaloziPregled()
        {
            InitializeComponent();
        }

        private void frmNaloziPregled_Load(object sender, EventArgs e)
        {
            BindingList<nalozi> PregledNaloga = null;
            using(var db = new putni_naloziEntities()){
                PregledNaloga = new BindingList<nalozi>(db.nalozi.ToList());
            }
            naloziBindingSource.DataSource = PregledNaloga;
        }

        private void dgvNaloziPregled_Click(object sender, EventArgs e)
        {
            nalozi nalog = (nalozi)naloziBindingSource.Current;
            frmNaloziUnos NaloziUnos = new frmNaloziUnos(nalog);
            NaloziUnos.MdiParent = this.MdiParent;
            NaloziUnos.Show();
            this.Close();
        }
            
    }
}
