namespace Demo03
{
    class StringFunction
    {
        public static int GetCountOfUpperCasechars(string word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        ++count;
                    }
                }
            }
            return count;
        }
        public static int GetCountOfLowerCasechars(string word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        ++count;
                    }
                }
            }
            return count;
        }
    }
}
