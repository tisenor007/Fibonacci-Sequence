using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        public static int[] cache = new int[20];
        static void Main(string[] args)
        {
            
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(FIB(i) + " = " + i);
            }
            //Console.ReadKey(true);
        }

        //gives you any value from enter number in numeral order
        static void Fib(int wantedValue)
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

        //fibonacci pattern that catches when it breaks
        static void Fpattern()
        {
            int firstValue = 0;
            int secondValue = 1;
            int result = 0;
            int maxNumber = 0;
            bool stop = false;

            while (stop == false)
            {
                result = firstValue + secondValue;
                if (result < maxNumber)
                {
                    stop = true;
                    break;
                }
                maxNumber = result;

                Console.WriteLine();
                Console.WriteLine(result);
                firstValue = secondValue;
                secondValue = result;
                
                
            }
            Console.ReadKey(true);
           
        }
        static int FIB(int r)
        {
            if (r <= 1) { return 0; }
            else if (r == 2) { return 1; }
            else { return FIB(r - 1) + FIB(r - 2); }

        }
    }
}
