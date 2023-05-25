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
    public partial class fNakit_Kart : Form
    {
        public fNakit_Kart()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e) { }
        private void txtBarkod_TextChanged(object sender, EventArgs e) { }
        private void fNakit_Kart_Load(object sender, EventArgs e) { }
        private void txtNakit_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNakit.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                    onayla_Click();
            }
        }
        public void bNx_Click(object sender, EventArgs e)
        {
            // Butonun tıklanma olayını temsil eden metot

            // Sender parametresini Button türüne dönüştürerek butonu elde ederiz
            Button b = (Button)sender;

            // Butonun metnini kontrol ederiz
            if (b.Text == ",")
            {
                // Eğer butonun metni ",", yani virgülse:

                // txtNakit.Text içindeki virgül sayısını kontrol ederiz
                int virgul = txtNakit.Text.Count(x => x == ',');

                // Eğer virgül sayısı 1'den az ise (yani zaten bir virgül yoksa), txtNakit.Text üzerine virgülü ekleriz
                if (virgul < 1)
                    txtNakit.Text += b.Text;
            }
            else if (b.Text == "<")
            {
                // Eğer butonun metni "<" ise:

                // txtNakit.Text'in uzunluğunu kontrol ederiz
                if (txtNakit.Text.Length > 0)
                {
                    // Eğer txtNakit.Text boş değilse, son karakteri silmek için txtNakit.Text üzerinde bir işlem yaparız
                    txtNakit.Text = txtNakit.Text.Substring(0, txtNakit.Text.Length - 1);
                }
            }
            else
            {
                // Yukarıdaki koşulların hiçbiri sağlanmıyorsa, yani butonun metni virgül veya "<" değilse:

                // Butonun metnini txtNakit.Text'e ekleriz
                txtNakit.Text += b.Text;
            }
        }//elle giriş kısmı
        private void bNakit_Click(object sender, EventArgs e)
        {
            if (txtNakit.Text != "")
                onayla_Click();
        }
        private void onayla_Click()
        {
            // "Onayla" butonunun tıklanma olayını temsil eden metot

            // "fSatis" formunu alıyoruz
            fSatis f = (fSatis)Application.OpenForms["fSatis"];

            // Nakit miktarını ve genel toplamı ilgili metotlar aracılığıyla double türüne dönüştürüyoruz
            double nakit = Islemler.doubleYap(txtNakit.Text);
            double geneltoplam = Islemler.doubleYap(f.txtToplam.Text);

            // Kart miktarını hesaplıyoruz (genel toplamdan nakit miktarını çıkarıyoruz)
            double kart = geneltoplam - nakit;

            // fSatis formundaki ilgili etiketleri güncelliyoruz
            f.lblNakit.Text = Islemler.doubleYap(nakit.ToString()).ToString();
            f.lblKart.Text = Islemler.doubleYap(kart.ToString()).ToString();

            // SatisYap metodu aracılığıyla satış işlemini gerçekleştiriyoruz (ödeme şekli olarak "Kart-Nakit" kullanılıyor)
            f.SatisYap("Kart-Nakit");

            // Bu formu gizliyoruz
            this.Hide();
        }

        private void txtNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false&&e.KeyChar!=(char)08)
                e.Handled = true;
        }
    }
}
