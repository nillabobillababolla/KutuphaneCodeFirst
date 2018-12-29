using System;
using System.Windows.Forms;
using KutuphaneCodeFirst.Entities;

namespace KutuphaneCodeFirst.Helpers
{
   public static class KitapHelper
    {
        public static int KitapEkle(Kitap kitap)
        {
            var db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    db.Kitaplar.Add(kitap);
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
