using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        // code
        // varibale
        // varibale Declaration
        // location in memory used for store data

        // Declare Varaible
        // Datatype VaraibleName;

        int Number = 20;
        // Allocate unInitialized 4 bytes at Memory

        // console.writeline(Number); Invalid
        // Note: u cant use unAssinged local variable

        // variable:
        //1-name number
        //2-data type int
        //3-size  4bytes
        //4-value  5
        //5-address 0xFA32 (0-9 A-F)

        // int Number; //Invalid

        // int Number01;
        // int Number02;
        // int Number03;

        //int Number01=3,int Number02=12,int Number03=13,
        //Console.WriteLine(Number01);
        //Console.WriteLine(Number02);
        //Console.WriteLine(Number03);


        //int int;
        //int if;
        //int class;

        //value type - stack

        int Number01;
        // Allocate unInitialized 4 bytes at Stack
        //Console.WriteLine(Number01); // Invalid
        // int : C# Keyword
        //Number01 =5;
        //int32 : BCL Keyword
        //Console.WriteLine(Number01); 
        //int 32 Number02=12;
        //int32 : BCL Keyword
        //Console.WriteLine(Number02); 
        //Number02=Number01


        // Declare For Reference(Point) From Type 'Point'
        // P01 : Can Refer To Object (instance) From Type 'Point'
        // P01 : Refer To Null
        // 8 Bytes will Be Allocated At stack for the Reference  'P01'
        // 0 Bytes will Be Allocated At Heap


        //Console.WriteLine(P01.X);

        // new
        // 1- Allocate The NUMBER of Required Bytes For The Object (Point) At Heap (8 Bytes+)
        // 2- initialize the Allocated Bytes At Heap with the default value of Datatype
        // 3- Call User-Defined Constructor if Exists
        // 4- Assign The object to the Reference


        // P01.X =12;
        //Console.WriteLine(P01.X); 12

        // Point P02 = new Point();
        //Console.WriteLine(P02.X);
        //Console.WriteLine(P02.Y);

        //P02 = P01;
        //Console.WriteLine(P02.X);
 

        // OJECT :
        // Reference Type - Class
        // Parent of All Datatypes

        object O1;
        // Declare For Reference From Type 'Object'
        // O1 : Can Refer TO Instance From type object or and datatype which inherited from object

        //O1 = new object();
        //O1 = 1;  
        //Console.WriteLine(O1);

        //Point P = new Point();

        //Console.WriteLine(P.ToString());
        //Console.WriteLine(P.GetHashCode());
        //Console.WriteLine(P.GetType());


        // Casting :
        // convert from any datatype to ant datatype

        //1- Implicit Casting

        //int x=12;
        //long Y = /*(long)*/ x;//Implicitly [Safe Casting]
        // (long) : Casting Operator

        //Console.WriteLine(Y);

        //int x=12;
        //double Y = /*(double)*/ x;//Implicitly [Safe Casting]
        //Console.WriteLine(Y);



        //2- Explicit Casting

        //long x =120000000000000;
        // int Y =(int) x; // exlicit Casting (unSafe Casting)
        // May Cause Error
        //Console.WriteLine(Y);


        //Parse : Used For Convert String To any Datatype
        //int Age;
        //Console.WriteLine("Enter Your Age : ");
        // Age = int.Parse(Console.ReadLine());
        //Console.WriteLine("Your Enter Age : " +Age);

        // Convert : Contain Function Used For Cast 

        //int Age;
        //Console.WriteLine("Enter Your Age : ");
        // Age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Your Enter Age : " +Age);

        // TryParse

        //int Age;
        //Console.WriteLine("Enter Your Age : ");
        // bool Flag = int.TryParse(Console.ReadLine(),out Age);
        //Console.WriteLine("Your Enter Age : " +Age);
        //Console.WriteLine("Flag : " +Flag);


        //double x = 1.5;
        //float x = 1.5F;
        //float x = 1.5f;
        //decimal x = 1.5M;
        //decimal x = 1.5m;

        // Discard : _
        // long x = 10_000_000_000;
        //Console.WriteLine(x);


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







    }
}
