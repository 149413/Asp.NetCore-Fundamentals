namespace Common
{
    public class TypeB
    {

        private int X;
        internal int Y;
        public int Z;


        void Func01()
        {
            TypeB typeB = new TypeB(); // The same Class
            TypeA typeA = new TypeA();  // Valid : TypeA is Intrnal


            typeB.X = 1; // Valid 
            typeB.Y = 2; // Valid
            typeB.Z = 3; // Valid
        }
        public enum Gender
        {
            Male,
            Female

        };

    }
}
