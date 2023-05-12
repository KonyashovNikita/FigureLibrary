using System;

namespace FugureLibrary
{
    abstract public class Figure
    {
        public abstract double calcArea();
    }

    public class Circle:Figure
    {
        public double radius;

        public Circle(double Radius){
            radius = Radius;
        }

        public override double calcArea()
        {
            return 2*Math.PI*radius;
        }

        public override string ToString()
        {
            return $"This is Circle. R = {this.radius}";
        }
    }

    public class Triangle:Figure
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public override double calcArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool isTriangleRight()
        {
            bool firstType = (a*a + b*b == c*c);
            bool secondType = (b*b + c*c == a*a);
            bool thirdType = (a*a + c*c == b*b);
            return firstType || secondType || thirdType;
        }

        public override string ToString()
        {
            return $"This is Triangle. A = {this.a}, B = {this.b}, C = {this.c}";
        }
    }
}
namespace FugureLibrary
{
    public class MainClass
    {
        public static void Main()
        {
            var figure = new Circle(12);
            Console.WriteLine(figure.calcArea());
            var secondFigure = new Triangle(3, 4, 5);
            Console.WriteLine(secondFigure.isTriangleRight());
            List<Object> fList = new List<Object>();
            fList.Add(figure);
            fList.Add(secondFigure);
            fList.Add(new Triangle(1, 1, 1));
            foreach (Figure f in fList){
                Console.WriteLine(f.ToString());
                Console.WriteLine($"Area of {f.GetType()} is {f.calcArea()}");
                Triangle t = f as Triangle;
                if (t != null){
                    Console.WriteLine("Triangle is " + (t.isTriangleRight() ? "Right" : "NotRight"));
                }
                Console.WriteLine();
            }
        }
    }
}
    
