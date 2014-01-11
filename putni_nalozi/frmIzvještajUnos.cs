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
    public partial class frmIzvještajUnos : Form
    {
        private putni_izvjestaji izv = null;
        public frmIzvještajUnos(putni_izvjestaji _izv=null)
        {
            InitializeComponent();
            izv = _izv;

        }

        private void frmIzvještajUnos_Load(object sender, EventArgs e)
        {
            dtpIzvjestajVrijemePolaska.Format = DateTimePickerFormat.Custom;
            dtpIzvjestajVrijemePolaska.CustomFormat = "dd MM yyyy hh mm";
            dtpIzvjestajVrijemeDolaska.Format = DateTimePickerFormat.Custom;
            dtpIzvjestajVrijemeDolaska.CustomFormat = "dd MM yyyy hh mm";
            using (var db = new putni_naloziEntities())
            {
                var nalozi = db.nalozi.ToList();
                foreach (var nalog in nalozi)
                {
                    if (izv == null && nalog.putni_izvjestaji.Count != 0)
                    {
                            continue;
                    }
                    cbNalog.Items.Add(nalog.nalog_id);
                    if (izv != null && nalog.nalog_id == izv.nalog_id)
                    {
                        cbNalog.SelectedIndex = cbNalog.Items.Count - 1;
                    }                    
                }
                if (izv != null)
                {
                    db.putni_izvjestaji.Attach(izv);
                    btSpremi.Visible = false;
                    cbNalog.Enabled = false;
                    dgvRacuni.ReadOnly = true;
                    dgvKretanjeVozila.ReadOnly = true;
                    tbIzvještajDuljinaPuta.ReadOnly = true;
                    dtpIzvjestajVrijemeDolaska.Enabled = false;
                    dtpIzvjestajVrijemePolaska.Enabled = false;               
                    dtpIzvjestajVrijemePolaska.Value = izv.vrijeme_polaska;
                    dtpIzvjestajVrijemeDolaska.Value = izv.vrijeme_dolaska;
                    tbIzvještajDuljinaPuta.Text = izv.duljina_puta.ToString();                   
                    double suma_racuna = 0;
                    foreach (izvjestaj_racuni ir in izv.izvjestaj_racuni)
                    {
                        DataGridViewRow red = (DataGridViewRow)dgvRacuni.Rows[0].Clone();
                        red.Cells[0].Value = ir.tip_racuna;
                        red.Cells[1].Value = ir.iznos;
                        red.Cells[2].Value = ir.broj_racuna;
                        red.Cells[3].Value = ir.racun_izdao;
                        red.Cells[4].Value = ir.datum_vrijeme;
                        dgvRacuni.Rows.Add(red);
                        suma_racuna += ir.iznos;
                    }
                    tbIzvještajTrošakPuta.Text = suma_racuna.ToString();                    
                    foreach (izvjestaji_kretanja_vozila kr in izv.izvjestaji_kretanja_vozila)
                    {
                        DataGridViewRow red = (DataGridViewRow)dgvKretanjeVozila.Rows[0].Clone();
                        red.Cells[0].Value = kr.stanje_brojila;
                        red.Cells[1].Value = kr.mjesto;
                        dgvKretanjeVozila.Rows.Add(red);
                    }
                }
            }            
        }

        private void cbNalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nalog_id = int.Parse(cbNalog.SelectedItem.ToString());
            using (var db = new putni_naloziEntities())
            {
                nalozi nalog = (from n in db.nalozi where n.nalog_id == nalog_id select n).First<nalozi>();
                tbNalogZaposlenik.Text = nalog.zaposlenici.ime+" "+nalog.zaposlenici.prezime;
                tbNalogVozilo.Text = nalog.vozila.marka;
                tbNalogVrijemePolaska.Text = nalog.vrijeme_polaska.ToString();
                tbNalogVrijemeDolaska.Text = nalog.vrijeme_dolaska.ToString();
                tbNalogPredviđeniTrošak.Text = nalog.trosak_puta.ToString();
            }
        }

        private void btSpremi_Click(object sender, EventArgs e)
        {
            int nalog_id = int.Parse(cbNalog.SelectedItem.ToString());
            using (var db = new putni_naloziEntities())
            {
                putni_izvjestaji pu = new putni_izvjestaji();
                pu.nalog_id = nalog_id;
                pu.vrijeme_polaska = dtpIzvjestajVrijemePolaska.Value;
                pu.vrijeme_dolaska = dtpIzvjestajVrijemeDolaska.Value;
                pu.duljina_puta = float.Parse(tbIzvještajDuljinaPuta.Text);
                pu.izvjestaj_kreirao= 2;
                pu.datum_kreiranja=DateTime.Now;
                pu.dat_zad_izmjene=DateTime.Now;
                pu.zap_zad_izmjene=2;

                db.putni_izvjestaji.Add(pu);
                db.SaveChanges();
                foreach (DataGridViewRow red in dgvKretanjeVozila.Rows)
                {
                    if (red.Cells[0].Value != null)
                    {
                        izvjestaji_kretanja_vozila kv = new izvjestaji_kretanja_vozila();
                        kv.putni_izvjestaj_id = pu.putni_izvjestaj_id;
                        kv.stanje_brojila = int.Parse(red.Cells[0].Value.ToString());
                        kv.mjesto = red.Cells[1].Value.ToString();
                        db.izvjestaji_kretanja_vozila.Add(kv);
                    }
                }
                foreach (DataGridViewRow red in dgvRacuni.Rows)
                {
                    if (red.Cells[0].Value != null)
                    {
                        izvjestaj_racuni rac = new izvjestaj_racuni();
                        rac.putni_izvjestaj_id = pu.putni_izvjestaj_id;
                        rac.tip_racuna = int.Parse(red.Cells[0].Value.ToString());
                        rac.iznos = float.Parse(red.Cells[1].Value.ToString());
                        rac.broj_racuna = red.Cells[2].Value.ToString();
                        rac.racun_izdao = red.Cells[3].Value.ToString();
                        rac.datum_vrijeme = Convert.ToDateTime(red.Cells[4].Value.ToString());
                        db.izvjestaj_racuni.Add(rac);
                    }
                }
                db.SaveChanges();
            }
            this.Close();
        }                 
    }
}
