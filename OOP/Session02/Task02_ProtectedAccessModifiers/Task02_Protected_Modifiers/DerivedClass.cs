namespace Task02_ProtectedAccessModifiers.Task02_Protected_Modifiers
{
    internal class DerivedClass : BaseClass
    {
        public void Show()
        {
            Console.WriteLine("Drived Class Inside The Same Project\nOnly Valid: ");
            Console.WriteLine($"Protected Modifier: {Protected}");
            Console.WriteLine($"PrivateProtected Modifier: {PrivateProtected}");
            Console.WriteLine($"InternalProtected Modifier: {InternalProtected}");
        }
    }
}
