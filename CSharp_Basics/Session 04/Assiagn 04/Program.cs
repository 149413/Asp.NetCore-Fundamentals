using System.Text;

namespace Assiagn_04
{
    internal class Program
    {
        #region Q01
        static void ValueType(int A)
        {
            A = 10;
        }
        static void ReferanceType(ref int A)
        {
            A = 10;
        }


        #endregion

        #region Q02
        static void SayHello(StringBuilder Msg)
        {

            Msg = new StringBuilder("Welcom World");
            Console.WriteLine($"{Msg} -----> {Msg.GetHashCode()}");
        }
        static void SayHello(ref StringBuilder Msg)
        {

            Msg = new StringBuilder("Welcom World");
            Console.WriteLine($"{Msg} -----> {Msg.GetHashCode()}");
        }

        #endregion

        #region Q03
        static void SummitionSub(int X, int Y, out int Sum, out int Sub)
        {
            Sum = X + Y;
            Sub = X - Y;
        }

        #endregion

        #region Q04 
        static int SumDigits(int Num)
        {
            Num = Math.Abs(Num);

            int sum = 0;
            while (Num != 0)
            {
                sum += Num % 10;
                Num /= 10;
            }
            return sum;
        }

        #endregion

        #region Q05
        static bool IsPrime(int Num)
        {
            if (Num == 1 || Num == 0) return false;
            for (int i = 2; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        #endregion

        #region Q06
        static void minMaxArray(ref int[] array, ref int min, ref int max)
        {
            min = array.Min();
            max = array.Max();
        }


        #endregion

        #region Q07
        static long Factorial(int Num)
        {
            long fact = 1;
            for (int i = 1; i <= Num; i++)
            {
                fact *= i;
            }
            return fact;
        }

        #endregion

        #region Q08
        static void ChangeeChar(ref char ch)
        {
            Console.Write("Enter your New Charscter: ");
            ch = char.Parse(Console.ReadLine());
        }

        #endregion

        #region Q09

        static void IdentityMatrix(int[,] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

        #endregion

        #region Q10
        static int SumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        #endregion

        #region Q11
        static int[] MergeAray(int[] array1, int[] array2, int N)
        {

            int[] mergeArray = new int[2 * N];

            array1.CopyTo(mergeArray, 0);
            array2.CopyTo(mergeArray, N);
            Array.Sort(mergeArray);

            // O(2N Log(2N))

            return mergeArray;
        }


        #endregion

        #region Q12
        static void MinMax(int[] array, out int Min, out int Max)
        {
            Min = 0;
            Max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Min = array.Min();
                Max = array.Max();
            }
        }

        #endregion

        #region Q13

        static int SecondLargestElement(int[] array)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }
            }
            return array[1];
        }


        #endregion

        #region Q14

        static int FindLLargeDist_BetweenTwoCells(int[] array, out int cell)
        {
            cell = 0;
            int LargDist = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int diff = Array.LastIndexOf(array, array[i]) - Array.IndexOf(array, array[i]) - 1;
                if (diff > LargDist)
                {
                    LargDist = diff;
                    cell = array[i];
                }
            }

