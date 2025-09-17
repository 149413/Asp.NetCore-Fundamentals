using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assiagnment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*****************************************   Part 01   *********************************************************/

            #region Q1
            // 1.Write a program that allows the user to enter a number
            // then print it.

            //int number;
            //do
            //{
            //    Console.Write("Enter Your Number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));

            //Console.WriteLine("Number: " + number);


            #endregion

            #region Q2
            // 2.Write C# program that converts a string to an integer, 
            // but the string contains non - numeric characters.And mention
            // what will happen

            // Console.Write("Enter your sting: ");
            // int num;
            //bool flag = int.TryParse(Console.ReadLine() , out num);
            // if (flag)
            // {
            //     Console.WriteLine($"Number: {num}");
            // }
            // else
            // {
            //     Console.WriteLine("String Not Nummeric");
            // }


            #endregion

            #region Q3
            // 3.Write C# program that Perform a simple arithmetic 
            // operation with floating-point numbers And mention what will
            // happen


            //Console.WriteLine("Enter Ths 1st num : ");
            //float X = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Ths 2nd num : ");
            //float Y = float.Parse(Console.ReadLine());

            //Console.WriteLine($"{X} + {Y} = {X+Y}");


            #endregion

            #region Q4
            // 4.Write C# program that Extract a substring from a given 
            // string.


            //Console.Write("Enter String: ");
            //string str = Console.ReadLine();
            //Console.Write("Enter StartIndex: ");
            //int stidx = int.Parse(Console.ReadLine());

            //Console.Write("Enter Length: ");
            //int len = int.Parse(Console.ReadLine());

            //string sub = str.Substring(stidx , len);
            //Console.WriteLine($"String: {str}");
            //Console.WriteLine($"SubString: {sub}");


            #endregion

            #region Q5
            // 5.Write C# program that Assigning one value type variable 
            // to another and modifying the value of one variable and
            // mention what will happen


            //int a = 10;
            //int b = a;

            //a = 20;
            //Console.WriteLine("a = "+a);
            //Console.WriteLine("b = "+b);

            // a , b Value type (a Take Only copy from b And Value of a not Affect on b)


            #endregion

            #region Q6

            /* 6.Write C# program that Assigning one reference type 
            variable to another and modifying the object through one
            variable and mention what will happen*/

            //StringBuilder sb = new StringBuilder("Ahmed");
            //StringBuilder sb1 = sb;

            ////  modify
            // sb1.Replace(sb1.ToString() , "Ali");

            //Console.WriteLine(sb);
            //Console.WriteLine(sb1);


            #endregion

            #region Q7

            /* 7.Write C# program that take two string variables and 
             print them as one variable*/

            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();

            //Console.WriteLine("Concate: "+str1 + " " + str2); 

            #endregion

            #region Q8

            /* 8.Write a program that calculates the simple interest
             given the principal amount, rate of interest, and time. The
             formula for simple interest is
             Interest = (principal * rate * time) / 100.*/


            //decimal principal = decimal.Parse(Console.ReadLine());
            //decimal rate = decimal.Parse(Console.ReadLine());
            //decimal time = decimal.Parse(Console.ReadLine());

            //decimal interest = (principal * rate * time) / 100;
            //Console.WriteLine(interest.ToString("P0"));


            #endregion

            #region َََQ9
            /*9.Write a program that calculates the Body Mass Index
            (BMI) given a person's weight in kilograms and height in 
            meters.The formula for BMI is
            BMI = (Weight) / (Height * Height) */

            //decimal Weight = decimal.Parse(Console.ReadLine());
            //decimal Height = decimal.Parse(Console.ReadLine());

            //decimal BIM = (Height <= 0 || Weight <= 0) ? 0 : Weight / (Height * Height);
            //Console.WriteLine("BIM: " + BIM);


            #endregion


            #region Q10


            /* 10.Write a program that uses the ternary operator to check
             if the temperature is too hot, too cold, or just good. 
             Assign the result in a variable then display the result. 
             Assume that below 10 degrees is "Just Cold", above 30
             degrees is "Just Hot", and anything else is "Just Good". */


            //Console.Write("Enter the temprature in Celisios: ");
            //double temp = double.Parse(Console.ReadLine());
            //string result;
            // switch(temp)
            //{
            //    case < 10:
            //        result = "Just Cold";
            //        break;
            //    case > 30:
            //        result = "Just Hot";
            //        break;
            //    default:
            //        result = "Just Good";
            //        break;

            //}
            //Console.WriteLine(result);


            #endregion

            #region Q11

            /* 11.Write a program that takes the date from the user and
            displays it in various formats using string interpolation. 
            Ex:
            Today’s date : 20 , 11 , 2001
            Today's date : 20 / 11 / 2001 
            Today's date : 20 – 11 – 2001*/


            //Console.Write("day: ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Month: ");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("Year: ");
            //int year = int.Parse(Console.ReadLine());
            //DateTime date = new DateTime(year, month, day);

            //Console.WriteLine($"ToDay's: {date:dd,MM,yyy}");
            //Console.WriteLine($"ToDay's: {date:dd/MM/yyy}");
            //Console.WriteLine($"ToDay's: {date:dd-MM-yyy}");
            //Console.WriteLine($"ToDay's: {date:MM/dd/yyyy}");

            #endregion

            #region Q12

            /*12.What is the output of the following C# code? 
            DateTime date = new DateTime(2024, 6, 14);
            Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            a.The event is on 14/06/2024 
            b. The event is on 2024-06-14 
            c. The event is on 06/14/2024 
            d. The event is on June 14, 2024*/


            // c. The event is on 06/14/2024 



            #endregion

            #region Q13

            /*  13.Which of the following statements is correct about the
              C#.NET code snippet given below?*/

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);

            //output: A value 1 will be assigned to d.

            #endregion

            #region Q14


            /* 14.Which of the following is the correct output for the C# 
             code given below ?*/

            // Console.WriteLine(13 / 2 + " " + 13 % 2);

            //OutPut: d. 6 1


            #endregion

            #region Q15

            /* 15 - What will be the output of the C# code given below? */

            /*int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);*/


            //output: a. 7  7

            #endregion


            /*****************************************   Part 01   *********************************************************/

            #region Q1

            /* 1 - Write a program that takes a number from the user then print yes if that
             number can be divided by 3 and 4 otherwise print no.

             Example(1)
             Input: 12
             Output: Yes
             Example(2)
             Input: 9
             Output: No*/

            //Console.Write("Enter your Number: ");
            //int num = int.Parse(Console.ReadLine());
            //if(num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");


            #endregion

            #region Q2

            /* 2 - Write a program that allows the user to insert an integer then print
             negative if it is negative number otherwise print positive.
             Example(1)
             Input: -5
             Output: negative
             Example(2)
             Input: 10
             Output: positive*/



            //Console.Write("Enter your Number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positive");

            #endregion


            #region Q3

            /* 3 - Write a program that takes 3 integers from the user then prints the max
             element and the min element.
             Example(1)
             Input: 7,8,5
             Output:
             max element = 8
             min element = 5
             Example(2)
             Input: 3 6 9
             Outputs:
             Max element = 9
             Min element = 3*/


            //int[] Number = new int[3];
            //for (int i = 0; i < Number.Length; i++)
            //{
            //    Console.Write($"Enter Number{i}: ");
            //    Number[i] = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine($"Max: {Number.Max()}");
            //Console.WriteLine($"Min: {Number.Min()}");

            #endregion


            #region Q4

            /* 4 - Write a program that allows the user to insert an integer number then
             check If a number is even or odd.*/

            //Console.Write("Enter your Number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");

            #endregion


            #region Q5

            /*5 - Write a program that takes character from the user then if it is a vowel
            chars(a, e, I, o, u) then print(vowel) otherwise print(consonant). 
            Example(1)
            Input: O
            Output: vowel
            Example(2)
            Input: b
            Output: Consonant*/

            //string viow = "eaiou";
            //Console.Write("Enter Your character: ");
            //char C = char.Parse(Console.ReadLine().ToLower());

            //if(viow.Contains(C))
            //{
            //    Console.WriteLine("Vowel");
            //}else
            //    Console.WriteLine("Consonant");

            #endregion


            #region Q6

            /*6 - Write a program that allows the user to insert an integer then print all
            numbers between 1 to that number.
            Example
            Input: 5
            Output: 1, 2, 3, 4, 5*/

            //Console.Write("Enter Number: ");
            //int end = int.Parse(Console.ReadLine());
            //int bgn = 1;
            //while (bgn <= end && end > 0)
            //{
            //    Console.Write(bgn+ " ");
            //    ++bgn;
            //}

            #endregion


            #region Q7

            /*7 - Write a program that allows the user to insert an integer then
            print a multiplication table up to 12.
            Example
            Input: 5
            Outputs: 5 10 15 20 25 30 35 40 45 50 55 60*/

            //Console.Write("Enter Number: ");
            //int num = int.Parse(Console.ReadLine());
            //int coun = 1;
            //while(coun <= 12 && num > 0)
            //{
            //    Console.Write(coun*num + " ");
            //    ++coun;
            //}

            #endregion


            #region Q8

            /* 8 - Write a program that allows to user to insert number then print all even
             numbers between 1 to this number
             Example: 
             Input: 15
             Output: 2 4 6 8 10 12 14*/

            //Console.Write("Enter Number: ");
            //int end = int.Parse(Console.ReadLine());
            //int bgn = 2;
            //while (bgn <= end && end >= 2)
            //{
            //    Console.Write(bgn + " ");
            //    bgn += 2;
            //}


            #endregion


            #region Q9


            /* 9 - Write a program that takes two integers then prints the power. 
             Example:
             Input: 4 3
             Output: 64
             Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64*/


            //Console.Write("Enter base: ");
            //int @base = int.Parse(Console.ReadLine());

            //Console.Write("Enter power: ");
            //int power = int.Parse(Console.ReadLine());

            //int res = @base;
            //int i = 1;
            //while (i < power)
            //{
            //    res *= @base;
            //    i++;
            //}
            //Console.WriteLine(res);

            #endregion

            #region Q10
            /*10 - Write a program to enter marks of five subjects and calculate total, 
                average and percentage.
                Example
                Input: -Enter Marks of five subjects: 95 76 58 90 89
                Output: Total marks = 408
                        Average Marks = 81
                        Percentage = 81
                */

            //int[] subjects = new int[5];

            //double marks;
            //double sum = 0;
            //for (int i = 1; i <= subjects.Length; i++)
            //{
            //    Console.Write($"Marks Of subject{i}: ");
            //    marks = double.Parse(Console.ReadLine());
            //    sum += marks;

            //}
            //Console.WriteLine($" Total marks = {sum}");
            //Console.WriteLine($"Avarage Marks = {sum / subjects.Length}");
            //Console.WriteLine($"Percentage = {(sum / subjects.Length)}"); 
            #endregion


            #region Q11

            /* 11 - Write a program to input the month number and print the number of days in 
             that month. 
             Example
             Input: Month Number: 1
             Output: Days in Month: 31*/

            // Console.Write("Month Number: ");
            // int MonthNum = int.Parse(Console.ReadLine());
            //if(MonthNum >=  1 && MonthNum <= 15)
            //{
            // int DaysOgMonth = DateTime.DaysInMonth(2025, MonthNum);
            // Console.WriteLine($"Day in Month : {DaysOgMonth}");
            //}

            #endregion



            #region Q12
            /* 12 - Write a program to create a Simple Calculator.*/

            //[Addition - Subtraction -  Division - Multiplication - Modulus]

            //Console.Write("Enter The 1st Number: ");
            //decimal num1 = decimal.Parse(Console.ReadLine());
            //Console.Write("Enter The 2nd Number: ");
            //decimal num2 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("\n1. Addition");
            //Console.WriteLine("\n2. Subtruction");
            //Console.WriteLine("\n3. Multiplication");
            //Console.WriteLine("\n4. Division");
            //Console.WriteLine("\n5. Modulos");

            //Console.Write("Choose Your Operation: ");
            //decimal ch = decimal.Parse(Console.ReadLine());

            //decimal result = ch switch
            //{
            //    1 => num1 + num2,
            //    2 => num1 - num2,
            //    3 => num1 * num2,
            //    4 => num1 / num2,
            //    5 => num1 % num2
            //};

            //Console.WriteLine($"Result: {result}");

            #endregion



            #region Q13
            ///* 13 - Write a program to allow the user to enter a string and print the REVERSE
            //    of it.*/


            //Console.Write("Enter String: ");
            //string str = Console.ReadLine();
            //StringBuilder sb =  new StringBuilder();

            //for (int i = 0; i < str.Length;i++)
            //{
            //    sb.Append(str[str.Length - 1 - i]);
            //}

            //Console.WriteLine($"String: {str}");
            // Console.WriteLine($"String Reverse: {sb}");


            // Another Solution

            //Console.Write("Enter String: ");
            //string str = Console.ReadLine();
            //char[] array = str.ToCharArray();
            //Array.Reverse(array);
            //string Reversed = new string(array);
            //Console.WriteLine($"String: {str}");
            //Console.WriteLine($"String Reverse: {Reversed}");

            #endregion



            #region Q14
            /* 14 - Write a program to allow the user to enter int and print the REVERSED of it.*/

            //  123456  ----> 654321

            //Console.Write("Enter The Number: ");
            //int Num = int.Parse(Console.ReadLine());
            //int revNum = Num % 10;
            //Num /= 10;

            //while (Num != 0)
            //{
            //    revNum *= 10;
            //    revNum += Num % 10;
            //    Num /= 10;
            //}
            // Console.WriteLine($"Reversed Number: {revNum}");

            #endregion


            #region 15

            /*15 - Write a program in C# Sharp to find prime numbers within a range of 
            numbers. 
            Test Data : 
            Input starting number of range: 1
            Input ending number of range  : 50
            Expected Output : 
            The prime number between 1 and 50 are:
            2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 */


            //Console.Write("Enter Begining Of Range: ");
            //int bgn = int.Parse(Console.ReadLine());

            //Console.Write("Enter Ending Of Range: ");
            //int end = int.Parse(Console.ReadLine());

            //bgn = 2;
            // for (int i = bgn; i <= end ; i++)
            //{

            //    bool IsPrime = true; 
            //    for (int j = bgn; j <= i/2; j++)
            //    {
            //        if(i % j == 0)
            //        {
            //            IsPrime = false;
            //            break;
            //        }
            //    }

            //    if(IsPrime)
            //    {
            //        Console.Write(i+" ");
            //    }
            //}


            #endregion


            #region Q16

            /* 16 - Create a program that asks the user to input three points(x1, y1),
                  (x2,y2), and(x3, y3), and determines whether these points lie on a single straight line.*/

            //Point[] point = new Point[3];

            //for (int i = 0; i < point.Length; i++)
            //{
            //    Console.WriteLine($"Point {i+1} ");
            //    Console.Write("X: ");
            //    point[i].x = int.Parse(Console.ReadLine());

            //    Console.Write("y: ");
            //    point[i].y = int.Parse(Console.ReadLine());
            //}
            //foreach (var item in point)
            //{
            //    Console.WriteLine(item.x + " " + item.y);
            //}

            //if ((point[0].x == point[1].x && point[1].x == point[2].x) || (point[0].y == point[1].y && point[1].y == point[2].y))
            //{
            //    Console.WriteLine("these points lie on a single straight line");
            //}
            //else
            //    Console.WriteLine("these points lie on a Diffrent lines");



            #endregion


            #region Q17

            /* 17 - Within a company, the efficiency of workers is evaluated based on the
             duration required to complete a specific task.A worker's efficiency level is 
             determined as follows:  -If the worker completes the job within 2 to 3 hours, they are considered
             highly efficient.  - If the worker takes 3 to 4 hours, they are instructed to increase their
             speed.  - If the worker takes 4 to 5 hours, they are provided with training to
             enhance their speed.  - If the worker takes more than 5 hours, they are required to leave the
             company.
             To calculate the efficiency of a worker, the time taken for the task is
             obtained via user input from the keyboard.*/

           /* Console.Write("Please Enter The Time Taken For The Task: ");
            float TaskTime = float.Parse(Console.ReadLine());

            if (TaskTime > 0 && TaskTime <= 3)
                Console.WriteLine("Highly efficient");
            else if (TaskTime > 3 && TaskTime <= 4)
                Console.WriteLine("Need to Increasing Speed");
            else if (TaskTime > 4 && TaskTime <= 5)
                Console.WriteLine("Reqiuring Take training To enhance their speed");
            else
                Console.WriteLine("required to leave The company.");*/

 



            #endregion

        
            
        //Console.WriteLine("\n\nEnter Your Key");

        }
        struct Point
        {
            public int x;
            public int y;
        }

    }
}
