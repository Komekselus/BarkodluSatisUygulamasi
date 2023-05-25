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
    public partial class fBaslangic : Form
    {
        public fBaslangic()
        {
            InitializeComponent();
        }
         
        private void btnSatisIslemi_Click(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();
            fSatis f=new fSatis();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();
            Islemler.cursorBitir();
        }
        
        private void btnGenelRapor_Click(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();
            fRapor f = new fRapor();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();
            Islemler.cursorBitir();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();
            fStok f = new fStok();
            f.ShowDialog();
            f.lblKullanici.Text = lblKullanici.Text;
            Islemler.cursorBitir();
        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();
            fUrunGiris f = new fUrunGiris();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();
            Islemler.cursorBitir();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();
            fAyarlar f = new fAyarlar();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();

            Islemler.cursorBitir();

        }

        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();
            fFiyatGuncelle f = new fFiyatGuncelle();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();

            Islemler.cursorBitir();
        }

        private void btnYedekleme_Click(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();
            Islemler.Backup();
            Islemler.cursorBitir();
        }

        private void btnKullaniciDegistir_Click(object sender, EventArgs e)
        {
            Islemler.cursorBaslat();
            fGiris giris = new fGiris();
            giris.Show();
            this.Hide();

            Islemler.cursorBitir();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fBaslangic_Load(object sender, EventArgs e)
        {

        }
    }
}
