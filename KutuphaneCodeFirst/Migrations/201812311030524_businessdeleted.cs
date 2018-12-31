namespace KutuphaneCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class businessdeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kitaplar", "AktifMi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kitaplar", "AktifMi", c => c.Boolean(nullable: false));
        }
    }
}
