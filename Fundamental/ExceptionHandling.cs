using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;

public class ExceptionHandling
{
    public static void Main(string[] args)
    {
        /* 
            Root class error di c# itu adalah Exception
            - DevideByZeroException
            - NullReferenceException
            Keyword yang digunakan untuk menangani exception:
            - Try, Catch, Finally, Throw
        */

        /* try
        {
            var a = 10;
            var b = 0;
            Console.WriteLine(a / b);
        } 
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        } 
        finally
        {
            Console.WriteLine("Ini code setelah error: ");
        } */
        try
        {
            FindName();
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Code setelah error!");
    }

    public static string FindName()
    {
        List<string> names = new List<string>
        {
            "Ryan",
            "Hasbie",
            "Andika"
        };

        string? temp = null;
        var input =  Console.ReadLine();

        foreach (var item in names)
        {
            if (!item.Equals(input)) continue;
            temp = item; 
        }

        if (temp is null) throw new Exception("Name not found!");
        return temp;
    }
}
