using System.Collections;

namespace Demo01
{

    // Genaric Class
    internal static class Helper /*<T>*/  <T01> where T01 : class, /*Point,*/ IComparable, ICloneable, IComparer, new()
    {

        // Genaric Constrians:
        // 1. Primary Constraints [0:1]
        // 1.1 class
        // 1.1 struct
        // 1.1 special type point
        // 1.1 ebum
        // 1.1 notnull

        // 2. Secoundry Constraints [0:M]
        // T Implement Interface [IComparable ,ICloneable , IComparer]

        // 3. Constructor Constraints  [new()]


        // T : Mudt Be Type Which Implement The Icomparable Interface

        #region Non Genaric SWAP
        //public static void SWAP(ref int A, ref int B)
        //{
        //    int Temp = A;
        //    A = B;
        //    B = Temp;
        //}
        //public static void SWAP(ref double A, ref double B)
        //{
        //    double Temp = A;
        //    A = B;
        //    B = Temp;
        //}
        //public static void SWAP(ref Point P01, ref Point P02)
        //{
        //    Point Temp = P01;
        //    P01 = P02;
        //    P02 = Temp;
        //}
        #endregion

        #region Genaric SWAP
        // Genaric Method
        public static void SWAP<T>(ref T A, ref T B)
        {
            T Temp = A;
            A = B;
            B = Temp;
        }


        //public static void Print(T Data)
        //{

        //}
        //public static void Print<T01 , T02>(T01 A , T02 B)
        //{
        //    Console.WriteLine($"A: {A}");
        //    Console.WriteLine($"B: {B}");
        //} 
        #endregion


        #region Non Genaric LinearSearch
        //// Linear Search Algo
        //public static int LinearSearch(int[] Array, int Num)
        //{
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        if (Array?.Length > 0)
        //        {
        //            if (Array[i] == Num)
        //                return i;
        //        }
        //    }
        //    return -1;
        //}

        #endregion

        #region Genaric LinearSearch
        //Genaric LinearSearch

        public static int LinearSearch<T>(T[] Array, T Value)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array?.Length > 0)
                {
                    //if (Array[i] == Num) //Not Support
                    if (Array[i].Equals(Value))
                        return i;
                }
            }
            return -1;
        }
        #region Genaric IEqualityComparer
        public static int LinearSearch<T>(T[] Array, T Value, IEqualityComparer<T> equalityComparer)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array?.Length > 0)
                {
                    //if (Array[i] == Num) //Not Support
                    if (equalityComparer.Equals(Array[i], Value))
                        return i;
                }
            }
            return -1;
        }
        #endregion

        #endregion


        #region Non Genaric Bubble Sort

        //public static int[] BubbleSort(int[] Array)
        //{
        //    if (Array?.Length > 0)
        //    {
        //        for (int i = 0; i < Array.Length; i++)
        //        {
        //            for (int j = 0; j < Array.Length - i - 1; j++)
        //            {
        //                if (Array[j] > Array[j + 1])
        //                    SWAP(ref Array[j], ref Array[j + 1]);
        //            }
        //        }
        //    }
        //    return Array;
        //}

        //public static void PrintArray(int[] Array)
        //{
        //    foreach (int i in Array)
        //    {
        //        Console.Write($"{i} ");
        //    }
        //    Console.WriteLine();
        //} 
        #endregion

        #region Genaric Bubble sort
        public static T[] BubbleSort<T>(T[] Array) where T : IComparable /*<T>*/
        {
            if (Array?.Length > 0)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length - i - 1; j++)
                    {
                        //if (Array[j] > Array[j + 1])
                        if (Array[j].CompareTo(Array[j + 1]) > 0)
                            SWAP(ref Array[j], ref Array[j + 1]);
                    }
                }
            }
            return Array;
        }
        #region Genaric IComparable
        public static T[] BubbleSort<T>(T[] Array, IComparer<T> comparable) where T : IComparable /*<T>*/
        {
            if (Array?.Length > 0)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length - i - 1; j++)
                    {
                        if (comparable.Compare(Array[j], Array[j + 1]) > 0)
                            SWAP(ref Array[j], ref Array[j + 1]);
                    }
                }
            }
            return Array;
        }
        #endregion

        public static void PrintArray<T>(T[] Array) where T : IComparable /*<T>*/
        {
            foreach (T i in Array)
            {
                Console.Write($"{i} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        #endregion



    }
}
