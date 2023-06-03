using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;

public class ReferenceAndValue
{

    /*public static void Main(string[] args)
    {
        
        int a = 10;
        // int b = a;
        // b = 15;
        // Show(a);
        ShowReference(ref a);
        Console.WriteLine(a);
        // Console.WriteLine(b); 

        /*var numbers = new int[] { 1, 2, 3 };
        var anotherNumber = numbers; // Alamat memory yang dicopy
        var anotherNumbers = new int[numbers.Length];
        Array.Copy(numbers, anotherNumbers, numbers.Length);

        anotherNumbers[0] = 10;

        Console.WriteLine(numbers.GetHashCode());
        Console.WriteLine(anotherNumbers.GetHashCode());

        foreach (int i in numbers)
        {
            Console.WriteLine($"Numbers: {i}");
        }

        foreach(int j in anotherNumbers)
        {
            Console.WriteLine($"Another Number: {j}");
        } */

        /* Car ayla = new Car();
        ayla.Brand = "Toyota";

        Car jazz = ayla;
        jazz.Brand = "Honda";

        Console.WriteLine(ayla.Brand);
        Console.WriteLine(jazz.Brand); 
    } */
    
    // Passing by value
    public static void Show(int a)
    {
        a *= a;
        Console.WriteLine($"Variable a didalam method: {a}");
    }

    // Passing by reference
    public static void ShowReference(ref int a)
    {
        a *= a;
        Console.WriteLine($"Variable a didalam method: {a}");
    }
}
