
using System;

public abstract class Figure
{
    public abstract double CalculateArea();
}

public class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Rectangle : Figure
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine("The area of ​​the circle:  " + circle.CalculateArea());
        Console.WriteLine("The area of ​​the rectangle:  " + rectangle.CalculateArea());
    }
}