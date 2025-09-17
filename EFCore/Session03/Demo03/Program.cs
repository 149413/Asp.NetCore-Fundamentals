using Demo03.Data;

namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();


            #region Data
            //var department = new List<Department>()
            //{
            //    new Department() {  Name = "HR"},
            //    new Department() {  Name = "PR"},
            //    new Department() {  Name = "IT"},

            //};


            //var employee = new List<Employee>()
            //{
            //    new Employee(){Name = "Ahmed Ali" , Address = "Cairo" , Age = 29 , Salary = 12000 , Dept_Id = 100},
            //    new Employee(){Name = "Omar Ali" , Address = "Giza" , Age = 32 , Salary = 15000 , Dept_Id = 100},
            //    new Employee(){Name = "Mona Ali" , Address = "Cairo" , Age = 25 , Salary = 13000 , Dept_Id = 100},
            //    new Employee(){Name = "Ahmed Khalid" , Address = "Nasr City" , Age = 30 , Salary = 17000 , Dept_Id = 200},
            //    new Employee(){Name = "Mariam Ahmed" , Address = "Alex" , Age = 24 , Salary = 10000 , Dept_Id = 200},
            //    new Employee(){Name = "Maha Ahmed" , Address = "Alex" , Age = 25 , Salary = 14000 , Dept_Id = 300},
            //    new Employee(){Name = "Mohamed Ali" , Address = "Cairo" , Age = 33 , Salary = 18000 , Dept_Id = 100},

            //}; 
            #endregion

            #region Loading  Navigation Property
            //context.AddRange(department);
            //context.AddRange(employee);

            //context.SaveChanges();


            //var employee = context.Employees.FirstOrDefault(E => E.Id == 10);


            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);

            //Console.WriteLine(employee?.Dept_Id ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA"); // Null


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item?.Name ?? "NA");
            //}





            // Note : EF Core Dont't Loading Any Navigation Property

            // 3 Ways tos To Load Navigation Property
            // 1- Explicit Loading
            // 2- Eager Loading
            // 3- Lazy Loading


            #region Explicite Loading
            //1. Explicite Loading

            //var employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            //context.Entry(employee).Reference("WorkFor").Load();
            //context.Entry(employee).Reference(nameof(Employee.WorkFor)).Load();

            //context.Entry(employee).Reference(E => E.WorkFor).Load(); // Best practice



            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);

            //Console.WriteLine(employee?.Dept_Id ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA"); // HR



            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            //context.Entry(department).Collection(nameof(department.Employees)).Load();
            //context.Entry(department).Collection(D => D.Employees).Load();

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item?.Name ?? "NA");
            //}

            #endregion


            #region  Eager Propety
            // 2. Eager Propety

            //var employee = context.Employees.Include(E => E.WorkFor).FirstOrDefault(E => E.Id == 10);


            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);

            //Console.WriteLine(employee?.Dept_Id ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA"); // HR


            //var department = context.Departments.Include(D => D.Employees).FirstOrDefault(D => D.Id == 100);


            //////If there is More Than Naviigation Property(Relation)
            ////var department = context.Departments.Include(D => D.Employees).Include()FirstOrDefault(D => D.Id == 100);

            ////// Iif There Is Nested Navigation [Navigation Inside Navig] 
            ////var department = context.Departments.Include(D => D.Employees).ThenInclude().FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item?.Name ?? "NA");
            //}

            #endregion


            #region Lazy Property
            // 3. Lazy Loading
            // 3.1. Install Pakage Proxies
            // 3.2. Update OnCongfiguring(), UseLazyLoadingProxies
            // 3.2. Make All Entities Public
            // 3.3  Make All Navogational Properties Virtual 


            //var employee = context.Employees.FirstOrDefault(E => E.Id == 10);


            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);

            //Console.WriteLine(employee?.Dept_Id ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA"); // HR


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item?.Name ?? "NA");
            //} 
            #endregion
            #endregion

            #region Join Operator - inner Operator
            // Join Operator - inner Operator

            //var result = context.Employees.Join(context.Departments, E => E.Dept_Id, D => D.Id, (E, D) => new
            //{
            //    EmpId = E.Id,
            //    EmpName = E.Name,
            //    DeptId = D.Id,
            //    DeptName = D.Name
            //}).Where(D => D.DeptName == "HR");


            //var result = from E in context.Employees
            //             join D in context.Departments
            //             on E.Dept_Id equals D.Id
            //             where D.Name == "HR"
            //             select new
            //             {
            //                 EmpId = E.Id,
            //                 EmpName = E.Name,
            //                 DeptId = D.Id,
            //                 DeptName = D.Name
            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Tracking && NoTracking
            // Tracking && NoTracking

            //var result = context.Employees.FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(context.Entry(result).State); // Unchanged  : Tracked By Context
            //result.Name = "Omar"; // Local
            //Console.WriteLine(context.Entry(result).State); // Modified

            //Console.WriteLine(result.Name);
            //context.SaveChanges();

            //// To Avoid Traking
            //var result = context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(context.Entry(result).State); // Detached  : Not Tracked By Context
            //result.Name = "Omar"; // Local
            //Console.WriteLine(context.Entry(result).State); // Detached

            //Console.WriteLine(result.Name);
            //context.SaveChanges();

            #endregion

            #region Remote & Local
            // Remote & Local

            // Remotly
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();
            //var result = context.Employees.Any();

            //context.Employees.Load();

            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();
            //var result = context.Employees.Local.Any();



            #endregion




            #region  Maping View
            //// Maping View

            //var result = context.DepaermentManagers.FromSqlRaw("Select * from DepartmentManagersView");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.DeptName);
            //} 
            #endregion




        }
    }
}
