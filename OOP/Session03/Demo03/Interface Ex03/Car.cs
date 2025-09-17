namespace Demo03.Interface_Ex03
{
    internal class Car : IMovable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car BackWard From IMovable");
        }

        public void Forward()
        {
            Console.WriteLine("Car Forward From IMovable");
        }

        public void Left()
        {
            Console.WriteLine("Car Left From IMovable");
        }

        public void Right()
        {
            Console.WriteLine("Car Right From IMovable");
        }
    }
}
