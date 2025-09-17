// Code => Function => Class => NameSpace

namespace C_Basic01G02
{
    //class point
    //{
    //    public int x;
    //    public int y;
    //}
    class Program
    {
        static void Main()
        {
            // code

            #region 1.Revision
            //Console.WriteLine("Hellow World From Main");
            //Console.WriteLine("Hellow World From Main");
            //Console.WriteLine("Hellow World From Main");
            //Console.WriteLine("Hellow World From Main");
            //Console.WriteLine("Hellow World From Main");
            //Console.WriteLine("Hellow World From Main"); 
            #endregion

            #region 2.Variable
            // Variable
            //  Variable Declaration
            // LogLocation in Memory Used For Store Data
            // 
            // Declare Variable
            // Datatype VariableName;


            int Number;
            // Allocate Uninitialized 4 Bytes at Memory (RAM)

            // Console.WriteLine(Number);  // InValid
            // Note: U Can't Use UnAssiagned Local Variable 

            Number = 5;
            // Console.WriteLine(Number); // 5 


            // Variable
            // 1. Name      : Number
            // 2. DataType  : int
            // 3. Size      : 4 Byte
            // 4. Value     : 5
            // 5. Address   : 0FxA7 (0-9  A-Z)


            //int Number; // InValid

            //int Number1;
            //int Number2;
            //int Number3;

            // int Number1 = 3, Number2 = 5, Number3 = 10;

            //int int;   inValid 
            //int if;    inValid 
            //int class; inValid 

            #endregion

            #region 3. CTS & CLS
            // CTS ===> Common Type  System
            // CLs ===> Common Language System  
            // Rreturn to Vedieo 
            #endregion

            #region 4. Stack VS Heap
            // Stack        &       Heap
            //   Value Type Vs        Referance Type
            //   Fixed Size Vs        Dynamic Size
            //   Size Smaller Than    Size Greater Tgan 
            //   Heep                 Stack
            //   Access Data Faster    Access Data Slower

            #endregion

            #region 5. DataTypes
            // DataTypes
            // 1. Value DataType
            //      1. Struct
            //      2. Enum
            // 2. Referance DataType
            //      1. Class
            //      2. Interface

            // Note : DataType Can Be
            //       1. Build-in DataType 
            //       2. User-Defined DataType


            // Build-in DataType (Value Type) - Struct

            /*
           1. byte  1 byte
           2. Short 2 bytes
           3. int   4 bytes
           4. long  8 bytes

           1. float   4 bytes
           2. double  8 bytes
           3. Decimal 16 bytes

           1.  bool (True - False)

           2. Char 'A' 2 bytes

           3. Datatime 16 bytes

            */


            // Build-in DataType (Referance Type) - Class
            /*
             1. String
             2. Array
             3. Object
             4. Delegate

             */
            #endregion


            #region 6. Value Type - STACK
            // Value type - STACK

            // Number1; // C# KeyWord
            // Declare UnInitialized 4 bytes in SACK
            // Console.WriteLine(Number); // InValid
            // Number1= 10;
            //Console.WriteLine(Number1);


            // Int32 Number02 = 12;
            // Int32 :BCL KeyWord
            //Console.WriteLine(Number02);
            //Number02 = Number1;

            #endregion


            #region Referance Type - HEAP
            // Point P01;
            // Declare Refereance (Pointer) To point To Object From Type (Point)
            //  P01 : Can Refere or point To Any Object(Instance) From Type "Point"
            //  P01 : Now Refer to Null


            // 8 Bytes will Be Allocated At STACK For The Reference 'P01'
            // 0 Bytes Will Bee Allcoted in HEAP




            //P01 = new Point();


            // Console.WriteLine(P01.X);  // 0
            //Console.WriteLine(P01.Y);  // 0

            // P01.X = 12;
            // Console.WriteLine(P01.X);
            /*
             * New Keyword 
             1. Allocate Number Of Required Bytes  That  object Need At Heap ((x,y) 8 Bytes +). 
             2. initialized The Allocated Bytes At heap With the Dafault Value of DataType
             3. Call User-Default Constructor if Exists.
             4. Make Referance or Pointer 'P01' point to The Object .
            */

            //Point P02 = new Point();
            //   P02 = P01;
            //   Console.WriteLine(P01.X);
            //   Console.WriteLine(P02.X) 
            #endregion;

            #region 8. Object
            // Object is The Parent Class for Another Data Type  
            // Like Template in C++

            //object Ob;
            // Declare Referance From Type "Object"
            // Ob: Referance Can Refer To Any (Instance)From Type "Object" or Any Data Type Inherited From "Object"
            // Ob: now point to Null


            //Ob = new object();
            //Ob = 1;
            //Ob = 2.75;
            //Ob = 'A';
            //Ob = true;
            //Ob = "Hello";
            //Ob = new Point();  

            //Console.WriteLine(Ob); // NameSpace ??

            //Point P = new Point();
            //Console.WriteLine(P);

            //Console.WriteLine(P.ToString());
            //Console.WriteLine(P.GetHashCode());




            #endregion

            #region 9.  Casting

            // Casting : Convert  From Datatype To anothe DataType
            // Implicit Casting  : Widining (Small To Large)
            //int x = 100;
            //long y1 = (long)x;
            //long y2 = x;  // Implicittly (Safe Casting)

            //Console.WriteLine(y1);
            //Console.WriteLine(y2);

            //int X = 50;
            //double Y1 = (double)X;
            //double Y2 = X;
            //Console.WriteLine(Y1);
            //Console.WriteLine(Y2);


            // Explicit Casting : Norrowing (Large To Small)

            //long x = 1200000000000;
            ////int y = x; Error
            //int y = (int)x;  // Grabage // Explicity [Unsafe Casting]
            //Console.WriteLine(y);

            //double X = 1.5;
            //int Y = (int)X; 
            //Console.WriteLine(Y);  // Unsafecasting
            #endregion

            #region 10.  Parsing & Converting

            // 1. Parsing : Usefor Convert From string To Any Data type
            //int Age;
            //Console.WriteLine("Enter your Age : ");
            ////Age = (int)Console.ReadKey(); // Error
            //Age = int.Parse(Console.ReadLine());  // By Bcl Keyword

            //Console.WriteLine("You Enter Age : " + Age);



            // 2. Converting : Contain Function Used For Cast
            //int Age;
            //Console.WriteLine("Enter your Age : ");
            // //Age = int.Parse(Console.ReadLine());
            // Age = Convert.ToInt32(Console.ReadLine());  // By CSharp KeyWord

            //Console.WriteLine("You Enter Age : " + Age);



            // 3.  Try parsing : Return If The Input Compatable  With DataType Or Not
            //int Age;
            //Console.WriteLine("Enter your Age : ");
            // bool Flag = int.TryParse(Console.ReadLine() , out Age);

            //Console.WriteLine("You Enter Age : " + Age);
            //Console.WriteLine("Flag : " + Flag);


            #endregion

            #region 11.   Fraction & Discard

            // Note : Default Value in Integer Num :   Int
            // Note : Default Value in Fraction Num :  double


            float f = 1.5f;
            double d = 1.75d;
            decimal dm = 1.125m;
            decimal dm1 = 1.125M;

            // Discard : _
            double de = 100_000_000_000;
            Console.WriteLine(de);

            #endregion

            #region Operator


            // 1-unary operators : works on one operand (variable) ++ --
            // int x =10;
            // x++; //Postfix [print then Increment]
            // ++x; //Prefix [Increment then print]

            // x--; //Postfix [print then Decrement]
            // --x; //Prefix [Decrement then print]



            //2-Binary operators : works on Two Operands (variables) + = / * %


            // 3- Assignment Operators 


            //4-Relational Operators 


            //5-Logical Operators [AND,OR,NOT]

            //6-Bitwise Operators


            //7- Ternary Operators


            /*
             1-unary operators
             2-Round Braces ()
             3-* / %
             4- + -

             */


            #endregion










        }

    }
}






