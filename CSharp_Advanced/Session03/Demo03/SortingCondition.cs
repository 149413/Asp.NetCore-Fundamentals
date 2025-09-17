namespace Demo03
{
    internal class SortingCondition
    {
        public static bool CompareGrt(int X, int Y) { return X > Y; }
        public static bool CompareLess(int X, int Y) { return X < Y; }

        public static bool CompareGrt(string X, string Y) { return X.Length > Y.Length; }
        public static bool CompareLess(string X, string Y) { return X.Length < Y.Length; }
    }
}
