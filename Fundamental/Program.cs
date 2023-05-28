namespace Fundamental;

public class Program
{
    public static void Main(string[] args)
    {
        SayHello();
        Message("Ryan");
        Console.WriteLine(Sum(10,10));
        var anonimous = delegate ()
        {
            Console.WriteLine();
        };
    }

    static void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }

    static void Message(string message)
    {
        Console.WriteLine($"Good Morning {message}");
    }

    static int Sum(int x, int y)
    {
        return x + y;
    }
}

