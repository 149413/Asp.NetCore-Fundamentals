namespace Assiagn02
{
    internal class Program
    {

        #region Q 02

        static bool IsPalindrom(int[] Array, int N)
        {
            for (int i = 0; i < N / 2; i++)
            {
                if (Array[i] != Array[N - 1 - i])
                    return false;
            }
            return true;
        }

        #endregion

        #region Q 03
        static void Revers<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            while (queue.Count() > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count() > 0)
            {
                queue.Enqueue(stack.Pop());
            }

        }



        #endregion

        #region Q 04

        //static bool IsBalanced(Stack<char> stack)
        //{
        //    Stack<char> temp = new Stack<char>();
        //    while (stack.Count() > 0)
        //    {
        //        char c = stack.Pop();
        //        if (temp.Count() != 0)
        //        {
        //            if()
        //        }

        //        // [[()}{]]

        //    }
        //    if (temp.Count() > 0)
        //    {
        //        return false;
        //    }

        //    return true;
        //}
        #endregion

        #region Q 05
        static void RemoveDuplicate(ref int[] array)
        {
            //Array.Sort(array);
            Queue<int> queue = new Queue<int>();
            int i = 0;
            queue.Enqueue(array[i++]);
            while (i < array.Length)
            {
                if (queue.Contains(array[i]) == false)
                {
                    queue.Enqueue(array[i]);
                }
                i++;
            }

            array = new int[queue.Count];
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = queue.Dequeue();
            }

            //return array;

        }


        #endregion

        #region Q 06

        static void removeOddNum(ref int[] array)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    temp.Add(array[i]);
                }
            }
            array = temp.ToArray();

        }


        #endregion


        #region Q 11
        static void ReverseFirstKElements<T>(Queue<T> queue, int k)
        {
            if (queue == null || k <= 0 || k > queue.Count)
                return;

            Stack<T> stack = new Stack<T>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            int remaining = queue.Count - k;
            for (int i = 0; i < remaining; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }



        #endregion

        static void Main(string[] args)
        {

            #region Q01
            /* 1.Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
                     Ex:
                 Input
                 3 3                    //Size of array , number of queries
                 11 5 3                  //Array 
                 1                      //Query1
                 5                     //Query2
                 13                  //Query 3
                 Output
                 3                   //11,5,3
                 1                  //11
                 0 */

            //int size = int.Parse(Console.ReadLine());
            //int numOfQuery = int.Parse(Console.ReadLine());

            //int[] array = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //int t = 0;
            //int[] Query = new int[numOfQuery];
            //while (t < numOfQuery)
            //{
            //    Query[t] = int.Parse(Console.ReadLine());
            //    t++;
            //}
            //int j = 0;

            //while (j < numOfQuery)
            //{
            //    int count = 0;
            //    for (int i = 0; i < size; i++)
            //    {
            //        if (array[i] > Query[j])
            //            ++count;
            //    }
            //    j++;
            //    Console.WriteLine(count);
            //}

            #endregion


            #region Q02

            /* 2.Given a number N and an array of N numbers.Determine if it's palindrome or not.
             Ex:
             Input:
             5
             1 3 2 3 1
             Output:
             YES*/


            //int N = int.Parse(Console.ReadLine());
            //int[] Array = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    Array[i] = int.Parse(Console.ReadLine());
            //}
            //bool flag = IsPalindrom(Array, N);
            //if (flag)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{ Console.WriteLine("No"); }

            #endregion


            #region Q03

            /*            3.Given a Queue, implement a function to reverse the elements of a queue using a stack.
            */

            //Queue<int> queue = new Queue<int>();
            //bool f = true;
            //do
            //{
            //    f = int.TryParse(Console.ReadLine(), out int peek);
            //    if (f)
            //    {
            //        queue.Enqueue(peek);
            //    }

            //} while (f);

            //foreach (int i in queue)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Revers(queue);
            //foreach (int i in queue)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion


            #region Q04

            /*  4.Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
              Ex:
              Input:
              [()] { }
              Output:
              Balanced*/

            //Stack<char> parentheses = new Stack<char>();
            //bool f = false;
            //Console.WriteLine("Press Enter To Quit");
            //do
            //{
            //    f = char.TryParse(Console.ReadLine(), out char peek);
            //    if (f)
            //    {
            //        parentheses.Push(peek);
            //    }
            //} while (f);



            //bool flag = IsBalanced(parentheses);
            //if (flag)
            //    Console.WriteLine("Balanced");
            //else
            //    Console.WriteLine("Not Balanced");



            #endregion

            #region Q05

            /*5.Given an array, implement a function to remove duplicate elements from an array.*/


            //int[] Array = { 1, 2, 3, 4, 5, 2, 6, 4, 2, 6, 7 };
            //foreach (int i in Array)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //RemoveDuplicate(ref Array);
            //foreach (int i in Array)
            //{
            //    Console.Write(i + " ");
            //
            #endregion


            #region Q06

            /*6.Given an array list , implement a function to remove all odd numbers from it.*/

            //int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int i in Array)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //removeOddNum(ref Array);
            //foreach (int i in Array)
            //{
            //    Console.Write(i + " ");

            //}

            #endregion


            #region Q07

            /* 7.Implement a queue that can hold different data types. 
             And insert the following data:
             queue.Enqueue(1)
             queue.Enqueue(“Apple”)
             queue.Enqueue(5.28)*/

            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q08

            /* 8.Create a function that pushes a series of integers onto a stack.
             * Then, search for a target integer in the stack.If the target is found, 
             * print a message indicating that the target was found how many elements were checked before
             * finding the target(“Target was found successfully and the count = 5”).
             * If the target is not found, print a message indicating that the target was not found(“Target was not found”).
             Note : take the target as input from the user*/
            /*
                        Stack<int> stack = new Stack<int>();
                        for (int i = 10; i < 100; i += 10)
                        {
                            stack.Push(i);
                        }
                        foreach (int i in stack)
                        {
                            Console.WriteLine(i);
                        }
                        Console.Write("Target: ");
                        int Target = int.Parse(Console.ReadLine());

                        int count = stack.Count(), size = stack.Count();
                        while (stack.Count() > 0)
                        {

                            if (stack.Pop() == Target)
                                break;

                            --count;
                        }

                        if (count != 0)
                            Console.WriteLine($"Target was found successfully and the count = {size - count + 1}");
                        else
                            Console.WriteLine("Target was not found");*/


            #endregion


            #region Q 09

            /*9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
            Ex : 
            Input :
            5 , 3
            [1,2,3,4,4] , [10,4,4]
            Output : 
            [4,4]
            */

            //Console.Write($"size1: ");
            //int s1 = int.Parse(Console.ReadLine());
            //Console.Write($"size2: ");
            //int s2 = int.Parse(Console.ReadLine());
            //int[] array1 = new int[s1];
            //int[] array2 = new int[s2];
            //Console.WriteLine("array1:");
            //for (int i = 0; i < s1; i++)
            //{
            //    array1[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("array2:");

            //for (int i = 0; i < s2; i++)
            //{
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //List<int> res = new List<int>();
            //for (int i = 0; i < s1; i++)
            //{
            //    for (int j = 0; j < s2; j++)
            //    {
            //        if (array2[j] == array1[i])
            //        {
            //            res.Add(array1[i]);
            //            array2[j] = -1;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //foreach (int i in res)
            //{

            //    Console.WriteLine(i + " ");
            //}


            #endregion

            #region Q 10


            /* 10.Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
             Ex:
             Input:
             [1, 2, 3, 7, 5]
             12
             Output:
             [2, 3, 7] */



            //ArrayList array = new ArrayList() { 2, 4, 1, 3, 6 };  // t : 8
            //int Target = 8;
            //ArrayList list = new ArrayList();
            //int left = 0, right = 0;
            //while (right < array.Count)
            //{
            //    int Sum = 0;
            //    for (int i = left; i <= right; i++)
            //    {
            //        Sum += (int)array[i];
            //    }
            //    if (Sum == Target)
            //    {
            //        for (int i = left; i <= right; i++)
            //        {
            //            list.Add(array[i]);
            //        }
            //        break;
            //    }
            //    else if (Sum < Target)
            //    {
            //        ++right;
            //    }
            //    else if (Sum > Target)
            //    {
            //        ++left;
            //    }

            //}
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Q11
            /* 11.Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order
             Ex : 
             Input:
             [1, 2, 3, 4, 5]
             K = 3
             Output:
             [3, 2, 1, 4, 5] */

            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            //int k = 3;

            //foreach (int i in queue)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //ReverseFirstKElements(queue, k);

            //foreach (int i in queue)
            //{
            //    Console.Write(i + " ");
            //}


            #endregion



        }
    }
}
