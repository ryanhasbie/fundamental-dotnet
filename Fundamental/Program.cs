public class Program
{
    public static void Main(string[] args)
    {

        /* 
            Integer Types:
                - byte 8bit
                - short 16bit
                - int 32bit
                - long 64bit
            Floating Point Types:
                - float 32bit
                - double 64bit
                - decimal 128bit
         */

        /* 
           Example:
        */

        // Integer Types
        byte byteNumber = 128;
        short shortNumber = 10000;
        int intNumber = 1000000;
        long longNumber = 1000000000000L;

        //Floating Point Types
        float floatNumber = 12345.6F;
        double doubleNumber = 1234567.8D;
        decimal decimalNumber = 123123123.5m;

        /*
            String Data Types 
        */

        char charString = 'A';
        string stringString = "Ryan Hasbie";    

        // Escape Charater
        string message = "Hello, \"World\"";
        // Verbatim String
        string path = @"C:\Mydoc\Project";
        // Concatenation String
        string fullName = "Ryan " + "Hasbie";
        // Interpolation string
        string firstName = "Ryan";
        string lastName = "Hasbie";
        Console.WriteLine($"{firstName} {lastName}");    
    }
}

