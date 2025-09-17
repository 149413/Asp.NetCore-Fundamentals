using Task02_ProtectedAccessModifiers.Task02_Protected_Modifiers;

namespace Demo02.Task02_Protected_Modifiers
{
    internal class Other_UN_DerivedClass
    {
        public void Show()
        {
            Console.WriteLine("UN_Drived Class Outside The Project\nOnly Valid: ");

            BaseClass B = new BaseClass();
            //Console.WriteLine($"Protected Modifier: {B.Protected}");                 // InValid (Only Derived Class)
            //Console.WriteLine($"PrivateProtected Modifier: {B.PrivateProtected}");  //  InValide (Only Derived Class)
            //Console.WriteLine($"InternalProtected Modifier: {B.InternalProtected}");//  Invalid Allow Outside Only Derived Class

            Console.WriteLine("No Thing");

        }
    }
}
