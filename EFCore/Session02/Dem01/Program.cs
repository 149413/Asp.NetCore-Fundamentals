using Dem01.Contexts;
namespace EFCore.Dem01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Revision
            // EF - ORM in .NET
            // ORM : Object Relation Mapping

            // 1. Mapping
            // Code First [Generate Table Per Class]
            // DB first   [Generate Class Per Table]

            // 3 Ways Generate
            // 1. TPC : Table Per Class
            // 2. TPH : Table per Hierarchy
            // 3. TPCC: Table per Concrate Class 
            #endregion


            #region CRUD Operations

            // CRUD 

            //AppDbContext context = new AppDbContext();

            #region Open Channel With DB

            // Open Channel With DB

            //// 1. 
            //try
            //{
            //    // CRUD
            //}
            //finally
            //{
            //    context.Dispose(); // Close connection
            //}


            //// 2. 
            //using (AppDbContext context = new AppDbContext())
            //{
            //    // CRUD
            //}

            // 3.
            //using AppDbContext context = new AppDbContext();
            //// CRUD

            #endregion

            #region Create - Insert
            ////1. Create - Insert

            //Employee employee = new Employee()
            //{
            //    Name = " Abdullah",
            //    Salary = 5000,
            //    Email = "Abd@gmail.com",
            //    Age = 27,

            //};

            ////employee.Name = "Omar";

            //Console.WriteLine(context.Entry(employee).State); // Detached
            ////context.Add(employee);
            //context.Employees.Add(employee);

            //Console.WriteLine(context.Entry(employee).State); // Added

            //var Result = context.SaveChanges(); // Return: Number Of Changes

            //Console.WriteLine(context.Entry(employee).State); // UnChanged

            //employee.Name = "Ahmed";

            //Console.WriteLine(context.Entry(employee).State); // Modified


            //Console.WriteLine(Result);

            //// By Brief
            //context.Employees.Add(employee);
            //context.SaveChanges();

            #endregion

            #region Retrieve / Read - Select

            // 2. Retrieve / Read - Select

            //using AppDbContext context = new AppDbContext();

            //var result = context.Employees.Where(E => E.EmpId == 10);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = context.Employees.Where(E => E.EmpId == 10).FirstOrDefault();
            //var result = context.Employees.FirstOrDefault(E => E.EmpId == 10);
            //Console.WriteLine(result?.Name);
            //Console.WriteLine(result?.EmpId);

            //Console.WriteLine(context.Entry(result).State);
            //result.Name = "Hazem";
            //Console.WriteLine(context.Entry(result).State);

            //var result = context.Employees.Select(E => E.Name);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Update

            // Update

            //AppDbContext context = new AppDbContext();

            //var emp = context.Employees.FirstOrDefault(E => E.EmpId == 10);
            //Console.WriteLine(emp);
            //Console.WriteLine(context.Entry(emp).State); // Unchanged
            ////emp.Name = "Seliem";  // Update In Memory  && Change The State
            //context.Update(emp); // Only Change The State
            //Console.WriteLine(context.Entry(emp).State); // Modified
            ////Console.WriteLine(emp.Name);
            ////var emp2 = context.Employees.FirstOrDefault(E => E.EmpId == 10);  // Fetch From Memory 
            ////Console.WriteLine(emp2);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(emp).State); // Unchanged 
            #endregion

            #region Deleted
            // Delete


            AppDbContext context = new AppDbContext();

            //var emp = context.Employees.FirstOrDefault(E => E.EmpId == 5);

            //Console.WriteLine(context.Entry(emp).State); // Unchanged

            //context.Remove(emp);

            //Console.WriteLine(context.Entry(emp).State); // Deleted --> The Object Marked By Flag  

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(emp).State); // Detached --> Obj become Not Tracked By context

            // Remove Range

            //var Names = context.Employees.Where(E => E.Name == "Omar");

            //context.RemoveRange(Names);

            //var result = context.SaveChanges();

            //Console.WriteLine(result);
            #endregion


            #endregion


        }
    }
}





