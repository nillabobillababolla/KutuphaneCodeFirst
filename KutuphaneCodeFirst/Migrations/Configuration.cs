using System;
using System.Linq;
using KutuphaneCodeFirst.MockData;

namespace KutuphaneCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyContext context)
        {
            if (!context.Yazarlar.Any())
            {
                foreach (var item in Mock.Yazarlar)
                {
                    context.Yazarlar.Add(item);
                }
                context.SaveChanges();
            }

            if (!context.Kitaplar.Any())
            {
                var yazarlar = context.Yazarlar.ToList();
                Random rnd = new Random();

                foreach (var item in Mock.Kitaplar)
                {
                    item.YazarId = yazarlar[rnd.Next(0, yazarlar.Count)].YazarId;
                    context.Kitaplar.Add(item);
                }
                context.SaveChanges();
            }

            if (!context.Kiralayanlar.Any())
            {
                foreach (var item in Mock.Kiralayanlar)
                {
                    context.Kiralayanlar.Add(item);
                }
                context.SaveChanges();
            }


            if (!context.Calisanlar.Any())
            {
                foreach (var item in Mock.Calisanlar)
                {
                    context.Calisanlar.Add(item);
                }
                context.SaveChanges();
            }


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
