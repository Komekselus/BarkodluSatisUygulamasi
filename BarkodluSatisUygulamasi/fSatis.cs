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
    public partial class fSatis : Form
    {
        BarkodDbEntities db = new BarkodDbEntities(); // Veritabanı bağlantısı için BarkodDbEntities nesnesi oluşturulur

        public fSatis()
        {
            InitializeComponent(); // Formun bileşenlerini başlatır
        }

        private void fSatis_Load(object sender, EventArgs e)
        {
            hizliButonDoldur(); // Hızlı butonlara kayıtlı değerleri atama işlevini çağırır
            paraBirimleriCevir(); // Hesap makinesinin solundaki para birimlerini dönüştürme işlevini çağırır
            using (var db = new BarkodDbEntities())
            {
                var sabit = db.Sabit.FirstOrDefault();
                chYazdirmaDurumu.Checked = (bool)sabit.Yazici; // Yazıcı durumunu kontrol ederek chYazdirmaDurumu kontrolünün seçili durumunu ayarlar
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { } // TableLayoutPanel nesnesinin Paint olayı işleyicisi

        private void label4_Click(object sender, EventArgs e) { } // Label nesnesinin Click olayı işleyicisi

        private void label5_Click(object sender, EventArgs e) { } // Label nesnesinin Click olayı işleyicisi

        private void button23_Click(object sender, EventArgs e) { } // Button nesnesinin Click olayı işleyicisi

        private void txtMiktar_TextChanged(object sender, EventArgs e) { } // TextBox nesnesinin TextChanged olayı işleyicisi

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e) { } // TableLayoutPanel nesnesinin Paint olayı işleyicisi

        private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e) { } // TableLayoutPanel nesnesinin Paint olayı işleyicisi

        private void txtParaUstu_TextChanged(object sender, EventArgs e) { } // TextBox nesnesinin TextChanged olayı işleyicisi

        private void paraBirimleriCevir()
        {
            b5.Text = 5.ToString("C2"); // 5 TL'ye formatlama ve b5 Button nesnesinin metin özelliğine atama
            b10.Text = 10.ToString("C2"); // 10 TL'ye formatlama ve b10 Button nesnesinin metin özelliğine atama
            b20.Text = 20.ToString("C2"); // 20 TL'ye formatlama ve b20 Button nesnesinin metin özelliğine atama
            b50.Text = 50.ToString("C2"); // 50 TL'ye formatlama ve b50 Button nesnesinin metin özelliğine atama
            b100.Text = 100.ToString("C2"); // 100 TL'ye formatlama ve b100 Button nesnesinin metin özelliğine atama
            b200.Text = 200.ToString("C2"); // 200 TL'ye formatlama ve b200 Button nesnesinin metin özelliğine atama
        }

        public void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender; // Buton nesnesi alınır

            if (b.Text == ",")
            {
                int virgul = txtHesap.Text.Count(x => x == ','); // txtHesap TextBox'ındaki virgül sayısı hesaplanır

                if (virgul < 1)
                {
                    txtHesap.Text += b.Text; // Hesap makinesine virgül eklenir
                }
            }
            else if (b.Text == "<")
            {
                if (txtHesap.Text.Length > 0)
                {
                    txtHesap.Text = txtHesap.Text.Substring(0, txtHesap.Text.Length - 1); // Hesap makinesinden son karakter silinir
                }
            }
            else
            {
                txtHesap.Text += b.Text; // Hesap makinesine butonun metin özelliği eklenir
            }
        }// Elle giriş kısmı

        private void hizliButonDoldur()
        {
            var hizliurun = db.HizliUrun.ToList(); // Hızlı ürünleri veritabanından alır ve bir liste olarak alır

            foreach (var item in hizliurun)
            {
                Button bhizli = this.Controls.Find("bHizli" + item.Id, true).FirstOrDefault() as Button; // Butonun adını bulur

                if (bhizli != null)
                {
                    double fiyat = Islemler.doubleYap(item.Fiyat.ToString()); // Ürün fiyatını çift hassasiyetli ondalık sayıya dönüştürür

                    bhizli.Text = item.UrunAd + "\n" + fiyat.ToString("C2"); // Butonun metin özelliğini ürün adı ve fiyatıyla günceller
                }
            }
        }

        private void hizliButonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender; // Tıklanan buton nesnesi alınır
            int butonid = Convert.ToInt16(b.Name.ToString().Substring(6, b.Name.Length - 6)); // Butonun isminden id değeri çıkarılır

            if (b.Text.ToString().StartsWith("-"))
            {
                fHizliButonÜrünEkle f = new fHizliButonÜrünEkle();
                f.lblButonId.Text = butonid.ToString(); // Hızlı butonun id'si formda görünen etiketin metin özelliğine atanır
                f.ShowDialog(); // Ürün ekleme formu açılır
            }
            else
            {
                var urunbarkod = db.HizliUrun.Where(a => a.Id == butonid).Select(a => a.Barkod).FirstOrDefault(); // Buton id'sine göre ürünün barkod bilgisi alınır
                var urun = db.Urun.Where(a => a.Barkod == urunbarkod).FirstOrDefault(); // Ürün veritabanından alınır
                UrunGetirListeye(urun, urunbarkod, Convert.ToDouble(txtMiktar.Text)); // Ürünü satış listesine ekler
                GenelToplam(); // Genel toplamı günceller
            }
        }// Hızlı butonların tıklanma ayarları

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Kodlar1(); // Barkod alanında Enter tuşuna basılınca çalışacak olan kodlar
        }

        private void txtMiktar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Kodlar1(); // Miktar alanında Enter tuşuna basılınca çalışacak olan kodlar
        }

        private void UrunGetirListeye(Urun urun, string barkod, double miktar)
        {
            int satirsayisi = dataVeri.Rows.Count; // Satır sayısını alır

            bool eklenmismi = false; // Ürünün daha önce eklenip eklenmediğini belirlemek için bir bayrak kullanılır

            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++)
                {
                    if (dataVeri.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        // Eğer aynı barkoda sahip ürün daha önce eklenmişse miktarı güncellenir
                        dataVeri.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(dataVeri.Rows[i].Cells["Miktar"].Value);

                        // Yeni toplam değeri hesaplanır
                        dataVeri.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(dataVeri.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(dataVeri.Rows[i].Cells["Fiyat"].Value), 2);

                        double dblKdvTutari = (double)urun.KdvTutari; // KDV tutarı alınır

                        eklenmismi = true; // Ürünün zaten eklenmiş olduğu işaretlenir
                    }
                }
            }

            if (!eklenmismi)
            {
                // Ürün daha önce eklenmemişse yeni bir satır oluşturulur ve veriler eklenir
                dataVeri.Rows.Add();
                dataVeri.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                dataVeri.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.UrunAD;
                dataVeri.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                dataVeri.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;
                dataVeri.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                dataVeri.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                dataVeri.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round((miktar * (double)urun.SatisFiyat), 2);
                dataVeri.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                dataVeri.Rows[satirsayisi].Cells["KdvTutari"].Value = urun.KdvTutari;
            }
        }

        private void Kodlar1()
        {
            // Kullanıcı tarafından girilen barkod değeri alınır ve gereken işlemler yapılır.
            string barkod = txtBarkod.Text.Trim();

            if (barkod.Length <= 2)
            {
                // Barkod 2 karakterden kısa ise, miktar olarak kabul edilir
                // Miktar alanı bu değerle doldurulur ve barkod alanı temizlenir.
                txtMiktar.Text = barkod;
                txtBarkod.Clear();
                txtBarkod.Focus();
            }
            else
            {
                if (db.Urun.Any(a => a.Barkod == barkod))
                {
                    // Barkod, veritabanında kayıtlı bir ürüne aitse
                    // İlgili ürün bilgileri veritabanından alınır ve UrunGetirListeye metodu çağrılır.
                    var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault();
                    UrunGetirListeye(urun, barkod, Convert.ToDouble(txtMiktar.Text));
                }
                else
                {
                    int onek = Convert.ToInt32(barkod.Substring(0, 2));

                    if (db.Terazi.Any(a => a.TeraziOnEk == onek))
                    {
                        // Barkod, terazi ürününe aitse
                        // Terazi ürününün barkod numarası ve miktar bilgisi alınır.
                        string teraziurunno = barkod.Substring(2, 5);

                        if (db.Urun.Any(a => a.Barkod == teraziurunno))
                        {
                            // Terazi ürününün bilgileri veritabanından alınır ve miktar kg olarak hesaplanır.
                            var urunterazi = db.Urun.Where(a => a.Barkod == teraziurunno).FirstOrDefault();
                            double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                            UrunGetirListeye(urunterazi, teraziurunno, miktarkg);
                        }
                        else
                        {
                            // Terazi ürünü kaydı bulunamadığında kullanıcı uyarılır.
                            Console.Beep(900, 2000);
                            MessageBox.Show("Kg Ürün ekleme sayfası");
                        }
                    }
                    else
                    {
                        // Barkod, yeni bir ürün girişi gerektiriyorsa
                        // Yeni ürün girişi için fUrunGiris formu açılır.
                        fUrunGiris f = new fUrunGiris();
                        f.txtBarkod.Text = barkod;
                        f.ShowDialog();
                    }
                }
            }

            // Veri gridi seçimini temizleme ve genel toplamı güncelleme işlemleri yapılır.
            dataVeri.ClearSelection();
            GenelToplam();
            txtBarkod.Focus();
        }

        private void GenelToplam()
        {
            // Ürünlerin toplam fiyatını hesaplar ve gösterir.

            double toplam = 0;

            for (int i = 0; i < dataVeri.Rows.Count; i++)
            {
                // Her bir satırdaki "Toplam" hücresinin değerini alıp toplama ekler.
                toplam += Convert.ToDouble(dataVeri.Rows[i].Cells["Toplam"].Value);
            }

            // Toplam fiyatı "C2" formatında metin kutusuna yazdırır.
            txtToplam.Text = toplam.ToString("C2");

            // Miktar alanını "1" olarak ayarlar.
            txtMiktar.Text = "1";

            // Barkod alanını temizler ve odaklanır.
            txtBarkod.Clear();
            txtBarkod.Focus();
        }

        private void dataVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                // Hücre içeriği tıklanabilir bir düğme ise (silme düğmesi)
                // Seçili satırı veri tablosundan kaldırır.

                dataVeri.Rows.Remove(dataVeri.CurrentRow);

                // Veri gridindeki seçimi temizler.
                dataVeri.ClearSelection();

                // Genel toplamı günceller.
                GenelToplam();

                // Barkod alanına odaklanır.
                txtBarkod.Focus();
            }
        }

        private void bhizli_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Hızlı butonlardan birine sağ tıklandığında

                Button b = (Button)sender;

                if (!b.Text.StartsWith("-"))
                {
                    // Butonun metni "-" ile başlamıyorsa (ürün atanmışsa)

                    int butonid = Convert.ToInt16(b.Name.ToString().Substring(6, b.Name.Length - 6));

                    // İçerik menüsü oluşturulur
                    ContextMenuStrip s = new ContextMenuStrip();

                    // Silme işlemi için bir menü öğesi eklenir
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No:" + butonid.ToString();
                    sil.Click += Sil_Click;

                    s.Items.Add(sil);

                    // İçerik menüsü formun bağlantılı içerik menüsü olarak ayarlanır.
                    this.ContextMenuStrip = s;
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUrun.Find(butonid);

            // Silinecek hızlı ürünün bilgilerini sıfırlar.
            guncelle.Barkod = "-";
            guncelle.UrunAd = "-";
            guncelle.Fiyat = 0;
            db.SaveChanges();

            double fiyat = 0;

            Button b = this.Controls.Find("bhizli" + butonid, true).FirstOrDefault() as Button;

            // Hızlı butonun metnini günceller.
            b.Text = "-" + "\n" + fiyat.ToString("C2");
        }

        private void bAdet_Click(object sender, EventArgs e)
        {
            if (txtHesap.Text != "")
            {
                // Elle girilen adeti miktar alanına aktarır.
                txtMiktar.Text = txtHesap.Text;
                txtHesap.Clear();
                txtBarkod.Clear();
                txtBarkod.Focus();
            }
        }

        private void bOdenen_Click(object sender, EventArgs e)
        {
            if (txtHesap.Text != "")
            {
                double sonuc = Islemler.doubleYap(txtHesap.Text) - Islemler.doubleYap(txtToplam.Text);

                // Ödenen miktarı ve para üstünü hesaplar.
                txtParaUstu.Text = sonuc.ToString("C2");
                txtOdenen.Text = Islemler.doubleYap(txtHesap.Text).ToString("C2");

                txtHesap.Clear();
                txtBarkod.Focus();
            }
        }

        private void bBarkod_Click(object sender, EventArgs e)
        {
            if (txtHesap.Text != "")
            {
                if (db.Urun.Any(a => a.Barkod == txtHesap.Text))
                {
                    var urun = db.Urun.Where(a => a.Barkod == txtHesap.Text).FirstOrDefault();

                    // Elle girilen barkodu ürün listesine ekler.
                    UrunGetirListeye(urun, txtHesap.Text, Convert.ToDouble(txtMiktar.Text));

                    txtHesap.Clear();
                    txtBarkod.Focus();
                }
                else
                {
                    MessageBox.Show("Ürün eklemeyi aç");
                }
            }
        }

        private void ParaUstuHesapla_Clicl(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double sonuc = Islemler.doubleYap(b.Text) - Islemler.doubleYap(txtToplam.Text);

            // Elle girilen parayı kullanarak ödenen miktarı ve para üstünü hesaplar.
            txtOdenen.Text = Islemler.doubleYap(b.Text).ToString("C2");
            txtParaUstu.Text = sonuc.ToString("C2");
        }

        private void bDigerUrun_Click(object sender, EventArgs e)
        {
            if (txtHesap.Text != "")
            {
                // Eğer txtHesap metin kutusu boş değilse devam et
                int satirsayisi = dataVeri.Rows.Count;
                // dataVeri adlı DataGridView'in satır sayısını al ve satirsayisi değişkenine ata
                dataVeri.Rows.Add();
                // dataVeri DataGridView'ine yeni bir satır ekle
                dataVeri.Rows[satirsayisi].Cells["Barkod"].Value = "111111111116";
                // dataVeri DataGridView'inin satirsayisi indeksine sahip satırın "Barkod" hücresine "111111111116" değerini ata
                dataVeri.Rows[satirsayisi].Cells["UrunAdi"].Value = "Barkodsuz Ürün";
                // dataVeri DataGridView'inin satirsayisi indeksine sahip satırın "UrunAdi" hücresine "Barkodsuz Ürün" değerini ata
                dataVeri.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                // dataVeri DataGridView'inin satirsayisi indeksine sahip satırın "UrunGrup" hücresine "Barkodsuz Ürün" değerini ata
                dataVeri.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                // dataVeri DataGridView'inin satirsayisi indeksine sahip satırın "Birim" hücresine "Adet" değerini ata
                dataVeri.Rows[satirsayisi].Cells["AlisFiyat"].Value = 0;
                // dataVeri DataGridView'inin satirsayisi indeksine sahip satırın "AlisFiyat" hücresine 0 değerini ata
                dataVeri.Rows[satirsayisi].Cells["Miktar"].Value = "1";
                // dataVeri DataGridView'inin satirsayisi indeksine sahip satırın "Miktar" hücresine "1" değerini ata
                dataVeri.Rows[satirsayisi].Cells["Fiyat"].Value = Convert.ToDouble(txtHesap.Text);
                // dataVeri DataGridView'inin satirsayisi indeksine sahip satırın "Fiyat" hücresine txtHesap metin kutusunun değerini double türüne çevirerek ata
                dataVeri.Rows[satirsayisi].Cells["KdvTutari"].Value = "0";
                // dataVeri DataGridView'inin satirsayisi indeksine sahip satırın "KdvTutari" hücresine "0" değerini ata
                dataVeri.Rows[satirsayisi].Cells["Toplam"].Value = Convert.ToDouble(txtHesap.Text);
                // dataVeri DataGridView'inin satirsayisi indeksine sahip satırın "Toplam" hücresine txtHesap metin kutusunun değerini double türüne çevirerek ata
                txtHesap.Text = "";
                // txtHesap metin kutusunun değerini boş bir dizeye ayarla
                GenelToplam();
                // GenelToplam() adlı bir metodu çağır
                txtBarkod.Focus();
                // txtBarkod metin kutusuna odaklan
            }
        }

        private void bIadeIslemi_Click(object sender, EventArgs e)
        {
            if (chSatisIadeIslemi.Checked)
            {
                // chSatisIadeIslemi onay kutusu işaretlenmişse devam et
                chSatisIadeIslemi.Checked = false;
                // chSatisIadeIslemi onay kutusunun işaretini kaldır
                chSatisIadeIslemi.Text = "Satış Yapılıyor";
                // chSatisIadeIslemi onay kutusunun metin değerini "Satış Yapılıyor" olarak ayarla
            }
            else
            {
                // chSatisIadeIslemi onay kutusu işaretlenmemişse devam et
                chSatisIadeIslemi.Checked = true;
                // chSatisIadeIslemi onay kutusunu işaretle
                chSatisIadeIslemi.Text = "İade İşlemi";
                // chSatisIadeIslemi onay kutusunun metin değerini "İade İşlemi" olarak ayarla
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }//temizle tuşu
        private void Temizle()
        {
            txtMiktar.Text = "1";
            txtBarkod.Clear();
            txtOdenen.Clear();
            txtParaUstu.Clear();
            dataVeri.Rows.Clear();
            txtBarkod.Clear();
            txtBarkod.Focus();
            txtToplam.Clear();
            chSatisIadeIslemi.Checked = false;
            txtHesap.Text = "0";
        }//temizle metodu her yeri temizler
        private void bNakit_Click(object sender, EventArgs e)
        {
            SatisYap("Nakit");
        }//nakit satış
        public void SatisYap(string odemesekli)
        {
            int satirsayisi = dataVeri.Rows.Count;
            // dataVeri DataGridView'inin satır sayısını al ve satirsayisi değişkenine ata
            bool satisiade = chSatisIadeIslemi.Checked;
            // chSatisIadeIslemi onay kutusunun durumunu satisiade değişkenine ata
            double alisfiyattoplam = 0;
            if (satirsayisi > 0)
            {
                int? islemno = db.İslem.First().IslemNo;
                // db.İslem.First() ile ilk İslem nesnesini al ve IslemNo özelliğini islemno değişkenine ata
                Satis satis = new Satis();
                // Satis nesnesi oluştur
                for (int i = 0; i < satirsayisi; i++)
                {
                    // satirsayisi kadar döngüye gir
                    satis.IslemNo = islemno;
                    // satis nesnesinin IslemNo özelliğini islemno'ya ata
                    satis.UrunAd = dataVeri.Rows[i].Cells["UrunAdi"].Value.ToString();
                    // satis nesnesinin UrunAd özelliğini dataVeri DataGridView'indeki "UrunAdi" hücresinin değerine ata
                    satis.UrunGrup = dataVeri.Rows[i].Cells["UrunGrup"].Value.ToString();
                    // satis nesnesinin UrunGrup özelliğini dataVeri DataGridView'indeki "UrunGrup" hücresinin değerine ata
                    satis.Barkod = dataVeri.Rows[i].Cells["Barkod"].Value.ToString();
                    // satis nesnesinin Barkod özelliğini dataVeri DataGridView'indeki "Barkod" hücresinin değerine ata
                    satis.Birim = dataVeri.Rows[i].Cells["Birim"].Value.ToString();
                    // satis nesnesinin Birim özelliğini dataVeri DataGridView'indeki "Birim" hücresinin değerine ata
                    satis.AlisFiyat = Islemler.doubleYap(dataVeri.Rows[i].Cells["AlisFiyat"].Value.ToString());
                    // satis nesnesinin AlisFiyat özelliğini dataVeri DataGridView'indeki "AlisFiyat" hücresinin değerini double türüne dönüştürerek ata
                    satis.SatisFiyat = Islemler.doubleYap(dataVeri.Rows[i].Cells["Fiyat"].Value.ToString());
                    // satis nesnesinin SatisFiyat özelliğini dataVeri DataGridView'indeki "Fiyat" hücresinin değerini double türüne dönüştürerek ata
                    satis.Miktar = Islemler.doubleYap(dataVeri.Rows[i].Cells["Miktar"].Value.ToString());
                    // satis nesnesinin Miktar özelliğini dataVeri DataGridView'indeki "Miktar" hücresinin değerini double türüne dönüştürerek ata
                    satis.Toplam = Islemler.doubleYap(dataVeri.Rows[i].Cells["Toplam"].Value.ToString());
                    // satis nesnesinin Toplam özelliğini dataVeri DataGridView'indeki "Toplam" hücresinin değerini double türüne dönüştürerek ata
                    satis.KdvTutari = Islemler.doubleYap(dataVeri.Rows[i].Cells["KdvTutari"].Value.ToString()) * Islemler.doubleYap(dataVeri.Rows[i].Cells["Miktar"].Value.ToString());
                    // satis nesnesinin KdvTutari özelliğini dataVeri DataGridView'indeki "KdvTutari" hücresinin değerini double türüne dönüştürerek Miktar ile çarpıp ata
                    satis.OdemeSekli = odemesekli;
                    // satis nesnesinin OdemeSekli özelliğine odemesekli'yi ata
                    satis.İade = satisiade;
                    // satis nesnesinin İade özelliğine satisiade'yi ata
                    satis.Tarih = DateTime.Now;
                    // satis nesnesinin Tarih özelliğine şu anki tarih ve saati ata
                    satis.Kullanici = lblKullanici.Text;
                    // satis nesnesinin Kullanici özelliğine lblKullanici etiketinin değerini ata
                    db.Satis.Add(satis);
                    // db.Satis koleksiyonuna satis nesnesini ekle
                    db.SaveChanges();
                    // Veritabanındaki değişiklikleri kaydet
                    if (!satisiade)
                        Islemler.stokAzalt(dataVeri.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.doubleYap(dataVeri.Rows[i].Cells["Miktar"].Value.ToString()));
                    // İade işlemi değilse, stokAzalt metodunu kullanarak ürün stoklarını güncelle
                    else
                        Islemler.stokArtir(dataVeri.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.doubleYap(dataVeri.Rows[i].Cells["Miktar"].Value.ToString()));
                    // İade işlemiyse, stokArtir metodunu kullanarak ürün stoklarını güncelle
                    alisfiyattoplam += Islemler.doubleYap(dataVeri.Rows[i].Cells["AlisFiyat"].Value.ToString()) * Islemler.doubleYap(dataVeri.Rows[i].Cells["Miktar"].Value.ToString());
                    // alisfiyattoplam değişkenine satışın alış fiyatı ile miktarını çarparak ekleyin
                }
                IslemOzet io = new IslemOzet();
                // IslemOzet nesnesi oluştur
                io.IslemNo = islemno;
                // io nesnesinin IslemNo özelliğine islemno'yu ata
                io.Iade = satisiade;
                // io nesnesinin Iade özelliğine satisiade'yi ata
                io.AlisFiyatToplam = alisfiyattoplam;
                // io nesnesinin AlisFiyatToplam özelliğine alisfiyattoplam'ı ata
                io.Gelir = false;
                io.Gider = false;
                if (!satisiade)
                    io.Aciklama = odemesekli + "Satış";
                else
                    io.Aciklama = $"İade işlemi ({odemesekli})";
                // İade işlemiyse, Aciklama özelliğine "İade işlemi (odemesekli)" şeklinde bir açıklama ata. İade işlemi değilse, "odemesekli Satış" şeklinde bir açıklama ata.
                io.OdemeSekli = odemesekli;
                // io nesnesinin OdemeSekli özelliğine odemesekli'yi ata
                io.Kullanici = lblKullanici.Text;
                // io nesnesinin Kullanici özelliğine lblKullanici etiketinin değerini ata
                io.Tarih = DateTime.Now;
                // io nesnesinin Tarih özelliğine şu anki tarih ve saati ata

                switch (odemesekli)
                {
                    case "Nakit":
                        io.Nakit = Islemler.doubleYap(txtToplam.Text);
                        io.Kart = 0;
                        break;
                    case "Kart":
                        io.Nakit = 0;
                        io.Kart = Islemler.doubleYap(txtToplam.Text);
                        break;
                    case "Kart-Nakit":
                        io.Nakit = Islemler.doubleYap(lblNakit.Text);
                        io.Kart = Islemler.doubleYap(lblKart.Text);
                        break;
                }
                // OdemeSekli'ne göre Nakit ve Kart özelliklerine değerler ata

                db.IslemOzet.Add(io);
                // db.IslemOzet koleksiyonuna io nesnesini ekle
                db.SaveChanges();
                // Veritabanındaki değişiklikleri kaydet
                var islemnoartir = db.İslem.First();
                islemnoartir.IslemNo++;
                db.SaveChanges();
                // İşlem numarasını artır ve veritabanındaki değişiklikleri kaydet

                if (chYazdirmaDurumu.Checked)
                {
                    Yazdir yazdir = new Yazdir(islemno);
                    yazdir.YazdirmayaBasla();
                    // chYazdirmaDurumu onay kutusu işaretliyse, Yazdir sınıfından bir nesne oluştur ve YazdirmayaBasla metodunu çağır
                }

                Temizle();
                // Temizle metodunu çağır
            }
        }
        //satis yapma
        private void bKart_Click(object sender, EventArgs e)
        {
            SatisYap("Kart");
        }//kart satış
        private void bNakitKart_Click(object sender, EventArgs e)
        {
            fNakit_Kart f = new fNakit_Kart();
            f.ShowDialog();
        }//nakit kart geçiş
        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
                e.Handled = true;
        }
        private void fSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                SatisYap("Nakit");
            if (e.KeyCode == Keys.F2)
                SatisYap("Kart");
            if (e.KeyCode == Keys.F3)
            {
                fNakit_Kart f = new fNakit_Kart();
                f.ShowDialog();
            }
        }//satış yap kısayollar
        private void bislembeklet_Click(object sender, EventArgs e)
        {
            if (bislembeklet.Text == "İşlem Beklet")
            {
                Bekle();
                bislembeklet.BackColor = Color.BlueViolet;
                bislembeklet.Text = "İşlem Beklemede";
                dataVeri.Rows.Clear();
            }
            else
            {
                BeklemedenCik();
                bislembeklet.BackColor = Color.IndianRed;
                bislembeklet.Text = "İşlem Beklet";
                dataVeriBekle.Rows.Clear();
            }
        }//İşlem bekletme tuşu
        private void Bekle()
        {
            int satir = dataVeri.Rows.Count;
            int sutun = dataVeri.Columns.Count;

            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    dataVeriBekle.Rows.Add();

                    // dataVeri tablosundaki her satırı dolaş
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        // dataVeriBekle tablosuna yeni bir satır ekle

                        // dataVeri tablosundaki her hücrenin değerini, aynı sütundaki dataVeriBekle tablosunun ilgili hücresine ata
                        dataVeriBekle.Rows[i].Cells[j].Value = dataVeri.Rows[i].Cells[j].Value;
                    }
                }
            }
        }
        private void BeklemedenCik()
        {
            int satir = dataVeriBekle.Rows.Count;
            int sutun = dataVeriBekle.Columns.Count;

            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    // dataVeri tablosuna yeni bir satır ekle
                    dataVeri.Rows.Add();

                    // dataVeriBekle tablosundaki her satırı dolaş
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        // dataVeri tablosundaki her hücrenin değerini, aynı sütundaki dataVeriBekle tablosunun ilgili hücresine ata
                        dataVeri.Rows[i].Cells[j].Value = dataVeriBekle.Rows[i].Cells[j].Value;
                    }
                }
            }
        }


        private void chSatisIadeIslemi_CheckedChanged(object sender, EventArgs e)
        {
            if (chSatisIadeIslemi.Checked)
            {
                chSatisIadeIslemi.Text = "İade Yapılıyor";
            }
            else
            {
                chSatisIadeIslemi.Text = "Satış Yapılıyor";
            }
        }

        private void chYazdirmaDurumu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
