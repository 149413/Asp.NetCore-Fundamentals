namespace Asiagnment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Revision 

            /*
             1.   Variable
             2.   CTS And CLS
             3.   DataTypes(Value type - ReferanceType)
             4.   Memory (STACK - HEAP)
             5.1. DataTypes
             5.2. Value Type (Struct - Enum)
             6.   Object
             7.   Casting (Implicit Casting (Widining) - Explicit Casting (Narrowing)) 
             8.   BCL (Parse - Convert - TryParse)
             9.   Fraction - Discard _
             10.  Operators


           */
            #endregion

            #region 1.  String Formating


            //1. String Concatination : Difficault In Flexable
            // Immutable -> Can't Change its Value After creation

            //int X = 3, Y = 4;
            //string Massage = "Equation: " + "X" + " + " + "Y" + " = " + (X + Y);
            //Console.WriteLine(Massage);


            //2. String Formating : Few Flexable in Changing And Performance [Take Params Parameters]

            //int X = 2, Y = 5;
            //string Massage = string.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);
            //Console.WriteLine(Massage);


            //3. String Interpolation Hieght Flexable And Performance
            //Mutable Type:

            //int X = 2, Y = 5;
            //string Massage = $"Equation: {X} + {Y} = {X+Y}";  // Perfect
            //Console.WriteLine(Massage);


            #endregion

            #region Control Statements
            // Control Statmebts:
            // 1. Condition Control Statement (if Statement - Switch Case)
            // 2. Loop Control Statement (for - foreach - while - do-while) 
            #endregion

            #region  1. Condition Control Statement (if Statement - Switch Case)

            #region EX01
            // 1. if Statement
            //Console.Write("Enter The Number of Month In The 1rst Quarter: ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //// 1--> Jan
            //// 2--> Fib
            //// 3-->Mar

            //if(MonthNumber == 1)
            //    Console.WriteLine("Jan");

            //if(MonthNumber == 2)
            //    Console.WriteLine("Fib");

            //if(MonthNumber == 3)
            //     Console.WriteLine("Mar");

            // if , else
            //if (MonthNumber == 1)
            //    Console.WriteLine("Jan");

            //else if (MonthNumber == 2)
            //    Console.WriteLine("Fib");

            //else if (MonthNumber == 3)
            //    Console.WriteLine("Mar");
            //else
            //{
            //    Console.WriteLine("InValid Number!");
            //}

            // 2. Switch Case :Jump Table

            //switch(MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fib");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("InValid Number!");
            //        break;
            //}

            // Note : Break is Mendatory in Switch Case (Must Be Putten)

            #endregion

            #region EX02
            //Console.Write("Enter your Name: ");
            //string name = Console.ReadLine();

            //if(name == "Ahmed" || name == "ahmed")
            //{
            //    Console.WriteLine("Hi, Ahmed");
            //}
            //if(name == "Omar" || name == "omar")
            //{
            //    Console.WriteLine("Hi, Omar");
            //}
            //if(name == "Ali" || name == "ali")
            //{
            //    Console.WriteLine("Hi, Ali");
            //}
            //if(name == "Mariam"  || name == "mariam")
            //{
            //    Console.WriteLine("Hi, Mariam");
            //}

            //// Jump Table
            //switch (name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("Hi, Ahmed");
            //        break;
            //    case "Omar":
            //    case "omar":
            //        Console.WriteLine("Hi, Omar");
            //        break;
            //    case "Ali":
            //    case "ali":
            //        Console.WriteLine("Hi, Ali");
            //        break;
            //    case "Mariam":
            //    case "mariam":
            //        Console.WriteLine("Hi, Mariam");
            //        break;
            //}

            #endregion

            #region Ex03

            //// if statement
            //Console.Write("Enter Your Age: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age > 18)
            //    Console.WriteLine("Welcom :)");
            //else if (age < 18)
            //{
            //    Console.WriteLine("Bye Bye :(");
            //}
            //else
            //{
            //    Console.WriteLine("Equal !!");
            //}

            //// jump Table
            //switch (age)    // Must Be Fixd Value (18)
            //{
            //    case > 18:
            //        Console.WriteLine("Welcom :)");
            //        break;
            //    case < 18:
            //        Console.WriteLine("Bye Bye :(");
            //        break;
            //    default:
            //        Console.WriteLine("Equal !!");
            //        break;
            //}

            #endregion

            #region C# 7.0
            // Swaitch Evolution 
            // Pattern Matching

            //object obj = new object();
            //obj = "Ahmed";
            ////obj = 7.5;

            //switch(obj)
            //{
            //    case int AliasX when AliasX > 12:
            //        Console.WriteLine("Integer AliasX");
            //        break;
            //    case double AliasX when AliasX >= 5:
            //        Console.WriteLine("Double AliasX");
            //        break;
            //    case string Str when Str.Length >= 5:
            //        Console.WriteLine("String Object >= 5");
            //        break;
            //} 
            #endregion

            #region C# 8.0
            // Switch Exepresion : its Support Syntax Sugar (=>)

            // string input = Console.ReadLine();
            //string output = input switch
            //{
            //    "1" => "Using Option 1",
            //    "2" => "Using Option 2",
            //    "3" => "Using Option 3"
            //};
            //Console.WriteLine(output);


            //Console.WriteLine(input switch
            //{
            //    "1" => "Using Option 1" ,
            //    "2" => "Using Option 2" ,
            //    "3" => "Using Option 3"
            //}
            //    );


            #endregion

            #endregion

            #region 2. Loop Control Statement (for - foreach )


            //for(/*Statement*/ ; /*Exepression*/ ; /*Statement*/ )
            //{
            //    // code
            //    //Console.WriteLine();
            //}

            //for( int i = 1; i <= 10;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1;  
            //for(Console.WriteLine("Hello 1") ; i <= 10; Console.WriteLine("Hello 2"))
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}

            //2. foreach

            //int[] Numbers = { 1,2,3,4,5,6,7};
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region 2. Loop Control Statement (while - do-while)


            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}while (i <= 10);


            //// Force User To Enter Only Even Number 

            //int num;
            //bool flag;
            //do
            //{
            //    Console.Write("Even Number: ");
            // } while ( ! int.TryParse(Console.ReadLine(), out num) || num % 2 != 0);

            //Console.WriteLine(num);

            #endregion

            #region String
            // String:  Reference Type : HEAP(Class)
            // Imutable Type : Can't change its Value After Creation

            //string S01;
            // Declare Reference (pointer) From Type 'String'
            // S01 : Can Refere ToObject From Type 'String'
            // S01 : Refer To Null

            // 8 Bytes Will Be Allocated At STACK For Reference S01
            // 0 Byte Will be Allocated At  Heap

            //S01 = new string("Ahmed");
            // S01 = "Ahmed";  // Syntax Suger

            //new Keyword
            //1. Allocate Number Of Required Bytes For The object string At HEAP
            //2. Initialized The Allocated Bytes At Heap With Default Value 
            //3. Call User-Defined Constructor is Exist.
            //4. Assiagn Object To Referance.

            //Console.WriteLine(S01.GetHashCode()); // Id: Indicate Address Of Object


            // S01 = "Ali";
            //Console.WriteLine(S01.GetHashCode()); // Id: Indicate Address Of Object
            //new Keyword
            //1. Allocate Number Of Required Bytes For The object string At HEAP
            //2. Initialized The Allocated Bytes At Heap With Default Value 
            //3. Call User-Defined Constructor is Exist.
            //4. Assiagn Object To Referance.

            //S01 = "Yasmin";
            //Console.WriteLine(S01.GetHashCode()); // Id: Indicate Address Of Object

            //new Keyword
            //1. Allocate Number Of Required Bytes For The object string At HEAP
            //2. Initialized The Allocated Bytes At Heap With Default Value 
            //3. Call User-Defined Constructor is Exist.
            //4. Assiagn Object To Referance.


            string Massage = "Hello";
            Console.WriteLine("Massage: " + Massage);
            Console.WriteLine("HashCode: " + Massage.GetHashCode());
            Console.WriteLine();

            Massage += " Ahmed";
            Console.WriteLine("Massage: " + Massage);
            Console.WriteLine("HashCode: " + Massage.GetHashCode());
            #endregion

            #region StringBuilder

            // StringBuilder :  Class (Reference Type) : Heap
            //Mutable Typpe  :  Can Change Its Value after Creation

            //StringBuilder S02;
            // Declare Reference (pointer) From Type 'String'
            // S02 : Can Refere To Object From Type 'String'
            // S02 : Refer To Null

            //S02 = new StringBuilder("Hello ");
            // S02 = "Hello "; // Not Support Syntax Suger

            //new Keyword
            //1. Allocate Number Of Required Bytes For The object string At HEAP
            //2. Initialized The Allocated Bytes At Heap With Default Value 
            //3. Call User-Defined Constructor is Exist.
            //4. Assiagn Object To Referance.

            //Console.WriteLine("S02: " + S02);
            //Console.WriteLine("S02HashCode: " + S02.GetHashCode());
            //Console.WriteLine();


            //S02.Append("Ahemed");

            //Console.WriteLine("S02: " + S02);
            //Console.WriteLine("S02HashCode: " + S02.GetHashCode());

            #endregion

            #region String Methods
            // String Methods

            // string str = "Hello World";
            //string result = str.Substring(1 , 5);
            //Console.WriteLine(str.Replace("Hello" ,"Welcom"));
            //Console.WriteLine(str);
            //Console.WriteLine(result);

            //Console.WriteLine(str.StartsWith("h" ,true, null));l
            //Console.WriteLine(str.EndsWith("h" ,true, null));
            //Console.WriteLine(str.Contains("LLo"));

            //Console.WriteLine(str.IndexOf("o"));
            //Console.WriteLine(str.LastIndexOf("o"));
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.ToLower());

            //Console.WriteLine(str.Insert(0, str.Substring(0,6))); // Insert(StrtIdx , string Valu)
            //Console.WriteLine(str);


            //char[] charArray = str.ToCharArray(); // Store In Char Array

            //char[] strCopy = new char[charArray.Length];
            // strCopy = str.CopyTo(0, strCopy[] ,0 ,5);  ??


            #endregion

            #region StringBuilder Metods
            //StringBuilder Metods

            //StringBuilder sb = new StringBuilder("welcom World");

            //Console.WriteLine(sb.Replace("welcom", "Hello"));
            //Console.WriteLine(sb);

            //sb.AppendLine();
            //sb.Append();
            //sb.CopyTo(); 
            //sb.ToString();
            //sb.GetHashCode();
            //sb.GetType();


            //Console.WriteLine(sb.Insert(0,  " Ahmed"));
            //Console.WriteLine(sb);

            //Console.WriteLine(sb.Remove(0,7));
            //Console.WriteLine(sb); 
            #endregion






        }
    }
}
