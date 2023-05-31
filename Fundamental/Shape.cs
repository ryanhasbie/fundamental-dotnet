using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;

public abstract class Shape
{
    public abstract double GetSurface();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public override double GetSurface()
    {
        return Width * Length;
    }
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public override double GetSurface()
    {
        return 0.5 * Base * Height;
    }
}

/* public class Program
{
    public static void Main(string[] args)
    {
        var rectangle = new Rectangle
        {
           Width = 100,
           Length = 100,
        };

        Console.WriteLine(rectangle.GetSurface());

        var cities = new string[]{"Surabaya", "Karawang", "Jakarta"};
        foreach (var c in cities)
        {
            Console.WriteLine(c);
        }

    }
} */