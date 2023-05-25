using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisUygulamasi
{
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }

        private void lblStandart4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNumeric12_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnGoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var db = new BarkodDbEntities())
            {
                if (listFiltrelemeTuru.SelectedIndex == 0)//tümünü getir
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;

                    txtSatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    txtSatisKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Kart)).ToString("C2");

                    txtIadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Nakit)).ToString("C2");
                    txtIadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");

                    txtGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    txtGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Kart)).ToString("C2");

                    txtGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    txtGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Kart)).ToString("C2");

                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satistablosu = db.Satis.Local.ToBindingList();
                    double kdvtutarisatis = Islemler.doubleYap(satistablosu.Where(x => x.İade == false).Sum(x => x.KdvTutari).ToString());
                    double kdvtutariiade = Islemler.doubleYap(satistablosu.Where(x => x.İade == true).Sum(x => x.KdvTutari).ToString());
                    txtKdvToplam.Text = (kdvtutarisatis - kdvtutariiade).ToString("C2");


                }
                else if (listFiltrelemeTuru.SelectedIndex == 1)//satışlar
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == false && x.Gelir == false && x.Gider == false).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;



                }
                else if (listFiltrelemeTuru.SelectedIndex == 2)//iadeler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (listFiltrelemeTuru.SelectedIndex == 3)//gelirler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (listFiltrelemeTuru.SelectedIndex == 4)//giderler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
            }
            Islemler.GridDuzenle(gridListe);






            Cursor.Current = Cursors.Default;
        }

        private void fRapor_Load(object sender, EventArgs e)
        {
            listFiltrelemeTuru.SelectedIndex = 0;
            txtKartKomisyon.Text = Islemler.KartKomisyon().ToString();
            btnGoster_Click(null, null);
        }

        private void gridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;
                }
            }

        }

        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GELİR";
            f.kullanici = lblKullanici.Text;

            f.ShowDialog();

        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GİDER";
            f.kullanici = lblKullanici.Text;

            f.ShowDialog();
        }

        private void detayGoster_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListe.Rows.Count > 0)
            {
                int islemno = Convert.ToInt32(gridListe.CurrentRow.Cells["IslemNo"].Value.ToString());
                if (islemno != 0)
                {
                    fDetayGoster f = new fDetayGoster();
                    f.islemno = islemno;
                    f.ShowDialog();

                }


            }
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            Raporlar.Baslik = "GENEL RAPOR";
            Raporlar.SatisNakit = txtSatisNakit.Text;
            Raporlar.SatisKart = txtSatisKart.Text;
            Raporlar.IadeKart = txtIadeKart.Text;
            Raporlar.IadeNakit = txtIadeNakit.Text;
            Raporlar.GelirKart=txtGelirKart.Text;
            Raporlar.GelirNakit = txtGelirNakit.Text;
            Raporlar.GiderNakit=txtGiderNakit.Text;
            Raporlar.GiderKart = txtGiderKart.Text;
            Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
            Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
            Raporlar.KdvToplam = txtKdvToplam.Text;
            Raporlar.KartKomisyon=txtKartKomisyon.Text;



            Raporlar.RaporSayfasiRaporu(gridListe);
            
        }

        private void lblKullanici_Click(object sender, EventArgs e)
        {

        }
    }
}
