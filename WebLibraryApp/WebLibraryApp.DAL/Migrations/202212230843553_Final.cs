namespace WebLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Books", name: "UserCard_Id", newName: "Card_Id");
            RenameIndex(table: "dbo.Books", name: "IX_UserCard_Id", newName: "IX_Card_Id");
            AddColumn("dbo.Books", "NumberOfAvailable", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "NumberOfExamples");
            DropColumn("dbo.Books", "NumberOfGivenExamples");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "NumberOfGivenExamples", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "NumberOfExamples", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "NumberOfAvailable");
            RenameIndex(table: "dbo.Books", name: "IX_Card_Id", newName: "IX_UserCard_Id");
            RenameColumn(table: "dbo.Books", name: "Card_Id", newName: "UserCard_Id");
        }
    }
}
