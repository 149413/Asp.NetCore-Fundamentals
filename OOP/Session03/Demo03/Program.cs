using Demo03.Interface_Ex02;

namespace Demo03
{
    internal class Program
    {
        #region Interface Ex02
        //static void Print10Series(SeriesByTwo SeriesByTwo)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{SeriesByTwo.Current} ");
        //        SeriesByTwo.Next();
        //    }
        //    Console.WriteLine();
        //    SeriesByTwo.Restart();

        //}
        //static void Print10Series(SeriesByThree SeriesByTwo)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{SeriesByTwo.Current} ");
        //        SeriesByTwo.Next();
        //    }
        //    Console.WriteLine();
        //    SeriesByTwo.Restart();

        //}
        //static void Print10Series(SeriesByFour SeriesByTwo)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{SeriesByTwo.Current} ");
        //        SeriesByTwo.Next();
        //    }
        //    Console.WriteLine();
        //    SeriesByTwo.Restart();

        //}

        static void Print10Series(ISeries Series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{Series.Current} ");
                Series.Next();
            }
            Console.WriteLine();
            Series.Restart();

        }
        #endregion

        static void Main(string[] args)
        {
            #region Revision
            // 00 Revision
            // 1. Class Vs. Struct
            // 2. Interface
            //  3. Polymorephism 
            // 1. Polymorephism Function OverLoading
            // 2. Polymorephism Function Overriding 
            #endregion

            #region Interface Ex01

            // Interface : Value Type
            // Contact between Developer Who Write It and Developer Who Will Use it.

            // IMyType myType = new IMyType();  // Cannot create an instance of the abstract class or interface 'interface'

            //Before Implement Methods
            //MyType myType = new MyType();

            // myType.MyFun();  // .NotImplementedException: 'The method or operation is not implemented.'
            // //myType.Print(); // MyType Class Doen't Contaians Function Print : As Its Implemente Method 

            // // After Implement Methods

            // MyType type = new MyType();

            // type.Salary = 2000;
            // Console.WriteLine(type.Salary);
            // type.MyFun();
            // // type.Print(); // Not found

            // IMyType ImyType;  // Binding
            // // Ref  --->  Refer To Object From Any Class Which Implement The Refrence 'IMyType' 
            // ImyType = new MyType();

            // ImyType.MyFun();
            // ImyType.Print();  // Valid

            #endregion

            #region Interface Ex02

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();
            //SeriesByFour seriesByfour = new SeriesByFour();

            //Print10Series(seriesByTwo);
            //Print10Series(seriesByThree);
            //Print10Series(seriesByfour); 


            //int[] nums = { 9, 1, 3, 12, 4, 6, 7, 8 };
            //Array.Sort(nums);

            //foreach (int i in nums)
            //{
            //    Console.Write($"{i} ");
            //}

            //Employee[] employee = new Employee[3]
            //{
            //    new Employee{Id = 1 , Name = "Omar" , Age = 30},
            //    new Employee{Id = 2 , Name = "Ahmed" , Age = 45},
            //    new Employee{Id = 3 , Name = "Ali" , Age = 20},
            //};

            //Array.Sort(employee);  // 'Failed to compare two elements in the array.'

            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine(emp);
            //}

            #endregion

            #region Interface Ex03
            //Car car = new Car();

            //car.Speed = 250;
            //Console.WriteLine(car.Speed);
            //car.Forward();
            //car.Backward();
            //car.Left();
            //car.Right();


            //AirPlane plane = new AirPlane();
            // Not Contain Any Methods or Properties

            //Console.WriteLine(plane.Speed);
            //plane.Backward();          Syntax Error
            //plane.Imovable.Backward(); Syntax Error


            //IMovable movable = new AirPlane();

            //movable.Speed = 300;
            //Console.WriteLine(movable.Speed);
            //movable.Forward();
            //movable.Right();

            //IFlyable flyable = new AirPlane();
            //flyable.Speed = 350;
            //Console.WriteLine(flyable.Speed);
            //flyable.Forward();
            //flyable.Right(); 


            // Note: This Example Show Role of Interface In Solving Diamond Problem ,
            // That Result in Multiple Inheritance

            #endregion


            #region Shallow Copy Vs. Deep Copy
            // // Shallow Copy Vs. Deep Copy

            // #region 1. By Value Type
            // //1.By Value Type

            // int[] Arr01 = { 1, 2, 3 };
            // int[] Arr02 = { 3, 4, 5 };
            // // Idetity(Address) + Oobject State(Data)

            // Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            // Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            // Console.WriteLine();

            // Arr02 = Arr01; // Shallow Copy
            //// Copy Identity
            // // { 1,2,3}
            // //--->Has Two References  Arr01 , Arr02
            // // { 4,5,6,}
            //// --->UnReachable Onject

            // Arr02 = (int[])Arr01.Clone(); // Deep Copy
            //// Clone Method Will Copy The Object State of The Caller(Arr01)
            //// Assiagne The New Object To Arr02, Will Generate New Identity

            // Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            // Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            // Arr02[0] = 100;
            // Console.WriteLine(Arr01[0]);
            #endregion

            #region 2. By Reference Type

            // 2. By Reference Type

            // 1. Imutable
            //string[] Arr01 = { "Ahmed", "Omar", "Ali" };
            //string[] Arr02 = { "Ziad", "Abdallah", "Amr" };

            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            //Console.WriteLine();

            //Arr02 = Arr01;  // Shallow Copy
            //                // Copy Identity (Address)

            //Arr02 = (string[])Arr01.Clone();  // Shallow Copy
            //// Copy Object State

            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Arr02[0] += " Ali";
            //Console.WriteLine(Arr01[0]);



            //2. Mutable
            //StringBuilder[] Arr01 = new StringBuilder[]
            //{
            //    new StringBuilder ( "Ahmed" ),
            //    new StringBuilder ( "Ahmed" ),
            //    new StringBuilder ( "Ahmed" )
            //  };

            //StringBuilder[] Arr02 = new StringBuilder[]
            //{
            //    new StringBuilder ( "Ziad" ),
            //    new StringBuilder ( "Omar" ),
            //    new StringBuilder ( "Amr" )
            //  };

            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            //Console.WriteLine();

            ////Arr02 = Arr01;  // Shallow Copy
            //// Copy Identity (Address)

            //Arr02 = (StringBuilder[])Arr01.Clone();  // Shallow Copy
            //// Copy Object State

            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Arr02[0] = new StringBuilder("Ahmed Ali");
            //Console.WriteLine(Arr01[0]);

            #endregion

#endregion


            #region Build-in Interface ICloneable
            //// ICloneable

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 20, Salary = 2000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Omar", Age = 30, Salary = 3000 };

            ////E02 = E01;  // Shallow Copy
            ////E02 = (Employee)E01.Clone(); // Deep Copy : By Clone()
            //E02 = new Employee(E01); // Deep Copy : By Copy Constructor

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());
            //E01.Salary = 5;
            //Console.WriteLine(E01);
            //Console.WriteLine(E02);


