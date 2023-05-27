public class Program
{
    public static void Main(string[] args)
    {
        // for loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Loop ke {i}");
        }

        // while loop
        var j = 0;
        while (j < 10)
        {
            Console.WriteLine($"While loop ke-{j}");
            j++;
        }

        // do while
        var k = 0;
        do
        {
            Console.WriteLine($"Do While ke-{k}");
            k++;
        } while (k < 10);
    }
}

