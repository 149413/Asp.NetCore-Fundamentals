using Demo02.Binding;

namespace Demo02
{
    internal class Program
    {
        #region Method OverLoading
        static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        static int Sum(int X, int Y)
        {
            return X + Y;
        }
        static double Sum(double X, double Y)
        {
            return X + Y;
        }
        static double Sum(int X, double Y)
        {
            return X + Y;
        }
        static double Sum(double X, int Y)
        {
            return X + Y;
        }

        #endregion

        #region When U Need Binding
        public static void EmployeeProcess(Employee Emp)
        {
            if (Emp is not null)
            {
                Emp.Fun01();
                Emp.Fun02();
            }
        }
        #endregion


        static void Main(string[] args)
        {
            #region Revision

            // 00 Revision

            //1. Struct : Value Type : STACK
            //2. OOP:

            // Pilars
            //1. Encasolation
            // 1.1. Make All Attributes Private

            // 1.2. Creating By Setter & Getter Functions
            // 1.2. or By Properties Functions
            // [Full Properties - Automatic Properties - Special Properties (Index)]

            //2. Inheritance
            //3. Polymorphism
            //4. Abstraction

            //3. Class :Reference Type : HEAP 
            #endregion

            #region Inheritance
            // Inheritance:

            //X---> Y
            // The  Principal Inheritance :
            //1. Aceive Principle DRY ---> Don't Repeat Yorself
            //2. Class Don't Allow multiple Inheritance ==> Child1, Child2 -----> Parent XXX
            //3. Class Allow Multi-Level Inheritance  ==> child2 --> child1 --> Parent

            //Parent P = new Parent(1, 2);

            ////Console.WriteLine(P);

            ////P.Fun01();
            ////P.Fun02();


            //Child C = new Child(1, 2, 3);
            ////Console.WriteLine(C);

            ////C.Fun01();
            ////C.Fun02();


            //Parent C2 = new Child(1, 2, 3);

            //Console.WriteLine(C2);

            //C2.Fun01();  // From Parent
            //C2.Fun02(); // From Parent

            #endregion


            #region Polymorephism
            //3. Polymorephism 
            // 3.1. Polymorephism Methods (Functions) Overloading
            // 3.2. Polymorephism Methods (Functions) Overriding

            //// Ex.
            //Console.WriteLine(); 
            #endregion

            #region 3.1. Polymorephism Methods (Functions) Overloading
            //// 3.1. Polymorephism Methods (Functions) Overloading
            //// There are More than functions With The same NAME [in The Same Scope [Class - Struct]] 
            //// Thesee Have The Different Signature(Count - Name - Type)


            //Sum(1, 2, 3);
            //Sum(1, 2);
            //Sum(2.4, 3.5);
            //Sum(1.5, 1); 
            #endregion

            #region  3.2. Polymorephism Methods (Functions) Overriding
            //// 3.2. Polymorephism Methods (Functions) Overriding
            //// There is more than one Functions [in the differnt Classes]
            //// they have the Same Segnature But with Different Behavior

            //TypeB typeB = new TypeB() { A = 12, B = 13 };

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //typeB.Func01();
            //typeB.Func02(); 
            #endregion


            #region What is The Binding ? 
            //// Binding
            ////What is The Binding ? 
            ////ReferenceType -- (point to )---> Objec Type

            TypeA Ref;
            //Ref = new TypeA();
            Ref = new TypeB(); // Binding

            Ref.A = 12;
            //Ref.B = 13; // Not found

            Ref.Fun01(); // Static Binded Methods  (At Compile time)
            Ref.Fun02(); // Dynamic Binding Methods (At Run Time) 
            #endregion

            #region  Not Binding 
            // What is Not The Binding ?

            // Binding
            // ReferenceType ---> ObjectType

            //TypeA Ref;
            //Ref = new TypeA();
            //Ref = new TypeB(); // Bnding

            //Child is a parent

            //TypeB Ref;
            //Ref = new TypeB();
            //Ref = new TypeA(); // Error

            // Parent is a Child (possible)

            // Animal ---> Dog : Dog is a Animal 
            // Dog -> (Dog) Animal : animal is a Dog


            //TypeA Ref = new TypeB();
            //Ref = new TypeB();

            //TypeB typeB = (TypeB)Ref; // UnBinding : (Explicit Casting) 
            #endregion

            #region When U Need Binding ??
            //// When U Need Binding ??

            //// FullTime Employee
            //// Id , Name , Email , Address , Salary

            //FullTimeEmployee fullEmployee = new FullTimeEmployee()
            //{
            //    Id = 123,
            //    Name = "Ali",
            //    Email = "Ali23@gmail.com",
            //    Address = "Cairo",
            //    Salary = 5000
            //}
            //;

            ////FullTimeEmployee fullEmployee = null;


            //EmployeeProcess(fullEmployee);

            //// PartTime Employee 
            //// Id , Name , Email , Address , HourRate , Nuber Of Hours

            //PaertTimeEmployee partEmployee = new PaertTimeEmployee()
            //{
            //    Id = 123,
            //    Name = "Ahmed",
            //    Email = "Ahmed23@gmail.com",
            //    Address = "Cairo",
            //    HourRate = 200,
            //    NumberofHours = 300
            //};

            //EmployeeProcess(partEmployee); 
            #endregion


            #region Example  Binding
            //TypeA typeA = new TypeA();
            //typeA = new TypeB();    // TypeA Parent of typeB
            //typeA = new TypeC();    // TypeA Indirect Parent of typeC
            //typeA = new TypeD();    // TypeA Indirect Parent of typeD
            //typeA = new TypeE();    // TypeA Indirect Parent of typeE

            //typeA.A = 12;
            ////typeA.B = 13;
            ////typeA.C = 14;
            ////typeA.D = 15;


            //typeA.Fun01(); // From A
            //typeA.Fun02();// From C Last override

            //// New Serial from override
            //TypeD typeD = new TypeD();
            //typeD = new TypeE();    // TypeD Parent of typeE


            //typeD.Fun01(); // from D
            //typeD.Fun02(); // From E Last Override

            #endregion



            // Note:

            #region Task_02 [Access Protected Modifiers]

            //Other_DerivedClass derivedClass = new Other_DerivedClass();
            //derivedClass.Show();

            //Console.WriteLine();

            //Other_UN_DerivedClass un_derivedClass = new Other_UN_DerivedClass();
            //un_derivedClass.Show();




            #endregion

        }
    }
}
