namespace WebLibraryAppMVC.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        NumberOfAvailable = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        DateOfMaking = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fake = c.String(),
                        FirstName = c.String(nullable: false),
                        SecondName = c.String(),
                        Login = c.String(nullable: false, maxLength: 20, unicode: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Login, unique: true);
            
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
            DropForeignKey("dbo.BookAuthor", "BookRefId", "dbo.Books");
            DropForeignKey("dbo.BookAuthor", "AuthorRefId", "dbo.Authors");
            DropForeignKey("dbo.UserCards", "Id", "dbo.Users");
            DropForeignKey("dbo.BookUserCard", "BookRefId", "dbo.Books");
            DropForeignKey("dbo.BookUserCard", "UserCardRefId", "dbo.UserCards");
            DropForeignKey("dbo.BookBookTopic", "BookRefId", "dbo.Books");
            DropForeignKey("dbo.BookBookTopic", "BookTopicRefId", "dbo.BookTopics");
            DropIndex("dbo.BookAuthor", new[] { "BookRefId" });
            DropIndex("dbo.BookAuthor", new[] { "AuthorRefId" });
            DropIndex("dbo.BookUserCard", new[] { "BookRefId" });
            DropIndex("dbo.BookUserCard", new[] { "UserCardRefId" });
            DropIndex("dbo.BookBookTopic", new[] { "BookRefId" });
            DropIndex("dbo.BookBookTopic", new[] { "BookTopicRefId" });
            DropIndex("dbo.Users", new[] { "Login" });
            DropIndex("dbo.UserCards", new[] { "Id" });
            DropTable("dbo.BookAuthor");
            DropTable("dbo.BookUserCard");
            DropTable("dbo.BookBookTopic");
            DropTable("dbo.Users");
            DropTable("dbo.UserCards");
            DropTable("dbo.BookTopics");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
