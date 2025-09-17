namespace Assiagn05
{

    #region Q 01
    enum WeekDays
    {

        MonDay,
        TuesDay,
        WedneseDay,
        ThursDay,
        FriDay,
        SaterDay,
        SunDay,
    }
    #endregion

    #region Q 02
    enum Season : byte
    {
        Sprint = 1,
        Winter,
        Summer,
        Autumn
    }

    #endregion


    #region Q 03
    [Flags]
    enum Permisson : byte
    {
        Read = 8,
        Write = 4,
        Execute = 2,
        Delete = 1
    }
    #endregion

    #region Q 04
    public enum Colors
    {
        Red = 1,
        Green,
        Blue
    }
    #endregion


    internal class Program
    {


        //static public int[] PlusOne(int[] digits)
        //{
        //    string nstr = string.Join("", digits);

        //    int num = int.Parse(nstr);
        //    ++num;
        //    nstr = string.Join("", num);
        //    digits = new int[nstr.Length];

        //    for (int i = 0; i < nstr.Length; i++)
        //    {
        //        digits[i] = int.Parse(nstr[i].ToString());
        //    }
        //    return digits;
        //}



        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }


        static void Main(string[] args)
        {

            /*******************************************************  Part 01  ***************************************************************/
            /*1.Try all what we have learned in the lecture.*/

            // Please Look At The demo


            /*******************************************************  Part 02  ***************************************************************/

            #region Q 01

            /* 1 - Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.
           Then, write a C# program that prints out all the days of the week using this enum.*/

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine($"Day {i + 1}: {(WeekDays)i}");
            //}

            #endregion

            #region Q 02

            /* 2.Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) 
             as its members.Write a C# program that takes a season name as input from the user and
             displays the corresponding month range for that season. Note range for seasons 
             ( spring march to may , summer june to august , autumn September to November , winter December to February)*/
            //bool flag;
            //object O01;
            //do
            //{
            //    Console.Write("Please, Enter your Favorite Season: ");
            //    flag = Enum.TryParse(typeof(Season), Console.ReadLine(), true, out O01);
            //} while (!flag);
            //Season S01 = (Season)O01;

            //if (S01.Equals(Season.Sprint))
            //{
            //    Console.WriteLine("From March To May");
            //}
            //else if (S01.Equals(Season.Winter))
            //{
            //    Console.WriteLine("From December To February");
            //}
            //if (S01.Equals(Season.Summer))
            //{
            //    Console.WriteLine("From June To August");
            //}
            //if (S01.Equals(Season.Autumn))
            //{
            //    Console.WriteLine("From September To November");
            //}
            //else
            //    Console.WriteLine("Out Of Range");

            #endregion

            #region Q 03

            /* Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
             Create Variable from previous Enum to Add and Remove Permission from variable, 
                  check if specific Permission is existed inside variable*/

            //Permisson P01 = Permisson.Read;
            //Console.WriteLine("Initialize Permissions\t\t: " + P01);

            //P01 |= Permisson.Write;
            ////P01 ^= Permisson.Write;

            //Console.WriteLine("After Add Write Permission\t: " + P01);


            //P01 &= ~(Permisson.Write);
            //// P01 ^= Permisson.Write;

            //Console.WriteLine("After Remove Write Permissiont\t: " + P01);


            //bool hasExecute = P01.HasFlag(Permisson.Read);
            //Console.WriteLine("Is P01 Has Execute Permision\t: " + hasExecute);

            //Console.WriteLine();
            //if ((P01 & Permisson.Delete) == Permisson.Delete)
            //{
            //    Console.WriteLine("Permissin Delete Exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Permissin Delete Not Exists");
            //}

            #endregion

            #region Q 04

            /*Create an enum called "Colors" with the basic colors(Red, Green, Blue)
            as its members.Write a C# program that takes a color name as input from the user
            and displays a message indicating whether the input color is a primary color or not.*/

            //string[] colors = { "red", "green", "blue", "yellow", "black", "white", "orange", "purple", "1", "2", "3" };
            //string? input;

            //// First : Check if input is Color or Not

            //do
            //{
            //    Console.Write("Enter a color name: ");
            //    input = Console.ReadLine();
            //} while (!colors.Contains(input.ToLower()));

            ////Secound: Check if input is A primery Color Or Not 

            //bool isParsed = Enum.TryParse(typeof(Colors), input, true, out object O01);
            //Colors color = O01 is not null ? (Colors)O01 : 0;

            //if (isParsed && Enum.IsDefined(typeof(Colors), color))
            //{
            //    Console.WriteLine($"{input.ToUpper()} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input.ToUpper()} is NOT a primary color.");
            //}



            #endregion



            //int[] arr1 = { 1, 2, 3 };

            //string nstr = string.Join("", arr1);

            //int num = int.Parse(nstr);
            //++num;
            //nstr = string.Join("", num);
            //arr1 = new int[nstr.Length];

            //for (int i = 0; i < nstr.Length; i++)
            //{
            //    arr1[i] = int.Parse(nstr[i].ToString());
            //}

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}





        }
    }
}
