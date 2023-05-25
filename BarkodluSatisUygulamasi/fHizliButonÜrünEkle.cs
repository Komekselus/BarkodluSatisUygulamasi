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
    public partial class fHizliButonÜrünEkle : Form
    {
        public fHizliButonÜrünEkle()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAra.Text != "")
            {
                // Ürün arama metin kutusu boş değilse devam et

                string urunad = txtUrunAra.Text;
                // Ürün adını metin kutusundan al

                var urunler = db.Urun.Where(a => a.UrunAD.Contains(urunad)).ToList();
                // Veritabanında ürün adı metin kutusundaki değeri içeren ürünleri sorgula

                dataUrunler.DataSource = urunler;
                // Ürünlerin listesini veri kaynağı olarak ayarla

                Islemler.GridDuzenle(dataUrunler);
                // Veri tablosunu düzenleme işleviyle düzenle
            }
        }


        private void dataUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUrunler.Rows.Count > 0)
            {
                // Ürünlerin bulunduğu tablonun satır sayısı 0'dan büyükse devam et

                string barkod = dataUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunad = dataUrunler.CurrentRow.Cells["UrunAD"].Value.ToString();
                double fiyat = Convert.ToDouble(dataUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                // Seçilen hücrelerden barkod, ürün adı ve fiyat bilgilerini al

                int id = Convert.ToInt16(lblButonId.Text);
                // Buton ID'sini al

                var guncellenecek = db.HizliUrun.Find(id);
                // Veritabanında güncellenecek butonu bul

                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunad;
                guncellenecek.Fiyat = fiyat;
                // Butonun barkod, ürün adı ve fiyat bilgilerini güncelle

                db.SaveChanges();
                // Değişiklikleri veritabanına kaydet

                MessageBox.Show("Buton Tanımlanmıştır");
                // Kullanıcıya bir bilgi mesajı göster

                fSatis f = (fSatis)Application.OpenForms["fsatis"];
                if (f != null)
                {
                    // Satış formu açıksa devam et

                    Button b = f.Controls.Find("bhizli" + id, true).FirstOrDefault() as Button;
                    // Güncellenen butonu formda bul

                    b.Text = urunad + "\n" + fiyat.ToString("C2");
                    // Butonun metin içeriğini güncelle
                }
            }
        }

        private void HizliButonÜrünEkle_Load(object sender, EventArgs e)
        {

        }
        private void chTumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chTumu.Checked)
            {
                // "Tümü" onay kutusu işaretlendiğinde devam et

                dataUrunler.DataSource = db.Urun.ToList();
                // Ürünlerin tamamını veritabanından al ve veri kaynağı olarak ata

                dataUrunler.Columns["AlisFiyat"].Visible = false;
                dataUrunler.Columns["SatisFiyat"].Visible = false;
                dataUrunler.Columns["KdvOrani"].Visible = false;
                dataUrunler.Columns["KdvTutari"].Visible = false;
                dataUrunler.Columns["Miktar"].Visible = false;
                // Görüntülenen tablodaki belirli sütunları gizle

                Islemler.GridDuzenle(dataUrunler);
                // Tabloyu düzenle (sütun başlıkları, hücre stilleri vb.)

            }
            else
            {
                // "Tümü" onay kutusu işaretlenmemişse devam et

                dataUrunler.DataSource = null;
                // Veri kaynağını temizle (tabloyu boşalt)
            }
        }


        private void dataUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
