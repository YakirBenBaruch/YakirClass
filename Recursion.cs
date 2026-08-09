using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Recursion
    {
        public static int Count(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            return 1 + Count(num / 10);
        }

        public static int SumNumbers(int N)
        {
            if (N == 1)
            {
                return 1;
            }

            else
            {
                return N + SumNumbers(N - 1);
            }
        }

        public static int Factorial(int N)
        {
            if (N == 0 || N == 1)
            {
                return 1;
            }

            else
            {
                return N * Factorial(N - 1);
            }
        }

        public static void UnitTest()
        {
            int number = 1717;
            int digitCount = Count(number);
            Console.WriteLine($"The number of digits in {number} is: {digitCount}");
        }
    }
}
