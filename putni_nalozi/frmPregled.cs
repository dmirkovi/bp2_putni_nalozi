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
    public partial class frmPregled : Form
    {
        public frmPregled()
        {
            InitializeComponent();
        }

        private void frmPregled_Load(object sender, EventArgs e)
        {
            BindingList<putni_izvjestaji> ir = null;
            using (var db = new putni_naloziEntities())
            {
                ir = new BindingList<putni_izvjestaji>(db.putni_izvjestaji.ToList());                
            }
            putniizvjestajiBindingSource.DataSource = ir;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            putni_izvjestaji izv = (putni_izvjestaji)putniizvjestajiBindingSource.Current;
            frmIzvještajUnos ir= new frmIzvještajUnos(izv);
            ir.MdiParent = this.MdiParent;
            ir.WindowState = FormWindowState.Maximized;
            ir.Show();
        }
    }
}
