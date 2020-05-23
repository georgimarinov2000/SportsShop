namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingTheDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.String(),
                        City_Id = c.Int(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.City_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemCustomers",
                c => new
                    {
                        Item_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Item_Id, t.Customer_Id })
                .ForeignKey("dbo.Items", t => t.Item_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Item_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.ItemCustomers", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Employees", "City_Id", "dbo.Cities");
            DropIndex("dbo.ItemCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.ItemCustomers", new[] { "Item_Id" });
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropIndex("dbo.Employees", new[] { "City_Id" });
            DropTable("dbo.ItemCustomers");
            DropTable("dbo.Items");
            DropTable("dbo.Customers");
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
            DropTable("dbo.Cities");
        }
    }
}
