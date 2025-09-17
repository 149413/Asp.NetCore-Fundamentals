namespace Demo_04
{

    //1. class   --> Function
    //2. Struct  --> Function
    //3. InterFace --> Function
    //4. Enum

    public class NewData
    {
        public int Sum;
        public int Mult;
    };

    internal class Program
    {

        static void PrintShap(string Pattrn = "$_$", int count = 4)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Pattrn);
            }
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        // Passing Parameter Value Type

        static void SWAP(ref int X, ref int y)
        {
            int temp = X;
            X = y;
            y = temp;
        }
        // Passing Paramete Refrance Type
        //  Ex 01
        static int SumArray(ref int[] arr)
        {
            int sum = 0;
            arr[0] = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        // Ex 02
        //static int SumArray(ref int[] arr)
        //{
        //    int sum = 0; 
        //    arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        // Pass by Out
        //static int SumMult(int X, int Y)
        //{
        //    return X + Y;
        //    return X * Y;
        //}

        //static int[] SumMult(int X, int Y)
        //{
        //    int[] result = { X + Y, X * Y };  // Syntax Suger
        //    return result;
        //}

        static NewData SumMult(int X, int Y)
        {
            NewData result = new NewData();
            result.Sum = X + Y;
            result.Mult = X * Y;

            return result;
        }
        static void SumMult(int X, int Y, out int Sum, out int Mult)
        {
            Sum = X + Y;
            Mult = X * Y;

        }
        // Params
        //static int SumArray(params int[] Array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        sum += Array[i];
        //    }
        //    return sum;
        //}
        // ================================================****** Entry Point *****==========================================================
        static void Main(string[] args)
        {
            #region 00 Revision
            /*
                 * 00 revision
                 1.Strinng Formattings
                         1.String concatination
                         2.String formatting
                         3.String Interpolation

                 2.Control Flow
                     1.Condition Statements[if state - Switch Case]
                     2.Loop statement[for - foreach -While = do -While]

                 3. string &String Metods
                 4.StringBuilder & StringBuilder Methods
              */
            #endregion

            #region 1D Array
            // One D Array
            //int[] Number;
            // Declare Referance (Pointer) from type Object 'Array'
            // Number : Refer To Object Fron Type 'Array'
            //  Number : Now Refer To Null


            // 8 Bytes Will be Allocted At STACK For Referance (Pointer) Number
            // 0 Bytes Will BeAllocted At HEAP 

            //Number = new int[5];
            // new
            //1. Allocate or Store theRequired Bytes At Heap For Obbject Array (Size of Type * Size of Array)
            //2. Inisialize Required Bytes At  Heap By Default Value
            //3. Call User-Defined Constructor is Exists
            //4. Assiagne Referance(Pointr) to Object Array

            //Number[0] = 1;  // O(1)  ---> (Index * No of Bytes + Address) => (4 * 5 + 0X00)
            //Number[1] = 2;
            //Number[2] = 3;
            //Number[3] = 4;
            //Number[4] = 5;
            ////Number[5] = 6; // Out Of Range

            //Console.WriteLine(Number[0]);
            //Console.WriteLine(Number[1]);
            //Console.WriteLine(Number[2]);
            //Console.WriteLine(Number[3]);
            //Console.WriteLine(Number[4]);

            //Console.WriteLine(Number); // TypeArray (NameSpace)   // System.Int32[]


            //Console.WriteLine(Number.Length); // Length
            //Console.WriteLine(Number.Rank); // Dimention

            //for (int i = 0; i < Number.Length; i++)
            //{
            //    Console.Write($"Enter Number[{i}]: ");
            //    Number[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("=========================== ");
            //for (int i = 0; i < Number.Length; i++)
            //{
            //    Console.Write(Number[i] + " ");
            //} 
            #endregion

            #region 2D Array
            #region 1. Rectangle array
            // 1. Rectangle array
            ////Two D Array
            //int[,] Marks = new int[3, 3];

            //Marks[0, 0] = 99;
            //Marks[0, 1] = 80;
            //Marks[0, 2] = 70;

            //Marks[1, 0] = 100;
            //Marks[1, 1] = 80;
            //Marks[1, 2] = 77;

            //Marks[2, 0] = 82;
            //Marks[2, 1] = 60;
            //Marks[2, 2] = 200;

            ////Console.WriteLine(Number[0, 0]);
            ////Console.WriteLine(Number[0, 1]);
            ////Console.WriteLine(Number[0, 2]);

            ////Console.WriteLine(Number[1, 0]);
            ////Console.WriteLine(Number[1, 1]);
            ////Console.WriteLine(Number[1, 2]);

            ////Console.WriteLine(Number[2, 0]);
            ////Console.WriteLine(Number[2, 1]);
            ////Console.WriteLine(Number[2, 2]);


            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine(Marks[i, j]);
            //    }
            //    Console.WriteLine();

            //} 
            #endregion

            #region 2. Juddged Array
            // Juddged Array
            //int[][] Marks = new int[3][];

            //Marks[0] = new int[] { 1,2,3}; 
            //Marks[1] = new int[] { 1,2}; 
            //Marks[2] = new int[] { 1,2,3,4};

            //Console.WriteLine(Marks[0][0]);
            //Console.WriteLine(Marks[0][1]);
            //Console.WriteLine(Marks[0][2]);

            //Console.WriteLine(Marks[1][0]);
            //Console.WriteLine(Marks[1][1]);

            //Console.WriteLine(Marks[2][0]);
            //Console.WriteLine(Marks[2][1]);
            //Console.WriteLine(Marks[2][2]);
            //Console.WriteLine(Marks[2][3]);



            //int[][] Marks1 = new int[3][];

            //Marks1[0] = new int[3];
            //Marks1[1] = new int[2];
            //Marks1[2] = new int[4];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks1[i].Length; j++)
            //    {
            //        Console.Write($"Marks1[{i}][{j}]: ");
            //        Marks1[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks1[i].Length; j++)
            //    {
            //        Console.Write(Marks1[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #endregion

            #region Function prototype And Calling

            // Function : Block Of Code That have A Name If U Need To Execute It U Must Call it By Name
            // DRY

            // Function Prototype
            // 1. Signature
            // 1. Name
            // 2. Rturn type
            // 3. Parameters (Inputs)

            // 2. Body (Code)

            // Calling For The Methods
            //PrintShap();

            // Methods
            // 1. Class Member Method   (Static Method)
            // 2. Object Member Method  (Non Static Method)

            //1 -
            //Program.PrintShap();  // Static Method
            // PrintShap();  // Static Method

            // 2.
            //Program P = new Program(); 
            //P.PrintShap();        // Non Static Method

            //PrintShap("%_%", 5);  // Calling By order
            //PrintShap(count: 5, Pattrn: "%_%"); // Calling By Name
            //PrintShap("#_#"); // Calling By Default
            //PrintShap(); // Calling By Default


            //// Calling:
            //int sum = Sum(1, 2);
            //Console.WriteLine(Sum(1, 3));

            #endregion

            #region Functions Stack frame
            // Every function Have Stack frame 
            // Each Stack Frame contain(Parameter Variables & Local Variables)

            // Revise it from Vedeos or PDF
            #endregion

            #region Passing by Value && Passing By Referance
            ////Passing by Value
            ////Passing By referance

            #region Passing Parameter Value Type
            //// 1.Passing Parameter(Value Type)
            //// 1.Passing by Value

            //int A = 4, B = 9;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Console.WriteLine("------- after Swapping -------");
            //SWAP(A, B);

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");


            //// 2. Passing By referance

            //int A = 4, B = 9;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Console.WriteLine("------- after Swapping -------");
            //SWAP(ref A, ref B);

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            #endregion

            #region Passing Paramter (Referance Type)
            // Passing Paramter (Referance Type)
            #region Ex 01
            //// 1. Passing by Value

            //int[] Number = { 1, 2, 3 };

            //int result = SumArray(Number);  // Passing By Value
            //Console.WriteLine(result); // 105
            //Console.WriteLine(Number[0]); // 100


            // 2. Passing By Referance

            //int[] Number = { 1, 2, 3 };

            //int result = SumArray(ref Number); // Passing By Ref
            //// The Address Of The Number

            //Console.WriteLine(result); // 105
            //Console.WriteLine(Number[0]); // 100


            // Note : Not Always Passing by Reference Matching Passing By Value in Passig parameter (Reference  Type)

            #endregion

            #region EX 02

            // 1. Passing by Value

            //int[] Number = { 1, 2, 3 };

            //int result = SumArray(Number);  // Passing By Value
            //Console.WriteLine(result);     // 15
            //Console.WriteLine(Number[0]);  // 1


            // 2. Passing By Referance

            //int[] Number = { 1, 2, 3 };

            //int result = SumArray(ref Number); // Passing By Ref
            //// The Address Of The Number

            //Console.WriteLine(result);    // 15
            //Console.WriteLine(Number[0]); // 4

            #endregion

            #endregion

            #endregion

            #region Passing By out
            // Passing By out

            //1.  One Return
            //int A = 3, B = 4;

            //int result = SumMult(A, B);
            //Console.WriteLine(result);

            //// 2. By Array
            //int A = 10, B = 20;
            //int[] result = SumMult(A, B);
            //Console.WriteLine(result); // Namespace
            //Console.WriteLine(result[0]);  // 30
            //Console.WriteLine(result[1]);  // 200

            ////3. By Class
            //int A = 10, B = 20;
            //NewData Result = SumMult(A, B);
            //Console.WriteLine(Result.Sum);
            //Console.WriteLine(Result.Mult);


            // 4. Passing By out

            //int a = 10, b = 20, Sum, Mult;
            //SumMult(a, b, out Sum, out Mult);

            //int A = 20, B = 20;
            //SumMult(A, B, out int Sum, out int Mult);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mult); 
            #endregion


            #region Params
            // Params
            ////1. By addressArray
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //int result = SumArray(Numbers);
            //Console.WriteLine(result);

            //// By Array
            //int result1 = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine(result); 
            #endregion

            #region Note
            // Note 
            // 1. Passing By Value      : Iput Parameter
            // 2. Passing By Referance  : InputOutput Parameter
            // 2. Passing By Out        : Output Parameter

            #endregion

        }



    }
}
