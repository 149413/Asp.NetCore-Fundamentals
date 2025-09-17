namespace Demo03
{
    public delegate bool StringFunctionDelegate(int X, int Y);
    public delegate bool StringFunctionDelegateV02(string X, string Y);

    public delegate bool StringFunctionDelegateVT<T>(T X, T Y);

    internal class SortingAlgorithms
    {
        #region Genaric Sort
        // Genaric
        public static void BubbleSort<T>(T[] Array, StringFunctionDelegateVT<T> X /*reference*/)
        {
            if (Array.Length > 0)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length - 1; j++)
                    {
                        //if (Array[j] > Array[j + 1])
                        if (X.Invoke(Array[j], Array[j + 1]))
                        {
                            SWAP(ref Array[j], ref Array[j + 1]);
                        }
                    }

                }
            }
        }
        #endregion

        #region NonGenaric Sort 
        // Non Genaric
        //public static void BubbleSort(int[] Array, StringFunctionDelegate X /*reference*/)
        //{
        //    if (Array.Length > 0)
        //    {
        //        for (int i = 0; i < Array.Length; i++)
        //        {
        //            for (int j = 0; j < Array.Length - 1; j++)
        //            {
        //                //if (Array[j] > Array[j + 1])
        //                if (X.Invoke(Array[j], Array[j + 1]))
        //                {
        //                    SWAP(ref Array[j], ref Array[j + 1]);
        //                }
        //            }

        //        }
        //    }
        //}
        //public static void BubbleSort(string[] Array, StringFunctionDelegateV02 X /*reference*/)
        //{
        //    if (Array.Length > 0)
        //    {
        //        for (int i = 0; i < Array.Length; i++)
        //        {
        //            for (int j = 0; j < Array.Length - 1; j++)
        //            {
        //                //if (Array[j] > Array[j + 1])
        //                if (X.Invoke(Array[j], Array[j + 1]))
        //                {
        //                    SWAP(ref Array[j], ref Array[j + 1]);
        //                }
        //            }

        //        }
        //    }
        //} 
        #endregion


        #region Simple Sort
        //public static void BubbleSortAscending(int[] Array)
        //{
        //    if (Array.Length > 0)
        //    {
        //        for (int i = 0; i < Array.Length; i++)
        //        {
        //            for (int j = 0; j < Array.Length - 1; j++)
        //            {
        //                //if (Array[j] > Array[j + 1])
        //                if (SortingCondition.CompareGrt(Array[j], Array[j + 1]))
        //                {
        //                    SWAP(ref Array[j], ref Array[j + 1]);
        //                }
        //            }

        //        }
        //    }
        //}
        //// Not Imp DRY Concept:
        //public static void BubbleSortDescending(int[] Array)
        //{
        //    if (Array.Length > 0)
        //    {
        //        for (int i = 0; i < Array.Length; i++)
        //        {
        //            for (int j = 0; j < Array.Length - 1; j++)
        //            {
        //                //if (Array[j] < Array[j + 1])
        //                if (SortingCondition.CompareLess(Array[j], Array[j + 1]))
        //                {
        //                    SWAP(ref Array[j], ref Array[j + 1]);
        //                }
        //            }

        //        }
        //    }
        //} 
        #endregion




        public static void SWAP(ref int X, ref int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }
        public static void SWAP(ref string X, ref string Y)
        {
            string temp = X;
            X = Y;
            Y = temp;
        }

        public static void SWAP<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }



    }
}
