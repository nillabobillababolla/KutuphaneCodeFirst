namespace KutuphaneCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class A5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAd = c.String(maxLength: 100),
                        YazarSoyad = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.YazarId);
            
            AddColumn("dbo.Kitaplar", "YazarId", c => c.Int(nullable: false));
            AlterColumn("dbo.Kitaplar", "KitapAdi", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Kitaplar", "YazarId");
            AddForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar", "YazarId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            AlterColumn("dbo.Kitaplar", "KitapAdi", c => c.String(nullable: false));
            DropColumn("dbo.Kitaplar", "YazarId");
            DropTable("dbo.Yazarlar");
        }
    }
}
