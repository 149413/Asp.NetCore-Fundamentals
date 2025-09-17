namespace Demo03.Interface_Ex02
{
    internal interface ISeries
    {
        public int Current { get; set; }  // Segniture Of Property

        void Next();

        public void Restart()
        {
            Current = 0;
        }


    }
}
