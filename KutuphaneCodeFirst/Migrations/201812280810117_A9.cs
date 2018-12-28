namespace KutuphaneCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class A9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calisanlar",
                c => new
                    {
                        CalisanId = c.Int(nullable: false, identity: true),
                        Tckn = c.String(maxLength: 11),
                        CalisanAd = c.String(maxLength: 50),
                        Gorev = c.String(maxLength: 20),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CalisanId)
                .Index(t => t.Tckn, unique: true);
            
            CreateTable(
                "dbo.Kiralayanlar",
                c => new
                    {
                        KiralayanId = c.Int(nullable: false, identity: true),
                        KiralayanAd = c.String(maxLength: 50),
                        Adres = c.String(maxLength: 200),
                        KayıtTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KiralayanId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Calisanlar", new[] { "Tckn" });
            DropTable("dbo.Kiralayanlar");
            DropTable("dbo.Calisanlar");
        }
    }
}
