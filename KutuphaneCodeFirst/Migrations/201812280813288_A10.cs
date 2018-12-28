namespace KutuphaneCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class A10 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Calisanlar", new[] { "Tckn" });
            AddColumn("dbo.Kiralayanlar", "Tckn", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Calisanlar", "Tckn", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Calisanlar", "CalisanAd", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Calisanlar", "Tckn", unique: true);
            CreateIndex("dbo.Kiralayanlar", "Tckn", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Kiralayanlar", new[] { "Tckn" });
            DropIndex("dbo.Calisanlar", new[] { "Tckn" });
            AlterColumn("dbo.Calisanlar", "CalisanAd", c => c.String(maxLength: 50));
            AlterColumn("dbo.Calisanlar", "Tckn", c => c.String(maxLength: 11));
            DropColumn("dbo.Kiralayanlar", "Tckn");
            CreateIndex("dbo.Calisanlar", "Tckn", unique: true);
        }
    }
}
