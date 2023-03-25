using System;

namespace FugureLibrary
{
    public class Figure
    {
        public Figure(){}

        public virtual double calcArea()
        {
            return 0;
        }
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

        public bool siTriangleRight()
        {
            bool firstPar = (a*a + b*b == c*c);
            bool secondPar = (b*b + c*c == a*a);
            bool thirdPar = (a*a + c*c == b*b);
            return firstPar || secondPar || thirdPar;
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
            Console.WriteLine(secondFigure.siTriangleRight());
        }
    }
    
}