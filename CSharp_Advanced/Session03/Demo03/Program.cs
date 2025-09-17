namespace Demo03
{
    // Class 
    // Interface
    // Enum
    // Struct
    // Delegate



    #region Deleegate EX01
    // Step 01: Create NEW Delgete (class) : Special Class [Have Prototype - methods - constructor - Event]
    public delegate int StringFunDelegate(string s);
    // NEW Delegete (class) : Reference (Pointer) Can Refer To Function Or More (Pointer Of Function)
    // These Functions Must Have The Same Segnature of Delegate  int(string)
    // Regardness Function Name , Parameter Names or Access Modifier 
    #endregion


    delegate bool NumFuncDelegate(int x);
    delegate bool NumFuncDelegateV02(string s);


    delegate bool NumFuncDelegateVT<T>(T t);


    internal class Program
    {
        public static object Dectionary { get; private set; }



        #region Delegate EX02
        public static void PrintArray<T>(T[] Array)
        {
            Console.WriteLine();
            if (Array.Length > 0)
            {
                for (int i = 0; i < Array.Length; i++)
                {

                    Console.Write(Array[i] + " ");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Delegate EX03

        #region With Delegate

        //public static List<T> FindElements<T>(List<T> list, Predicate<T> reference)
        //{
        //    List<T> Result = new List<T>();
        //    if (list.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            //if (list[i] % 2 != 0)
        //            if (reference.Invoke(list[i]))
        //                Result.Add(list[i]);
        //        }
        //    }
        //    return Result;
        //}

        public static List<int> FindElements(List<int> list, Func<int, bool> reference /*Predicate<T> reference*/)
        {
            List<int> Result = new List<int>();
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    //if (list[i] % 2 != 0)
                    if (reference.Invoke(list[i]))
                        Result.Add(list[i]);
                }
            }
            return Result;
        }

        //public static List<int> FindElements(List<int> list, NumFuncDelegate reference)
        //{
        //    List<int> OddNum = new List<int>();
        //    if (list.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            //if (list[i] % 2 != 0)
        //            if (reference.Invoke(list[i]))
        //                OddNum.Add(list[i]);
        //        }
        //    }
        //    return OddNum;
        //}
        //public static List<string> FindElements(List<string> list, NumFuncDelegateV02 reference)
        //{
        //    List<string> Result = new List<string>();
        //    if (list.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            //if (list[i] % 2 != 0)
        //            if (reference.Invoke(list[i]))
        //                Result.Add(list[i]);
        //        }
        //    }
        //    return Result;
        //}
        #endregion


        #region Without Delegate
        //public static List<int> FindOddNum(List<int> list)
        //{
        //    List<int> OddNum = new List<int>();
        //    if (list.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            //if (list[i] % 2 != 0)
        //            if (ConditionFunction.CheckOdd(list[i]))
        //                OddNum.Add(list[i]);
        //        }
        //    }
        //    return OddNum;
        //}
        //public static List<int> FindEvenNum(List<int> list)
        //{
        //    List<int> OddNum = new List<int>();
        //    if (list.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            //if (list[i] % 2 == 0)
        //            if (ConditionFunction.CheckEven(list[i]))
        //                OddNum.Add(list[i]);
        //        }
        //    }
        //    return OddNum;
        //}
        //public static List<int> FindDivideBy3(List<int> list)
        //{
        //    List<int> OddNum = new List<int>();
        //    if (list.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            //if (list[i] % 3 == 0)
        //            if (ConditionFunction.CheckDivide3(list[i]))
        //                OddNum.Add(list[i]);
        //        }
        //    }
        //    return OddNum;
        //}
        //public static List<int> FindDivideBy4(List<int> list)
        //{
        //    List<int> OddNum = new List<int>();
        //    if (list.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 4 == 0)
        //                OddNum.Add(list[i]);
        //        }
        //    }
        //    return OddNum;
        //} 
        #endregion 

        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Build-in Delegate

        //delegate bool NumFuncDelegateVT<T>(T t);

        public static int Fun01()
        {
            return 1;
        }
        public static int Fun02(string s)
        {
            return 1;
        }
        public static void Print1()
        {
            Console.WriteLine("Hello World 1");
        }
        public static void Print2(string s)
        {
            Console.WriteLine("Hello World 2");
        }


        #endregion


        #region Function Return Function

        public static Action MyFunc()
        {
            //Action action = Print; 
            //Action action = delegate () { Console.WriteLine("Hello World"); }; 
            Action action = () => Console.WriteLine("Hello world");
            return action;
        }
        public static void Print()
        {
            Console.WriteLine("Hellp World");
        }

        #endregion


        static void Main(string[] args)
        {
            #region Delegate Overview
            // Delegate : C# Featue

            // C# Pure OOP

            // Functional Progamming
            // Even-Deriven Programming


            // Java: Pure OOP
            // DP: Desiagne Pattern 
            #endregion

            #region Delegete EX01
            // New Delegate(class) : 

            //X = GetCountOfUpperCasechars;
            //StringFunDelegate X;
            //X = StringFunction.GetCountOfUpperCasechars;

            // Step 02 : Declare Variable Delegete
            //StringFunDelegate X = new StringFunDelegate(StringFunction.GetCountOfUpperCasechars);

            //StringFunDelegate X = StringFunction.GetCountOfUpperCasechars;  // Syntax Suger
            //X += StringFunction.GetCountOfLowerCasechars;

            ////int count = X.Invoke("Hello World");
            //int count = X("Hello World"); // Syntax Suger

            //Console.WriteLine(count); 
            #endregion

            #region Delegare EX02
            #region Without Genaric
            //int[] Array = { 7, 5, 2, 4, 8, 6, 2, 1, 9 };
            //PrintArray(Array);

            ////SortingAlgorithms.BubbleSortAscending(Array);
            ////SortingAlgorithms.BubbleSortDescending(Array);

            ////StringFunctionDelegate X = SortingCondition.CompareGrt;
            ////StringFunctionDelegate X = SortingCondition.CompareLess;

            ////SortingAlgorithms.BubbleSort(Array, SortingCondition.CompareGrt);
            //SortingAlgorithms.BubbleSort(Array, SortingCondition.CompareLess);
            //PrintArray(Array); 
            #endregion

            #region With Genaric
            //string[] Names = { "Ahmed", "Osama", "Mariam", "Ola", "Mohamed", "Hassan" };

            //PrintArray(Names);

            ////SortingAlgorithms.BubbleSort(Names, SortingCondition.CompareGrt);
            //SortingAlgorithms.BubbleSort(Names, SortingCondition.CompareLess);

            //PrintArray(Names); 
            #endregion

            #endregion

            #region Delegate EX03
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();
            ////List<int> OddNum = FindOddNum(Numbers);
            ////List<int> EvenNum = FindEvenNum(Numbers);
            ////List<int> DivideBy3 = FindDivideBy3(Numbers);
            ////List<int> DivideBy4 = FindDivideBy4(Numbers);


            //List<int> OddNum = FindElements(Numbers, ConditionFunction.CheckOdd);
            //List<int> EvenNum = FindElements(Numbers, ConditionFunction.CheckEven);
            //List<int> DivideBy3 = FindElements(Numbers, ConditionFunction.CheckDivide3);
            //List<int> DivideBy4 = FindElements(Numbers, ConditionFunction.CheckDivide4);


            //PrintList(EvenNum);

            //// String
            //List<string> Names = new List<string> { "Ahmed", "Osam", "Mariam", "Ola", "Mohamed", "Ali" };

            //PrintList(Names);
            ////List<string> Result = FindElements(Names, ConditionFunction.LengthGtr4);
            ////List<string> Result = FindElements(Names, ConditionFunction.LengthLess4);
            //List<string> Result = FindElements(Names, ConditionFunction.LengthEqual4);

            //PrintList(Result);



            #endregion

            #region  Build-in Delegate
            // Build-in Delegate
            //1. Predicate<>  [Default ReturnType Boolian]
            //2. Func<>  [Default Return Any datatype]
            //3. Acion<>  [Default ReturnType Void]


            // String
            //List<string> Names = new List<string> { "Ahmed", "Osam", "Mariam", "Ola", "Mohamed", "Ali" };

            //PrintList(Names);
            //NumFuncDelegateVT<string> f = ConditionFunction.LengthGtr4;
            //// Priidicat 
            //Predicate<string> pre = ConditionFunction.LengthGtr4;
            //List<string> Result = FindElements(Names, pre);

            //PrintList(Result);


            //// predicate
            //Predicate<int> predicate = ConditionFunction.CheckOdd;
            //bool f = predicate(2);
            //Console.WriteLine(f);

            //// 2. Func
            //Func<int, bool> func = ConditionFunction.CheckOdd;
            //bool r = func.Invoke(2);
            //Console.WriteLine(r);

            //Func<int> func1 = Fun01;
            //Func<string , int> func2 = Fun02;

            ////3. action
            //Action action = Print1;
            //action();
            //action.Invoke();

            //Action<string> action2 = Print2;
            //action2("AA");
            //action2.Invoke("AA");

            #endregion

            #region Anomennous Methods && Lamda Expression
            //// Anomennous Methods && Lamda Expression
            //// C# 2.0 2005

            ////Func<int, bool> func = ConditionFunction.CheckEven;
            //// 1. Anomennous Methods
            ////Func<int, bool> func = delegate (int X) { return X % 2 == 0; }; 
            ////bool f = func(2);

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Func<int, bool> func = delegate (int X) { return X % 2 == 0; };

            ////FindElements(Numbers, func);
            //FindElements(Numbers, delegate (int N) { return N % 2 == 0; });

            //// 2. Lambda Exepression
            //// C# 3.0 2007

            //Func<int, bool> fun = X => X % 2 == 0; // Syntax Suger for Anoumenos

            //FindElements(Numbers, (int N) => N % 2 == 0);
            //FindElements(Numbers, N => N % 2 != 0);


            //Enumerable.Where(Numbers, ConditionFunction.CheckEven);
            //Enumerable.Where(Numbers, delegate (int N) { return N % 2 == 0; }); // Anomenous Expression
            //Enumerable.Where(Numbers, (N) => N % 2 == 0); // Lambda Expression


            #endregion


            #region Function Return Function
            //// Function Return Function

            //Action action = MyFunc();
            //action.Invoke();
            //action();

            //// OR

            ////MyFunc();
            //MyFunc()();  // [ action = MyFunc() ] + () 
            #endregion

            #region  Non-Genaric HashTable : HashTable
            // 2. Hash Table
            // 2.1. Non-Genaric Hash Table

            //Hashtable phoneBook = new Hashtable();
            //phoneBook.Add("Ahmed", 1111111);
            //phoneBook.Add("Ali", 2222222);
            //phoneBook.Add("Amr", 3333333);
            //phoneBook.Add("Samy", 11111111);
            //phoneBook.Add(2222222, "Ahmed");

            //Console.WriteLine(phoneBook.Count);

            //Console.WriteLine(phoneBook.IsFixedSize);
            //Console.WriteLine(phoneBook.IsReadOnly);


            //foreach (var item in phoneBook.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in phoneBook.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //phoneBook["Ahmed"] = 123456789;
            //Console.WriteLine(phoneBook["Ahmed"]);

            //Console.WriteLine(phoneBook.Contains("Ali"));  // O(1)
            //Console.WriteLine(phoneBook.Contains("ABC"));

            //Console.WriteLine(phoneBook.ContainsKey("Ahmed")); // O(1)


            //phoneBook.Remove("Amr");
            //phoneBook.Remove("ABD");
            ////phoneBook.Remove(null); // throw Exception


            ////Console.WriteLine();
            //Console.WriteLine("=================");
            //foreach (DictionaryEntry item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Genaric HashTable : Dictionary
            // Genaric HashTable : Dictionary

            //Dictionary<string, long> phoneBook = new Dictionary<string, long>();

            //phoneBook.Add("Ahmed", 1111111);
            //phoneBook.Add("Ali", 2222222);
            //phoneBook.Add("Amr", 111111);

            //phoneBook.Add(null, 4444444);

            //phoneBook.Add(2222222,  3333333333);  // Invalid


            //var Flag = phoneBook.Remove("Ahmed");
            //Console.WriteLine(Flag);

            //var Flag = phoneBook.Remove("Ahmed", out long result);
            //Console.WriteLine(Flag);
            //Console.WriteLine(result);


            ////phoneBook.Add("Ahmed", 1342564);
            //var flag = phoneBook.TryAdd("Ahmed", value: 1342564);
            //Console.WriteLine(flag);


            //var Flag = phoneBook.TryGetValue("Ahmed", out long result);
            //var Flag = phoneBook.TryGetValue("Ahfggmed", out long result);
            //Console.WriteLine(Flag);
            //Console.WriteLine(result);


            //foreach (KeyValuePair<string, long> item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Genaric HashTable : HashSet
            //// Genaric HashTable : HashSet

            //HashSet<string> Names = new HashSet<string>();

            //Names.Add("Ahmed");
            //Names.Add("Ahmed");
            //Names.Add("Ali");
            //Names.Add("Amr");

            ////Names.Count();
            ////Names.Comparer;
            ////Names.


            //foreach (var item in Names)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


        }
    }
}