            return LargDist;
        }

        #endregion

        #region Q15
        static string[] SplitSentance()
        {
            Console.Write("Enter Your Sentance : ");
            string sentance = Console.ReadLine();

            string[] phrases = sentance.Split(' ');

            return phrases;
        }

        #endregion

        #region Q16

        static int[,] _2DCopyTo(int[,] source)
        {
            int rows = source.GetLength(0);
            int cols = source.GetLength(1);

            int[,] distance = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    distance[i, j] = source[i, j];
                }
            }
            return distance;
        }

        #endregion

        #region Q17

        static void Reverse(ref int[] array)
        {
            int N = array.Length;
            int[] rev = new int[N];
            for (int i = 0; i < N; i++)
            {
                rev[i] = array[N - i - 1];
            }
            array = rev;
        }

        #endregion


        static void Main(string[] args)
        {

            //-------------------------------------------------  Functions ---------------------------------------------------

            #region Q1
            /* 1 - Explain the difference between passing(Value type parameters)
             by value and by reference then write a suitable c# example. */

            // In Value Type Parameter
            //1. Paasing By Value : Take Copy from The Variables And  work it on The stake Frame Of Functions in Independant 
            // So The Changing in The Value Not affect on Original Variables 

            //2. Pass By Refernce : The Varibles of Parameter is The Same Original Variable ,
            // which is Created Only one Time At Stack frame of The Function Calling ex. (Main) 

            //Ex

            //int X = 5;
            //Console.WriteLine($"X: {X}");
            //Console.WriteLine("------- By ValueType Function ------");
            //ValueType(X);
            //Console.WriteLine($"X: {X}");

            //Console.WriteLine();

            //Console.WriteLine($"X: {X}");
            //Console.WriteLine("------- By ReferanceType Function ------");
            //ReferanceType(ref X);
            //Console.WriteLine($"X: {X}");

            #endregion


            #region Q2
            /* 2 - Explain the difference between passing(Reference type
             parameters) by value and by reference then write a suitable c#  example.*/

            // In Referance Type Parameter
            //1. Passing By Value : Create New Referance In The Stack Frame of Function ,
            //Which Point To The Same Object That The Original refrance refere To it.

            //2. Passing By Referance: The Referance (pointer) is The Same Original Referance ,
            //Which Created Only  Only One Time AtThe Stack Frame of   The Function Calling ex.(Main()) 


            // EX


            //StringBuilder msg = new StringBuilder("Hello");
            //Console.WriteLine($"{msg} -----> {msg.GetHashCode()}");
            //Console.WriteLine("------- By ValueType Function ------");
            //SayHello(msg);
            //Console.WriteLine($"{msg} -----> {msg.GetHashCode()}");



            //Console.WriteLine($"{msg} -----> {msg.GetHashCode()}");
            //Console.WriteLine("------- By ValueType Function ------");
            //SayHello(ref msg);
            //Console.WriteLine($"{msg} -----> {msg.GetHashCode()}");

            #endregion


            #region Q3

            /* 3 - Write a c# Function that accept 4 parameters from user and 
            return result of summation and subtracting of two numbers*/

            //int num1 = int.Parse(Console.ReadLine()), num2 = int.Parse(Console.ReadLine());

            //SummitionSub(num1, num2, out int Sum, out int Sub);
            //Console.WriteLine($"Sum : {Sum}");
            //Console.WriteLine($"Sub : {Sub}");

            #endregion


            #region Q4
            /*4 - Write a program in C# Sharp to create a function to calculate the sum of the 
            individual digits of a given number.
            Output should be like
            Enter a number: 25
            The sum of the digits of the number 25 is: 7*/

            //Console.Write("Enter a Number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The sum of the digits of the number {num} is: " + SumDigits(num));

            #endregion


            #region Q5
            /* 5 - Create a function named "IsPrime", which receives an integer number
             and retuns true if it is prime, or false if it is not:*/

            //Console.Write("Enter Your Num: ");
            //int Num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"IsPrime: {IsPrime(Num)}");

            #endregion


            #region Q6
            /* 6 - Create a function named MinMaxArray, to return the minimum and
             maximum values stored in an array, using reference parameters*/

            //int[] array = { 12, 2, 5, 4, 80, 25 };
            //int Min = 0, Max = 0;
            //minMaxArray(ref array, ref Min, ref Max);
            //Console.WriteLine($"Min:{Min}");
            //Console.WriteLine($"Max:{Max}");

            #endregion


            #region Q7
            /* 7 - Create function to calculate the factorial of the number specified asparameter .*/

            //Console.Write("Enter Your Num: ");
            //int num = int.Parse(Console.ReadLine());
            //long Fact = Factorial(num);
            //Console.WriteLine($"factorial {num} : {Fact}");

            #endregion


            #region Q8

            /* 8 - Create a function named "ChangeChar" to modify a letter in a certain
             position(0 based) of a string, replacing it with a different letter*/

            //char C = 'A';

            //ChangeeChar(ref C);
            //Console.WriteLine("New Char: " + C);
            #endregion


            #region َََQ9

            /* 9 - .Write a program that prints an identity matrix using for loop, in 
             other words takes a value n from the user and shows the identity table of size n * n.*/

            //Console.Write("Ente The matrix Size: ");
            //int N = int.Parse(Console.ReadLine());
            //int[,] arr = new int[N, N];
            //IdentityMatrix(arr, N);


            #endregion


            #region Q10

            /* 10 - Write a program in C# Sharp to find the sum of all elements of the array. */

            //Console.Write("enter Size: ");
            //int N = int.Parse(Console.ReadLine());
            //int[] array = new int[N];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"array[{i}]: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("The Sum: " + SumArray(array));

            #endregion


            #region Q11

            /* 11- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.*/

            //  2 1 4 5 7         3 2 1 4 5


            //Console.Write("Enter size: ");
            //int N = int.Parse(Console.ReadLine());

            //int[] arry1 = new int[N];
            //int[] arry2 = new int[N];
            //Console.WriteLine("Arry1: ");
            //for (int i = 0; i < arry1.Length; i++)
            //{
            //    Console.Write($"arry1[{i}]: ");
            //    arry1[i] = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("Arry2: ");
            //for (int i = 0; i < arry2.Length; i++)
            //{
            //    Console.Write($"arry2[{i}]: ");
            //    arry2[i] = int.Parse(Console.ReadLine());

            //}

            //int[] merge = MergeAray(arry1, arry2, N);  // O (2N Log(2N))

            //foreach (int i in merge)
            //{
            //    Console.Write(i + " ");
            //}



            #endregion


            #region Q12

            /*12 - Write a program in C# Sharp to find maximum and minimum element in an array */

            //Console.Write("Enter size: ");
            //int N = int.Parse(Console.ReadLine());

            //int[] array = new int[N];
            //Console.WriteLine("Arry1: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"arry1[{i}]: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //int Min = 0, Max = 0;
            //MinMax(array, out Min, out Max);
            //Console.WriteLine($"Min: {Min}");
            //Console.WriteLine($"Max: {Max}");

            #endregion

            #region Q13

            /* 13 - Write a program in C# Sharp to find the second largest element in an array.*/


            //Console.Write("Enter size: ");
            //int N = int.Parse(Console.ReadLine());

            //int[] array = new int[N];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"arry[{i}]: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("Seound Largest Element: " + SecondLargestElement(array));


            #endregion

            #region Q14

            /* 14 - Consider an Array of Integer values with size N, having values as
             in this Example
              7   0  0  0  5  6  7  5  0  7  5  3
             write a program to find the longest distance between Two equal cells. In this example.The
             distance is measured by the number Of cells- for example, the distance between the first and the
             fourth cell is 2(cell 2 and cell 3).
             In the example above, the longest distance is between the first 7 and the
             10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
             And the 10th 7s.
             Note: 
             Array values will be taken from the user
             If you have input like 1111111 then the distance is the number of
             Cells between the first and the last cell.*/



            //Console.Write("Enter size: ");
            //int N = int.Parse(Console.ReadLine());

            //int[] array = new int[N];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"arry[{i}]: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");

            //}

            //int LargeDist = FindLLargeDist_BetweenTwoCells(array, out int cell);
            //Console.WriteLine($"The Largest Ditance is Between {cell}: " + LargeDist);


            #endregion

            #region Q15

            /* 15 Given a list of space separated words, reverse the order of the words. 
             Input: this is a test
             Input: all your base
             Input: Word
             Note :  
             Output: test a is this
             Output: base your all
             Output: Word
             Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement*/

            //string[] Phases = SplitSentance();

            //Console.Write("Reverse Sentance: ");
            //for (int i = Phases.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(Phases[i] + " ");
            //}

            #endregion

            #region Q16

            //16 - Write a program to create two multidimensional arrays of same size. 
            //Accept values from the user and store them in first array. Now copy all
            //the elements of the first array on second array and print second array.

            //Console.Write("size of Rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("size of Columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] array = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"array[{i}, {j}]: ");
            //        array[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //int[,] array2 = _2DCopyTo(array);


            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Q17

            /* 17 - Write a Program to Print One Dimensional Array in Reverse Order*/


            //Console.Write("Enter Size: ");
            //int N = int.Parse(Console.ReadLine());
            //var array = new int[N];

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"array[{i}]: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Reverse(ref array);

            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion




        }
    }

}
