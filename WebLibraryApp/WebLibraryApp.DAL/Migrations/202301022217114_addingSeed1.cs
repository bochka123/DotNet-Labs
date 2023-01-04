namespace WebLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingSeed1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Fake", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Fake");
        }
    }
}
