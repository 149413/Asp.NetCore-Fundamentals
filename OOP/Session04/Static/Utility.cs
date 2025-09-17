using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_05_Demo.Static
{

    /// Static Class
    ///Is A Just Container For Static Members [Attributes , Properties , Constructor , Method]
    ///And Constant
    ///You Can't Create Object From This Class (Helper Class)
    ///No Inheitance For This Class
    internal static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        //// Object Memeber Constructor: Non-static Constructor 
        //public Utility(int X, int Y)
        //{
        //    this.X = X;
        //    this.Y = Y;
        //   // pi = 3.14; //is not the right place for intializing the sataic attributes
        //}


        // Static Constructor [Max Only One Per Class]
        // U Can't Specify Access Modifier OR Parameters for Static Constructor
        // Will be Called Just Only One Time Per Class Lifetime Before the First Usage of the Class
        /// The Usages of the Class as following 
        /// 1. Create Object from this Class OR from another Class "Inheriting from this Class".
        /// 2. Call Static Property
        /// 3. Call Static Method
        
        static Utility()
        {
            //pi = 3.14;

        }
        //public override string ToString()
        //{
        //    return $"({X}, {Y})";
        //}

        // Object Memeber Method: Non-Static Method محتاجه ارقيها
        // Class Memeber Method: Static Method 

        public static double CmToInch(double Cm)
        {
            return Cm / 2.54;
        }

        // Object Member Attribute: Non-Static Attribute
        // 1. Class Member Attribute: Static Attribute
        ///private static readonly double pi = /*default*/ 3.14;
        /// CLR will Intialize Each and Every Static Attribute With its Datatype Default Value 
        /// Before the First Usage of the Class

        // 2. Constant
        private const double pi = 3.14;

        // Object Memeber Property: Non-Static Property
        /// Class  Memeber Property: Static Property:[ Must Deal With One Of the Following]:
        /// 1. Static Attribute
        /// 2. Constant
        public static double PI
        {
            get { return pi; }
            //set { pi = value; }
        }



        // Object Memeber Method: Non-Static Method
        // Class Memeber Method: Static Method 
        public static double CalcCircleArea(double Radius)
        {
            //Utility U01 = new Utility(1, 2);
            //Utility U02 = new Utility(5, 10);

            return Utility.PI * Radius * Radius;
        }


    }
}
