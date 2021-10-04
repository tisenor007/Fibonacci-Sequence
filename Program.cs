using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Fpattern();
            FIB(50);
            Console.ReadKey(true);
        }

        static void FIB(int wantedValue)
        {
            double firstValue = 0;
            double secondValue = 1;
            double result = 0;
            for (int i = 0; i <= wantedValue - 3; i++)
            {
                result = firstValue + secondValue;
                firstValue = secondValue;
                secondValue = result;
                if (i == wantedValue)
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }

        static void Fpattern()
        {
            double firstValue = 0;
            double secondValue = 1;
            double result = 0;
            while (true)
            {
                result = firstValue + secondValue;

                Console.WriteLine();
                Console.WriteLine(result);
                Console.ReadKey(true);
                firstValue = secondValue;
                secondValue = result;
            }
        }
    }
}
