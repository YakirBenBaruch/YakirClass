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

            if (N % 2 == 0)
            {
                return (N * N) + T10(N - 1);
            }

            return (N * 2) + T10(N - 1);
        }

        public static double T11(int N)
        {
            if (N == 0)
            {
                return 0;
            }

            else
            {
                if (N % 2 == 0)
                {
                    return -Math.Sqrt(2 * N - 1) + T11(N - 1);
                }

                else
                {
                    return (2 * N - 1) + T11(N - 1);
                }
            }
        }



        public static int T14(int[] arr, int i)
        {
            if (i == 0)
            {
                return arr[0];
            }

            return arr[i] + T14(arr, i - 1);
        }

        public static int T15(int[] arr, int i)
        {
            if (i == 0)
            {
                if (arr[0] > 0)
                {
                    return 1;
                }

                return 0;
            }

            if (arr[i] > 0)
            {
                return 1 + T15(arr, i - 1);
            }

            else
            {
                return T15(arr, i - 1);
            }
        }

        public static int T16(int[] arr, int num, int i = 0)
        {
            if (i > arr.Length)
            {
                return -1;
            }

            else if (num == arr[i])
            {
                return i;
            }

            else
            {
                return T16(arr, num, i + 1);
            }
        }

        public static bool T17(int[] arr, int i = 0)
        {
            if (i >= arr.Length - 1)
            {
                return true;
            }

            return (arr[i] < arr[i + 1]) && T17(arr, i + 1);
        }

        public static bool T18(int[] arr, int i = 0)
        {
            if (i >= arr.Length)
            {
                return false;
            }

            if (T8(arr[i], 2))
            {
                return true;
            }

            return T18(arr, i + 1);
        }


        public static bool T20(int[] arr)
        {
            Random rnd = new Random();

            int r = rnd.Next(0, arr.Length);
            int r2 = rnd.Next(0, arr.Length);

            return T20(arr, Math.Min(r, r2), Math.Max(r, r2));
        }

        public static bool T20(int[] arr, int Ileft, int Iright)
        {
            if (Ileft >= Iright)
            {
                return true;
            }

            if (arr[Ileft] != arr[Iright])
            {
                return false;
            }

            return T20(arr, Ileft + 1, Iright - 1);
        }


        public static bool Tclass(int N)
        {
            if (N < 10)
            {
                return N % 2 == 1;
            }

            if (N % 2 == 0)
            {
                return false;
            }

            return Tclass(N / 10);
        }

        public static int T21(string str, int i = 0)
        {
            if (i >= str.Length)
            {
                return 0;
            }

            if (str[i] >= 'a' && str[i] <= 'z')
            {
                return 1 + T21(str, i + 1);
            }

            return T21(str, i + 1);
        }

        public static string T22(string str, int i = 0)
        {
            if (i >= str.Length)
            {
                return "";
            }

            if ((i + 1) % 3 == 0)
            {
                return str[i] + "*" + T22(str, i + 1);
            }

            return str[i] + T22(str, i + 1);
        }

        public static string T23(string str, int i = 0)
        {
            if (i >= str.Length)
            {
                return "";
            }

            return T23(str, i + 1) + str[i];
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
            Console.WriteLine(T11(4));
            Console.WriteLine(T14(new int[] { 1, 2, 3, 4, 5 }, 4));
            Console.WriteLine(T15(new int[] { -2, 5, 3, -1, 7 }, 4));
            Console.WriteLine(T16(new int[] { 4, 8, 2, 9, 6 }, 9));
            Console.WriteLine(T18(new int[] { 4, 6, 8, 11, 12 }));
            Console.WriteLine(T20(new int[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(Tclass(13579));
            Console.WriteLine(T21("AbCdEf"));
            Console.WriteLine(T22("abcdefghi"));
            Console.WriteLine(T23("abcdef"));
            Console.WriteLine(T17(new int[] { 1, 2, 3, 4, 5 }));
        }
    }
}