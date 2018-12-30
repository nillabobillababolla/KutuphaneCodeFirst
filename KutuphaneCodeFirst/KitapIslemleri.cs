using KutuphaneCodeFirst.Entities;
using KutuphaneCodeFirst.Helpers;
using KutuphaneCodeFirst.MockData;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneCodeFirst
{
    public partial class KitapIslemleri : Form
    {
        private Kitap _seciliKitap = new Kitap();
        private Yazar _seciliYazar = new Yazar();

        public KitapIslemleri()
        {
            InitializeComponent();
        }
        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }

        private void ListeDoldur()
        {
            var db = new MyContext();
            Mock.Yazarlar = db.Yazarlar.ToList();
            Mock.Kitaplar = db.Kitaplar.ToList();
            lstKitaplar.DataSource = Mock.Kitaplar;
            cmbYazar.DataSource = Mock.Yazarlar;
        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            KtpAyrintiGetir();
        }

        private void KtpAyrintiGetir()
        {
            _seciliKitap = (Kitap)lstKitaplar.SelectedItem;
            _seciliYazar = (Mock.Yazarlar.Where(o => o.YazarId == _seciliKitap.YazarId)).First();

            txtKitapAdi.Text = _seciliKitap.KitapAdi;
            txtKategori.Text = _seciliKitap.Kategori;
            cmbYazar.SelectedItem = _seciliYazar;
            txtAdet.Text = _seciliKitap.Adet.ToString();
        }

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {

            var db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var yazar = cmbYazar.SelectedItem as Yazar;
                    if (yazar == null) return;

                    var query = (from k in db.Kitaplar
                        where k.KitapAdi == txtKitapAdi.Text
                        select k.Adet);
                   

                    if (query.First() > 0)
                    {
                        MessageBox.Show(@"Eklemeye calistiginiz kitap zaten var.");
                    }
                    else
                    {
                        var kitap = new Kitap
                        {
                            KitapAdi = txtKitapAdi.Text.ToLower(),
                            Adet = int.Parse(txtAdet.Text),
                            Kategori = txtKategori.Text.ToLower(),
                            YazarId = yazar.YazarId,
                        };
                        db.SaveChanges();
                        KitapHelper.KitapEkle(kitap);
                        tran.Commit();
                        MessageBox.Show($@"{kitap.KitapAdi} Kitabı Eklendi.");
                    }
                   
                }
                catch (Exception exception)
                {
                    tran.Rollback();
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItem == null) return;

            var db = new MyContext();
            var seciliKitap = (Kitap)lstKitaplar.SelectedItem;
            var result = db.Kitaplar.SingleOrDefault(b => b.KitapId == seciliKitap.KitapId);

            if (seciliKitap == null) return;

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    if (result != null)
                    {
                        result.KitapAdi = txtKitapAdi.Text.ToLower();
                        result.Adet = int.Parse(txtAdet.Text);
                        result.Kategori = txtKategori.Text.ToLower();
                    }

                    db.SaveChanges();
                    tran.Commit();
                    ListeDoldur();

                    if (result != null) MessageBox.Show($@"{result.KitapAdi} güncellendi.");
                }
                catch (Exception exception)
                {
                    tran.Rollback();
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(@"Kaydı silmek istiyor musunuz?", @"Uyarı!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;

            if (lstKitaplar.SelectedItem == null) return;

            var db = new MyContext();
            var seciliKitap = (Kitap)lstKitaplar.SelectedItem;

            var silinecekKitap = db.Kitaplar.SingleOrDefault(b => b.KitapId == seciliKitap.KitapId);

            if (silinecekKitap == null) return;

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    db.Kitaplar.Remove(silinecekKitap);

                    db.SaveChanges();
                    tran.Commit();
                    MessageBox.Show($@"{silinecekKitap.KitapAdi} adlı kitap silindi.",@"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    ListeDoldur();
                }
                catch (Exception exception)
                {
                    tran.Rollback();
                    MessageBox.Show(exception.Message);
                }
            }
        }


    }
}
