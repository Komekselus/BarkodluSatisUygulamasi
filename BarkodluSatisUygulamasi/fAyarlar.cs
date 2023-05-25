using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BarkodluSatisUygulamasi
{
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text == "Kaydet")
            {
                // Gerekli alanların dolu olup olmadığını kontrol et
                if (txtAdSoyad.Text != "" && txtTelefon.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "")
                {
                    // Şifrelerin eşleştiğini kontrol et
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        using (var db = new BarkodDbEntities())
                        {
                            // Kullanıcı adının veritabanında zaten mevcut olmadığını kontrol et
                            if (!db.Kullanici.Any(x => x.KullaniciAd == txtKullaniciAdi.Text))
                            {
                                // Yeni bir Kullanici nesnesi oluştur
                                Kullanici k = new Kullanici
                                {
                                    AdSoyad = txtAdSoyad.Text,
                                    Telefon = txtTelefon.Text,
                                    Eposta = txtEposta.Text,
                                    KullaniciAd = txtKullaniciAdi.Text.Trim(),
                                    Sifre = txtSifre.Text,
                                    Satis = chSatisEkrani.Checked,
                                    Rapor = chRapor.Checked,
                                    Stok = chStok.Checked,
                                    UrunGiris = chUrunGiris.Checked,
                                    Ayarlar = chAyarlar.Checked,
                                    FiyatGuncelle = chFiyatGuncelle.Checked,
                                    Yedekleme = chYedekleme.Checked
                                };

                                // Kullanici nesnesini veritabanına ekle ve kaydet
                                db.Kullanici.Add(k);
                                db.SaveChanges();

                                Doldur();
                                temizle();
                            }
                            else
                            {
                                MessageBox.Show("Bu kullanıcı zaten kayıtlı");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("E Posta hariç her alan zorunlu doldurulmalıdır.");
                }
            }
            else if (btnKaydet.Text == "Güncelle")
            {
                // Gerekli alanların dolu olup olmadığını kontrol et
                if (txtAdSoyad.Text != "" && txtTelefon.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "")
                {
                    // Şifrelerin eşleştiğini kontrol et
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(lblKullaniciId.Text);
                        using (var db = new BarkodDbEntities())
                        {
                            // Güncellenecek kullanıcıyı veritabanından bul
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();

                            // Kullanıcı bilgilerini güncelle
                            guncelle.AdSoyad = txtAdSoyad.Text;
                            guncelle.Telefon = txtTelefon.Text;
                            guncelle.Eposta = txtEposta.Text;
                            guncelle.KullaniciAd = txtKullaniciAdi.Text;
                            guncelle.Sifre = txtSifre.Text;
                            guncelle.Satis = chSatisEkrani.Checked;
                            guncelle.Rapor = chRapor.Checked;
                            guncelle.Stok = chStok.Checked;
                            guncelle.UrunGiris = chUrunGiris.Checked;
                            guncelle.Ayarlar = chAyarlar.Checked;
                            guncelle.FiyatGuncelle = chFiyatGuncelle.Checked;
                            guncelle.Yedekleme = chYedekleme.Checked;

                            db.SaveChanges();

                            MessageBox.Show("Başarıyla Güncellenmiştir");
                            btnKaydet.Text = "Kaydet";
                            Doldur();
                            temizle();
                        }
                    }
                }
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void temizle()
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtSifreTekrar.Clear();
            chSatisEkrani.Checked = false;
            chRapor.Checked = false;
            chStok.Checked = false;
            chUrunGiris.Checked = false;
            chAyarlar.Checked = false;
            chFiyatGuncelle.Checked = false;
            chYedekleme.Checked = false;
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Grid üzerinde satır var mı kontrol et
            if (gridListeKullanici.Rows.Count > 0)
            {
                // Seçili satırın Id değerini al
                int id = Convert.ToInt32(gridListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lblKullaniciId.Text = id.ToString();

                using (var db = new BarkodDbEntities())
                {
                    // Id'ye göre kullanıcıyı veritabanından getir
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();

                    // Kullanıcı bilgilerini ilgili alanlara yerleştir
                    txtAdSoyad.Text = getir.AdSoyad;
                    txtTelefon.Text = getir.Telefon;
                    txtEposta.Text = getir.Eposta;
                    txtKullaniciAdi.Text = getir.KullaniciAd;
                    txtSifre.Text = getir.Sifre;
                    txtSifreTekrar.Text = getir.Sifre;
                    chSatisEkrani.Checked = (bool)getir.Satis;
                    chRapor.Checked = (bool)getir.Rapor;
                    chStok.Checked = (bool)getir.Stok;
                    chUrunGiris.Checked = (bool)getir.UrunGiris;
                    chAyarlar.Checked = (bool)getir.Ayarlar;
                    chFiyatGuncelle.Checked = (bool)getir.FiyatGuncelle;
                    chYedekleme.Checked = (bool)getir.Yedekleme;
                    btnKaydet.Text = "Güncelle";

                    Doldur();
                }
            }
        }


        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();
            Doldur();
            
            Islemler.cursorBitir();
        }
        private void Doldur()
        {
            using (var db = new BarkodDbEntities())
            {
                // Kullanıcıları veritabanından al ve grid üzerinde listele
                if (db.Kullanici.Any())
                {
                    gridListeKullanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();
                }

                Islemler.SabitVarsayilan();

                // Yazıcı durumunu kontrol et ve görsel metni güncelle
                var yazici = db.Sabit.FirstOrDefault();
                chYazmaDurumu.Checked = (bool)yazici.Yazici;
                if (chYazmaDurumu.Checked)
                {
                    chYazmaDurumu.Text = "Yazma Durumu AKTİF";
                }
                else
                {
                    chYazmaDurumu.Text = "Yazma Durumu PASİF";
                }

                // Sabit verileri al ve ilgili alanlara yerleştir
                var sabitler = db.Sabit.FirstOrDefault();
                txtKartKomisyon.Text = sabitler.KartKomisyon.ToString();

                // Terazi öneklerini al ve combobox üzerinde listele
                var teraziOnEk = db.Terazi.ToList();
                cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                cmbTeraziOnEk.ValueMember = "Id";
                cmbTeraziOnEk.DataSource = teraziOnEk;

                // İş yeri bilgilerini al ve ilgili alanlara yerleştir
                txtIsYeriAdSoyad.Text = sabitler.AdSoyad;
                txtIsYeriUnvan.Text = sabitler.Unvan;
                txtIsYeriAdres.Text = sabitler.Adres;
                txtIsYeriTelefon.Text = sabitler.Telefon;
                txtIsYeriEposta.Text = sabitler.Eposta;
            }
        }



        private void chYazmaDurumu_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new BarkodDbEntities())
            {
                // Yazma durumu değiştiğinde veritabanındaki değeri güncelle ve görsel metni güncelle
                if (chYazmaDurumu.Checked)
                {
                    Islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = true;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu AKTİF";
                }
                else
                {
                    Islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = false;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu PASİF";
                }
            }
        }

        private void txtKartKomisyon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKartKomisyonAyarla_Click(object sender, EventArgs e)
        {
            // Kart komisyonu ayarlamak için butona tıklandığında gerçekleşecek işlemler

            if (txtKartKomisyon.Text != "")
            {
                // Kart komisyon bilgisi girilmişse devam et

                using (var db = new BarkodDbEntities())
                {
                    // Veritabanı bağlantısını oluştur

                    var sabit = db.Sabit.FirstOrDefault();
                    // Sabit tablosundan ilk kaydı al

                    sabit.KartKomisyon = Convert.ToInt16(txtKartKomisyon.Text);
                    // Kullanıcının girdiği kart komisyon değerini sabit tablosundaki ilgili alana kaydet

                    db.SaveChanges();
                    // Değişiklikleri veritabanına kaydet

                    MessageBox.Show("Kart komisyon ayarlandı");
                    // Kullanıcıya kart komisyonunun ayarlandığına dair bilgi mesajı göster

                }
            }
            else
            {
                MessageBox.Show("Kart komisyon bilgisi giriniz");
                // Kullanıcıya kart komisyon bilgisinin girilmesi gerektiğine dair hata mesajı göster
            }
        }

        private void btnTeraziOnEkKaydet_Click(object sender, EventArgs e)
        {
            // Terazi ön ekini kaydetmek için butona tıklandığında gerçekleşecek işlemler

            if (txtTeraziOnEk.Text != "")
            {
                // Terazi ön ek bilgisi girilmişse devam et

                int onek = Convert.ToInt16(txtTeraziOnEk.Text);
                // Kullanıcının girdiği terazi ön ek değerini integer'a dönüştür

                using (var db = new BarkodDbEntities())
                {
                    // Veritabanı bağlantısını oluştur

                    if (!db.Terazi.Any(x => x.TeraziOnEk == onek))
                    {
                        // Terazi tablosunda, girilen ön ek değeri ile eşleşen bir kayıt olup olmadığını kontrol et

                        Terazi t = new Terazi();
                        t.TeraziOnEk = onek;
                        // Yeni bir Terazi nesnesi oluştur ve ön ek değerini ata

                        db.Terazi.Add(t);
                        // Terazi nesnesini veritabanına ekle

                        db.SaveChanges();
                        // Değişiklikleri veritabanına kaydet

                        MessageBox.Show("Bilgiler Kaydedilmiştir");
                        // Kullanıcıya bilgilerin kaydedildiğine dair bilgi mesajı göster

                        cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazi.ToList();
                        // Terazi ön eklerini göstermek için ComboBox'ı güncelle

                        txtTeraziOnEk.Clear();
                        // Terazi ön ek giriş kutusunu temizle
                    }
                    else
                    {
                        MessageBox.Show(onek.ToString() + " önek zaten kayıtlı");
                        // Girilen ön ek değeri zaten kayıtlı ise kullanıcıya hata mesajı göster
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi önek bilgisini giriniz");
                // Terazi ön ek bilgisinin girilmesi gerektiğine dair hata mesajı göster
            }
        }

        private void btnTeraziOnEkSil_Click(object sender, EventArgs e)
        {
            // Terazi ön ekini silmek için butona tıklandığında gerçekleşecek işlemler

            if (cmbTeraziOnEk.Text != "")
            {
                // ComboBox'ta bir terazi ön ek seçilmişse devam et

                int onekid = Convert.ToInt16(cmbTeraziOnEk.SelectedValue);
                // Seçilen terazi ön ek kaydının Id değerini integer olarak al

                DialogResult onay = MessageBox.Show(cmbTeraziOnEk.Text + " öneki silmek istiyor musunuz?", "Terazi Önek Silme İşlemi", MessageBoxButtons.YesNo);
                // Kullanıcıya silme işlemi hakkında onay isteği göster

                if (onay == DialogResult.Yes)
                {
                    // Kullanıcı onay verdiyse silme işlemine devam et

                    using (var db = new BarkodDbEntities())
                    {
                        // Veritabanı bağlantısını oluştur

                        var onek = db.Terazi.Find(onekid);
                        // Silinecek terazi ön ek kaydını veritabanından bul

                        db.Terazi.Remove(onek);
                        // Terazi ön ek kaydını veritabanından sil

                        db.SaveChanges();
                        // Değişiklikleri veritabanına kaydet

                        cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazi.ToList();
                        // Terazi ön eklerini göstermek için ComboBox'ı güncelle

                        MessageBox.Show("Önek başarıyla silinmiştir");
                        // Kullanıcıya başarılı bir şekilde silindiğine dair bilgi mesajı göster
                    }
                }
            }
            else
            {
                MessageBox.Show("Önek seçiniz");
                // Bir terazi ön ek seçilmediğinde hata mesajı göster
            }
        }

        private void btnIsYeriKaydet_Click(object sender, EventArgs e)
        {
            // İş yeri bilgilerini kaydetmek için butona tıklandığında gerçekleşecek işlemler

            if (txtIsYeriAdSoyad.Text != "" && txtIsYeriUnvan.Text != "" && txtIsYeriAdres.Text != "" && txtIsYeriTelefon.Text != "")
            {
                // İş yeri adı, unvanı, adresi ve telefonu boş değilse devam et

                using (var db = new BarkodDbEntities())
                {
                    // Veritabanı bağlantısını oluştur

                    var isyeri = db.Sabit.FirstOrDefault();
                    // İş yeri bilgilerini tutan kaydı veritabanından al

                    isyeri.AdSoyad = txtIsYeriAdSoyad.Text;
                    isyeri.Unvan = txtIsYeriUnvan.Text;
                    isyeri.Adres = txtIsYeriAdres.Text;
                    isyeri.Telefon = txtIsYeriTelefon.Text;
                    isyeri.Eposta = txtIsYeriEposta.Text;
                    // Kullanıcının girdiği iş yeri bilgileriyle kaydı güncelle

                    db.SaveChanges();
                    // Değişiklikleri veritabanına kaydet

                    MessageBox.Show("İş yeri bilgileri başarıyla kaydedilmiştir");

                    var isyeri2 = db.Sabit.FirstOrDefault();
                    // Güncellenmiş iş yeri bilgilerini veritabanından al

                    txtIsYeriAdSoyad.Text = isyeri2.AdSoyad;
                    txtIsYeriUnvan.Text = isyeri2.Unvan;
                    txtIsYeriAdres.Text = isyeri2.Adres;
                    txtIsYeriTelefon.Text = isyeri2.Telefon;
                    txtIsYeriEposta.Text = isyeri2.Eposta;
                    // Güncellenmiş iş yeri bilgilerini kullanıcı arayüzüne yansıt
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

        }

        private void btnYedekYukle_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\ProgramRestore.exe");
            Application.Exit();
        }
    }
}




