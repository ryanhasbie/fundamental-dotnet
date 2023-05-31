using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fundamental;

/* 
    Static member {Method atau Attribut} itu hanya bisa dipanggil sesama static 
*/

public class Person
{
    public string Name { get; set; } // tidak dapat di instance sebagai object dan hanya dapat dipakai sekali juga tidak dapat berubah
    public int Age { get; set; }

    /* public static void GetInfo()
    {
        Console.WriteLine($"{Name}");
    }

    public override string ToString()
    {
        return $"{nameof(Age)}: {Age}";
    } */
}

public class Util
{
    public static string Input(string info)
    {
        while(true)
        {
            Console.Write(info);
            var input = Console.ReadLine();
            if (input == null || input == "") continue;
            return input;
        }
    }
}

/* public class Program
{
    public void Main(string[] args)
    {
        Person.Name = "Budi";
        var budi = new Person();

        Person.Name = "Andi";
        var andi = new Person();
        budi.Age = 10;
        andi.Age = 20;

        Console.WriteLine(Person.Name);
        Console.WriteLine(budi.ToString());
        Console.WriteLine(andi.ToString()); 

        var budi = new Person
        {
            Name = Util.Input("Enter your name: "),
        };

        Console.WriteLine(budi.Name);
    }
} */
