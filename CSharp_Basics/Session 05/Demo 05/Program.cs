namespace Demo_05
{


    #region Enum EX01

    //byte: 0 -> 255
    enum Season : byte
    {
        Sprint = 2, /*256  -- > Out Of Range*/
        Winter = 4, /*255  Not perfect*/
        Summer,
        Autumn
    }

    enum WeekDay
    {
        SaterDay = 10,
        SunDay,
        MonDay = 100,
        TuesDay = 3,
        WedneseDay,
        ThursDay,
        FriDay

    }


    enum Gender
    {
        M = 1,
        F = 2,
        Male = 1,
        Female = 2
    }

    #endregion

    #region Enum Ex02

    // Read , Write , Execute , Delete

    [Flags]
    enum Permisson : byte
    {
        Read = 8,
        Write = 4,
        Execute = 2,
        Delete = 1
    }

    #endregion



    internal class Program
    {


        #region Exception Handling and Protective Code
        static void DoSomeCode()
        {
            int X, Y, Z;
            //try
            //{
            //    Console.Write("Enter The First Number: ");
            //    X = int.Parse(Console.ReadLine());

            //    Console.Write("Enter The Secound Number: ");
            //    Y = int.Parse(Console.ReadLine());

            //    Z = X / Y;
            //    Console.WriteLine("Z =  " + Z);

            //    int[] arry = { 1, 2, 3, 4 };
            //    Console.WriteLine("Enter ypur Index");
            //    int idx = int.Parse(Console.ReadLine());

            //    arry[idx] = 1000;
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            try
            {
                Console.Write("Enter The First Number: ");
                X = int.Parse(Console.ReadLine());

                Console.Write("Enter The Secound Number: ");
                Y = int.Parse(Console.ReadLine());

                Z = X / Y;
                Console.WriteLine("Z =  " + Z);

                int[] arry = { 1, 2, 3, 4 };
                Console.WriteLine("Enter ypur Index");
                int idx = int.Parse(Console.ReadLine());

                arry[idx] = 1000;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Successfully");
                // Used To Handel 1 of 4 The Following
                // release / Deallocate  --> in C++
                // Disconnected / UnManaged database ---> C#
            }
            Console.WriteLine("After Handlening exception");


        }

        static void DoSomeProtectedCode()
        {
            int X, Y, Z;
            bool flag;
            try
            {
                do
                {
                    Console.Write("Enter The First Number: ");
                    flag = int.TryParse(Console.ReadLine(), out X);
                } while (flag == false);

                do
                {
                    Console.Write("Enter The Secound Number: ");
                    flag = int.TryParse(Console.ReadLine(), out Y);
                } while (flag == false || Y == 0);


                Z = X / Y;
                Console.WriteLine("Z =  " + Z);

                int[] arry = { 1, 2, 3, 4 };
                int idx;
                do
                {
                    Console.WriteLine("Enter ypur Index");
                    flag = int.TryParse(Console.ReadLine(), out idx);
                } while (flag == false || idx < 0 || idx > arry.Length);


                arry[idx] = 1000;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        #endregion


        static void Main(string[] args)
        {
            #region 00 Revision
            //1. 1D Array
            //2. 2D Array
            //1. Rectangle array (row = cols)
            //2. juddged Array  (row != cols)
            //3. Function ProtoType
            //4. Function Stack Frame
            //5. ValueType Parameter Passing By Value && By Reference
            //6. ReferenceType Parameter Passing By Value && By Reference
            //7. Passing By Out
            //8. Params

            #endregion


            #region 1. Boxing && UnBoxing
            // Boxing & UnBuxing
            //Boxing   : Casting from Value Type to Reverence Type
            //UnBoxing : Casting from Reference Type To Value Type

            // 1. Boxing
            // object O1;
            // O1 : Reference Refer to Any Instance  From Type "Object" or Any Instance From Data Type 

            //O1 = 1;
            //O1 = "Abc";

            //O1 = 1;                  //Casting From ValueType [int]    To Reference Type [Object]  => Boxing
            //O1 = 1.5;                //Casting From ValueType [double] To Reference Type [Object]  => Boxing
            //O1 = 'A';                //Casting From ValueType [char]   To Reference Type [Object]  => Boxing
            //O1 = true;               //Casting From ValueType [bool]    To Reference Type [Object] => Boxing
            //O1 = new DateTime();    //Casting From ValueType [bool]    To Reference Type [Object]  => Boxing
            /* DateTime() ---> Build-in Struct */


            //int X = 5;
            //O1 = /*(object)*/ X;

            // Implicite Casting
            // Safe Casting
            // Boxing
            // Parant = Child => Child is A Parant

            // Animal = Dog   => Dog   ia A Animal

            //-----------------------------------------------------------------------------------------------------------------


            // // 2. UnBoxing
            //object O2 = 7;
            // int Y = (int)O2;

            // // Explicite Casting
            // // UnSafe Casting
            // // UnBoxing
            // // Dog = (Dog)Animal  => animal is Dog
            // // Child = Parent    => Parent is Child


            // // Note: 
            // // ValueType To ValueType           => Casting
            // // ReferenceType To referenceType   => Casting

            // // ValueType To ReferenceTyp        => Boxing
            // // ReferenceType To ValuType        => UnBoxing

            #endregion

            #region 2. Nullable ValueType
            //Nullable Value Type

            //int X = 5;
            //X = 10;
            //X = null;  // Invalide Value

            // Nullable Value Type  =>  Type Allow Null Value as avalid Value


            //Nullable<int>  : Allow Int Value or Null As Avalid Value 
            //int? Age = 20;

            //Age = null;

            //  Nullable < Double> : Allow double Value or Null Value

            //double? Salary = 2000.55;

            //Salary = null;


            //  Casting :  From ValueType (Int) to Nullabe Value  => Implicite Casting

            //int X = 5;

            ////Y: Nullable Value
            ////Y: Allow int Value or  Null

            //int? Y = /*(int?)*/ X;

            //// Ipmlicit Casting
            //// Safe Casting

            //Console.WriteLine(Y);



            //  Casting :  From Nullable Type  to Value (int)  => Explicit Casting

            //int? X = 5;
            //X = null;

            //int Y;

            // Y = (int)X;

            // Explicite Casting 
            // Un safe
            // May Throw Exception 


            // ========================================
            //definsive Code

            //if (X != null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            // ========================================

            //if (X is not null)
            //    Y = (int)X;
            //else
            //    Y = 0;
            // ========================================

            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;


            // Ternary

            //Y = X.HasValue ? X.Value : 0;
            //Y = X is not null ? X.Value : 0;

            //// Null Coalescing Operator ??
            //Y = X ?? 0;  // Syntax Suger : Y = X is not null ? X.Value : 0;


            //Console.WriteLine(Y);

            #endregion

            #region  3. Nullable Refernce Type [C# 10.0 Net 6.0]

            // Nullable Refernce Type [C# 10.0 Net 6.0]

            //string message01 = null; // Required


            //string? message02 = null; // Nullable

            //Console.WriteLine(message01);
            //Console.WriteLine(message02); 
            #endregion

            #region 4. Null Propagation Operator
            // Null Propagation operator ?

            //double X = default;  // 0
            //bool C = default; // false
            //Console.WriteLine(C);

            // int[] Arr = default; // null
            //int[] Arr = { 1, 2, 3, 4, 5 };

            //for (int i = 0; (Arr is not null) && i < Arr.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}


            //// Null Prrpagation Operator 
            //for (int i = 0; i < Arr?.Length; i++) // Syntax Suger  --> ;(Arr is not null) && i < Arr.Length ;
            //{
            //    Console.WriteLine(Arr[i]);
            //}

            //// Best Practise

            //if (Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Console.WriteLine(Arr[i]);
            //    }
            //}

            //// Emp?.DeptId
            //// Emp?.Departments?.Id


            // int len = Arr.Length;  // Throw Null Referance Exception

            // int Len = Arr is not null ? Arr.Length : 0;

            //  int? len = Arr?.Length;

            // int len = Arr?.Length is not null ? Arr.Length : 0;
            //int len = Arr?.Length ?? 0;  // Syntax Suger

            //Console.WriteLine(len); 
            #endregion

            #region 5. Exception Handling and Protective Code
            // Exception handling and Protective code

            //SystemException e;
            //// Exception  [Parent]
            ////1. System Exception [Child]
            ////1.1. FormatException
            //// 1.2. NullReferenceException
            //// 1.3. IndexOutOfRangeException
            //// 1.4. ArithmeticException
            //// 1.4.1 OverflowException
            //// 1.4.1 DivideByZeroException

            ////2. Aplication Exception [Child]
            //// Exception About Hardware (Memory - ...) / HardWare With softaWare (OS - ......)



            // DoSomeCode();
            //DoSomeProtectedCode(); 
            #endregion

            #region 6. Access Modifiers
            //Class Liberary

            //Common.TypeA typeA = new Common.TypeA();   // InValid : TypeA is Internal Accessable

            //Common.TypeB typeB = new Common.TypeB(); // Valid
            //TypeB typeB = new TypeB();  // Valid : TypeB Is Public

            ////typeB.X = 12; // Invalid : Pivate
            ////typeB.Y = 12; // InValid : Internal
            //typeB.Z = 12; // Valid

            #endregion

            #region Enum EX01

            // Enum : Value Type (Used When Have Constant Value)
            // Stack
            // CLR Represent Enum As Integer Value In The Memory
            // Enum Is A Numeric DataType (int - uint - short - ushort - byte - ......) ---> defult (Int)

            //int x = 0;

            //Season S01 = Season.Sprint;
            //S01 = Season.Summer;

            //Console.WriteLine(S01);
            //Console.WriteLine((int)S01);

            //WeekDay W01 = WeekDay.TuesDay;

            //W01 = (WeekDay)3;
            //W01 = (WeekDay)11;

            //Console.WriteLine(W01);
            //Console.WriteLine((int)W01);


            //Gender G01 = Enum.Parse(typeof(Gender), Console.ReadLine());  // Error : It rturns Object Value
            // Gender G01 = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

            // Console.WriteLine(G01); // M --> M    // 0 -> M  //  m --> Throw ArgumentException

            //Gender G01 = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true /*Ignore Case*/); // m ---> M  // Ahmed ==> Throw Format Exception
            //Console.WriteLine(G01);

            //To Handle Exception
            //bool flag = Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object O1);
            //Gender G02 = (Gender)O1;  // may Throw Exception
            //Console.WriteLine(G02);

            // Explicit Casting
            // UnSafe
            // UnBoxing : Convert from Referance Type (object)  To Value Type (Gender)

            // Input: M --> M    // 1 --> F   // f --> F   // Ahmed ---> Defualt Value : Null (Throw NullReferenceException)


            //  Console.WriteLine(G02);  // Male --> M  // Female  ---> F

            #endregion

            #region Enum EX02
            //Permisson P01 = Permisson.Read;


            // P01 ^= Permisson.Delete;  // Toggle : (if Permission Exist Remove it , If Not Exist add It )
            //Console.WriteLine(P01);
            //Console.WriteLine((byte)P01);

            //P01 ^= Permisson.Delete;
            //Console.WriteLine(P01); //Delete, Read
            //Console.WriteLine((byte)P01); // 9

            // P01 |= Permisson.Delete; // Add Permission
            //P01 |= Permisson.Delete;
            //Console.WriteLine(P01); // Delete, Read
            //Console.WriteLine((byte)P01); // 8+1 => 9

            // P01 &= Permisson.Delete;  

            //P01 &= ~(Permisson.Delete);  // ~ Not bitwise : Delete Permissin

            // & ===> Check Permisiion (if Exist or Not) 

            //if ((P01 & Permisson.Delete) == Permisson.Delete)
            //{
            //    Console.WriteLine("Permission Delete Exists");
            //}
            //else
            //{
            //    Console.WriteLine("Permission Delete Not Exists");
            //}

            //P01 <<= Permisson.Delete;

            //Console.WriteLine(P01);
            //Console.WriteLine((byte)P01);

            #endregion




            Console.ReadKey();


        }
    }
}
