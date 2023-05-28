namespace Fundamental;

public enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
}

public class Program
{

    // Enum in class
    public enum Gender
    {
        Male, Female
    }


    public static void Main(string[] args)
    {
        Console.WriteLine(GetRole());
        Console.WriteLine(Day.Friday);
    }

    static Gender GetRole ()
    {
        return Gender.Male;
    }
}

