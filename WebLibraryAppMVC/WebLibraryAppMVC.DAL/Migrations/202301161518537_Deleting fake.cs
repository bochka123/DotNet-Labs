namespace WebLibraryAppMVC.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deletingfake : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Fake");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Fake", c => c.String());
        }
    }
}
