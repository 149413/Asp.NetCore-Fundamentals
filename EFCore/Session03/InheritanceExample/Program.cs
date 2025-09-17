using InheritanceExample.Data;
using InheritanceExample.Models;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 Ways To Generate Schema
            // TPC  : Table Per Class
            // TPH  : Table Per Hirarchy
            // TPCC : Table Per Concret Class



            AppDbContext context = new AppDbContext();


            FullTimeEmployee fulltie01 = new FullTimeEmployee()
            {
                Name = "Ahemed Ali",
                Email = "AhmedAli@gmail.com",
                Address = "Cairo",

                Salary = 5000
            };

            FullTimeEmployee fulltie02 = new FullTimeEmployee()
            {
                Name = "Ahemed Hatem",
                Email = "AhmedHatem@gmail.com",
                Address = "Alex",

                Salary = 6000
            };

            FullTimeEmployee fulltie03 = new FullTimeEmployee()
            {
                Name = "Mariam",
                Email = "Mariam@gmail.com",
                Address = "Cairo",
                Salary = 9000


            };


            PartTimeEmployee partime01 = new PartTimeEmployee()
            {
                Name = "Samy Mohamed",
                Email = "SamyMohamed@gmail.com",
                Address = "Alex",

                NumberOfHours = 3,
                HourReate = 6

            };
            PartTimeEmployee partime02 = new PartTimeEmployee()
            {
                Name = "Ziad Ali",
                Email = "ZiadAli@gmail.com",
                Address = "Cairo",

                NumberOfHours = 2,
                HourReate = 5

            };



            // 1. TCH 
            //context.FullTimeEmployees.Add(fulltie01);
            //context.FullTimeEmployees.Add(fulltie02);
            //context.FullTimeEmployees.Add(fulltie03);


            //context.PartTimeEmployees.Add(partime01);
            //context.PartTimeEmployees.Add(partime02);

            //context.SaveChanges();


            //foreach (var employee in context.FullTimeEmployees)
            //{
            //    Console.WriteLine(employee.Name);
            //}


            // =======================================================================

            // TPH 2
            //context.Employees.Add(fulltie01);
            //context.Employees.Add(fulltie02);
            //context.Employees.Add(fulltie03);

            //context.Employees.Add(partime01);
            //context.Employees.Add(partime02);


            //context.SaveChanges();


            //context.Employees.Where(E => E.Desc)  ??

            //var result = context.Employees.OfType<FullTimeEmployee>();
            //var result = context.Employees.OfType<PartTimeEmployee>();

            //foreach (var employee in result)
            //{
            //    Console.WriteLine(employee.Name);
            //}

            // =======================================================================

            // 2. TPC

            //context.Employees.Add(fulltie01);
            //context.Employees.Add(fulltie02);
            //context.Employees.Add(fulltie03);

            //context.Employees.Add(partime01);
            //context.Employees.Add(partime02);

            //context.SaveChanges();


            //foreach (var item in context.FullTimeEmployees)
            //{
            //    Console.WriteLine(item.Name);
            //}


            // =======================================================================
            //3. TPCC


            //context.FullTimeEmployees.Add(fulltie01);
            //context.FullTimeEmployees.Add(fulltie02);
            //context.FullTimeEmployees.Add(fulltie03);

            //context.PartTimeEmployees.Add(partime01);
            //context.PartTimeEmployees.Add(partime02);

            //context.SaveChanges();


            //foreach (var item in context.FullTimeEmployees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Console.WriteLine("\n");

            //foreach (var item in context.PartTimeEmployees)
            //{
            //    Console.WriteLine(item.Name);
            //}


        }
    }
}
