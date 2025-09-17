using Task02_ProtectedAccessModifiers.Task02_Protected_Modifiers;

namespace Task02_ProtectedAccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Show();


            Console.WriteLine();

            Un_DerivedClass un_derivedClass = new Un_DerivedClass();
            un_derivedClass.Show();


        }
    }
}
