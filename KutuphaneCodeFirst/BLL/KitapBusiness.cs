using KutuphaneCodeFirst.Entities;
using System;
using System.Windows.Forms;

namespace KutuphaneCodeFirst.BLL
{
    public static class KitapBusiness
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
