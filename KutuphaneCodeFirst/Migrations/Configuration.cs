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
            var mockData = new Mock();
            if (!context.Yazarlar.Any())
            {
                foreach (var item in mockData.Yazarlar)
                {
                    context.Yazarlar.Add(item);
                }

                context.SaveChanges();
            }

            if (!context.Kitaplar.Any())
            {
                var yazarlar = context.Yazarlar.ToList();
                Random rnd = new Random();

                foreach (var item in mockData.Kitaplar)
                {
                    item.YazarId = yazarlar[rnd.Next(0, yazarlar.Count)].YazarId;
                    context.Kitaplar.Add(item);
                }

                context.SaveChanges();
            }

            if (!context.Kiralayanlar.Any())
            {
                var kiralayanlar = context.Kiralayanlar.ToList();
                Random rnd = new Random();

                foreach (var item in mockData.Kiralayanlar)
                {
                    context.Kiralayanlar.Add(item);
                }
                context.SaveChanges();
            }


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
