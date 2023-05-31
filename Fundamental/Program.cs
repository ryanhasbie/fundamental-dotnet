using System.Net;

namespace Fundamental;

// Enum out class
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

public class NoProgram
{

    // Enum in class
    public enum Gender
    {
        Male, Female
    }


    public void Main(string[] args)
    {
        Console.WriteLine(GetRole());
        Console.WriteLine(Day.Friday);
    }

    static Gender GetRole ()
    {
        return Gender.Male;
    }
}

