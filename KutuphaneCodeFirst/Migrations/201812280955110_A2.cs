namespace KutuphaneCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class A2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Kiralar");
            AddColumn("dbo.Kiralar", "KiraId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Kiralar", "KiraId");
            CreateIndex("dbo.Kiralar", "KitapId");
            CreateIndex("dbo.Kiralar", "KiralayanId");
            AddForeignKey("dbo.Kiralar", "KiralayanId", "dbo.Kiralayanlar", "KiralayanId", cascadeDelete: true);
            AddForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar", "KitapId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.Kiralar", "KiralayanId", "dbo.Kiralayanlar");
            DropIndex("dbo.Kiralar", new[] { "KiralayanId" });
            DropIndex("dbo.Kiralar", new[] { "KitapId" });
            DropPrimaryKey("dbo.Kiralar");
            DropColumn("dbo.Kiralar", "KiraId");
            AddPrimaryKey("dbo.Kiralar", new[] { "KitapId", "KiralayanId" });
        }
    }
}
