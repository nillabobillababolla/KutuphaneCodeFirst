using System;
using System.Windows.Forms;
using KutuphaneCodeFirst.Entities;
// ReSharper disable UnusedMember.Global

namespace KutuphaneCodeFirst.BLL
{
    public static class KiralamaBusiness
    {
        public static int Kirala(Kitap kitap,Kiralayan kiralayan)
        {
            var db = new MyContext();
            if (kitap != null && kitap.Adet == 0)
            {
                MessageBox.Show(@"Kitap Stokta Yok!");
                return 0;
            }

            if (kitap != null)
            {
                var kira = new Kira
                {
                    KiralamaTarihi = DateTime.Now,
                    KiralayanId = kiralayan.KiralayanId,
                    KitapId = kitap.KitapId,
                };
                kitap.Adet--;
                db.Kiralar.Add(kira);
            }
          return db.SaveChanges();
        }

        public static int TeslimAl(Kitap kitap,Kiralayan kiralayan)
        {
            return 0;
        }



    }
}
