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
            {
                return 1;
            }

            return 1 + T4(N / 10);
        }

        public static int T5(int N1, int N2)
        {
            if (N1 < N2)
            {
                return 0;
            }

            return 1 + T5(N1 - N2, N2);
        }

        public static int T6(int N1, int N2)
        {
            if (N1 < N2)
            {
                return N1;
            }

            return T6(N1 - N2, N2);
        }

        public static bool T7(int X, int Y)
        {
            if (X == 0)
            {
                return true;
            }

            if (X < Y)
            {
                return false;
            }

            return T7(X - Y, Y);
        }

        public static bool T8(int N, int I)
        {
            if (N < 2)
            {
                return false;
            }

            if (I == N)
            {
                return true;
            }

            if (N % I == 0)
            {
                return false;
            }

            return T8(N, I + 1);
        }

        public static bool T9(int N)
        {
            if (N < 10)
            {
                return true;
            }

            int lastDigit = N % 10;
            int beforeLastDigit = (N / 10) % 10;

            if (lastDigit % 2 != beforeLastDigit % 2)
            {
                return false;
            }

            return T9(N / 10);
        }
        public static int T10(int N)
        {
            if (N == 0)
            {
                return 0;
            }

            if (N == 1)
            {
                return 2;
            }

            if (N % 2 == 0)
            {
                return (N * N) + T10(N - 1);
            }

            else
            {
                return (N * 2) + T10(N - 1);
            }
        }

        public static void UnitTest()
        {
            int number = 1717;
            int digitCount = Count(number);
            Console.WriteLine($"The number of digits in {number} is: {digitCount}");
            Console.WriteLine(T1(5));
            Console.WriteLine(T2(5));
            Console.WriteLine(T3(7));
            Console.WriteLine(T4(1717));
            Console.WriteLine(T5(17, 5));
            Console.WriteLine(T6(17, 5));
            Console.WriteLine(T7(12, 3));
            Console.WriteLine(T7(14, 3));
            Console.WriteLine(T8(29, 2));
            Console.WriteLine(T9(2468));
            Console.WriteLine(T10(5));
        }
    }
}
