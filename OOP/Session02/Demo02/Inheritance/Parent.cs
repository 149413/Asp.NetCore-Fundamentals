namespace Demo02.Inheritance
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }


        //public Parent()
        //{

        //}

        public Parent(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

        }

        public void Fun01()
        {
            Console.WriteLine("I am Parent [Base]");
        }
        public void Fun02()
        {
            Console.WriteLine($"X: {X} ,  Y: {Y}");
        }




        public override string ToString()
        {
            return $"X: {X} ,  Y: {Y}";
        }

    }
}
