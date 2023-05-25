using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisUygulamasi
{
    public partial class fGelirGider : Form
    {
        public fGelirGider()
        {
            InitializeComponent();
        }
        public string gelirgider { get; set; }

        public string kullanici { get; set; }

        private void fGelirGider_Load(object sender, EventArgs e)
        {
            lblGelirGider.Text = gelirgider+" İŞLEMİ YAPILIYOR";
        }

        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.SelectedIndex == 0)
            {
                txtNakit.Enabled = true;
                txtKart.Enabled = false;

            }
            else if (cmbOdemeTuru.SelectedIndex == 1)
            {
                txtNakit.Enabled = false;
                txtKart.Enabled = true;
            }
            else if (cmbOdemeTuru.SelectedIndex == 2)
            {
                txtNakit.Enabled = true;
                txtKart.Enabled = true;
            }

            txtNakit.Text = "0";
            txtKart.Text = "0";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.Text != "")
            {
                // Ödeme türü seçildiyse devam et

                if (txtNakit.Text != "" && txtKart.Text != "")
                {
                    // Nakit ve kart alanları dolu ise devam et

                    using (var db = new BarkodDbEntities())
                    {
                        // Veritabanı bağlantısını oluştur

                        IslemOzet io = new IslemOzet();
                        // Yeni bir IslemOzet nesnesi oluştur

                        io.IslemNo = 0;
                        io.Iade = false;
                        io.OdemeSekli = cmbOdemeTuru.Text;
                        io.Nakit = Islemler.doubleYap(txtNakit.Text);
                        io.Kart = Islemler.doubleYap(txtKart.Text);
                        // İşlem özetinin ödeme türü, nakit ve kart değerlerini kullanıcı tarafından girilen değerlerle güncelle

                        if (gelirgider == "GELİR")
                        {
                            io.Gelir = true;
                            io.Gider = false;
                        }
                        else
                        {
                            io.Gelir = false;
                            io.Gider = true;
                        }
                        // İşlem özetinin gelir ve gider değerlerini kullanıcı tarafından seçilen gelirgider değerine göre güncelle

                        io.AlisFiyatToplam = 0;
                        io.Aciklama = gelirgider + " - İşlemi " + txtAciklama.Text;
                        io.Tarih = dateTarih.Value;
                        io.Kullanici = kullanici;
                        // İşlem özetinin diğer değerlerini belirle

                        db.IslemOzet.Add(io);
                        // İşlem özetini veritabanına ekle

                        db.SaveChanges();
                        // Değişiklikleri veritabanına kaydet

                        MessageBox.Show(gelirgider + " işlemi kaydedildi");
                        // İşlem kaydedildi mesajını kullanıcıya göster

                        txtNakit.Text = "0";
                        txtKart.Text = "0";
                        txtAciklama.Clear();
                        cmbOdemeTuru.Text = "";
                        // Alanları temizle

                        fRapor f = (fRapor)Application.OpenForms["fRapor"];
                        if (f != null)
                        {
                            f.btnGoster_Click(null, null);
                        }
                        // Rapor formunu kontrol et ve yenile

                        this.Hide();
                        // Bu formu gizle
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödeme türünü seçiniz");
                // Ödeme türü seçilmediyse hata mesajı göster
            }
        }
    }
}
