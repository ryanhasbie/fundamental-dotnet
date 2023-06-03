using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;

public class Collection
{
    public static void Main(string[] args)
    {
        /* 
            Collection mirip seperti array dan ada banyak macamnya
            keunggulan dari collection
            - Menambah data terus menerus
            - Kita bisa mengoprasikan CRUD
            - Flexible
            System.Collections.Generic
            - List x
            - Stack
            - Queue
            - LinkedList
            - HashSet x
            - SortedSet x
            - Dictionary x
            - SortedDictionary x
            - SortedList x
         */

        // Cara Pertama
        List<int> numbers = new();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        /* foreach(var number in numbers)
        {
            Console.WriteLine(number);
        } */

        // Cara Kedua - Mengisi langsung
        var cities = new List<String>
        {
            "Karawang",
            "Jakarta",
            "Bandung"
        };

        // Update list
        // Console.WriteLine(cities[2]);
        // cities[2] = "Surabaya";
        // Console.WriteLine(cities[2]);

        // Remove list
        // cities.RemoveAt(0); // Remove by index
        // cities.Remove("Surabaya"); // Remove by element

        /* foreach(var city in cities)
        {
            Console.WriteLine($"Final city: {city}"); 
        } */

        Console.WriteLine("Inputkan cities yang akan diubah: ");
        for (int i = 0; i < cities.Count; i++)
        {
            var city = cities[i];
            Console.WriteLine($"{i + 1}. {city}");
        }

        var input = int.Parse( Console.ReadLine() );
        for (var j = 0; j < cities.Count; j++)
        {
            if (j != input - 1) continue;
            var inputUpdate = Console.ReadLine();
            cities[j] = inputUpdate;
        }

        foreach (var city in cities)
        {
            Console.WriteLine($"final cities: {city}");
        }

    }
}
