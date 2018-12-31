using KutuphaneCodeFirst.Entities;
using KutuphaneCodeFirst.MockData;
using System;
using System.Linq;
using System.Windows.Forms;
using KutuphaneCodeFirst.BLL;
using KutuphaneCodeFirst.ViewModels;

namespace KutuphaneCodeFirst
{
    public partial class KiralamaIslemleri : Form
    {
        public KiralamaIslemleri()
        {
            InitializeComponent();
        }
        MyContext db = new MyContext();
        private void KiralamaIslemleri_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }

        private void ListeDoldur()
        {
            lstKitaplar.DataSource = db.Kitaplar.Select(x => new KitapViewModel
            {
                Adet = x.Adet,
                KitapAdi = x.KitapAdi,
                Kategori = x.Kategori,
                KitapId = x.KitapId,
                YazarId = x.YazarId,
                YazarAdi = x.Yazar.YazarAd,
                YazarSoyadi = x.Yazar.YazarSoyad
            }).ToList();
            cmbKiralayanlar.DataSource = db.Kiralayanlar.OrderBy(b => b.KiralayanAd).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    if (cmbKiralayanlar.SelectedItem==null) return;
                    if (lstKitaplar.SelectedItem == null) return;

                    var kitap = (KitapViewModel)lstKitaplar.SelectedItem;
                    var seciliKitap = db.Kitaplar.SingleOrDefault(b => b.KitapId == kitap.KitapId);

                    var kiralayan = (Kiralayan)cmbKiralayanlar.SelectedItem;

                    if (KiralamaBusiness.Kirala(seciliKitap, kiralayan) <= 0) return;

                    tran.Commit();
                    MessageBox.Show($@"{kitap} kitabı {kiralayan}'a verildi.");
                    ListeDoldur();
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
            UyeKitapListele();
        }

        private void UyeKitapListele()
        {
            if (cmbKiralayanlar.SelectedItem == null) return;

            var kiralayanId = ((Kiralayan)cmbKiralayanlar.SelectedItem).KiralayanId;
            if (cmbKiralayanlar.SelectedItem == null) return;
            var sorgu = db.Kiralar
                .Where(x => x.KiralayanId == kiralayanId)
                .Select(x => new KiraViewModel()
                {
                    KitapId = x.KitapId,
                    KitapAdi = x.Kitap.KitapAdi,
                    KiralayanId = x.KiralayanId,
                    KiralayanAdi = x.Kiralayan.KiralayanAd,
                    KiralayanSoyad = x.Kiralayan.KiralayanSoyad,
                    KiralamaTarihi = x.KiralamaTarihi,
                }).ToList();

            lstUyeKitaplari.DataSource = sorgu;
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                if (cmbKiralayanlar.SelectedItem == null) return;
                if (lstUyeKitaplari.SelectedItem == null) return;

                var seciliUye = cmbKiralayanlar.SelectedItem as Kiralayan;
                var seciliKitap = lstUyeKitaplari.SelectedItem as Kitap;

                try
                {
                    var kiralayan = db.Kiralayanlar.SingleOrDefault(x => x.KiralayanId == seciliUye.KiralayanId);
                    var kitap = db.Kitaplar.SingleOrDefault(y => y.KitapId == seciliKitap.KitapId);

                    if (KiralamaBusiness.TeslimAl(kitap, kiralayan) <= 0) return;
                    {
                        tran.Commit();
                        UyeKitapListele();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
