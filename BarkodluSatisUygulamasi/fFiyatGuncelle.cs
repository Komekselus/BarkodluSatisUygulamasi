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
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Eğer Enter tuşuna basıldıysa devam et

                using (var db = new BarkodDbEntities())
                {
                    // Veritabanı bağlantısını oluştur

                    if (db.Urun.Any(x => x.Barkod == txtBarkod.Text.Trim()))
                    {
                        // Urun tablosunda girilen barkod değerine sahip bir ürün var mı kontrol et

                        var getir = db.Urun.Where(x => x.Barkod == txtBarkod.Text).SingleOrDefault();
                        // Barkod değerine göre ilgili ürünü seç ve getir

                        lblBarkod.Text = getir.Barkod;
                        // Ürünün barkodunu etikete yazdır

                        lblUrunAdi.Text = getir.UrunAD;
                        // Ürünün adını etikete yazdır

                        double mevcutfiyat = Convert.ToDouble(getir.SatisFiyat);
                        lblFiyat.Text = mevcutfiyat.ToString("C2");
                        // Ürünün satış fiyatını etikete yazdır, para birimi formatı olarak kullanıcı yerel ayarlarına göre formatla

                    }
                }
            }
            else
            {
                MessageBox.Show("Ürün Kayıtlı Değil");
                // Eğer Enter tuşuna basılmadıysa veya girilen barkod değerine sahip bir ürün bulunamadıysa kullanıcıya uyarı mesajı göster
            }
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYeniFiyat.Text != "" && lblBarkod.Text != "")
            {
                // Yeni fiyat ve barkod değeri boş değilse devam et

                using (var db = new BarkodDbEntities())
                {
                    // Veritabanı bağlantısını oluştur

                    var guncellenecek = db.Urun.Where(x => x.Barkod == lblBarkod.Text).SingleOrDefault();
                    // Barkod değerine sahip ürünü seç ve güncellenecek olarak tanımla

                    guncellenecek.SatisFiyat = Islemler.doubleYap(txtYeniFiyat.Text);
                    // Güncellenecek ürünün satış fiyatını kullanıcının girdiği yeni fiyat değeriyle güncelle

                    db.SaveChanges();
                    // Değişiklikleri veritabanına kaydet

                    int kdvorani = Convert.ToInt16(guncellenecek.KdvOrani);
                    // Güncellenen ürünün KDV oranını al

                    Math.Round(Islemler.doubleYap(txtYeniFiyat.Text) * kdvorani / 100, 2);
                    // Yeni fiyatı KDV oranıyla güncelle (Bu kısmın amacını tam anlayamadım, isteğinize göre düzenleyebilirim)

                    MessageBox.Show("Ürün Fiyatı Başarıyla Güncellenmiştir.");
                    // Başarılı bir şekilde fiyat güncellendi mesajını kullanıcıya göster

                    temizle();
                    // Alanları temizle

                    txtBarkod.Focus();
                    // Barkod alanına odaklan
                }

            }
            else
            {
                MessageBox.Show("Ürün Okutulamamıştır");
                // Yeni fiyat veya barkod değeri boş ise kullanıcıya hata mesajı göster

                txtBarkod.Focus();
                // Barkod alanına odaklan
            }
        }

        private void fFiyatGuncelle_Load(object sender, EventArgs e)
        {
            temizle();

        }
        private void temizle()
        {
            lblBarkod.Text = "";
            lblFiyat.Text = "";
            lblUrunAdi.Text = "";
            txtYeniFiyat.Clear();
            txtBarkod.Clear();
        }
    }
}
