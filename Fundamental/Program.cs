namespace Fundamental;

public class Program
{
    public static void Main(string[] args)
    {

        // Explicit declaration array

        /* int[] numbers = new int[5];
        numbers[0] = 11;
        numbers[1] = 12;
        numbers[2] = 13;
        numbers[3] = 14;
        numbers[4] = 15;
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        string[] cities = { "Karawang", "Bogor", "Jakarta" };
        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine($"Cities: {cities[i]}");
        } */


        // Array multidimensional
        /* 
            {
                {1,2}, {3,4}
            }
        */
        int[,] matrixs = new int[2, 2];
        matrixs[0, 0] = 1;
        matrixs[0, 1] = 2;
        matrixs[1, 0] = 3;
        matrixs[1, 1] = 4;

        for (var i = 0; i < matrixs.GetLength(0); i++)
        {
            for (var j = 0; j < matrixs.GetLength(1); j++) 
            {
                Console.WriteLine(matrixs[i,j]) ;
            }
        }
     }
}

