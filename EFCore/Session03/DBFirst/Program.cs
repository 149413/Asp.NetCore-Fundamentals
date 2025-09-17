using DBFirst.Data.Contexts;

namespace DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            #region Check

            //var category01 = new Category()
            //{
            //    CategoryName = "Handasa",
            //    Description = "Hello"
            //};

            //context.Categories.Add(category01);
            //context.SaveChanges();

            //var result = context.Categories;

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            #endregion

            #region  Run SQL Query 
            // Run SQL Query 
            // 1. Select Statements : FromSqlRaw() , FromSqlInterploated()

            //var result = context.Categories.FromSqlRaw("Select * from Categories");

            //var result = context.Products.FromSqlRaw("Select * From Products where UnitsInStock = 0");

            int Price = 10;
            //var result = context.Products.FromSqlRaw("Select * From Products where UnitsInStock > 10");

            //var result = context.Products.FromSqlRaw($"Select * From Products where UnitsInStock > {Price}");

            //var result = context.Products.FromSqlRaw("Select * From Products where UnitsInStock > {0}", Price);

            // FromSqlInterploated  : Support Only String InterPolation 

            //var result = context.Products.FromSqlInterpolated($"Select * From Products where UnitsInStock > {Price}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}



            // 2. DML Statements    : ExecuteSqlRaw() , FromSql Interploated()

            //var result = context.Database.ExecuteSqlRaw("Update Products Set UnitsInStock = 40 Where ProductID = 1");

            // Note : There is No Tracking hare

            //var result = context.Database.ExecuteSqlRaw("Delete From Products Where ProductID = 1");

            // ExecuteSqlInterpolated : Support Only String InterPolation 
            //var result = context.Database.ExecuteSqlInterpolated($"Update Products Set UnitsInStock = 39 Where ProductID = 1");

            #endregion





        }
    }
}
