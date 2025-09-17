namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Genaric :
            // C3 Feature 2005 C3 2.0
            //  Before 2005 Class Object

            #region Genaric Ex01 : SWAP
            #region Non Genaric SWAP
            // Non Genaric Swap
            //int A = 1;
            //int B = 2;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("******* After SWAP  *******");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");



            //double A = 1.5;
            //double B = 2.8;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("******* After SWAP  *******");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //// Point X , Y
            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(2, 3);
            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");
            //Console.WriteLine("******* After SWAP  *******");
            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");

            #endregion

            #region Genaric SWAP
            ////Non Genaric Swap
            //int A = 1;
            //int B = 2;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("******* After SWAP  *******");
            //Helper.SWAP/*<int>*/(ref A, ref B);
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");



            //double A = 1.5;
            //double B = 2.8;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("******* After SWAP  *******");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //// Point X , Y
            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(2, 3);
            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");
            //Console.WriteLine("******* After SWAP  *******");
            //Helper.SWAP/*<Point>*/(ref P01, ref P02);
            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");


            //// By Genaric Class [Need Tyo Call It]
            //// Point X , Y
            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(2, 3);
            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");
            //Console.WriteLine("******* After SWAP  *******");
            //Helper<Point>.SWAP(ref P01, ref P02);
            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}"); 
            #endregion

            #endregion

            #region Genaric Ex02 : Linear Search
            // Linear Search Algo
            //Array : 4 5 2 11 12 13 -1 -12 10 6

            //int[] array = { 4, 5, 2, 11, 12, 13, -1, -12, 10, 6 };
            //int idx = Helper.LinearSearch(array, 100);

            //Console.WriteLine($"index: {idx}");


            //// Employee :: Id , Name , Age , Salary
            //Employee E01 = new Employee() { Id = 1, Name = "Ali", Age = 25, Salary = 3000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ahmed", Age = 30, Salary = 3500 };
            //Employee E03 = new Employee() { Id = 3, Name = "Samy", Age = 27, Salary = 4000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Age = 35, Salary = 6000 };

            //Employee[] Emp = { E01, E02, E03, E04 };

            //int idx = Helper.LinearSearch(Emp, E03);

            //Console.WriteLine($"index: {idx}");


            //Console.WriteLine(E01 == E02); 
            #endregion

            #region Equality in Class or Struct [Equal() | ==]
            // Employee
            // Equality:
            //'Class' HasEqual Function Which Inherit From Object Class ==> Compare Reference
            //'Struct' HasEqual Function Which Inherit From Object Class ==> Compare Data
            // Note : 'Stuct' Don't Have Implementation For The == Operator

            //// Equality in Class or Struct [Equal() - ==]


            //// Employee :: Id , Name , Age , Salary
            //Employee E01 = new Employee() { Id = 1, Name = "Ali", Age = 25, Salary = 3000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ali", Age = 25, Salary = 3000 };
            //Employee E03 = new Employee() { Id = 2, Name = "Ahmed", Age = 30, Salary = 3500 };


            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());


            //if (E01.Equals(E02))
            //{
            //    Console.WriteLine("E01 = E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01 != E02");
            //}


            //if (E01 == E02)
            //{
            //    Console.WriteLine("E01 == E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01 != E02");
            //} 
            #endregion

            #region Genaric Ex03 : Bubble Sort
            //// BubbleSort
            //int[] Array = { 4, 5, 5, 7, 10, 11, 8, 9, 6, -1, 22 };
            //Helper.PrintArray(Array);
            //Console.WriteLine("======= After Sort =======");
            //Helper.BubbleSort(Array);
            //Helper.PrintArray(Array);

            //// Point
            //Point[] points =
            //    {
            //        new Point(2,4),
            //        new Point(2,3),
            //        new Point(4,4),
            //        new Point(3,1),
            //        new Point(2,2),
            //        new Point(1,1)
            //    };
            //Helper.PrintArray(points);
            //Console.WriteLine(value: "=========== After Sort ===========");
            //Helper.BubbleSort(points);
            //Helper.PrintArray(points); 

            //// Employee
            //Employee E01 = new Employee() { Id = 1, Name = "Ali", Age = 25, Salary = 3000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ahmed", Age = 30, Salary = 3500 };
            //Employee E03 = new Employee() { Id = 3, Name = "Samy", Age = 27, Salary = 4000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Age = 35, Salary = 6000 };

            //Employee[] Emp = { E01, E02, E03, E04 };
            //Helper.PrintArray(Emp);
            //Console.WriteLine(value: "============== After Sort =============");
            //Helper.BubbleSort(Emp);
            //Helper.PrintArray(Emp);


            #endregion

            #region is && as Casting Operator  
            // is And as Operator In handle Casting

            //Point P01 = new(1, 2);
            //Point P02 = new(1, 3);

            //if (P01.CompareTo("P02") > 0)
            //    Console.WriteLine("P01 is Greater Than P02");
            //else
            //    Console.WriteLine("P02 is not Greater Than P02"); 
            #endregion

            #region Non Genaric IComparable && Genaric IComparable
            //// Point
            //Point[] points =
            //    {
            //        new Point(2,4),
            //        new Point(2,3),
            //        new Point(4,4),
            //        new Point(3,1),
            //        new Point(2,2),
            //        new Point(1,1)
            //    };
            //Helper.PrintArray(points);
            //Console.WriteLine(value: "=========== After Sort ===========");
            //Helper.BubbleSort(points);
            //Helper.PrintArray(points);

            //// Employee
            //Employee E01 = new Employee() { Id = 1, Name = "Ali", Age = 25, Salary = 3000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ahmed", Age = 30, Salary = 3500 };
            //Employee E03 = new Employee() { Id = 3, Name = "Samy", Age = 27, Salary = 4000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Age = 35, Salary = 6000 };

            //Employee[] Emp = { E01, E02, E03, E04 };
            //Helper.PrintArray(Emp);
            //Console.WriteLine(value: "============== After Sort =============");
            //Helper.BubbleSort(Emp);
            //Helper.PrintArray(Emp); 
            #endregion

            #region Buil-in Interface Genaric IEquatable
            // Buil-in Interface  IEquatable


            //// Employee :: Id , Name , Age , Salary
            //Employee E01 = new Employee() { Id = 1, Name = "Ali", Age = 25, Salary = 3000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ali", Age = 25, Salary = 3000 };
            //Employee E03 = new Employee() { Id = 2, Name = "Ahmed", Age = 30, Salary = 3500 };


            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());


            //if (E01.Equals(E03))
            //{
            //    Console.WriteLine("E01 == E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01 != E02");
            //} 
            #endregion

            #region Build-in Genaric IEqualityComparer
            //// Employee :: Id , Name , Age , Salary
            //Employee E01 = new Employee() { Id = 1, Name = "Ali", Age = 25, Salary = 3000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ahmed", Age = 30, Salary = 3500 };
            //Employee E03 = new Employee() { Id = 3, Name = "Samy", Age = 27, Salary = 4000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Age = 35, Salary = 6000 };

            //Employee[] Emp = { E01, E02, E03, E04 };

            ////int idx = Helper.LinearSearch(Emp, new Employee() { Id = 2, Name = "Ahmed", Age = 30, Salary = 3500 });
            //int idx = Helper.LinearSearch(Emp, new Employee() { Name = "Ahmed" }, new EmployeeICompatableCompare());

            //Console.WriteLine($"index: {idx}"); 
            #endregion

            #region Genaric Icomparer Wih bubble Sort

            // Employee
            //Employee E01 = new Employee() { Id = 1, Name = "Ali", Age = 25, Salary = 3000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ahmed", Age = 30, Salary = 3500 };
            //Employee E03 = new Employee() { Id = 3, Name = "Samy", Age = 27, Salary = 4000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Age = 35, Salary = 6000 };

            //Employee[] Emp = { E01, E02, E03, E04 };
            //Helper.PrintArray(Emp);
            //Console.WriteLine(value: "============== After Sort =============");
            ////Helper.BubbleSort(Emp);
            ////Helper.BubbleSort(Emp, new EmployeeIcomparerSalary());
            //Helper.BubbleSort(Emp, new EmployeeIcomparerNameLength());
            //Helper.PrintArray(Emp);

            //// Array.Sort()

            #endregion

            #region GenaricConstains

            // Helper class

            #endregion

        }
    }
}