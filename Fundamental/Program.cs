public class Program
{
    public static void Main(string[] args)
    {
        // if else
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

        // switch
        var grade = 'A';
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excelent");
                break;
            case 'B':
                Console.WriteLine("Good");
                break;
            case 'C':
                Console.WriteLine("Not Bad");
                break;
            case 'D':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Grade not valid!");
                break;
        }
    }
}

