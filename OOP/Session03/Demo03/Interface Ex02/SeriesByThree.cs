namespace Demo03.Interface_Ex02
{
    internal class SeriesByThree : ISeries
    {
        public int Current { get; set; }  // Defualt : 0

        public void Next()
        {
            Current += 3;
        }

    }
}
