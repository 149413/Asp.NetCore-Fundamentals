namespace Demo01
{
    internal static class IntExtension
    {
        // Note: class in Extension Method Must be Static
        public static int Reverse(this int Number)
        {
            int ReverseNumber = 0, LastDegit = 0;
            while (Number > 0)
            {
                LastDegit = Number % 10;
                ReverseNumber = ReverseNumber * 10 + LastDegit;
                Number /= 10;

            }

            return ReverseNumber;
        }
        public static long Reverse(this long Number)
        {
            long ReverseNumber = 0, LastDegit = 0;
            while (Number > 0)
            {
                LastDegit = Number % 10;
                ReverseNumber = ReverseNumber * 10 + LastDegit;
                Number /= 10;

            }

            return ReverseNumber;
        }
    }
}
