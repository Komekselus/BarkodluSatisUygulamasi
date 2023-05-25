using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BarkodluSatisUygulamasi
{
    internal class Yazdir
    {
        public int? IslemNo { get; set; }
        public Yazdir(int? islemno)
        {
            this.IslemNo = islemno;
        }
        PrintDocument pd = new PrintDocument();
        public void YazdirmayaBasla()
        {
            try
            {
                pd.PrintPage += Pd_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            BarkodDbEntities db = new BarkodDbEntities();
            var isyeri = db.Sabit.FirstOrDefault();
            var liste = db.Satis.Where(x => x.IslemNo == IslemNo).ToList();
            if (isyeri!=null&&liste!=null)
            {
                int kagituzunlugu = 120;
                for (int i = 0; i < liste.Count; i++)
                {
                    kagituzunlugu += 15;
                }
                PaperSize ps58 = new PaperSize("58mm Termal", 220, kagituzunlugu + 120);
                pd.DefaultPageSettings.PaperSize = ps58;

                Font fontbaslik = new Font("Calibri",10,FontStyle.Bold);
                Font fontBilgi = new Font("Calibri", 8, FontStyle.Bold);

                Font fontİcerikBaslik = new Font("Calibri", 8, FontStyle.Underline);
                var yaziRengiSiyah = Brushes.Black;
                StringFormat ortala = new StringFormat(StringFormatFlags.FitBlackBox);
                ortala.Alignment = StringAlignment.Center;
                RectangleF rcUnvanKonum = new RectangleF(0,20,220,20);
                e.Graphics.DrawString(isyeri.Unvan, fontbaslik, yaziRengiSiyah,rcUnvanKonum,ortala);
                e.Graphics.DrawString("Telefon : "+isyeri.Telefon,fontBilgi,yaziRengiSiyah,new Point(5,45));
                e.Graphics.DrawString("İşlem No : " + IslemNo.ToString(), fontBilgi, yaziRengiSiyah, new Point(5, 60));
                e.Graphics.DrawString("Tarih : " + DateTime.Now.ToString(), fontBilgi, yaziRengiSiyah, new Point(5, 75));
                e.Graphics.DrawString("---------------------------------------------------------", fontBilgi, yaziRengiSiyah,new Point(5,90));
                e.Graphics.DrawString("Ürün Adı", fontİcerikBaslik, yaziRengiSiyah, new Point(5, 105));
                e.Graphics.DrawString("Miktar", fontİcerikBaslik, yaziRengiSiyah, new Point(100, 105));
                e.Graphics.DrawString("Fiyat", fontİcerikBaslik, yaziRengiSiyah, new Point(140, 105));
                e.Graphics.DrawString("Tutar", fontİcerikBaslik, yaziRengiSiyah, new Point(180, 105));

                int yukseklik = 120;
                double genelToplam = 0;
                foreach (var item in liste)
                {
                    e.Graphics.DrawString(item.UrunAd, fontBilgi, yaziRengiSiyah,new Point(5,yukseklik));
                    e.Graphics.DrawString(item.Miktar.ToString(),fontBilgi,yaziRengiSiyah,new Point(110,yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.SatisFiyat).ToString("C2"), fontBilgi, yaziRengiSiyah, new Point(140, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.Toplam).ToString("C2"), fontBilgi, yaziRengiSiyah, new Point(180, yukseklik));
                    yukseklik += 15;
                    genelToplam +=(double) item.Toplam;
                }
                e.Graphics.DrawString("---------------------------------------------------------", fontBilgi, yaziRengiSiyah, new Point(5, yukseklik));
                e.Graphics.DrawString("TOPLAM : "+genelToplam.ToString("C2"),fontİcerikBaslik,yaziRengiSiyah,new Point(5,yukseklik+20));
                e.Graphics.DrawString("---------------------------------------------------------", fontBilgi, yaziRengiSiyah, new Point(5, yukseklik+40));
                e.Graphics.DrawString("(Mali Değeri Yoktur)", fontBilgi, yaziRengiSiyah, new Point(5, yukseklik + 60));
                


            }
        }
    }
}
