namespace Assiagnment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Note: Use ListGenerators.cs & Customers.xml


            #region LINQ - Restriction <Operators>
            /* 1.Find all products that are out of stock. */

            //var result = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            // ================================================================================


            /*2.Find all products that are in stock and cost more than 3.00 per unit. */


            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region  LINQ - Element Operators
            /*  1.Get first Product out of Stock*/

            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(result);


            // ================================================================================


            /*2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned. */

            //var result = ProductList.SingleOrDefault(P => P.UnitPrice > 1000, null);
            //Console.WriteLine(result);

            #endregion


            #region LINQ - Aggregate Operators

            /*  1.Uses Count to get the number of odd numbers in the array */

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(N => N % 2 != 0).Count();
            //Console.WriteLine(result);

            // ================================================================================

            /*2.Get the total of the numbers in an array. */


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);


            // ================================================================================


            /*3.Get the total number of characters of all words in dictionary_english.txt(Read
            dictionary_english.txt into Array of String First).*/


            //var file = File.ReadAllLines(path: "dictionary_english.txt");
            //var result = file.Count();
            //Console.WriteLine($"Total Number of Characters = " + result);


            // ================================================================================

            /* 4.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into
             Array of String First).*/

            //var file = File.ReadAllLines(path: "dictionary_english.txt").ToArray();
            //var result = file.Where(W => W.Length > 0).MinBy(W => W.Length);
            //Console.WriteLine($"Word: {result} , Len: {result.Length}");


            // ================================================================================

            /*5.Get the total units in stock for each product category.*/


            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .Select(C => new
            //                        {
            //                            Category = C.Key,
            //                            TotalUnitis = C.Sum(c => c.UnitsInStock)
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            /*Another Solution*/

            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category);

            //foreach (var Categogry in result)
            //{
            //    Console.WriteLine(Categogry.Key);
            //    var SumUnits = Categogry.Sum(C => C.UnitsInStock);
            //    Console.WriteLine($"Sum = {SumUnits}");
            //}

            // ================================================================================


            /* 6.Get the cheapest price among each category's products */


            //var result = ProductList.GroupBy(P => P.Category)
            //                        .Select(C => new
            //                        {
            //                            Category = C.Key,
            //                            CheapestProduct = C.MinBy(p => p.UnitPrice)
            //                        });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} -> {item.CheapestProduct.ProductName} ({item.CheapestProduct.UnitPrice})");
            //}

            ///*Another Solution*/

            //Console.WriteLine("\n\n");
            //var resul = ProductList.GroupBy(P => P.Category);

            //foreach (var Category in resul)
            //{
            //    Console.WriteLine(Category.Key);
            //    var MinPrice = Category.MinBy(C => C.UnitPrice);
            //    Console.WriteLine($"Minnimum Price = {MinPrice.UnitPrice}");
            //}


            // ================================================================================


            /* 7.Get the products with the cheapest price in each category(Use Let)*/


            //var result = from P in ProductList
            //             group P by P.Category
            //             into g
            //             let Cheapestprice = g.MinBy(P => P.UnitPrice)
            //             select new
            //             {
            //                 g.Key,
            //                 ProducName = Cheapestprice.ProductName,
            //                 CheapestPrice = Cheapestprice.UnitPrice
            //             };

            //foreach (var item in result)
            //{
            //     Console.WriteLine(item);
            //}





            // ================================================================================



            /* 8.Get the average price of each category's products.*/

            //var result = ProductList.GroupBy(P => P.Category)
            //                        .Select(C => new
            //                        {
            //                            Category = C.Key,
            //                            AvgPrice = C.Average(g => g.UnitPrice)
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} -> AvragePrice = {item.AvgPrice.ToString("c3")}");
            //}

            /*Another Solution*/

            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category);

            //foreach (var Categogry in result)
            //{
            //    Console.WriteLine(Categogry.Key);
            //    var MinPrice = Categogry.Average(C => C.UnitPrice);
            //    Console.WriteLine($"Avrage Price = {MinPrice.ToString("C3")}");
            //}

            #endregion


            #region LINQ - Ordering Operators

            /*1.Sort a list of products by name*/

            //var result = ProductList.OrderBy(P => P.ProductName)
            //                        .Select(P => new
            //                        {
            //                            P.ProductID,
            //                            P.ProductName,
            //                            P.UnitPrice,
            //                            P.Category
            //                        });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            // ================================================================================


            /* 2.Sort a list of products by units in stock from highest to lowest.*/

            //var result = ProductList.Where(P => P.UnitsInStock > 0).OrderByDescending(P => P.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // ================================================================================


            /*3.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.*/

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = from P in ProductList
            //             orderby P.ProductName.Length, P.ProductName
            //             select new
            //             {
            //                 ProductLenght = P.ProductName.Length,
            //                 P.ProductName,
            //                 P.Category,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // ================================================================================

            /*4.Sort a list of products, first by category, and then by unit price, from highest to lowest.*/

            //var result = ProductList.OrderByDescending(P => P.Category)
            //                         .ThenByDescending(P => P.UnitPrice)
            //                         .Select(P => P);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // ================================================================================


            //5.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = from p in Arr
            //             orderby p.Length, p.ToLower() descending
            //             select new
            //             {
            //                 Len = p.Length,
            //                 Word = p


            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            // =================================================================================

            /*6.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in  the original array.*/


            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //.Where(d => d.Length > 1 && d[1] == 'i')
            //.Reverse();

            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}




            #endregion


            #region  LINQ – Transformation Operators

            /*1.Return a sequence of just the names of a list of products.*/

            //var result = ProductList.Select(P => P.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // ================================================================================


            /*2.Produce a sequence of the uppercase and lowercase versions of each word in the original array
            (Anonymous Types).*/

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(X => new
            //{
            //    UpperCase = X.ToUpper(),
            //    LowerCae = X.ToLower(),
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            // ================================================================================

            /* 3.Returns all pairs of numbers from both arrays such that the number from numbersA is less
             than the number from numbersB.*/


            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            //Console.WriteLine("Pairs Where a < b");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.A} is Less than {item.B}");
            //}

            // ================================================================================

            //4.Select all orders where the order total is less than 500.00.

            //var result = CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region  LINQ - Set Operators

            /*  1.Find the unique Category names from Product List*/

            //var result = ProductList.Select(P => P.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            // ===================================================================================================

            /*2.Produce a Sequence containing the unique first letter from both product and customer names.*/


            //var result = ProductList.Select(p => p.ProductName[0])
            //             .Union(CustomerList
            //             .Select(c => c.CustomerName[0])
            //             );


            //var result = (from P in ProductList
            //              select P.ProductName[0]
            //             ).Union
            //             (from c in CustomerList
            //              select c.CustomerName[0]);


            //foreach (var item in result)
            //{
            //    Console.Write(item + "  ");
            //}

            // ===================================================================================================

            /* 3.Create one sequence that contains the common first letter from both product   and   customer
             names.*/


            // Fluant Syntax 
            //var result = ProductList.Select(p => p.ProductName[0])
            //                         .Intersect(CustomerList
            //                         .Select(c => c.CustomerName[0])
            //                         );

            // Query Syntax
            //var result = (from P in ProductList
            //              select P.ProductName[0]
            //             ).Intersect
            //             (from C in CustomerList
            //              select C.CustomerName[0]);

            //foreach (var item in result)
            //{
            //    Console.Write(item + "  ");
            //}

            // ===================================================================================================


            /* 4.Create one sequence that contains the first letters of product names that are not also first letters
             of customer names. */


            //var result = ProductList.Select(p => p.ProductName[0])
            //             .Except(CustomerList
            //             .Select(c => c.CustomerName[0])
            //             );

            //var result = (from P in ProductList
            //              select P.ProductName[0]
            //             ).Except
            //             (from C in CustomerList
            //              select C.CustomerName[0]);

            //foreach (var item in result)
            //{
            //    Console.Write(item + "  ");
            //}


            #endregion


            #region LINQ - Partitioning Operators 

            /*1.Get the first 3 orders from customers in Washington*/

            //var result = CustomerList.Where(C => C.City == "Washington")
            //                          .SelectMany(C => C.Orders)
            //                          .Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            // ===================================================================================================


            /* 2.Get all but the first 2 orders from customers in Washington.*/


            //var result = CustomerList.Where(C => C.City == "London")
            //                          .SelectMany(C => C.Orders)
            //                          .Skip(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            // ===================================================================================================


            /* 3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array. */


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((N, I) => N > I);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            // ===================================================================================================


            /* 4.Get the elements of the array starting from the first element divisible by 3.*/

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(N => N % 3 != 0);
            //foreach (var item in result)
            //{
            //    Console.Write(item + "  ");
            //}


            #endregion


            #region  LINQ - Quantifiers

            /*1.  Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into
                      Array of String First) contain the substring 'ei'.*/


            //var file = File.ReadAllLines("dictionary_english.txt");
            //var result = file.Take(20).Contains("ei");
            //foreach (var line in file)
            //{
            //    Console.WriteLine(line);
            //}


            // ===================================================================================================


            /*  2.  Return a grouped a list of products only for categories that have at least one product that is out of stock.*/

            //var result = from p in ProductList
            //             group p by p.Category
            //             into g
            //             where g.Any(C => C.UnitsInStock == 0)
            //             select g;

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($".... {product}");
            //    }
            //}


            // ===================================================================================================

            /* 3. Return a grouped a list of products only for categories that have all of their products in stock. */


            //var result = from P in ProductList
            //             group P by P.Category
            //             into g
            //             where g.All(C => C.UnitsInStock > 0)
            //             select g;

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($".... {product}");
            //    }
            //}


            #endregion


            #region LINQ – Grouping Operators

            /* 1.Uses group by to partition a list of words by their first letter. 
                Use dictionary_english.txt for Input*/

            //var file = File.ReadAllLines("dictionary_english.txt");

            //var result = from word in file
            //             group word by word[0];


            //foreach (var letter in result)
            //{
            //    Console.WriteLine($"Key ===> {letter.Key}");
            //    foreach (var word in letter)
            //    {
            //        Console.WriteLine($".... {word}");
            //    }
            //}


            #endregion




        }
    }
}
