namespace KutuphaneCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class A1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calisanlar",
                c => new
                    {
                        CalisanId = c.Int(nullable: false, identity: true),
                        CalisanAd = c.String(nullable: false, maxLength: 50),
                        CalisanSoyad = c.String(nullable: false, maxLength: 50),
                        Gorev = c.String(maxLength: 20),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CalisanId);
            
            CreateTable(
                "dbo.Kiralar",
                c => new
                    {
                        KiraId = c.Int(nullable: false, identity: true),
                        KitapId = c.Int(nullable: false),
                        KiralayanId = c.Int(nullable: false),
                        KiralamaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KiraId)
                .ForeignKey("dbo.Kiralayanlar", t => t.KiralayanId, cascadeDelete: true)
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .Index(t => t.KitapId)
                .Index(t => t.KiralayanId);
            
            CreateTable(
                "dbo.Kiralayanlar",
                c => new
                    {
                        KiralayanId = c.Int(nullable: false, identity: true),
                        KiralayanAd = c.String(maxLength: 50),
                        KiralayanSoyad = c.String(maxLength: 50),
                        Adres = c.String(maxLength: 200),
                        KayıtTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KiralayanId);
            
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(nullable: false, maxLength: 50),
                        Kategori = c.String(nullable: false, maxLength: 50),
                        Adet = c.Int(nullable: false),
                        YazarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAd = c.String(nullable: false, maxLength: 50),
                        YazarSoyad = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.YazarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.Kiralar", "KiralayanId", "dbo.Kiralayanlar");
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kiralar", new[] { "KiralayanId" });
            DropIndex("dbo.Kiralar", new[] { "KitapId" });
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Kiralayanlar");
            DropTable("dbo.Kiralar");
            DropTable("dbo.Calisanlar");
        }
    }
}
