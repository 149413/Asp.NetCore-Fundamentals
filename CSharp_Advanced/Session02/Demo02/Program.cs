using System.Collections;

namespace Demo02
{
    internal class Program
    {


        static int SumArrayList(ArrayList list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += (int)list[i];  // UnBnoxing :  Referencetype[object] To Valuetype[int] - Unsafe
                }
            }
            return Sum;
        }

        static void PrintList<T>(List<T> list)
        {

            if (list is not null)
            {
                foreach (T item in list)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }
        }

        static int SumArrayList(List<int> list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += (int)list[i];
                }
            }
            return Sum;
        }

        static void PrintLinkedList<T>(LinkedList<T> linkedlist)
        {
            Console.Write("Null");
            foreach (T item in linkedlist)
            {
                Console.Write($" <- {item} -> ");
            }
            Console.Write("Null");
        }

        static void PrintStack<T>(Stack<T> stack)
        {
            Console.WriteLine();
            foreach (var top in stack)
            {
                Console.WriteLine(top);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            #region Revision
            // Revision
            // Genaric: CC3 Feature 2005 C# 2.0
            // Before that Used  Object class 
            #endregion

            #region What is Collection ?

            // Collections in C#
            // 1. Lists
            // 2. Hashtables

            // Generic - Non-Generic
            // Lists:
            //Non-Generic Lists: Arraylist - Stack - ueue
            // Genaric lists   : Lists,Linkedlist , Stack , Queue

            // Hastables:
            // Non-Genarics HashTables : HashTable
            // Genarics HashTables     : Dictionary - SortedDictionary

            #endregion

            #region Non-Genaric Lists: ArrayList
            // Lists:
            // Non-Genaric Lists: ArrayList

            // ArrayList Likearray 
            // Array Based
            // index

            // Array     Indexed Collection : Fixed Size
            // ArrayList Indexed Collection : Dynamic Size
            //Index: 0 1 2 3 4 5 
            //Items : 4 5 6 2 1 7
            // size : 6

            // Array[1] = 5
            //int[] Numbers = { 9, 8, 5, 7, 4, 6, 2, 3, 1, 10 };
            //Console.WriteLine(Numbers[1]);
            //Numbers[1] = 12;
            //Console.WriteLine(Numbers[1]);

            //ArrayList arrayList = new ArrayList();
            ////arrayList = new ArrayList(Numbers);
            //arrayList = new ArrayList(new int[] { 1, 2, 3, 4 });  // Icollection
            //arrayList = new ArrayList(3);

            //Console.WriteLine($"Count: {arrayList.Count} Capacity {arrayList.Capacity}");
            //arrayList.Add(6);
            //arrayList.Add(4);
            //arrayList.Add(5);
            //arrayList.Add(2);
            //arrayList.Add(5);
            //arrayList.Add(2);
            //arrayList.Add(5);
            //Console.WriteLine($"Count: {arrayList.Count} Capacity {arrayList.Capacity}");

            // Property
            //Console.WriteLine(arrayList.IsFixedSize);
            //Console.WriteLine(arrayList.IsReadOnly);
            //Console.WriteLine(arrayList[1]);

            #region Functions (Operations)
            // Functions
            //arrayList.AddRange(new int[] { 10, 20, 30 }); // add The End
            //foreach (var item in arrayList)
            //{
            //    Console.Write(item + " ");
            //}
            //int indx = arrayList.BinarySearch(3);
            //Console.WriteLine(indx);

            //// Employee
            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 30 };
            //Employee E02 = new Employee() { Id = 2, Name = "ALi", Salary = 11000, Age = 29 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 13000, Age = 32 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 10000, Age = 27 };

            //ArrayList list = new ArrayList();
            //list.AddRange(new Employee[] { E01, E02, E03, E04 });

            ////Console.WriteLine(list.BinarySearch(E02));
            ////Console.WriteLine(list.BinarySearch(E03, new EmployeeIComparerSalary()));
            ////Console.WriteLine(list.BinarySearch(new Employee() { Salary = 13000 }, new EmployeeIComparerSalary()));
            ////Console.WriteLine(list.BinarySearch(new Employee() { Name = "ALi" }, new EmployeeIComparerName()));
            //Console.WriteLine(list.BinarySearch(0, 2, new Employee() { Name = "ALi" }, new EmployeeIComparerName()));
            //Console.WriteLine("======================");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);

            //Console.WriteLine($"Count: {list.Count} Capacity {list.Capacity}");

            //list.Clear();
            //Console.WriteLine($"Count: {list.Count} Capacity {list.Capacity}");

            //int[] Arr = new int[10];
            ////list.CopyTo(Arr);
            //list.CopyTo(1, Arr, 3, 2);
            //foreach (int i in Arr)
            //{
            //    Console.WriteLine(i);
            //}

            //ArrayList arr = new ArrayList();
            //arr = list.GetRange(0, 2);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list.IndexOf(5));
            //Console.WriteLine(list.LastIndexOf(5));
            //Console.WriteLine(list.Contains(5));

            //list.Insert(0, value: 100);
            //list.InsertRange(0, new int[] { 10, 20, 30 });

            //list.Remove(4);
            //list.RemoveAt(0);
            //list.RemoveRange(0, 2);

            //list.SetRange(index: 1, new int[] { 10, 20, 30 });

            //list.Sort();
            //list.Reverse();

            //Console.WriteLine($"Count: {list.Count} Capacity {list.Capacity}");

            //list.TrimToSize();  // Delete | release

            //Console.WriteLine($"Count: {list.Count} Capacity {list.Capacity}");


            //foreach (int i in list)
            //{
            //    Console.Write(i + " ");
            //}  
            #endregion

            #endregion

            #region problems With Non-Genaric Lists: ArrayList
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            ////list.Add("Helo World");  // Throw Exceotion 
            ////list.Add(new Employee());
            ////list.Add(2.3);

            //int sum = SumArrayList(list);
            //Console.WriteLine(sum); 
            #endregion

            #region Genaric List : Lit
            // Genaric List : Lit
            // List : Version Genaric Of ArrayList
            // List Like ArrayList and Array : Genaric - Dynamic size


            //List<int> list = new List<int>() { 1, 2, 3, 4 };
            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            //list.Add("Hello"); // Error From Compiler
            //int sum = SumArrayList(list);
            //Console.WriteLine(sum);

            //list.AddRange(new int[] { 10, 20, 30 });  // Add At the End
            //PrintList(list);

            //list.AsReadOnly();
            //int i = list.BinarySearch(3);
            //Console.WriteLine(i);

            //// Employee
            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 30 };
            //Employee E02 = new Employee() { Id = 2, Name = "ALi", Salary = 11000, Age = 29 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 13000, Age = 32 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 10000, Age = 27 };
            //Employee E05 = new Employee() { Id = 45, Name = "Samy", Salary = 10000, Age = 27 };

            //List<Employee> list = new List<Employee>() { E01, E02, E03, E04, E05 };
            //int i = list.BinarySearch(E03);
            //int i = list.BinarySearch(new Employee() { Id = 2, Name = "ALi", Salary = 11000, Age = 29 });
            //int i = list.BinarySearch(new Employee() { Name = "Samy" }, new EmployeeIComparerName());
            //Console.WriteLine(i);

            //Console.WriteLine("=========================");
            //PrintList(list);

            //list.AddRange(new Employee[] { E01, E02, E03, E04 });

            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}");
            ////list.EnsureCapacity(4);
            //list.EnsureCapacity(10);  // resize

            //Console.WriteLine($"Count: {list.Count} , Capasity: {list.Capacity}");

            //List<int> res = list.GetRange(0, 2); ;
            //foreach (int item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Slice(0, 2); // return Range in List or integer
            //list.TrimExcess();  // like TrimTosize(); 
            #endregion

            // Genaraic Lists: LinkedList

            //LinkedList<int> linkedlist = new LinkedList<int>();
            //linkedlist.AddFirst(1);
            //linkedlist.AddFirst(2);
            //linkedlist.AddFirst(3);

            //linkedlist.AddLast(1);
            //linkedlist.AddLast(2);

            //LinkedListNode<int> node = new LinkedListNode<int>(3);
            //linkedlist.AddLast(node);

            ////linkedlist.AddAfter(node, 4);
            ////linkedlist.AddBefore(node, 4);

            //LinkedListNode<int> Node = linkedlist.Find(2);
            ////Console.WriteLine(Node!.Value);
            //if (Node is not null)
            //{
            //    linkedlist.AddAfter(Node, 4);
            //}

            ////Console.WriteLine(linkedlist.First); // Naming space
            //Console.WriteLine(linkedlist.First.Value);
            //Console.WriteLine(linkedlist.First.Next.Value);
            //Console.WriteLine(linkedlist.Last.Value);

            //linkedlist.Remove(linkedlist.First);
            //linkedlist.Remove(2);
            //linkedlist.RemoveFirst();
            //linkedlist.RemoveLast();

            //PrintLinkedList(linkedlist);

            #region Genaric list: Stack

            // Genaric list: Stack

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //int top = stack.Peek();
            // bool flag = stack.TryPeek(out int top);
            //Console.WriteLine(top);

            //int top = stack.Pop();
            //bool flag = stack.TryPop(out int top);
            //Console.WriteLine(top);

            //PrintStack(stack);


            #endregion

            #region Genaric list: Stack
            ////Genaric list: Stack
            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //queue.Dequeue();

            //int top = queue.Peek();
            //Console.WriteLine(top); 
            #endregion





        }
    }



}
