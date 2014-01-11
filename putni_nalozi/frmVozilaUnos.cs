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
    public partial class frmVozilaUnos : Form
    {
        private vozila vozila_za_uredivanje=null;
        public frmVozilaUnos(vozila _vozila_za_uredivanje=null)
        {
            InitializeComponent();
            vozila_za_uredivanje = _vozila_za_uredivanje;
            if (vozila_za_uredivanje != null)
            {
                tbMarkaVozila.Text = vozila_za_uredivanje.marka;
                tbBrojSasije.Text = vozila_za_uredivanje.broj_sasije;
                tbBrojSjedala.Text = vozila_za_uredivanje.broj_sjedala.ToString();
                tbKategorija.Text = vozila_za_uredivanje.kategorija;
                tbNosivost.Text = vozila_za_uredivanje.nosivost.ToString();
                dtpDatumRegistracije.Value =  (DateTime)vozila_za_uredivanje.datum_reg;               
                tbRegistracijskaOznaka.Text = vozila_za_uredivanje.reg_oznaka;

            }
            dtpDatumRegistracije.Format = DateTimePickerFormat.Custom;
            dtpDatumRegistracije.CustomFormat = "dd MM yyyy";
        }

        private void btnVozilaSpremi_Click(object sender, EventArgs e)
        {
           
            using (var db = new putni_naloziEntities())
            {
                vozila voz = null;
                if (vozila_za_uredivanje == null)
                {
                    voz = new vozila();
                }
                else
                {
                    voz = vozila_za_uredivanje;
                    db.vozila.Attach(voz);
                } 
                voz.marka = tbMarkaVozila.Text;
                voz.broj_sasije = tbBrojSasije.Text;
                voz.broj_sjedala = int.Parse(tbBrojSjedala.Text);
                voz.kategorija = tbKategorija.Text;
                voz.nosivost = float.Parse(tbNosivost.Text);
                voz.datum_reg = dtpDatumRegistracije.Value; 
                voz.reg_oznaka = tbRegistracijskaOznaka.Text;
                voz.dat_zad_izmjene = DateTime.Now;
                voz.zap_zad_izmjene = 2;
                if (vozila_za_uredivanje == null)
                {
                    db.vozila.Add(voz);
                }
                db.SaveChanges();
            }
            frmVozilaPregled VozilaPregled = new frmVozilaPregled();
            VozilaPregled.MdiParent = this.MdiParent;
            VozilaPregled.Show();
            this.Close();
        }
    }
}
