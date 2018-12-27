using System.Data.Entity;

namespace KutuphaneCodeFirst
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyCon")
        {
            
        }
    }
}
