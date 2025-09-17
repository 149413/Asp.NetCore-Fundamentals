namespace Demo02.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int Z) : base(x, y)
        {
            this.Z = Z;
        }


        public void Fun01()
        {
            Console.WriteLine("I am Child [Drived]");
        }
        public void Fun02()
        {
            Console.WriteLine($"X: {X} , Y: {Y} , Z: {Z}");
        }


        public override string ToString()
        {
            return $"X: {X} , Y: {Y} , Z: {Z}";
        }

    }
}
