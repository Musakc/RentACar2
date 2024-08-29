namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePropertiesTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Properties",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Marka = c.String(),
                    Model = c.String(),
                    Yil = c.Int(),
                    Fiyat = c.Decimal(),
                    Renk = c.String(),
                    KM = c.Int(),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Properties");
        }
    }
}


