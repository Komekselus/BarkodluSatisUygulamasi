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
    public partial class fUrunGrubuEkle : Form
    {
        BarkodDbEntities db = new BarkodDbEntities();
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }

        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void btnStandart1_Click(object sender, EventArgs e)
        {
            if (txtUrunGrupAd.Text!="")
            {
                UrunGrup ug = new UrunGrup();
                ug.urunGrupAd = txtUrunGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupDoldur();
                txtUrunGrupAd.Clear();
                MessageBox.Show("Ürün grubu eklenmiştir");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (f!=null)
                {
                    f.GrupDoldur();
                }
                

            }
            else
            {
                MessageBox.Show("Boş eklenemez");
            }
        }
        private void GrupDoldur()
        {
            listUrunGrup.DisplayMember = "urunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.urunGrupAd).ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int grupid= Convert.ToInt32(listUrunGrup.SelectedValue.ToString());
            string grupad = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad + "grubunu silmek istiyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(x => x.Id == grupid);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                txtUrunGrupAd.Focus();
                MessageBox.Show(grupad + "ürün grubu silindi");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                f.GrupDoldur();
            }
        }
    }
}
 