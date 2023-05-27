public class Program
{
    public static void Main(string[] args)
    {
        var hour = 10;
        if (hour < 12 && hour > 0)
        {
            Console.WriteLine("Good Morning");
        } else if (hour > 12 && hour < 18)
        {
            Console.WriteLine("Good Afternoon");
        } else 
        {
            Console.WriteLine("Good Night");
        }
    }
}

