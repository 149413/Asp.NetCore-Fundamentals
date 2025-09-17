namespace Demo_01
{
    //Can Be Inside The the Class / Strut:
    //1. Attributes (Fields - Loca Variable)
    //2. Methods  (Functions)
    //3. Properties (Full Properties - Automitic Properties - Special Properties (Idexer))


    internal struct Point
    {
        public int X; // 4 Bytes
        public int Y; // 4 Bytes

        // Constructor: Parmeterless Constructor
        //1. Named Like Struct Name
        //2. Has No Return Type

        // CLR: Will Generate Parametrless Constructor
        // this Constructor Used To Will be Initialized The Attibutes With Defualt Value 


        // .Net 5.0 C# 9.0  --> Can Not Create Parameterles Constructor
        // .Net 6.0 C# 10.0 --> Can Create Parameterles Constructor , but Initialize All Attributes of object

        // After Version 11.0 All Senarios Are avilable
        // .Net 7.0 C# 11.0
        // .Net 8.0 C# 12.0



        // Parameterless Consructor 
        //public Point()
        //{

        //}
        //public Point()
        //{
        //    X = 5;
        //    Y = 6;
        //}

        // Uder-Defined Constructo
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //------------------------------------
        // Default User-Defined Constructor
        //public Point(int x = 1, int y = 1)
        //{
        //    X = x;
        //    Y = y;
        //}


        // Internal Constructor
        public Point(int X)
        {
            this.X = X;
        }
        //public Point(int Y)  base.Point(X)
        //{
        //    this.Y = Y;
        //}



        // Metods
        public void printPoint()
        {
            Console.WriteLine($"({X} , {Y})");
        }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }




    }
}
