namespace KutuphaneCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class A6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kitaplar", "Kategori", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Kitaplar", "KitapAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Yazarlar", "YazarAd", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Yazarlar", "YazarSoyad", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yazarlar", "YazarSoyad", c => c.String(maxLength: 100));
            AlterColumn("dbo.Yazarlar", "YazarAd", c => c.String(maxLength: 100));
            AlterColumn("dbo.Kitaplar", "KitapAdi", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Kitaplar", "Kategori");
        }
    }
}
