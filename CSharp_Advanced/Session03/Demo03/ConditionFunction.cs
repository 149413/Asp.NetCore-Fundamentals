namespace Demo03
{
    internal class ConditionFunction
    {
        public static bool CheckOdd(int X) { return X % 2 != 0; }
        public static bool CheckEven(int X) { return X % 2 == 0; }
        public static bool CheckDivide3(int X) { return X % 3 == 0; }
        public static bool CheckDivide4(int X) { return X % 4 == 0; }


        public static bool LengthGtr4(string X) { return X.Length > 4; }
        public static bool LengthLess4(string X) { return X.Length < 4; }
        public static bool LengthEqual4(string X) { return X.Length == 4; }
    }
}
