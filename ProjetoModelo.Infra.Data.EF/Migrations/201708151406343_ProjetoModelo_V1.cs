namespace ProjetoModelo.Infra.Data.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjetoModelo_V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 200, unicode: false),
                        Description = c.String(maxLength: 400, unicode: false),
                        Picture = c.Binary(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 200, unicode: false),
                        SupplierID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        QuantityPerUnit = c.String(maxLength: 200, unicode: false),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        UnitsInStock = c.Short(),
                        UnitsOnOrder = c.Short(),
                        ReorderLevel = c.Short(),
                        Discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.SupplierID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Discount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.String(nullable: false, maxLength: 100, unicode: false),
                        EmployeeID = c.Int(nullable: false),
                        OrderDate = c.DateTime(),
                        RequiredDate = c.DateTime(),
                        ShippedDate = c.DateTime(),
                        ShipVia = c.Int(nullable: false),
                        Freight = c.Decimal(precision: 18, scale: 2),
                        ShipName = c.String(maxLength: 40, unicode: false),
                        ShipAddress = c.String(maxLength: 60, unicode: false),
                        ShipCity = c.String(maxLength: 15, unicode: false),
                        ShipRegion = c.String(maxLength: 15, unicode: false),
                        ShipPostalCode = c.String(maxLength: 10, unicode: false),
                        ShipCountry = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Shippers", t => t.ShipVia)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeeID)
                .Index(t => t.ShipVia);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.String(nullable: false, maxLength: 100, unicode: false),
                        CompanyName = c.String(nullable: false, maxLength: 200, unicode: false),
                        ContactName = c.String(nullable: false, maxLength: 200, unicode: false),
                        ContactTitle = c.String(nullable: false, maxLength: 200, unicode: false),
                        Address = c.String(nullable: false, maxLength: 200, unicode: false),
                        City = c.String(nullable: false, maxLength: 200, unicode: false),
                        Region = c.String(maxLength: 200, unicode: false),
                        PostalCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        Country = c.String(nullable: false, maxLength: 50, unicode: false),
                        Phone = c.String(nullable: false, maxLength: 11, unicode: false),
                        Fax = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.CustomerDemographics",
                c => new
                    {
                        CustomerTypeID = c.String(nullable: false, maxLength: 100, unicode: false),
                        CustomerDesc = c.String(nullable: false, maxLength: 400, unicode: false),
                    })
                .PrimaryKey(t => t.CustomerTypeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Title = c.String(nullable: false, maxLength: 100, unicode: false),
                        TitleOfCourtesy = c.String(nullable: false, maxLength: 10, unicode: false),
                        BirthDate = c.DateTime(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        Address = c.String(nullable: false, maxLength: 100, unicode: false),
                        City = c.String(nullable: false, maxLength: 80, unicode: false),
                        Region = c.String(maxLength: 20, unicode: false),
                        PostalCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        Country = c.String(nullable: false, maxLength: 10, unicode: false),
                        HomePhone = c.String(nullable: false, maxLength: 30, unicode: false),
                        Extension = c.String(nullable: false, maxLength: 30, unicode: false),
                        Photo = c.Binary(nullable: false),
                        Notes = c.String(nullable: false, maxLength: 400, unicode: false),
                        ReportsTo = c.Int(nullable: false),
                        PhotoPath = c.String(nullable: false, maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Employees", t => t.ReportsTo)
                .Index(t => t.ReportsTo);
            
            CreateTable(
                "dbo.Territories",
                c => new
                    {
                        TerritoryID = c.Int(nullable: false, identity: true),
                        TerritoryDescription = c.String(nullable: false, maxLength: 50, unicode: false),
                        RegionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TerritoryID)
                .ForeignKey("dbo.Region", t => t.RegionID)
                .Index(t => t.RegionID);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        RegionID = c.Int(nullable: false, identity: true),
                        RegionDescription = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.RegionID);
            
            CreateTable(
                "dbo.Shippers",
                c => new
                    {
                        ShipperID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 40, unicode: false),
                        Phone = c.String(maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.ShipperID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 40, unicode: false),
                        ContactName = c.String(maxLength: 30, unicode: false),
                        ContactTitle = c.String(maxLength: 30, unicode: false),
                        Address = c.String(maxLength: 60, unicode: false),
                        City = c.String(maxLength: 15, unicode: false),
                        Region = c.String(maxLength: 15, unicode: false),
                        PostalCode = c.String(maxLength: 100, unicode: false),
                        Country = c.String(maxLength: 15, unicode: false),
                        Phone = c.String(maxLength: 24, unicode: false),
                        Fax = c.String(maxLength: 24, unicode: false),
                        HomePage = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.SupplierID);
            
            CreateTable(
                "dbo.CustomerCustomerDemo",
                c => new
                    {
                        CustomerTypeID = c.String(nullable: false, maxLength: 100, unicode: false),
                        CustomerID = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => new { t.CustomerTypeID, t.CustomerID })
                .ForeignKey("dbo.CustomerDemographics", t => t.CustomerTypeID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerTypeID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.EmployeeTerritories",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        TerritoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeID, t.TerritoryID })
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Territories", t => t.TerritoryID)
                .Index(t => t.EmployeeID)
                .Index(t => t.TerritoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Products", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "ShipVia", "dbo.Shippers");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.EmployeeTerritories", "TerritoryID", "dbo.Territories");
            DropForeignKey("dbo.EmployeeTerritories", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Territories", "RegionID", "dbo.Region");
            DropForeignKey("dbo.Orders", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "ReportsTo", "dbo.Employees");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.CustomerCustomerDemo", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.CustomerCustomerDemo", "CustomerTypeID", "dbo.CustomerDemographics");
            DropIndex("dbo.EmployeeTerritories", new[] { "TerritoryID" });
            DropIndex("dbo.EmployeeTerritories", new[] { "EmployeeID" });
            DropIndex("dbo.CustomerCustomerDemo", new[] { "CustomerID" });
            DropIndex("dbo.CustomerCustomerDemo", new[] { "CustomerTypeID" });
            DropIndex("dbo.Territories", new[] { "RegionID" });
            DropIndex("dbo.Employees", new[] { "ReportsTo" });
            DropIndex("dbo.Orders", new[] { "ShipVia" });
            DropIndex("dbo.Orders", new[] { "EmployeeID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Products", new[] { "SupplierID" });
            DropTable("dbo.EmployeeTerritories");
            DropTable("dbo.CustomerCustomerDemo");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Shippers");
            DropTable("dbo.Region");
            DropTable("dbo.Territories");
            DropTable("dbo.Employees");
            DropTable("dbo.CustomerDemographics");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
