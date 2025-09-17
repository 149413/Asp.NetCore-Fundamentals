using Assiagn01.Models;
//using System.Drawing;

namespace Assiagn01
{
    internal class Program
    {
        #region Q1

        static Point Addpoint()
        {
            Point p = new();
            Console.WriteLine($"Enter Point: ");
            Console.Write($"X: ");
            p.X = int.Parse(Console.ReadLine());
            Console.Write($"Y: ");
            p.Y = int.Parse(Console.ReadLine());

            return p;
        }

        static double Distance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);

        }
        #endregion

        #region Q02
        static Person AddPerson()
        {
            Person P = new();
            Console.Write("Name: ");
            P.Name = Console.ReadLine();
            Console.Write("Age: ");
            P.Age = int.Parse(Console.ReadLine());

            return P;
        }


        #endregion

        // ---------------  Part 02 ----------------

        #region Part02
        [Flags]
        enum Permissions : byte
        {
            None = 0,
            Read = 1,
            Write = 2,
            Execute = 4,
            Delete = 8,
        }

        #endregion


        static void Main(string[] args)
        {

            // ---------------------------------------------------------- Part 01 -------------------------------------------------------


            #region Q1
            /*1.Create a struct called "Point" to represent a 2D point with properties "X" and 
            "Y". Write a C# program that takes two points as input from the user and 
            calculates the distance between them.*/

            //Point P01 = new();
            //Point P02 = new();

            //P01 = Addpoint();
            //P02 = Addpoint();
            //Console.WriteLine($"Distance: {Distance(P01, P02)}");

            #endregion


            #region Q02
            /*2.Create a struct called "Person" with properties "Name" and "Age". Write a C# 
                program that takes details of 3 persons as input from the user and displays the
                name and age of the oldest person.*/

            //Person[] persons = new Person[3];
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Person{i + 1}: ");
            //    persons[i] = AddPerson();
            //}
            //int idx = 0;
            //int oldPerson = 1;
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > oldPerson)
            //    {
            //        oldPerson = persons[i].Age;
            //        idx = i;
            //    }
            //}
            //Console.WriteLine("Data Of Oldest Person");
            //Console.WriteLine($"Name: {persons[idx].Name}");
            //Console.WriteLine($"Age: {persons[idx].Age}");

            #endregion


            // ---------------------------------------------------------- Part 02 -------------------------------------------------------
            /* 1.Design and implement a Class for the employees in a company: 
             Notes: 
             ● Employee is identified by an ID, Name, security level, salary, hire date and Gender.
             ● We need to restrict the Gender field to be only M or F[Male or Female]  
            // ● Assign the following security privileges to the employee(guest,
             Developer, secretary and DBA) in a form of Enum.
             ● We want to provide the Employee Class to represent Employee data in a
             string Form(override ToString()), display employee salary in a currency
             format. [Use String.Format() Function].*/



            //// HiringDate date = new HiringDate();
            // date.Day = 10;
            // date.Month = 1;
            // date.Year = 2020;
            // Console.WriteLine(date);


            /* 0.Develop a Class to represent the Hiring Date Data: 
             ● Consisting of fields to hold the day, month and Years.
             0.
             Create an array of Employees with size three a DBA, Guest and
             the third one is security officer who have full permissions. (Employee
             [] EmpArr;) 
             Notes:
             ● Implement All the Necessary Member Functions on the Class
             (Getters, Setters)
             ● Define all the Necessary Constructors for the Class 
             ● Allow NO RUNTIME errors if the user inputs any data 
             ● Write down all the necessary Properties(Instead of setters
             and getters)*/



            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "Ali", 15000m, new HiringDate(1, 5, 2023), 'M', Role.DBA);

            //EmpArr[1] = new Employee(2, "Mona", 5000m, new HiringDate(10, 6, 2024), 'F', Role.Guest);

            //EmpArr[2] = new Employee(3, "Karim", 12000m, new HiringDate(20, 7, 2022), 'M', Role.Officer);


            //foreach (var item in EmpArr)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("\n");
            //}





        }
    }
}
