using System;

namespace TableConstruction
{
    public class MulTable
    {
        /***********************************************************************
        * FOR PRINTING THE MULTIPLICATION TABLE
        **********************************************************************/
        public static void Generate()
        {
            Console.Write("Enter a number (1-10000) for printing its multiplication table: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Upto what number do you want to calculate the table?(1-1000) : ");
            int upto = Convert.ToInt32(Console.ReadLine());
            if (n > 10000 || n < 1 || upto < 1 || upto > 1000)
            {
                Console.WriteLine("\nYou have entered a value that is beyond the limit for calculation.");
                return;
            }
            else
            {
                for (int i = 1; i <= upto; i++)
                {
                    Console.WriteLine(n + "x" + i + "=" + (n * i));
                }
            }
            Console.WriteLine("\n");
            return;
        }
    }
}