            //Console.WriteLine(); 
            #endregion


            #region Build-in Interface IComparable
            //Employee[] employee = new Employee[3]
            //    {
            //    new Employee{Id = 1 , Name = "Omar" , Age = 30, Salary = 11000},
            //    new Employee{Id = 2 , Name = "Ahmed" , Age = 27 , Salary = 12000},
            //    new Employee{Id = 3 , Name = "Ali" , Age = 20 , Salary = 13000},
            //    };

            //Array.Sort(employee);  // 'Failed to compare two elements in the array.'

            //int X = employee[0].CompareTo(employee[1]);
            //// +ve : Caller Greater Than Paameter 
            //// -ve : Caller Less Than Paameter 
            //// 0   : Caller Equal Paameter 

            //// Console.WriteLine(X);


            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine(emp);
            //} 
            #endregion


            #region Build-in Interface IComparable
            //Employee[] employee = new Employee[3]
            //   {
            //    new Employee{Id = 1 , Name = "Ali" , Age = 30, Salary = 12000},
            //    new Employee{Id = 2 , Name = "Ahmed" , Age = 27 , Salary = 13000},
            //    new Employee{Id = 3 , Name = "Omar" , Age = 20 , Salary = 11000},
            //   };

            ////Array.Sort(employee, new EmployeeComparerSalary());
            //Array.Sort(employee, new EmployeeComparerNameLength());



            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine(emp);
            //} 
            #endregion





        }
    }
}
