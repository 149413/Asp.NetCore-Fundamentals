namespace Demo03.Interface
{

    internal class MyType : IMyType  /* Implement*/
    {
        public decimal Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hellow World :)");
        }

        // Print Function   ===> is Fully Implemented


    }
}
