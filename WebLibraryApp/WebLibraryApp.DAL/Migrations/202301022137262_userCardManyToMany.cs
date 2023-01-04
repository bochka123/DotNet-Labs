namespace WebLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userCardManyToMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "UserCard_Id", "dbo.UserCards");
            DropIndex("dbo.Books", new[] { "UserCard_Id" });
            CreateTable(
                "dbo.BookUserCard",
                c => new
                    {
                        UserCardRefId = c.Int(nullable: false),
                        BookRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserCardRefId, t.BookRefId })
                .ForeignKey("dbo.UserCards", t => t.UserCardRefId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookRefId, cascadeDelete: true)
                .Index(t => t.UserCardRefId)
                .Index(t => t.BookRefId);
            
            DropColumn("dbo.Books", "UserCard_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "UserCard_Id", c => c.Int());
            DropForeignKey("dbo.BookUserCard", "BookRefId", "dbo.Books");
            DropForeignKey("dbo.BookUserCard", "UserCardRefId", "dbo.UserCards");
            DropIndex("dbo.BookUserCard", new[] { "BookRefId" });
            DropIndex("dbo.BookUserCard", new[] { "UserCardRefId" });
            DropTable("dbo.BookUserCard");
            CreateIndex("dbo.Books", "UserCard_Id");
            AddForeignKey("dbo.Books", "UserCard_Id", "dbo.UserCards", "Id");
        }
    }
}
