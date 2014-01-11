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
        private nalozi nalog_za_uredivanje = null;
        public frmNaloziUnos(nalozi _nalog_za_uredivanje=null)
        {

            InitializeComponent();
            nalog_za_uredivanje = _nalog_za_uredivanje;
            dtpDolaska.Format = DateTimePickerFormat.Custom;
            dtpDolaska.CustomFormat = "dd MM yyyy hh mm";
            dtpPolaska.Format = DateTimePickerFormat.Custom;
            dtpPolaska.CustomFormat = "dd MM yyyy hh mm";
            
        }

        private void frmNaloziUnos_Load(object sender, EventArgs e)
        {
            using (var db = new putni_naloziEntities())
            {
                var zaposlenici = db.zaposlenici.ToList();
                foreach (var zapsolenik in zaposlenici)
                {
                    cbZaposlenici.Items.Add(zapsolenik.zaposlenik_id + "  |  "+ zapsolenik.prezime + " "+ zapsolenik.ime);
                    if (nalog_za_uredivanje != null && nalog_za_uredivanje.zaposlenik_id == zapsolenik.zaposlenik_id)
                        cbZaposlenici.SelectedIndex = cbZaposlenici.Items.Count - 1;
                }

                var vozila = db.vozila.ToList();
                foreach (var vozilo in vozila)
                {
                    
                    cbVozila.Items.Add(vozilo.vozilo_id + "  |  " + vozilo.marka);
                    if (nalog_za_uredivanje != null && nalog_za_uredivanje.vozilo_id == vozilo.vozilo_id)
                        cbVozila.SelectedIndex = cbVozila.Items.Count - 1;
                }
                if (nalog_za_uredivanje != null)
                {
                    db.nalozi.Attach(nalog_za_uredivanje);
                    tbSvrha.Text = nalog_za_uredivanje.svrha;
                    tbTrosak.Text = nalog_za_uredivanje.trosak_puta.ToString();
                    dtpDolaska.Value = nalog_za_uredivanje.vrijeme_dolaska;
                    dtpPolaska.Value = nalog_za_uredivanje.vrijeme_polaska;
                    foreach (nalozi_mjesta mjesto in nalog_za_uredivanje.nalozi_mjesta)
                    {
                        DataGridViewRow red = (DataGridViewRow)dgvMjesta.Rows[0].Clone();
                        red.Cells[0].Value = mjesto.naziv_mjesta;
                        dgvMjesta.Rows.Add(red);
                    }
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

        private void cbVozila_SelectedIndexChanged(object sender, EventArgs e)
        {

            var vozilo = cbVozila.SelectedItem.ToString().Split('|');
            int vozilo_id = int.Parse(vozilo[0]);

            using (var db = new putni_naloziEntities())
            {
                vozila voz = (from v in db.vozila where v.vozilo_id == vozilo_id select v).First<vozila>();
                tbVozKategorija.Text = voz.kategorija;
                tbRegistracijskaOznaka.Text = voz.reg_oznaka;
                tbMarka.Text = voz.marka;
                tbNosivost.Text = voz.nosivost.ToString();
                tbDatumRegistracije.Text = voz.datum_reg.ToString();
                tbBrojSasije.Text = voz.broj_sasije;
                tbBrojSjedala.Text = voz.broj_sjedala.ToString();
            }
        }

        private void btNalogSpermi_Click(object sender, EventArgs e)
        {
            var zaposlenik = cbZaposlenici.SelectedItem.ToString().Split('|');
            int zaposlenik_id = int.Parse(zaposlenik[0]);

            var vozilo = cbVozila.SelectedItem.ToString().Split('|');
            int vozilo_id = int.Parse(vozilo[0]);

            using (var db = new putni_naloziEntities())
            {
                nalozi nalog = null;
                if (nalog_za_uredivanje == null)
                {
                    nalog = new nalozi();
                }
                else
                {
                    nalog = nalog_za_uredivanje;
                    db.nalozi.Attach(nalog);
                    db.Database.ExecuteSqlCommand("DELETE FROM nalozi_mjesta WHERE nalog_id={0}", nalog.nalog_id);
                    
                }
                nalog.zaposlenik_id = zaposlenik_id;
                nalog.vozilo_id = vozilo_id;
                nalog.vrijeme_polaska = dtpPolaska.Value;
                nalog.vrijeme_dolaska = dtpDolaska.Value;
                nalog.svrha = tbSvrha.Text;
                nalog.trosak_puta = float.Parse(tbTrosak.Text);
                nalog.datum_kreiranja = DateTime.Now;
                nalog.nalog_kreirao = 2;
                nalog.dat_zad_izmjene = DateTime.Now;
                nalog.zap_zad_izmjene = 2;
                if (nalog_za_uredivanje == null)
                {
                    db.nalozi.Add(nalog);
                }
                
                db.SaveChanges();
                foreach (DataGridViewRow red in dgvMjesta.Rows)
                {
                    if (red.Cells[0].Value != null)
                    {
                        nalozi_mjesta mjesto = new nalozi_mjesta();
                        mjesto.nalog_id = nalog.nalog_id;
                        mjesto.naziv_mjesta = red.Cells[0].Value.ToString();
                        db.nalozi_mjesta.Add(mjesto);

                    }
                }
                db.SaveChanges();
            }
            frmNaloziPregled NaloziPregled = new frmNaloziPregled();
            NaloziPregled.MdiParent = this.MdiParent;
            NaloziPregled.Show();
            this.Close();
        }

        
    }
}
