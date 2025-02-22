using DB_First.Data.Contexts;
using DB_First.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace DB_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using AppDbContext context = new AppDbContext();

            #region DB First
            //Category category = new Category()
            //{
            //    CategoryName = "sssss",
            //    Description = "hhhhhhhh"
            //};

            //context.Categories.Add(category);

            //context.SaveChanges(); 
            #endregion

            #region Run SQL Query
            //var result = context.Products.FromSqlRaw("Select * From Products Where UnitsInStock = 0");

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.ProductName);
            //}

            //context.Database.ExecuteSqlRaw("Update Products Set UnitsInStock = 40 Where ProductId =1"); 
            #endregion
        }
    }
}
