using System;

namespace TableConstruction
{
    static class Fibonacci
    {
        /**********************************************************************
          * FOR PRINTING FIBONACCI
          *********************************************************************/

        public static void Fib()
        {
           Console.Write("Enter till which number you want the series(1-30): ");
           Console.WriteLine();
           int n = Convert.ToInt32(Console.ReadLine());
           if (n<0 || n>30) return;
           if (n == 0) return;
           else if (n == 1) Console.WriteLine(0);
           else if (n == 2) Console.WriteLine(1);
           else
           {
               int prev = 1, prev2 = 0;
               Console.Write(prev2 + " " + prev + " ");
               for (int i = 2; i < n; i++)
               {
                   int curr = prev + prev2;
                   Console.Write(curr + " ");
                   prev2 = prev;
                   prev = curr;
               }
           }
           Console.WriteLine("\n");
           return;
        }
    }
}
