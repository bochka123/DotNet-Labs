namespace WebLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HopeFinaly : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserCards", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserCards", "UserId", c => c.Int(nullable: false));
        }
    }
}
