namespace Assiagn03.Q_01
{
    internal class Circle : ICircle
    {
        public double Area { get; set; }
        const float PI = 3.14f;
        float radius { get; set; }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Area: {4 * PI * radius * radius} :)");
        }
    }
}
