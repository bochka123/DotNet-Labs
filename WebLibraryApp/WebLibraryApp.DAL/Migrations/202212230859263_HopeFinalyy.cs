namespace WebLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HopeFinalyy : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "UserCardId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserCardId", c => c.Int(nullable: false));
        }
    }
}
