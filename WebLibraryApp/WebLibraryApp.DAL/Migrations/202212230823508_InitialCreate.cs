namespace WebLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfExamples = c.Int(nullable: false),
                        NumberOfGivenExamples = c.Int(nullable: false),
                        UserCard_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserCards", t => t.UserCard_Id)
                .Index(t => t.UserCard_Id);
            
            CreateTable(
                "dbo.BookTopics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Topic = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserCards",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DateOfMaking = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        UserCardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookBookTopic",
                c => new
                    {
                        BookTopicRefId = c.Int(nullable: false),
                        BookRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookTopicRefId, t.BookRefId })
                .ForeignKey("dbo.BookTopics", t => t.BookTopicRefId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookRefId, cascadeDelete: true)
                .Index(t => t.BookTopicRefId)
                .Index(t => t.BookRefId);
            
            CreateTable(
                "dbo.BookAuthor",
                c => new
                    {
                        AuthorRefId = c.Int(nullable: false),
                        BookRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AuthorRefId, t.BookRefId })
                .ForeignKey("dbo.Authors", t => t.AuthorRefId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookRefId, cascadeDelete: true)
                .Index(t => t.AuthorRefId)
                .Index(t => t.BookRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCards", "Id", "dbo.Users");
            DropForeignKey("dbo.Books", "UserCard_Id", "dbo.UserCards");
            DropForeignKey("dbo.BookAuthor", "BookRefId", "dbo.Books");
            DropForeignKey("dbo.BookAuthor", "AuthorRefId", "dbo.Authors");
            DropForeignKey("dbo.BookBookTopic", "BookRefId", "dbo.Books");
            DropForeignKey("dbo.BookBookTopic", "BookTopicRefId", "dbo.BookTopics");
            DropIndex("dbo.BookAuthor", new[] { "BookRefId" });
            DropIndex("dbo.BookAuthor", new[] { "AuthorRefId" });
            DropIndex("dbo.BookBookTopic", new[] { "BookRefId" });
            DropIndex("dbo.BookBookTopic", new[] { "BookTopicRefId" });
            DropIndex("dbo.UserCards", new[] { "Id" });
            DropIndex("dbo.Books", new[] { "UserCard_Id" });
            DropTable("dbo.BookAuthor");
            DropTable("dbo.BookBookTopic");
            DropTable("dbo.Users");
            DropTable("dbo.UserCards");
            DropTable("dbo.BookTopics");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
