using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneCodeFirst.Entities;

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
