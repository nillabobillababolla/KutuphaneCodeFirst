using KutuphaneCodeFirst.Entities;
using System.Data.Entity;

namespace KutuphaneCodeFirst
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyCon")
        {
           
        }
        public virtual DbSet<Kitap> Kitaplar { get; set; }
        public virtual DbSet<Yazar> Yazarlar { get; set; }
    }
    
}
