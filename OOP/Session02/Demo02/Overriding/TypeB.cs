namespace Demo02.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }


        // override or hide
        // apply override
        //1. Apply override using 'new' Keyword
        //2. Apply override using 'override' Keyword

        // Static Binding
        // Compiler bind The Function Call Based On Reference Type Not Object Type
        // At Compile time
        public new void Func01() // use 'new' keyword
        {
            Console.WriteLine("I am Type B");
        }
        // Must me Private And virtual in Parent Class
        //public override void Func02()  // use 'new' keyword
        //{
        //    Console.WriteLine($"A: {A}  B: {B}");
        //}


        // Dynamic Binding
        // CLR bind The Function Call Based On Object Type Not Reference Type
        // At Run time
        public override void Func02()  // use 'new' keyword
        {
            Console.WriteLine($"A: {A}  B: {B}");
        }
    }
}
