using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ORM_Dapper;
using System.Data;

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

#region Department Section
//var departmentRepo = new DapperDepartmentRepo(conn);

//var departments = departmentRepo.GetAllDepartments();

//foreach (var department in departments)
//{
//    Console.WriteLine(department.DepartmentID);
//    Console.WriteLine(department.Name);
//    Console.WriteLine();
//    Console.WriteLine();
//}
#endregion

var productRepo = new DapperProductRepo(conn);

//var productToUpdate = productRepo.GetProduct(941);

//productToUpdate.Name = "UPDATED!!!";
//productToUpdate.Price = 23.99;
//productToUpdate.CategoryID = 1;
//productToUpdate.OnSale = false;
//productToUpdate.StockLevel = 53;

//productRepo.UpdateProduct(productToUpdate);

productRepo.DeleteProduct(941);


var products = productRepo.GetAllProducts();

foreach (var product in products)
{
    Console.WriteLine(product.ProductID);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.CategoryID);
    Console.WriteLine(product.OnSale);
    Console.WriteLine(product.StockLevel);
    Console.WriteLine();
    Console.WriteLine();
}