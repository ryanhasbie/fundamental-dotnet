using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;


public class Car
{
    public string? Color { get; set; }
    public string? Brand { get; set; }
    public int? Fuel { get; set; }

    // private string _color;
    // private string _brand;

    // Cara kedua membuat setter dan getter
    /* public string Color
    {
        get { return _color; }
        set { _color = value; }
    } */


    /* public Car (string color, string brand)
    {
        Color = color;
        Brand = brand;
    }

    // Default constructor
    public Car() 
    { 
    } */

    // Cara pertama setter getter
    /* public string GetColor ()
    {
        return _color;
    }

    public void SetColor (string? color)
    {
        _color = color;
    } */
}

/* public class Program
{
    public static void Main(string[] args)
    {
        // Car ayla = new("Red", "Toyota");

        // Cara untuk menggunakan setter and getter pertama
        // Console.WriteLine(ayla.GetColor());


        // Console.WriteLine(ayla.Color);
        // Console.WriteLine(ayla.Brand);

        // direct access kurang bagus -> bisa juga untuk pemanggilan setter getter cara kedua dan cara ketiga
        // Car rush = new();
        // rush.Color = "Black";
        // rush.Brand = "Toyota";
        // Console.WriteLine(rush.Color);
        // Console.WriteLine(rush.Brand);
        var rush = new Car
        {
            Color = "Red",
            Brand = "Toyota",
            Fuel = 30,
        };

        Console.WriteLine(rush.Color);
        Console.WriteLine(rush.Brand);
        Console.WriteLine(rush.Fuel);
    }
} */
