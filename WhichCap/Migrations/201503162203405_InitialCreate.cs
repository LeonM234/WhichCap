namespace WhichCap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Which",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApplicationUserID = c.String(),
                        Title = c.String(),
                        Pic1Url = c.String(),
                        Pic2Url = c.String(),
                        Vote1 = c.Int(nullable: false),
                        Vote2 = c.Int(nullable: false),
                        Done = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Which");
        }
    }
}
