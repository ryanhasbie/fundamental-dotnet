public class Program
{
    public static void Main(string[] args)
    {
        // String Input
        // Console.WriteLine("Enter your name: ");
        // var inputUser = Console.ReadLine();
        // Console.WriteLine(inputUser);

        // Number Input
        Console.WriteLine("Enter number 1: ");
        var number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number2: ");
        var number2 = Convert.ToInt32(Console.ReadLine());
        var result = number1 + number2;
        Console.WriteLine("Result: ");
        Console.WriteLine(result);

    }
}

