namespace KutuphaneCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KiraCompositKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kiralar", "KiralayanId", "dbo.Kiralayanlar");
            DropForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Kiralar", new[] { "KitapId" });
            DropIndex("dbo.Kiralar", new[] { "KiralayanId" });
            DropPrimaryKey("dbo.Kiralar");
            AddPrimaryKey("dbo.Kiralar", new[] { "KitapId", "KiralayanId" });
            DropColumn("dbo.Kiralar", "KiraId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kiralar", "KiraId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Kiralar");
            AddPrimaryKey("dbo.Kiralar", "KiraId");
            CreateIndex("dbo.Kiralar", "KiralayanId");
            CreateIndex("dbo.Kiralar", "KitapId");
            AddForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar", "KitapId", cascadeDelete: true);
            AddForeignKey("dbo.Kiralar", "KiralayanId", "dbo.Kiralayanlar", "KiralayanId", cascadeDelete: true);
        }
    }
}
