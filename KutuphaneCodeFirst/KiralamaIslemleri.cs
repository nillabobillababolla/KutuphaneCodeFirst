using System;
using System.Linq;
using System.Windows.Forms;
using KutuphaneCodeFirst.Entities;
using KutuphaneCodeFirst.MockData;

namespace KutuphaneCodeFirst
{
    public partial class KiralamaIslemleri : Form
    {
        public KiralamaIslemleri()
        {
            InitializeComponent();
        }

        private void KiralamaIslemleri_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }

        private void ListeDoldur()
        {
            var db = new MyContext();
            Mock.Yazarlar = db.Yazarlar.ToList();
            Mock.Kiralayanlar = db.Kiralayanlar.ToList();
            lstKitaplar.DataSource = Mock.Kitaplar;
            cmbKiralayanlar.DataSource = Mock.Kiralayanlar;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    if (cmbKiralayanlar.SelectedItem==null) return;
                    if (lstKitaplar.SelectedItem != null)
                    {
                        var kitap = (Kitap)lstKitaplar.SelectedItem;
                        var seciliKitap = db.Kitaplar.SingleOrDefault(b => b.KitapId == kitap.KitapId);

                        var kiralayan = (Kiralayan)cmbKiralayanlar.SelectedItem;

                        if (seciliKitap.Adet==0)
                        {
                            MessageBox.Show(@"Kitap Stokta Yok!");
                            return;
                        }

                        var kira = new Kira
                        {
                            KiralamaTarihi = DateTime.Now,
                            KiralayanId = kiralayan.KiralayanId,
                            KitapId = seciliKitap.KitapId,
                        };

                        db.Kiralar.Add(kira);
                        seciliKitap.Adet--;
                        db.SaveChanges();
                        tran.Commit();
                        MessageBox.Show($@"{kitap} kitabı {kiralayan}'a verildi.");
                        ListeDoldur();
                    }
                }
                catch (Exception exception)
                {
                    tran.Rollback();
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void cmbKiralayanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var db = new MyContext();
            //var seciliKiralayan = (Kiralayan) cmbKiralayanlar.SelectedItem;
            //var liste = db.Kiralar.Where(b => b.KiralayanId == seciliKiralayan.KiralayanId).ToList();
            //foreach (var kira in liste)
            //{
            //    lstKitaplar.Items.Add(kira);
            //}
        }
    }
}
