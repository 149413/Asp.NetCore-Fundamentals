namespace Assiagn03.Q_01
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }

        float Length { get; set; }
        float Width { get; set; }
        public Rectangle(float len, float wid)
        {
            Length = len;
            Width = wid;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Area: {Length * Width} :)");
        }
    }
}
