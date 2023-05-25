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
    public partial class fDetayGoster : Form
    {
        public fDetayGoster()
        {
            InitializeComponent();
        }
        public int islemno { get; set; }
        private void fDetayGoster_Load(object sender, EventArgs e)
        {
            lblIslemNo.Text = "İşlem No : " + islemno.ToString();
            // İşlem numarasını etikete yazdır

            using (var db = new BarkodDbEntities())
            {
                // Veritabanı bağlantısını oluştur

                gridListe.DataSource = db.Satis.Select(x => new { x.IslemNo, x.UrunAd, x.UrunGrup, x.Miktar, x.Toplam })
                    .Where(x => x.IslemNo == islemno).ToList();
                // Satis tablosundan ilgili işlem numarasına sahip satış kayıtlarını seç ve veri kaynağı olarak kullan

                // Grid üzerinde görüntülenecek sütunları belirle

                Islemler.GridDuzenle(gridListe);
                // Grid'i düzenlemek için Yardımcı Sınıf'taki GridDuzenle metodu kullanılır.
                // Bu metod, grid üzerindeki görüntüyü düzenlemek ve özelleştirmek için gerekli işlemleri gerçekleştirir.
            }
        }


        private void lblIslemNo_Click(object sender, EventArgs e)
        {

        }
    }
}
