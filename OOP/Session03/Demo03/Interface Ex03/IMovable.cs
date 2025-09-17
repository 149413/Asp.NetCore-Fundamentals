namespace Demo03.Interface_Ex03
{
    internal interface IMovable
    {
        public int Speed { get; set; }

        void Forward();
        void Backward();
        void Left();
        void Right();
    }
}
