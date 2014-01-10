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
    public partial class frmVozilaPregled : Form
    {
        public frmVozilaPregled()
        {
            InitializeComponent();
        }

        private void frmVozilaPregled_Load(object sender, EventArgs e)
        {
           
            BindingList<vozila> PregledVozila = null;
            using (var db = new putni_naloziEntities())
            {
                PregledVozila = new BindingList<vozila>(db.vozila.ToList());
            }
            vozilaBindingSource.DataSource = PregledVozila;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            vozila voz = (vozila)vozilaBindingSource.Current;
            frmVozilaUnos VozilaUnos = new frmVozilaUnos(voz);
            VozilaUnos.MdiParent = this.MdiParent;
            VozilaUnos.Show();
            this.Close();
        }
    }
}
