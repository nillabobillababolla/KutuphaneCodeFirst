// ReSharper disable InconsistentNaming
namespace KutuphaneCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class KitapAdi_isunique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Kitaplar", "KitapAdi", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Kitaplar", new[] { "KitapAdi" });
        }
    }
}
