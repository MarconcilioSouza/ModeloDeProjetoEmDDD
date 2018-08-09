using ProjetoModelo.Infra.Data.Dapper.Repositorios;
using System;
using Dapper;
using System.IO;

namespace ProjetoModelo.Infra.Data.Dapper.Contexto
{
    public class CreateDatabase : RepositorioBase
    {
        public void CreateDatabaseSqlite()
        {
            try
            {
                if (File.Exists(DbFile))
                    return;

                using (var conn = GetConnection())
                {
                    conn.Open();

                    SqlBuilder sqlQuery = new SqlBuilder();
                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS Suppliers (");
                    sqlQuery.Append("	SupplierID	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	CompanyName	TEXT,");
                    sqlQuery.Append("	ContactName	TEXT,");
                    sqlQuery.Append("	ContactTitle	TEXT,");
                    sqlQuery.Append("	Address	TEXT,");
                    sqlQuery.Append("	City	TEXT,");
                    sqlQuery.Append("	Region	TEXT,");
                    sqlQuery.Append("	PostalCode	TEXT,");
                    sqlQuery.Append("	Country	TEXT,");
                    sqlQuery.Append("	Phone	TEXT,");
                    sqlQuery.Append("	Fax	TEXT,");
                    sqlQuery.Append("	HomePage	TEXT");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS Region(");
                    sqlQuery.Append("	RegionID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	RegionDescription TEXT NOT NULL");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS Territories(");
                    sqlQuery.Append("	TerritoryID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	TerritoryDescription TEXT NOT NULL,");
                    sqlQuery.Append("	RegionID INTEGER NOT NULL,");
                    sqlQuery.Append("	FOREIGN KEY(RegionID) REFERENCES Region");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS Employees(");
                    sqlQuery.Append("	EmployeeID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	LastName TEXT NOT NULL,");
                    sqlQuery.Append("	FirstName TEXT NOT NULL,");
                    sqlQuery.Append("	Title TEXT,");
                    sqlQuery.Append("	TitleOfCourtesy TEXT,");
                    sqlQuery.Append("	BirthDate BLOB,");
                    sqlQuery.Append("	HireDate BLOB,");
                    sqlQuery.Append("	Address TEXT,");
                    sqlQuery.Append("	City TEXT,");
                    sqlQuery.Append("	Region TEXT,");
                    sqlQuery.Append("	PostalCode TEXT,");
                    sqlQuery.Append("	Country TEXTL,");
                    sqlQuery.Append("	HomePhone TEXT,");
                    sqlQuery.Append("	Extension TEXT,");
                    sqlQuery.Append("	Photo BLOB,");
                    sqlQuery.Append("	Notes TEXT,");
                    sqlQuery.Append("	ReportsTo INTEGER,");
                    sqlQuery.Append("	PhotoPath TEXT,");
                    sqlQuery.Append("	FOREIGN KEY(ReportsTo) REFERENCES Employees");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS EmployeeTerritories(");
                    sqlQuery.Append("	EmployeeTerritoriesID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	EmployeeID INTEGER NOT NULL,");
                    sqlQuery.Append("	TerritoryID INTEGER NOT NULL,");
                    sqlQuery.Append("	FOREIGN KEY(EmployeeID) REFERENCES Employees");
                    sqlQuery.Append("	FOREIGN KEY(TerritoryID) REFERENCES Territories");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS Customers(");
                    sqlQuery.Append("	CustomerID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	CompanyName TEXT NOT NULL,");
                    sqlQuery.Append("	ContactName TEXT,");
                    sqlQuery.Append("	ContactTitle TEXT,");
                    sqlQuery.Append("	Address TEXT,");
                    sqlQuery.Append("	City TEXT,");
                    sqlQuery.Append("	Region TEXT,");
                    sqlQuery.Append("	PostalCode TEXT,");
                    sqlQuery.Append("	Country TEXT,");
                    sqlQuery.Append("	Phone TEXT,");
                    sqlQuery.Append("	Fax TEXT");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS Categories (");
                    sqlQuery.Append("    CategoryID	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("    CategoryName	TEXT NOT NULL,");
                    sqlQuery.Append("    Description	TEXT,");
                    sqlQuery.Append("    Picture	BLOB");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS Products (");
                    sqlQuery.Append("   ProductID	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("   ProductName	TEXT NOT NULL,");
                    sqlQuery.Append("   SupplierID	INTEGER,");
                    sqlQuery.Append("   CategoryID	INTEGER,");
                    sqlQuery.Append("   UnitPrice	NUMERIC NOT NULL,");
                    sqlQuery.Append("   QuantityPerUnit	TEXT,");
                    sqlQuery.Append("   UnitsInStock	INTEGER NOT NULL,");
                    sqlQuery.Append("   ReorderLevel	INTEGER NOT NULL,");
                    sqlQuery.Append("   Discontinued	INTEGER,");
                    sqlQuery.Append("   FOREIGN KEY(SupplierID) REFERENCES Suppliers,");
                    sqlQuery.Append("   FOREIGN KEY(CategoryID) REFERENCES Categories");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS CustomerDemographics(");
                    sqlQuery.Append("	CustomerTypeID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	CustomerDesc TEXT NULL");
                    sqlQuery.Append(" );");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS CustomerCustomerDemo(");
                    sqlQuery.Append("   CustomerCustomerDemoID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	CustomerID TEXT NOT NULL,");
                    sqlQuery.Append("	CustomerTypeID TEXT NOT NULL,");
                    sqlQuery.Append("   FOREIGN KEY(CustomerID) REFERENCES Customers,");
                    sqlQuery.Append("	FOREIGN KEY(CustomerTypeID) REFERENCES CustomerDemographics");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS Shippers(");
                    sqlQuery.Append("	ShipperID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	CompanyName TEXT NOT NULL,");
                    sqlQuery.Append("	Phone TEXT");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS Orders(");
                    sqlQuery.Append("	OrderID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,");
                    sqlQuery.Append("	CustomerID INTEGER,");
                    sqlQuery.Append("	EmployeeID INTEGER,");
                    sqlQuery.Append("	OrderDate BLOB,");
                    sqlQuery.Append("	RequiredDate BLOB,");
                    sqlQuery.Append("	ShippedDate BLOB,");
                    sqlQuery.Append("	ShipVia INTEGER,");
                    sqlQuery.Append("	Freight INTEGER,");
                    sqlQuery.Append("	ShipName TEXT,");
                    sqlQuery.Append("	ShipAddress TEXT,");
                    sqlQuery.Append("	ShipCity TEXT,");
                    sqlQuery.Append("	ShipRegion TEXT,");
                    sqlQuery.Append("	ShipPostalCode TEXT,");
                    sqlQuery.Append("	ShipCountry TEXT,");
                    sqlQuery.Append("	FOREIGN KEY(CustomerID) REFERENCES Customers,");
                    sqlQuery.Append("	FOREIGN KEY(EmployeeID) REFERENCES Employees,");
                    sqlQuery.Append("	FOREIGN KEY(ShipVia) REFERENCES Shippers");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE TABLE IF NOT EXISTS OrderDetails(");
                    sqlQuery.Append("	OrderID INTEGER NOT NULL,");
                    sqlQuery.Append("	ProductID INTEGER NOT NULL,");
                    sqlQuery.Append("	UnitPrice INTEGER NOT NULL,");
                    sqlQuery.Append("	Quantity INTEGER NOT NULL,");
                    sqlQuery.Append("	Discount REAL NOT NULL,");
                    sqlQuery.Append("	PRIMARY KEY (OrderID, ProductID)");
                    sqlQuery.Append("	FOREIGN KEY(OrderID) REFERENCES Orders,");
                    sqlQuery.Append("	FOREIGN KEY(ProductID) REFERENCES Products");
                    sqlQuery.Append(");");

                    sqlQuery.Append("CREATE INDEX IF NOT EXISTS `index_Categories` ON `Categories` (`CategoryID` ASC)");

                    conn.Execute(sqlQuery.ToString());
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
