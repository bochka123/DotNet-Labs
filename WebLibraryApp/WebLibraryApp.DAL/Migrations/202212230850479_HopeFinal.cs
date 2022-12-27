namespace WebLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HopeFinal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "isTaken", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "isTaken");
        }
    }
}
