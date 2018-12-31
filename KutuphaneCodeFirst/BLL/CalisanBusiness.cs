using System;
using System.Data.Entity;
using System.Windows.Forms;
using KutuphaneCodeFirst.Entities;

namespace KutuphaneCodeFirst.BLL
{
   public static class CalisanBusiness
    {
        public static int CalisanEkle(Calisan calisan)
        {
            var db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    db.Calisanlar.Add(calisan);

                    tran.Commit();
                    return db.SaveChanges();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }

        public static int CalisanKaldir(Calisan calisan)
        {
            return 0;
        }

        public static int CalisanGuncelle(Calisan calisan,Calisan seciliCalisan)
        {
            var db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    seciliCalisan.CalisanAd = calisan.CalisanAd;
                    seciliCalisan.CalisanSoyad = calisan.CalisanSoyad;
                    seciliCalisan.Gorev = calisan.Gorev;
                    seciliCalisan.Maas = calisan.Maas;

                    tran.Commit();
                    return db.SaveChanges();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }
    }
}
