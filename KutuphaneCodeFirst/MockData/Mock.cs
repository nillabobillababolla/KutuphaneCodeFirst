// ReSharper disable EmptyConstructor

using System.Collections.Generic;
using KutuphaneCodeFirst.Entities;

namespace KutuphaneCodeFirst.MockData
{
    public class Mock
    {
        public List<Yazar> Yazarlar { get; set; }
        public List<Kitap> Kitaplar { get; set; }
        public List<Kiralayan> Kiralayanlar { get; set; }


        public Mock()
        {
            Yazarlar=new List<Yazar>();
            Kitaplar =new  List<Kitap>();
           
            for (int i = 0; i < 100; i++)
            {
                Yazarlar.Add(new Yazar()
                {
                    YazarAd = FakeData.NameData.GetFirstName(),
                    YazarSoyad = FakeData.NameData.GetSurname()
                });
            }

            for (int i = 0; i < 100; i++)
            {
                Kitaplar.Add(new Kitap()
                {
                    KitapAdi = FakeData.NameData.GetCompanyName(),
                    Adet = FakeData.NumberData.GetNumber(10),
                    Kategori = FakeData.TextData.GetSentence()
                });
            }


            for (int i = 0; i < 100; i++)
            {
                Kiralayanlar.Add(new Kiralayan()
                {
                    KiralayanAd = FakeData.NameData.GetFirstName(),
                    KiralayanSoyad = FakeData.NameData.GetSurname(),
                    Adres = FakeData.TextData.GetAlphabetical(30),
                });
            }


        }
    }
}
