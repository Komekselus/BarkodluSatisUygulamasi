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
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }
        BarkodDbEntities dbx = new BarkodDbEntities();
        private void fStok_Load(object sender, EventArgs e)
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = dbx.UrunGrup.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridListe.DataSource = null;
            using (var db = new BarkodDbEntities())
            {
                if (cmbİslemTuru.Text != "")
                {
                    string urungrubu = cmbUrunGrubu.Text;
                    if (cmbİslemTuru.SelectedIndex == 0)
                    {
                        if (rdTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen filtreleme türünü seçiniz");
                        }
                    }
                    else if (cmbİslemTuru.SelectedIndex==1)
                    {
                        DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (rdTumu.Checked)
                        {
                            db.StokHareket.OrderByDescending(x=>x.Tarih).Where(x=> x.Tarih>=baslangic&&x.Tarih<=bitis).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();


                        }
                        else
                        {
                            MessageBox.Show("Lütfen filtreleme türünü seçiniz");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Lütfen işlem türünü seçiniz");
                }

            }
            Islemler.GridDuzenle(gridListe);
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAra.Text.Length>=2)
            {
                string urunad = txtUrunAra.Text;
                using (var db=new BarkodDbEntities())
                {
                    if (cmbİslemTuru.SelectedIndex==0)
                    {
                        db.Urun.Where(x => x.UrunAD.Contains(urunad)).Load();
                        gridListe.DataSource = db.Urun.Local.ToBindingList();

                    }
                    else if (cmbİslemTuru.SelectedIndex==1)
                    {
                        db.StokHareket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                    }
                }
                Islemler.GridDuzenle(gridListe);


            }
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            if (cmbİslemTuru.SelectedIndex==0)
            {
                Raporlar.Baslik = cmbİslemTuru.Text + " Raporu";
                Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
                Raporlar.StokRaporu(gridListe);
            }
            else if (cmbİslemTuru.SelectedIndex==1)
            {
                Raporlar.Baslik = cmbİslemTuru.Text + " Raporu";
                Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
                Raporlar.StokIzlemeRaporu(gridListe);
            }
            
        }
    }
}
