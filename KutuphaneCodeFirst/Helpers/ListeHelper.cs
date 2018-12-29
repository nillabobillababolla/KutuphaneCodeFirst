using KutuphaneCodeFirst.Entities;
using KutuphaneCodeFirst.MockData;
using KutuphaneCodeFirst.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace KutuphaneCodeFirst.Helpers
{
    public static class ListeHelper
    {
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
            var kitaplar = Mock.KitapViewModels;
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
