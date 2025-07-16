using System.Drawing;

namespace OCP.Bad
{
    public class OCPBadExample
    {
        public void Run()
        {
            var calculator = new AreaCalculator();
        Console.WriteLine("Toplam Alan: " + calculator.CalculateArea(new List<object>
        {
            new Rectangle { Width = 5, Height = 10 },
            new Circle { Radius = 7 }
        }));
    }
    }
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
    public class Circle
    {
        public double Radius { get; set; }
    }
        public class AreaCalculator
        {
            public double CalculateArea(List<object> shapes)
            {
                double totalArea = 0;
                foreach (var shape in shapes)
                {
                    if (shape is Rectangle rectangle)
                    {
                        totalArea += rectangle.Width * rectangle.Height;
                    }
                    else if (shape is Circle circle)
                    {
                        totalArea += Math.PI * Math.Pow(circle.Radius, 2);
                    }
                }
                return totalArea;
            }
        }
    }