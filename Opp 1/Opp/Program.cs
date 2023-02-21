using System;

namespace opp1
{


    abstract class Shape
    {
        protected double x, y;

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }

        public abstract void Show();
    }

    class Line : Shape
    {
        private double x2, y2;

        public Line(double x1, double y1, double x2, double y2)
            : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Show()
        {
            Console.WriteLine($"Line from ({x}, {y}) to ({x2}, {y2})");
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double x, double y, double radius)
            : base(x, y)
        {
            this.radius = radius;
        }

        public override void Show()
        {
            Console.WriteLine($"Circle with center at ({x}, {y}) and radius {radius}");
        }
    }

    class Rectangle : Shape
    {
        private double x2, y2, x3, y3, x4, y4;

        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
            : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        public override void Show()
        {
            Console.WriteLine($"Rectangle with vertices at ({x}, {y}), ({x2}, {y2}), ({x3}, {y3}) and ({x4}, {y4})");
        }
    }

    class PolyLine : Shape
    {
        private double[] xs, ys;
        private int numPoints;

        public PolyLine(double[] xs, double[] ys, int numPoints)
            : base(xs[0], ys[0])
        {
            this.xs = xs;
            this.ys = ys;
            this.numPoints = numPoints;
        }

        public override void Show()
        {
            Console.Write("Polyline with points:");
            for (int i = 0; i < numPoints; i++)
            {
                Console.Write($" ({xs[i]}, {ys[i]})");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(0, 0, 1, 1);
            line.Show();

            Circle circle = new Circle(0, 0, 1);
            circle.Show();

            Rectangle rectangle = new Rectangle(0, 0, 1, 0, 1, 1, 0, 1);
            rectangle.Show();

            double[] xs = { 0, 1, 2 };
            double[] ys = { 0, 1, 0 };
            PolyLine polyline = new PolyLine(xs, ys, 3);
            polyline.Show();
        }
    }

}