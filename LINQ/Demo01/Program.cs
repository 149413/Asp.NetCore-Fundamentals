namespace Demo01
{
    internal class Program
    {

        #region Implicitly-Type Local Variables [Var - dynamic]
        //public static var Print(var text)
        //{
        //    return text;
        //}

        //public static dynamic Print(dynamic text)
        //{
        //    return text;
        //}

        #endregion


        static void Main(string[] args)
        {

            #region Demo 01

            #region 1. Implicitly-Type Local Variables [[ Var - dynamic ]]
            // Var Vs Dynamic
            // Implicitly-Type Local Variables [Var - dynamic]
            // 
            // var
            //var Data01 = "Ahmed";
            // compiler Can Detect The DataType of The Local Variable Based on Initial Value , At Compile Time
            // Must Be Initialized
            // Can't Initialize The Local Variable with Null Value
            // Can't change The DataType of The local Variable After Initialization
            // Can't Use Var As a Parameter or Retun DataType


            //Data01 = 22; // Invalid


            // Dynamic: Like Var in JS 

            //dynamic data02 = "Ahmed";

            // CLR Detect the DataType of The Local Variable Based on The Last Value , At RunTime
            // Don't Need To Be Initialized 
            // Can Initialize The Local Variable with null Value
            // Can Change The DataType of The Local Variable After Initialization
            // Can Use dynamic Keyword as Parameter or Return Type 

            //dynamic data02;

            //data02 = null; // Valid

            //data02 = 12;
            //Console.WriteLine(data02.GetType().Name);
            //data02 = 1.24;
            //Console.WriteLine(data02.GetType().Name);
            //data02 = 16f;
            //Console.WriteLine(data02.GetType().Name);
            //data02 = 120.123m;
            //Console.WriteLine(data02.GetType().Name);
            //data02 = true;
            //Console.WriteLine(data02.GetType().Name);



            //Note:

            //var X = delegate() { Console.WriteLine("Hello  World");}; // Accept Anonymous Method 
            //var Y = () => Console.WriteLine("Hello  World"); // Accept Lambda Expression


            //// Dynamic Not Accept Anonymous Method OR Lambda Expression
            //dynamic X = delegate() { Console.WriteLine("Hello  World");};   // InValid
            //dynamic Y = () => Console.WriteLine("Hello  World");  // InValid





            #endregion

            #region 2. Anonymous Type
            // Anonymous Type

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000 };

            //var E01 = new { Id = 1, Name = "Ahmed", Salary = 12000.0m };
            //var E02 = new { Id = 1, Name = "Ahmed", Salary = 12000.0m };

            //var E02 = E01 with { Id = 2 }; // NEW Function in C# 10.0

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);

            //E01.Id = 12;  // InValid: Immutable Can't Change Value After Initialization 

            //Console.WriteLine(E01.GetType().Name); // <>f__AnonymousType0`3
            //Console.WriteLine(E02.GetType().Name); // <>f__AnonymousType0`3

            // The Same Anonymous Type as long as:
            // 1. The Same Property Names [Case Sensitive]
            // 2. The Same Property Order.

            //Console.WriteLine(E01);  // { Id = 1, Name = Ahmed, Salary = 12000.0 }
            // Compiler Will Override On ToString


            // TheCompiler will Override on Func GetHashCode() 
            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //if (E01.Equals(E02)) // Compiler override on Equal()
            //{
            //    Console.WriteLine("E01 == E02");
            //}
            //else
            //    Console.WriteLine("E01 !=  E02");


            //Console.WriteLine(E01);
            //Console.WriteLine(E02);

            #endregion

            #region 3. Extension Method
            // Extension Method : Can Call The Function/Method As a Member in The Class 
            // By Object From This class

            //int Number = 12345;


            ////var result = IntExtension.Reverse(Number); // Call As : Class Member method

            //var result = Number.Reverse();// Call As : Extention method

            //Console.WriteLine(result);


            //long Number1 = 12345;

            //var result1 = Number1.Reverse();
            //Console.WriteLine(result1); 
            #endregion

            #region LINQ    
            #endregion

            #region  What is The LINQ
            // What is The LINQ
            // LINQ: Language Integrated Query
            //     : 40+ Extension Methods (LINQ Operators) Against Any Data [Data Must in Sequence]
            //     : 13 Category
            //     : LINQ Operators Exist In Build-in Class "Enumerable"

            // Sequence : Object From Class Implement Interface "IEnumerable"
            // Local  Sequence  : L2O, L2XML
            // Remote Sequence  : L2EF

            // Shapes Of LINQ Operations

            // Input Sequence -> LINQ Operator -> OutPut Sequence
            // Input Sequence -> LINQ Operator -> One Value
            //                -> LINQ Operator -> OutPut Sequence


            // Note : Any Build-in Collection Will Implement Interface IEnumerable" 

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////1.
            //var result1 = Enumerable.Where(Numbers, N => N % 2 == 0); // Output: Sequence

            //foreach (var item in result1)
            //{
            //    Console.Write($"{item} ");
            //}

            ////2. 
            //var result2 = Enumerable.Any(Numbers, N => N % 2 == 0); //Output: One Value [True (Found) : False (Not Found)]
            //Console.WriteLine();
            //Console.WriteLine(result2);



            ////3.
            //var result3 = Enumerable.Range(1, 100); // Output: Sequence 
            //foreach (var item in result3)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region  LINQ Syntax

            // LINQ Syntax

            //1. Fluant Syntax : Use LINQ Methods


            // 1.1. LINQ Operator as => Class Member Method Through Class "Enumerable"

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Enumerable.Where(Numbers, N => N % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}


            // 1.2. LINQ Operator as :=> Extension Method through Sequence  [Recommended]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(N => N % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}

            //2. Query Syntax [Query Expression]  Like SQL Style
            // Start: From
            // End  : Select , group by
            // Query Syntax easier than Fluent with (join , Group by , Let , into )

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = from N in Numbers
            //             where N % 2 == 0
            //             select N;
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region LINQ Execution Ways
            // LINQ Execution Ways

            //1. Differed Way  : The Query line Not Implement at the Same Time

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(N => N % 2 == 0); // Differed

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (int n in result)// Execute here
            //{
            //    Console.Write($"{n} ");  // 2 4 6 8 10 12 14
            //}



            //2. Immediate Way : The Query Line Implement At The Same Time

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(N => N % 2 == 0).ToList(); // Immediate

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (int n in result)
            //{
            //    Console.Write($"{n} "); // 2 4 6 8 10
            //} 
            #endregion

            #region Setup Data

            // Setup Data

            //Console.WriteLine(ListGenerator.ProductList[0]);
            //Console.WriteLine(CustomerList[0]);

            //var result = ProductList.Where(P => P.UnitsInStock == 0);
            //var res = CustomerList.Where(C => C.City == "Berlin");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 1. Filteration Operator [ Where /  Oftype]
            //Filteration Operator

            // LINQ 40+ Operators
            // LINQ 13 Category

            //1 Filteration Operators - Where / OfType

            // Task : All Product Out Stock

            // Flaunt Syntax
            //var value = ProductList.Where(P => P.UnitsInStock == 0);

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry");

            //var res = ProductList.Where(P => P.UnitsInStock > 0).Where(C => C.Category == "Meat/Poultry");
            //var res = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");


            // Note : Indexed Where() Valid Only in Fluant Syntax
            // Can't Be Written Using Query Syntax [Query Expression]

            //var resl = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            //var resl = ProductList.Where((P, Index) => Index < 5);
            //var resl = ProductList.Where((P, Index) => Index < 5 && P.UnitsInStock > 0);
            //var resl = ProductList.Where(P => P.UnitsInStock > 0).Where((P, Idx) => Idx < 5);


            //// Query Syntax [Query Expression]
            //var value = from P in ProductList
            //            where P.UnitsInStock == 0
            //            select P;

            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;

            //var res = from P in ProductList
            //          where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //          select P;


            //foreach (var unit in res)
            //{
            //    Console.WriteLine(unit);
            //}


            //// OfType : Filter The Elements Based on dataType with NonGenaric Collection

            //ArrayList arraylist = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.5, 2.5, 1.7f, 1.8f, 2.3m, ProductList[0], ProductList[1] };


            //var result = arraylist.OfType<int>();
            //var result = arraylist.OfType<double>();
            //var result = arraylist.OfType<Product>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2. Transation Operators [Select / Select Many]

            // Transation Operators [Select / Select Many]

            //var result = ProductList.Select(P => P);
            //var result = ProductList.Select(P => P.ProductName);
            //var result = ProductList.Select(P => new { P.ProductName, P.Category });
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.Category,
            //                            OldPrice = P.UnitPrice,
            //                            NewPrice = P.UnitPrice - P.UnitPrice * .10m
            //                        }
            //                                );



            //var result = from P in ProductList
            //             select P;

            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == "Seafood"
            //             select new
            //             {
            //                 p.ProductName,
            //                 p.Category,
            //                 OldPrice = p.UnitPrice,
            //                 NewPrice = p.UnitPrice - p.UnitPrice * .10m
            //             };



            //var result = CustomerList.Select(C => C.Orders); // if One Of The Property Not Sequence

            //var result = CustomerList.SelectMany(C => C.Orders); // if One Of The Property is Sequence
            //var result = CustomerList.Where((C, I) => I < 10).SelectMany(C => C.Orders); // if One Of The Property is Sequence
            //var result = CustomerList.SelectMany(C => C.Orders).Where((C, I) => I < 10); // if One Of The Property is Sequence



            //var result = ProductList.Select((P, I) => new { I, P.ProductName });
            //var result = ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #endregion


            #region Demo 02

            #region 3. Ordering Opperator [OrderBy / OrderBy Descending / Reverse]

            // Ordering Opperator [OrderBy / OrderBy Descending / ThenBy / ThenByDescending / Reverse]
            // Sorting

            ////var result = ProductList.OrderBy(P => P.UnitsInStock);
            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                        .Select(P => new
            //                         {
            //                             P.ProductName,
            //                             P.UnitPrice,
            //                             P.UnitsInStock
            //                         });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                        .ThenBy(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.UnitPrice,
            //                            P.UnitsInStock
            //                        });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                        .ThenByDescending(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.UnitPrice,
            //                            P.UnitsInStock
            //                        });

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry")
            //                        .OrderByDescending(P => P.UnitsInStock)
            //                        .ThenByDescending(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.Category,
            //                            P.UnitPrice,
            //                            P.UnitsInStock
            //                        });

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry" && P.UnitsInStock > 0)
            //                        .OrderByDescending(P => P.UnitsInStock)
            //                        .ThenByDescending(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.Category,
            //                            P.UnitPrice,
            //                            P.UnitsInStock
            //                        });


            // By Query Syntax [Query Expresssion]

            //var result = from P in ProductList
            //             orderby P.UnitsInStock
            //             select P;

            //var result = from P in ProductList
            //             orderby P.UnitsInStock descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };


            //var result = from P in ProductList
            //             orderby P.UnitsInStock descending, P.UnitPrice
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };

            //var result = from P in ProductList
            //             orderby P.UnitsInStock descending, P.UnitPrice descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };

            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry" && P.UnitsInStock > 0
            //             orderby P.UnitsInStock descending, P.UnitPrice descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };



            //var result = ProductList.Reverse<Product>();  // IEnumerable<>


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 4. Elements Operator - Immediate Execution [First / Last / ElementAt / Single / DefaultifEmpty] Or Defualt From Them
            // Elements Operator - Immediate Execution

            //ProductList = new List<Product>();

            //var result = ProductList.First(); // May Throw Exception [Sequence contain No Element]
            //var result = ProductList.Last(); // May Throw Exception [Sequence contain No Element]

            //var result = ProductList.First(P => P.UnitsInStock == 17);
            //var result = ProductList.First(P => P.UnitsInStock == 200); // May Throw Exception [Sequence contain No Element]

            //var result = ProductList.Last(P => P.UnitsInStock == 17);
            //var result = ProductList.Last(P => P.UnitsInStock == 200); // May Throw Exception [Sequence contain No Element]


            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product { ProductName = "Default Product" });
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 17);
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product { ProductName = "Default Product" });


            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product { ProductName = "Default Product" });

            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 17);
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product { ProductName = "Default Product" });


            //Console.WriteLine(result);
            //Console.WriteLine(result.ProductName);


            //// ElementAt
            //var result = ProductList.ElementAt(0);
            //var result = ProductList.ElementAt(200); // May Throw exception [Index Out Of range]
            //var result = ProductList.ElementAt(200); // May Throw exception

            //var result = ProductList.ElementAtOrDefault(index: 20);
            //var result = ProductList.ElementAtOrDefault(1000);


            // Single:   
            //ProductList = new List<Product>();
            //ProductList = new List<Product>() { new Product() { ProductName = "Only Single Name" } };

            //var result = ProductList.Single();
            // Throw Exception: 
            // Sequence contains more than one Element 
            // Sequence contains No Elements 


            //var result = ProductList.Single(P => P.UnitsInStock == 27); // Single
            //var result = ProductList.Single(P => P.UnitsInStock == 0); // Throw Exception

            //var result = ProductList.SingleOrDefault(); // May Throw Exception 
            // Sequence contains more than one element
            // Return default Value [null] if The Sequence is Empty

            //ProductList = new List<Product>() { new Product() 
            //{
            //    ProductName = "Only One Product" }
            //};

            //var result = ProductList.SingleOrDefault(new Product() { ProductName = "Default Product" });

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 27);

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 27, new Product() { ProductName = "Default Product" });

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });


            //Console.WriteLine(result);
            //Console.WriteLine(result?.ProductName ?? "NA");


            // DefaultifEmpty : 

            //var result = ProductList.DefaultIfEmpty();
            //ProductList = new List<Product>();
            //var result = ProductList.DefaultIfEmpty();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 5. Aggragate Operator
            // Aggragate Operator
            // Count - Sum - Avg - Min - Max - Aggregate

            // Count()
            //var result = ProductList.Count; // 77
            //var result = ProductList.Count(); // 77


            //var result = ProductList.Count(P => P.UnitsInStock == 0); // 5
            //var result = ProductList.Where(P => P.UnitsInStock == 0).Count(); // 5

            ////Sum()
            //var result = ProductList.Sum(P => P.UnitPrice);
            //var result = ProductList.Sum(P => P.UnitsInStock);


            // Avg()
            //var result = ProductList.Average(p => p.UnitPrice);

            // Max
            // Note: At least one Object must implement IComparable.

            //var result = ProductList.Max(); //  £263.50, Based on IComparable (Price)
            //var result = ProductList.Max(new ProductComparerUnitInStock()); //  125, Based on IComparer (UnitInStock)


            // As At least one object implements IComparable , we can use Max() With Any Attributes.
            //var result = ProductList.Max(P => P.UnitPrice); // 263.5000
            //var result = ProductList.Max(P => P.UnitsInStock); // 125
            //var resul = ProductList.Max(P => P.ProductName); // Zaanse koeken


            //var result = ProductList.MaxBy(P => P.UnitPrice);
            //var result = ProductList.MaxBy(P => P.UnitsInStock);
            ////var resul = ProductList.MaxBy(P => P.ProductName);
            ///

            // Min

            // Note: At least one object must implement IComparable.

            //var result = ProductList.Min(); //  £2.50, Based on IComparable (Price)
            //var result = ProductList.Where(P => P.UnitsInStock != 0).Min(new ProductComparerUnitInStock()); //  3, Based on IComparer (UnitInStock)


            // As At least one object implements IComparable , we can use Max() With Any Attributes.
            //var result = ProductList.Min(P => P.UnitPrice); // 2.5000
            //var result = ProductList.Min(P => P.UnitsInStock); // 0
            //var result = ProductList.Min(P => P.ProductName); // Alice Mutton


            //var result = ProductList.MinBy(P => P.UnitPrice);
            //var result = ProductList.MinBy(P => P.UnitsInStock);
            //var result = ProductList.MinBy(P => P.ProductName);

            //Console.WriteLine(result);

            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Mohamed", "Samy" };


            //var result = Names.Aggregate((S01, S02) => $"{S01} {S02}");


            //Console.WriteLine(result); 
            #endregion

            #region 6. Casting Operators - Immediate Execution
            // Casting Operators - Immediate Execution

            //List<Product> list = /*(List<Product>)*/ ProductList.Where(P => P.UnitsInStock == 0);
            //List<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long, Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);
            //HashSet<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 7. Generetor Operators
            // Generator Operators
            // [ Range , Empty , Repeat ]
            // The Only Way To Call The Method as ->  Class Member Through "Enumerable" Class

            //var result = Enumerable.Range(1, 100);

            //var result = Enumerable.Empty<Product>().ToList();

            //result.Add(new Product() { ProductName = "Product01" });
            //result.Add(new Product() { ProductName = "Product02" });

            //var result = Enumerable.Repeat(ProductList[0], 3);
            //var result = Enumerable.Repeat(10, 5);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 8. Set Operators - Union Family

            // Set Operators
            // Union - Union All - Intersect - Except

            //var Seq01 = Enumerable.Range(1, 100);   // 1 .... 100
            //var Seq02 = Enumerable.Range(50, 100); //  50 .... 149


            //var result = Seq01.Union(Seq02); // Like Union in SQL Without Duplication 
            //var result = Seq01.Concat(Seq02); // Like Union All in SQL With Duplication 

            //result = result.Distinct();

            //var result = Seq01.Intersect(Seq02);
            //var result = Seq01.Except(Seq02);
            //var result = Seq02.Except(Seq01);



            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion




            #region 9. Quantifier Operators

            // Quantifier Operators - Return Boolian

            // Any - All - SequanceEqual - Contains

            //var Seq01 = Enumerable.Range(1, 100);   // 1 .... 100
            ////var Seq02 = Enumerable.Range(1, 100);   // 1 .... 100
            //var Seq02 = Enumerable.Range(50, 100); //  50 .... 149

            // Any() --> Return True if At Least one Element one in Sequance or Match The condition   
            //var result = Seq01.Any();

            //ProductList = new List<Product>();
            //var result = ProductList.Any(); // False

            // var result = Seq01.Any(N => N % 2 == 0);
            // var result = ProductList.Any(P => P.UnitsInStock == 0);


            // All() --> Retyrn True if  All Elements Match The Condition or The Sequance is Empty. 

            //var result = Seq01.All(N => N % 2 == 0);
            //var result = ProductList.All(P => P.UnitsInStock == 0);
            //var result = ProductList.All(P => P.UnitPrice > 0);

            // SequenceEqual
            //var result = Seq01.SequenceEqual(Seq02);

            // Contains()
            //var result = Seq01.Contains(1);

            //var Product = ProductList.FirstOrDefault(P => P.ProductID == 1);
            //var result = ProductList.Contains(Product);


            //Console.WriteLine(result); 
            #endregion

            #region 10. Zipping Operator

            // Zip Operator
            //var Word = new string[] { "Ten   ", "Twenty", "Thirty", "Fourty", "Fifty" };
            //var Number = new[] { 10, 20, 30, 40 };

            ////var result = Word.Zip(Number);
            ////var result = Word.Zip(Number, (W, N) => $"{W} => {N}");
            //var result = Word.Zip(Number, (W, N) => new { Number = N, World = W });



            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion

            #region 11. Grouping Operator
            // Grouping Operator

            //var Result = ProductList.GroupBy(P => P.Category);

            //var Result = from P in ProductList
            //             group P by P.Category;


            //var Result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category;


            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($".... {Product}");
            //    }
            //}


            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Categ
            //             where Categ.Count() > 11
            //             select Categ;

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($".... {Product}");
            //    }
            //}


            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Categ
            //             where Categ.Count() > 5
            //             select new
            //             {
            //                 CategoryName = Categ.Key,
            //                 CountOfCategory = Categ.Count(),
            //             };


            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .Where(C => C.Count() > 5)
            //                        .Select(C => new
            //                        {
            //                            Category = C.Key,
            //                            CountOfCategory = C.Count()
            //                        });


            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .OrderByDescending(P => P.Count())
            //                        .Where(C => C.Count() > 5)
            //                        .Select(C => new
            //                        {
            //                            Category = C.Key,
            //                            CountOfCategory = C.Count()
            //                        });


            //foreach (var category in Result)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region 12. Partioning Operators
            //  Partioning Operators - Take , TakLast , Skip , SkipLast, TakeWhile , SkipWhile

            //var Result = ProductList.Take(5);
            //var Result = ProductList.Where(P => P.UnitsInStock == 0).Take(2);

            //var Result = ProductList.TakeLast(5);


            //var Result = ProductList.Skip(count: 5);
            //var Result = ProductList.SkipLast(5);

            //int[] Number = { 9, 6, 4, 1, 2, 3, 4, 5 };

            //var Result = Number.TakeWhile(N => N % 3 == 0);
            //var Result = Number.SkipWhile(N => N % 3 == 0);



            //int[] Numbers = { 5, 4, 1, 3, 9, 6, 7, 2, 0 };

            //var Result = Numbers.TakeWhile((N, I) => N > I);
            //var Result = Numbers.SkipWhile((N, I) => N > I);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Let / Into

            // Let / Into
            // Only Query Syntax [Query Expression]
            // You must Search About keyWord Regex
            // aeaiouAEIOU
            //var result = Regex.Replace("Ahmed", "[aeiouAEIOU]", string.Empty);
            //Console.WriteLine(result);


            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Mohamed", "Mona", "Aya", "Mahmoud", "Sallama", "Osama" };


            // Into
            //var result = from Name in Names
            //             select Regex.Replace(Name, "[aeaiouAEIOU]", string.Empty)
            //             into NovolNames
            //             // into: Restart The Query  With Introducing NEW Range Variable (NOvolNames)
            //             where NovolNames.Length >= 3
            //             select NovolNames;

            ////Let
            //var result = from Name in Names
            //             let NovolNames = Regex.Replace(Name, "[aeaiouAEIOU]", string.Empty)
            //             // Let: Continue Query With Adding NEW Range Variable (NovolNames)
            //             where NovolNames.Length >= 3
            //             select NovolNames;


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion



            #endregion

















        }
    }
}
