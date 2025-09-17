namespace Demo03.Interface
{
    internal interface IMyType
    {

        //int X//Interfaces Cannot contain instance fields [Attributes]
        // readonly int  X;
        // What Can Access Ito The InterFace ?
        // 1. Segniture of Property
        // 2. Segniture of Methods [Name - Parameter - ReturnType]
        // 3. Defualt Implemented Methods [Full Implemeted Methods]


        static IMyType()
        {

        }

        // 2. Segniture of Methods [Name - Parameter - ReturnType]
        void MyFun();
        // 1. Segniture of Property
        public decimal Salary { get; set; }

        // 3. Defualt Implemented Methods [Full Implemeted Methods]

        static void Print()
        {
            Console.WriteLine("Defualt Implemented Methods [Full Implemeted Methods]\r\n");
        }



    }
}
