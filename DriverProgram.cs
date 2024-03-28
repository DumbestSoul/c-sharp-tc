using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableConstruction
{
    public class DriverProgram
    {
        public static void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("1.Multiplication Table for a number (1-10000)");
                Console.WriteLine("2. Print Fibonacci series(1-20)");     // Again I have restricted the upper limit for better view
                Console.WriteLine("3. Print pyramid pattern for n rows(1-15)"); // For printing a pyramid pattern
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        MulTable.Generate();    // From MulTable
                        break;
                    case 2:
                        Fibonacci.Fib();    // From Fibonacci
                        break;
                    case 3:
                        Pyramid.Build();    //From Pyramid
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;

                }
            }
        }
    }
}
