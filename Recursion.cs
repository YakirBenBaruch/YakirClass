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

        public static int T1(int N)
        {
            if (N == 1)
            {
                return 1;
            }

            else
            {
                return N + T1(N - 1);
            }
        }

        public static int T2(int N)
        {
            if (N == 0 || N == 1)
            {
                return 1;
            }

            else
            {
                return N * T2(N - 1);
            }
        }

        public static int T3(int N)
        {
            if (N <= 1)
            {
                return 1;
            }

            if (N % 2 == 0)
            {
                return T3(N - 1);
            }

            else
            {
                return N * T3(N - 2);
            }
        }

        public static int T4(int N)
        {
            if (N < 10)
                return 1;

            return 1 + T4(N / 10);
        }

        public static void UnitTest()
        {
            int number = 1717;
            int digitCount = Count(number);
            Console.WriteLine($"The number of digits in {number} is: {digitCount}");
        }
    }
}
