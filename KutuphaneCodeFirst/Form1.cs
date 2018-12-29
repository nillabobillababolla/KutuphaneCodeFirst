using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KutuphaneCodeFirst.MockData;
using KutuphaneCodeFirst.ViewModels;

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
            KitaplariGetir();
            YazarlariGetir();
            CalisanlariGetir();
        }
        private void KitaplariGetir()
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
                }))
                kitaplar.Add(model);

            lstKitaplar.DataSource = kitaplar;
        }

        private void CalisanlariGetir()
        {
            lstCalisanlar.DataSource = Mock.Calisanlar;
        }

        private void YazarlariGetir()
        {
            lstYazarlar.DataSource = Mock.Yazarlar;
        }

       
    }
}
