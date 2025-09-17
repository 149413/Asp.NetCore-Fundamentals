using Task02_ProtectedAccessModifiers.Task02_Protected_Modifiers;

namespace Demo02.Task02_Protected_Modifiers
{
    internal class Other_DerivedClass : BaseClass
    {
        public void Show()
        {
            Console.WriteLine("Drived Class Outside The Project\nOnly Valid: ");
            Console.WriteLine($"Protected Modifier: {Protected}");                 // Valid (Any Derived Class [inside or  outside])
            //Console.WriteLine($"PrivateProtected Modifier: {PrivateProtected}");  // In Valide (Only Derived Class Inside the Same Project)
            Console.WriteLine($"InternalProtected Modifier: {InternalProtected}");//
        }
    }
}
