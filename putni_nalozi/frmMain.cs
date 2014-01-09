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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unosZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposleniciUnos ZaposleniciUnos = new frmZaposleniciUnos();
            ZaposleniciUnos.MdiParent = this;
            ZaposleniciUnos.Show();
        }

        private void pregledZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposleniciPregled ZaposleniciPregled = new frmZaposleniciPregled();
            ZaposleniciPregled.MdiParent = this;
            ZaposleniciPregled.Show();
        }
    }
}
