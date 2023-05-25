using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatisUygulamasi
{
    static class Islemler
    {
        static public double doubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentUICulture.NumberFormat, out sonuc);
            return Math.Round(sonuc, 2);

        }
        static public void cursorBaslat()
        {
            Cursor.Current =Cursors.WaitCursor;
        }
        static public void cursorBitir()
        {
            Cursor.Current = Cursors.Default;

        }
        static public void stokAzalt(string barkod, double miktar)
        {
            if (barkod != "111111111116")
            {
                using (var db = new BarkodDbEntities())
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar -= miktar;
                    db.SaveChanges();
                }
            }
        }
        static public void stokArtir(string barkod, double miktar)
        {
            using (var db = new BarkodDbEntities())
            {
                if (barkod != "111111111116")
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar += miktar;
                    db.SaveChanges();
                }
            }
        }
        static public void GridDuzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "Id":
                            dgv.Columns[i].HeaderText = "Numara"; break;
                        case "UrunId":
                            dgv.Columns[i].HeaderText = "Urun Numarası"; break;
                        case "UrunAD":
                            dgv.Columns[i].HeaderText = "Ürün Adı"; break;
                        case "Aciklama":
                            dgv.Columns[i].HeaderText = "Açıklama"; break;
                        case "UrunGrup":
                            dgv.Columns[i].HeaderText = "Ürün Grubu"; break;
                        case "AlisFiyat":
                            dgv.Columns[i].HeaderText = "Alış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "SatisFiyat":
                            dgv.Columns[i].HeaderText = "Satış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "KdvOrani":
                            dgv.Columns[i].HeaderText = "Kdv Oranı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Birim":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;break;
                        case "Miktar":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "OdemeSekli":
                            dgv.Columns[i].HeaderText = "Ödeme Şekli";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "Kart":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Nakit":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Gelir":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Gider":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Kullanici":
                            dgv.Columns[i].HeaderText = "Kullanıcı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "KdvTutari":
                            dgv.Columns[i].HeaderText = "Kdv Tutarı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";break;
                            case "IslemNo":
                            dgv.Columns[i].HeaderText = "İşlem No"; break;
                        case "AlisFiyatToplam":
                            dgv.Columns[i].HeaderText = "Alış Fiyat Toplam";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";break;
                        case "Toplam":
                            dgv.Columns[i].HeaderText = "Toplam";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                    }
                }

            }

        }
        static public void StokHareket(string barkod,string urunad,string birim,double miktar,string urungrup,string kullanici)
        {
            using (var db=new BarkodDbEntities())
            {
                StokHareket sh = new StokHareket();
                sh.Barkod = barkod;
                sh.UrunAd = urunad;
                sh.Birim = birim;
                sh.Miktar = miktar;
                sh.UrunGrup = urungrup;
                sh.Kullanici=kullanici;
                sh.Tarih = DateTime.Now;
                db.StokHareket.Add(sh);
                db.SaveChanges();
            }
        }
        static public int KartKomisyon()
        {
            int sonuc = 0;
            using (var db=new BarkodDbEntities())
            {
                if (db.Sabit.Any())
                {
                    sonuc = (int)db.Sabit.First().KartKomisyon;
                }
                else
                {
                    sonuc = 0;
                }
                return sonuc;
            }
        }
        static public void SabitVarsayilan()
        {
            using (var db=new BarkodDbEntities())
            {
                if (!db.Sabit.Any())
                {
                    Sabit s = new Sabit();
                    s.KartKomisyon
                        = 0;
                    s.Yazici = false;
                    s.AdSoyad = "admin";
                    s.Adres = "admin";
                    s.Unvan = "admin";
                    s.Adres = "admin";
                    s.Telefon = "admin";
                    s.Telefon="admin";
                    s.Eposta = "admin";
                    db.Sabit.Add(s);
                    db.SaveChanges();
                }
            }
        }
        static public void Backup()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Veri yedek dosyası|0.bak";
            save.FileName = "Barkodlu_Satis_Programi_" + DateTime.Now.ToShortDateString();
            if (save.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    cursorBaslat();
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    var dbhedef = save.FileName;
                    string dbKaynak = Application.StartupPath + @"\BarkodDb.mdf";
                    using (var db=new BarkodDbEntities())
                    {
                       // string dbKaynak = db.Database.Connection.Database;
                        var cmd = @"BACKUP DATABASE[" + dbKaynak + "]TO DISK='" + dbhedef + "'";
                        db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,cmd);
                    }
                    MessageBox.Show("Yedekleme tamamlanmıştır");
                    cursorBitir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
