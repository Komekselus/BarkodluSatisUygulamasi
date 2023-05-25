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
    public partial class fGiris : Form
    {
        public fGiris()
        {
            InitializeComponent();
        }

        private void txtStandart1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();

            GirisYap();
            Islemler.cursorBitir();


        }
        private void GirisYap()
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                // Kullanıcı adı ve şifre alanları dolu ise devam et

                try
                {
                    // Hata yakalama bloğu başlat

                    using (var db = new BarkodDbEntities())
                    {
                        // Veritabanı bağlantısını oluştur

                        if (db.Kullanici.Any())
                        {
                            // En az bir kullanıcı varsa devam et

                            var bak = db.Kullanici.Where(x => x.KullaniciAd == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
                            // Kullanıcı adı ve şifreye göre kullanıcıyı veritabanından sorgula

                            if (bak != null)
                            {
                                // Kullanıcı bulunduysa devam et

                                fBaslangic f = new fBaslangic();
                                // Başlangıç formundan bir örnek oluştur

                                f.btnSatisIslemi.Enabled = (bool)bak.Satis;
                                f.btnGenelRapor.Enabled = (bool)bak.Rapor;
                                f.btnStok.Enabled = (bool)bak.Stok;
                                f.btnUrunGiris.Enabled = (bool)bak.UrunGiris;
                                f.btnAyarlar.Enabled = (bool)bak.Ayarlar;
                                f.btnFiyatGuncelle.Enabled = (bool)bak.FiyatGuncelle;
                                f.btnYedekleme.Enabled = (bool)bak.Yedekleme;
                                // Başlangıç formundaki düğmelerin etkinlik durumunu kullanıcının yetkilerine göre ayarla

                                f.lblKullanici.Text = bak.AdSoyad;
                                // Başlangıç formundaki kullanıcı adı etiketini kullanıcının adı soyadı ile güncelle

                                var isyeri = db.Sabit.FirstOrDefault();
                                f.lblIsyeri.Text = isyeri.Unvan.ToString();
                                // Başlangıç formundaki iş yeri etiketini veritabanından alınan iş yeri unvanı ile güncelle

                                f.Show();
                                // Başlangıç formunu göster

                                this.Hide();
                                // Giriş formunu gizle
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş");
                                // Kullanıcı bulunamazsa hata mesajı göster
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    // Hata durumunda hata mesajı göster
                }
            }
        }
        private void fGiris_KeyDown(object sender, KeyEventArgs e)
        {
            Islemler.cursorBaslat();

            if (e.KeyCode==Keys.Enter)
            {
                GirisYap();
            }
            Islemler.cursorBitir();
        }
    }
}
