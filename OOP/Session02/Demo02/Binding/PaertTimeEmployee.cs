namespace Demo02.Binding
{
    internal class PaertTimeEmployee : Employee
    {

        public double HourRate { get; set; }
        public double NumberofHours { get; set; }


        public void Fun01()
        {
            Console.WriteLine("I am Part Employee.");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Salary: {HourRate * NumberofHours}");
        }
    }
}
