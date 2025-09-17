namespace Demo02.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }


        public new void Fun01()
        {
            Console.WriteLine("I am FullTime Employee.");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Salary: {Salary}");
        }

    }
}
