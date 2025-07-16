namespace OCPGoodExample
{
    public class OCPGoodExample
    {
        public void Run()
        {
            var shapes = new List<IShape>
            {
                new Rectangle { Width = 5, Height = 10 },
                new Circle { Radius = 7 }
            };
            var calculator = new AreaCalculator();
            Console.WriteLine("Toplam Alan: " + calculator.CalculateArea(shapes));
            }
        }
    }

    public interface IShape
    {
        double GetArea();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class AreaCalculator
    {
        public double CalculateArea(List<IShape> shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.GetArea();
            }
            return totalArea;
        }
}