namespace Task02_ProtectedAccessModifiers.Task02_Protected_Modifiers
{
    internal class Un_DerivedClass
    {
        public void Show()
        {
            BaseClass B = new BaseClass();

            Console.WriteLine("UN_Drived Class Inside The Same Project\nOnly Valid: ");

            //Console.WriteLine($"Protected Modifier: {B.Protected}");                    // Invalid (Only Derived Class)
            //Console.WriteLine($"PrivateProtected Modifier: {B.PrivateProtected}");      // Invalid (Only Derived Class)
            Console.WriteLine($"InternalProtected Modifier: {B.InternalProtected}"); // Valid


        }
    }
}
