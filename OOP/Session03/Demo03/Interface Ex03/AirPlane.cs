namespace Demo03.Interface_Ex03
{
    internal class AirPlane : IMovable, IFlyable
    {
        int IMovable.Speed { get; set; }
        int IFlyable.Speed { get; set; }

        void IMovable.Backward()
        {
            Console.WriteLine("AirPlane BackWard From IMovable");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("AirPlane BackWard From IFlyable");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("AirPlane Forward From IMovable");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlane Forward From IFlyable");
        }

        void IMovable.Left()
        {
            Console.WriteLine("AirPlane Left From IMovable");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("AirPlane Left From IFlyable");
        }

        void IMovable.Right()
        {
            Console.WriteLine("AirPlane Right From IMovable");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("AirPlane Right From IFlyable");
        }
    }
}
