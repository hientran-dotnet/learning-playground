namespace bai_2
{
    public abstract class Shape()
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return 3.14 * (radius * radius);
        }
    }


    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(10);
            Shape rectangle = new Rectangle(10, 10);

            Console.WriteLine(circle.GetArea());
            Console.WriteLine(rectangle.GetArea());

        }
    }
}
