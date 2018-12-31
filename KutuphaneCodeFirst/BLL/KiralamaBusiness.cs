using System;
using System.Linq;
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
           var db = new MyContext();
            
           var kira = db.Kiralar.SingleOrDefault(x => x.KiralayanId == kiralayan.KiralayanId && x.KitapId == kitap.KitapId);

           if (kira == null) return 0;

           var gun = DateTime.Now.Subtract(kira.KiralamaTarihi);
           if (gun.Days>7)
           {
               var ceza = gun.Days * 5;
               MessageBox.Show($@"Odemeniz gereken ceza={ceza}",@"Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Error);
           }

           MessageBox.Show(@"Ceza Odemenize gerek yok.",@"Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
           db.Kiralar.Remove(kira);
           kitap.Adet++;
           return db.SaveChanges();
        }



    }
}
