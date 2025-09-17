namespace Demo03.Interface_Ex02
{
    internal class SeriesByFour : ISeries
    {
        public int Current { get; set; }  // Defualt : 0

        public void Next()
        {
            Current += 4;
        }

    }
}
