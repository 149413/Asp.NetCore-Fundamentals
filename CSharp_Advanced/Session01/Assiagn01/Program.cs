namespace Assiagn01
{
    internal class Program
    {
        #region Q02
        public static void ReverseArray<T>(T[] Array)
        {
            if (Array?.Length > 0)
            {
                for (int i = 0; i < Array.Length / 2; i++)
                {
                    // 1  2  3  4  5
                    // 0  1  2  3  4

                    T temp = Array[i];
                    Array[i] = Array[Array.Length - 1 - i];
                    Array[Array.Length - 1 - i] = temp;
                }

            }

        }
        #endregion

        #region Q03
        public static List<int> EvenNumbers(int[] Array)
        {
            List<int> EvenNum = new List<int>();
            if (Array?.Length > 0)
            {
                foreach (int i in Array)
                {
                    if (i % 2 == 0)
                        EvenNum.Add(i);
                }
            }
            return EvenNum;
        }

        #endregion

        static void Main(string[] args)
        {

            #region Q01
            /*1.create a generic Range < T > class that represents a range of values from a
            minimum value to a maximum value.The range should support basic
            operations such as checking if a value is within the range and determining
            the length of the range.
            Requirements: 
            1. Create a generic class named Range<T> where T represents the type of
            values.

            2. Implement a constructor that takes the minimum and maximum values
            to define the range. 

            3. Implement a method IsInRange(T value) that returns true if the given
            value is within the range, otherwise false. 

            4. Implement a method Length() that returns the length of the range (the
            difference between the maximum and minimum values). 

            5. Note: You can assume that the type T used in the Range<T> class
            implements the IComparable<T> interface to allow for comparisons.*/


            //Range<int> R01 = new Range<int>(5, 10);
            //Console.WriteLine(R01.IsInRange(7));
            //Console.WriteLine(R01.IsInRange(3));
            //Console.WriteLine(R01.IsInRange(11));
            //Console.WriteLine($"Length: {R01.Length()}");

            //Console.WriteLine();

            //Range<double> R02 = new Range<double>(5.8, 10.5);
            //Console.WriteLine(R02.IsInRange(5.8));
            //Console.WriteLine(R02.IsInRange(3.2));
            //Console.WriteLine(R02.IsInRange(11.7));
            //Console.WriteLine($"Length: {R02.Length()}");
            #endregion

            #region Q02
            /* 2.You are given an ArrayList containing a sequence of elements. try to
             reverse the order of elements in the ArrayList in-place(in the same
             arrayList) without using the built-in Reverse.Implement a function that
             takes the ArrayList as input and modifies it to have the reversed order of
             elements.*/

            ////int[] arr = { 1, 2, 3, 4, 5 };
            ////double[] arr = { 1.5, 2.5, 3.5, 4.5, 5.5 };
            //char[] arr = { 'H', 'e', 'l', 'l', 'o' };
            //foreach (var i in arr)
            //{
            //    Console.Write(i + " ");
            //}
            //ReverseArray(arr);
            //Console.WriteLine();
            //foreach (var i in arr)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Q03
            /* 3.You are given a list of integers. Your task is to find and return a new list
             containing only the even numbers from the given list.*/

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            //List<int> EvenNumber = EvenNumbers(Numbers);
            //foreach (int i in EvenNumber)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Q04

            /* 4.implement a custom list called FixedSizeList<T> with a predetermined
             capacity.This list should not allow more elements than its capacity and
             should provide clear messages if one tries to exceed it or access invalid indices.
             Requirements:

             1.Create a generic class named FixedSizeList<T>.

             2. Implement a constructor that takes the fixed capacity of the list as aparameter.

             3.Implement an Add method that adds an element to the list, but throws
             an exception if the list is already full. 

             4.Implement a Get method that retrieves an element at a specific index in 
             the list but throws an exception for invalid indices.*/

            //bool flag = false;
            //int input;
            //do
            //{
            //    Console.WriteLine("Enter Capsity:");
            //    flag = int.TryParse(Console.ReadLine(), out input);
            //} while (!flag);
            //int capacity = input;

            //FixedSizeList<int> list = new FixedSizeList<int>(capacity);
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add(40);

            //Console.WriteLine(list.Get(0));
            //Console.WriteLine(list.Get(2));
            //Console.WriteLine(list.Get(4));


            //foreach (var i in list.list)
            //{
            //    Console.Write(i + " ");
            //}


            #endregion








        }
    }
}
