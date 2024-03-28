using System;

namespace TableConstruction
{
    public class Pyramid
    {
        public static void Build()
        {
            Console.Write("How many rows do you want in the pyramid? : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= 2 * rows - 1; j++)
                {
                    if (j >= rows - (i - 1) && j <= rows + (i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
    }
}
