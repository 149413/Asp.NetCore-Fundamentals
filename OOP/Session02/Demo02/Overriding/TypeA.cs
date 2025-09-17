namespace Demo02.Overriding
{
    internal class TypeA
    {
        public int A { get; set; }

        public void Func01()
        {
            Console.WriteLine("I am Type A");
        }
        public virtual void Func02()
        {
            Console.WriteLine($"A: {A}");
        }


    }
}
