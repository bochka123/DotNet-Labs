namespace WebLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletingunnecessary : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Books", name: "Card_Id", newName: "UserCard_Id");
            RenameIndex(table: "dbo.Books", name: "IX_Card_Id", newName: "IX_UserCard_Id");
            DropColumn("dbo.Books", "isTaken");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "isTaken", c => c.Boolean(nullable: false));
            RenameIndex(table: "dbo.Books", name: "IX_UserCard_Id", newName: "IX_Card_Id");
            RenameColumn(table: "dbo.Books", name: "UserCard_Id", newName: "Card_Id");
        }
    }
}
