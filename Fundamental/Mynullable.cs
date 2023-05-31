using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;

public class Mynullabel
{
    public void Main(string[] args)
    {
        // Cara Pertama
        Nullable<int> n = null;

        // Cara Kedua
        int? anotherNumber = null;

        Console.WriteLine(anotherNumber);

        SayHello(null);
    }

    public static void SayHello(string? name)
    {
        Console.WriteLine($"Hello {name}");
    }
}
