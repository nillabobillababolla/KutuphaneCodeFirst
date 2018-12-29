using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KutuphaneCodeFirst.Entities;
using KutuphaneCodeFirst.MockData;
using KutuphaneCodeFirst.ViewModels;
// ReSharper disable TooManyDeclarations

namespace KutuphaneCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, System.EventArgs e)
        {
             
        }
        private KitapIslemleri _frmKitapIslemleri;
        private CalisanIslemleri _frmCalisanIslemleri;
        private UyeIslemleri _frmUyeIslemleri;
        private KiralamaIslemleri _frmKiralamaIslemleri;
        private YazarIslemleri _frmYazarIslemleri;
        private void kitapİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmKitapIslemleri == null || _frmKitapIslemleri.IsDisposed)
            {
                _frmKitapIslemleri = new KitapIslemleri
                {
                    MdiParent = this
                };
                _frmKitapIslemleri.Show();
            }
        }

        private void calisanİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmCalisanIslemleri == null || _frmCalisanIslemleri.IsDisposed)
            {
                _frmCalisanIslemleri = new CalisanIslemleri()
                {
                    MdiParent = this
                };
                _frmCalisanIslemleri.Show();
            }
        }

        private void uyeİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmUyeIslemleri == null || _frmUyeIslemleri.IsDisposed)
            {
                _frmUyeIslemleri = new UyeIslemleri()
                {
                    MdiParent = this
                };
                _frmUyeIslemleri.Show();
            }
        }

        private void kiralamaİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmKiralamaIslemleri == null || _frmKiralamaIslemleri.IsDisposed)
            {
                _frmKiralamaIslemleri = new KiralamaIslemleri()
                {
                    MdiParent = this
                };
                _frmKiralamaIslemleri.Show();
            }
        }

        private void yazarİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmYazarIslemleri == null || _frmYazarIslemleri.IsDisposed)
            {
                _frmYazarIslemleri = new YazarIslemleri()
                {
                    MdiParent = this
                };
                _frmYazarIslemleri.Show();
            }
        }



        public static List<Kiralayan> KiralayanlariGetir()
        {
            var kiralayanlar = (from o in Mock.Kiralayanlar
                                          orderby o.KiralayanAd
                                          select o)
                .ToList();
            return kiralayanlar;
        }

        public static List<KitapViewModel> KitaplariGetir()
        {
            var db = new MyContext();
            var kitaplar = new List<KitapViewModel>();
            foreach (var model in db.Kitaplar.OrderBy(x => x.KitapAdi)
                .Select(x => new KitapViewModel()
                {
                    KitapId = x.KitapId,
                    YazarId = x.YazarId,
                    Kategori = x.Kategori,
                    KitapAdi = x.KitapAdi,
                    YazarAdi = x.Yazar.YazarAd,
                    YazarSoyadi = x.Yazar.YazarSoyad,
                    Adet = x.Adet
                }))
                kitaplar.Add(model);
            return kitaplar;
        }

        public static List<Calisan> CalisanlariGetir()
        {
            var calisanlar = (from o in Mock.Calisanlar
                                        orderby o.CalisanAd
                                        select o)
                .ToList();
            return calisanlar;
        }

        public static List<Yazar> YazarlariGetir()
        {
            var yazarlar = (from o in Mock.Yazarlar
                                      orderby o.YazarAd
                                      select o)
                .ToList();
            return yazarlar;
        }

    }
}
