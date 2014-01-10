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
            ZaposleniciUnos.WindowState = FormWindowState.Maximized;
            ZaposleniciUnos.Show();
        }

        private void pregledZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposleniciPregled ZaposleniciPregled = new frmZaposleniciPregled();
            ZaposleniciPregled.MdiParent = this;
            ZaposleniciPregled.WindowState = FormWindowState.Maximized;
            ZaposleniciPregled.Show();
        }

        private void unosVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVozilaUnos VozilaUnos = new frmVozilaUnos();
            VozilaUnos.MdiParent = this;
            VozilaUnos.WindowState = FormWindowState.Maximized;
            VozilaUnos.Show();
        }

        private void pregledVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVozilaPregled VozilaPregled = new frmVozilaPregled();
            VozilaPregled.MdiParent = this;
            VozilaPregled.WindowState = FormWindowState.Maximized;
            VozilaPregled.Show();
        }

        private void dodajNalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNaloziUnos NaloziUnos = new frmNaloziUnos();
            NaloziUnos.MdiParent = this;
            NaloziUnos.WindowState = FormWindowState.Maximized;
            NaloziUnos.Show();
        }

        private void pregledNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
