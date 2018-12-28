namespace KutuphaneCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class A4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kitaplar");
        }
    }
}
