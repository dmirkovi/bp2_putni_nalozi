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
    public partial class frmNaloziUnos : Form
    {
        public frmNaloziUnos()
        {
            InitializeComponent();
        }

        private void frmNaloziUnos_Load(object sender, EventArgs e)
        {
            using (var db = new putni_naloziEntities())
            {
                var zaposlenici = db.zaposlenici.ToList();
                foreach (var zapsolenik in zaposlenici)
                {
                    cbZaposlenici.Items.Add(zapsolenik.zaposlenik_id + "  |  "+ zapsolenik.prezime + " "+ zapsolenik.ime);
                }
                var vozila = db.vozila.ToList();
                foreach (var vozilo in vozila)
                {
                    cbVozila.Items.Add(vozilo.vozilo_id + "  |  " + vozilo.marka);
                }
            }
        }

        private void cbZaposlenici_SelectedIndexChanged(object sender, EventArgs e)
        {
            var zaposlenik = cbZaposlenici.SelectedItem.ToString().Split('|');
            int zaposlenik_id = int.Parse(zaposlenik[0]);

            tbZapKategorija.Text = "";
            using (var db = new putni_naloziEntities())
            {
               zaposlenici zap = (from z in db.zaposlenici where z.zaposlenik_id==zaposlenik_id select z).First<zaposlenici>();
               if(zap.kat_a==1) tbZapKategorija.Text+=" A ";
                if(zap.kat_b==1) tbZapKategorija.Text+=" B ";
                if(zap.kat_c==1) tbZapKategorija.Text+=" C ";
                if(zap.kat_d==1) tbZapKategorija.Text+=" D ";
                if(zap.kat_e==1) tbZapKategorija.Text+=" E ";
            }
        }

        
    }
}
