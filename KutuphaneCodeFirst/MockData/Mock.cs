﻿// ReSharper disable EmptyConstructor

using KutuphaneCodeFirst.Entities;
using System.Collections.Generic;

namespace KutuphaneCodeFirst.MockData
{
    public static class Mock
    {
        public static List<Yazar> Yazarlar { get; set; }
        public static List<Kitap> Kitaplar { get; set; }
        public static List<Kiralayan> Kiralayanlar { get; set; }
        public static List<Calisan> Calisanlar { get; set; }
        public static List<Kira> Kiralar { get; set; }
        
        static Mock()
        {
            Yazarlar = new List<Yazar>();
            Kitaplar = new List<Kitap>();
            Kiralayanlar = new List<Kiralayan>();
            Calisanlar = new List<Calisan>();
            Kiralar = new List<Kira>();

            for (int i = 0; i < 25; i++)
                {
                    Yazarlar.Add(new Yazar()
                    {
                        YazarAd = FakeData.NameData.GetFirstName(),
                        YazarSoyad = FakeData.NameData.GetSurname()
                    });
                }

                for (int i = 0; i < 25; i++)
                {
                    var kat = FakeData.TextData.GetAlphabetical(10).ToLower();
                    var ad = FakeData.TextData.GetAlphabetical(10).ToLower();
                    Kitaplar.Add(new Kitap()
                    {
                        KitapAdi = ad.Length > 50 ? ad.Substring(0, 10) : ad,
                        Adet = FakeData.NumberData.GetNumber(1, 10),
                        Kategori = kat.Length > 50 ? kat.Substring(0, 50) : kat
                    });
                 }

            for (int i = 0; i < 25; i++)
                {
                    Kiralayanlar.Add(new Kiralayan()
                    {
                        KiralayanAd = FakeData.NameData.GetFirstName(),
                        KiralayanSoyad = FakeData.NameData.GetSurname(),
                        Adres = FakeData.TextData.GetAlphabetical(30)
                    });
            }

            for (int i = 0; i < 25; i++)
                {
                    Calisanlar.Add(new Calisan()
                    {
                        CalisanAd = FakeData.NameData.GetFirstName(),
                        CalisanSoyad = FakeData.NameData.GetSurname(),
                        Gorev = FakeData.TextData.GetAlphabetical(10),
                        Maas = FakeData.NumberData.GetNumber(1000, 10000)
                    });
                }
        }
    }
}
