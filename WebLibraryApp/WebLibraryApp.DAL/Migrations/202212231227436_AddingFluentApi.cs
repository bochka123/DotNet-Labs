namespace WebLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingFluentApi : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Authors", name: "Name", newName: "AuthorName");
            RenameColumn(table: "dbo.Books", name: "Name", newName: "BookName");
            AlterColumn("dbo.UserCards", "DateOfMaking", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Login", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            CreateIndex("dbo.Users", "Login", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Login" });
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Login", c => c.String());
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.UserCards", "DateOfMaking", c => c.DateTime(nullable: false));
            RenameColumn(table: "dbo.Books", name: "BookName", newName: "Name");
            RenameColumn(table: "dbo.Authors", name: "AuthorName", newName: "Name");
        }
    }
}
