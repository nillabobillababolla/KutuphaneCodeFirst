using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
            //KitaplariGetir();
            //YazarlariGetir();
            //CalisanlariGetir();
            //KiralayanlariGetir();
        }
        private KitapIslemleri _frmKitapIslemleri;
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



        //private void KiralayanlariGetir()
        //{
        //    lstKiralayanlar.DataSource = (from o in Mock.Kiralayanlar
        //        orderby o.KiralayanAd
        //        select o)
        //        .ToList();
        //}

        //private void KitaplariGetir()
        //{
        //    var db = new MyContext();
        //    var kitaplar = new List<KitapViewModel>();
        //    foreach (var model in db.Kitaplar.OrderBy(x => x.KitapAdi)
        //        .Select(x => new KitapViewModel()
        //        {
        //            KitapId = x.KitapId,
        //            YazarId = x.YazarId,
        //            Kategori = x.Kategori,
        //            KitapAdi = x.KitapAdi,
        //            YazarAdi = x.Yazar.YazarAd,
        //            YazarSoyadi = x.Yazar.YazarSoyad,
        //            Adet = x.Adet
        //        }))
        //        kitaplar.Add(model);

        //    lstKitaplar.DataSource = kitaplar;
        //}

        //private void CalisanlariGetir()
        //{
        //    lstCalisanlar.DataSource = (from o in Mock.Calisanlar
        //            orderby o.CalisanAd
        //            select o)
        //        .ToList();
        //}

        //private void YazarlariGetir()
        //{
        //    lstYazarlar.DataSource = (from o in Mock.Yazarlar
        //            orderby o.YazarAd
        //            select o)
        //        .ToList();
        //}

    }
}
