namespace KutuphaneCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class A14 : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.Kitaplar", "Adet", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.Kiralar", "KiralayanId", "dbo.Kiralayanlar");
            DropIndex("dbo.Kiralar", new[] { "KiralayanId" });
            DropIndex("dbo.Kiralar", new[] { "KitapId" });
            DropColumn("dbo.Kitaplar", "Adet");
            DropTable("dbo.Kiralar");
        }
    }
}
