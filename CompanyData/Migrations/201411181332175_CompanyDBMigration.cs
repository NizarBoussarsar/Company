namespace CompanyData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyDBMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 50),
                        CategoryDescription = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 50),
                        Description = c.String(maxLength: 50),
                        ImagePath = c.String(maxLength: 50),
                        UnitPrice = c.Decimal(precision: 18, scale: 0),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DayTimePhone = c.String(maxLength: 50),
                        EmailAddress = c.String(maxLength: 50),
                        CompanyName = c.String(maxLength: 50),
                        CompanyManager = c.String(maxLength: 50),
                        Fullname_FirstName = c.String(maxLength: 50),
                        Fullname_LastName = c.String(maxLength: 50),
                        Age = c.Int(),
                        IsCompany = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Category");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Products");
            DropTable("dbo.Category");
        }
    }
}
