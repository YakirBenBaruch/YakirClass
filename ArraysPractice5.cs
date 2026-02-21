using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class ArraysPractice5
    {
        public static void UnitTest()
        {
            //Console.WriteLine(ArraysPractice5.T1(5));
            //Console.WriteLine(ArraysPractice5.T2(new string[] { "Yakir", "Shlomi", "Avi", "Roni", "Moshe" }, new int[] { 50, 60, 70, 80, 90 }));
            //int[] winners = ArraysPractice5.T3(5);
            //Console.WriteLine($"First: {winners[0]}, Second: {winners[1]}");
            //ArraysPractice5.T4(3);
            //ArraysPractice5.T_5_RotateRight(new int[] { 1, 2, 3, 4, 5 });
            //ArraysPractice5.T_5_RotateLeft(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(ArraysPractice5.T6_a(90, 80, 70));
            //ArraysPractice5.T6_b(new int[] { 90, 80, 70 }, new int[] { 80, 70, 60 }, new int[] { 70, 60, 50 });
            //ArraysPractice5.T7(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 3, 2, 4, 5 }, 2);
        }
        public static int T1(int N)
        {
            int[] arr = new int[N];
            int[] resistance = new int[N];
            int countR = 0, sum = 0;
            double ave = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the resistance for resistor {i + 1}");
                resistance[i] = int.Parse(Console.ReadLine());
                sum += resistance[i];
            }

            ave = (double)sum / N;

            for (int j = 0; j < resistance.Length; j++)
            {
                if (resistance[j] < 0.9 * ave || resistance[j] > 1.1 * ave)
                {
                    countR++;
                }
            }

            return countR;
        }

        public static string T2(string[] name, int[] grade)
        {
            string s = "";
            int ave = 0;
            int sum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                sum += grade[i];
            }

            ave = sum / name.Length;

            for (int j = 0; j < grade.Length; j++)
            {
                if (grade[j] > ave)
                {
                    s += name[j] + " ";
                }
            }
            return s;
        }

        public static int[] T3(int N)
        {
            int[] counts = new int[N];

            int vote;
            Console.WriteLine("Enter project number (1..N) or -1 to finish:");
            vote = int.Parse(Console.ReadLine());

            while (vote != -1)
            {
                counts[vote]++;
                Console.WriteLine("Enter project number (1..N) or -1 to finish:");
                vote = int.Parse(Console.ReadLine());
            }

            int first = 1, second = 2;
            if (counts[second] > counts[first])
            {
                int tmp = first;
                first = second;
                second = tmp;
            }

            for (int i = 3; i <= N; i++)
            {
                if (counts[i] > counts[first])
                {
                    second = first;
                    first = i;
                }
                else if (counts[i] > counts[second])
                {
                    second = i;
                }
            }

            return new int[] { first, second };
        }

        public static int T4(int N)
        {
            int[] Judges = new int[5];
            int[] Proj = new int[N];
            int[] SumP = new int[N];

            for (int i = 0; i < Proj.Length; i++)
            {
                Console.WriteLine($"Enter the Grades for Proj number {i + 1} ");
                for (int j = 0; j < Judges.Length; j++)
                {
                    Judges[j] = int.Parse(Console.ReadLine());
                    SumP[i] += Judges[j];
                }
            }

            int max = SumP[0];
            int Imax = 1;

            for (int i = 1; i < SumP.Length; i++)
            {
                if (SumP[i] > max)
                {
                    max = SumP[i];
                    Imax = i + 1;
                }
            }

            return Imax;
        }

        // הזזה ימינה
        public static void T_5_RotateRight(int[] arr)
        {
            int temp = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = temp;
        }

        // הזזה שמאלה
        public static void T_5_RotateLeft(int[] arr)
        {
            int temp = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[arr.Length - 1] = temp;
        }

        public static int T6_a(int Bagrut, int Magen, int Proj)
        {
            double Sum = 0;
            Sum += Bagrut * 0.49 + Magen * 0.3 + Proj * 0.21;
            Sum += 0.5;

            return (int)Sum;
        }

        public static int[] T6_b(int[] Bagrut, int[] Magen, int[] Proj)
        {
            int[] finalGrades = new int[Bagrut.Length];
            for (int i = 0; i < Bagrut.Length; i++)
            {
                finalGrades[i] = T6_a(Bagrut[i], Magen[i], Proj[i]);
            }
            return finalGrades;
        }

        public static int[] T7(int[] arr1, int[] arr2, int n)
        {
            int Max = 0;
            int[] arr = new int[Max];
            Max = Math.Max(arr1[0], arr2[0]);

            for (int i = 0; i < Max; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    if (arr1[i] % n == 0)
                    {
                        arr[i] = arr1[i];
                    }
                }
            }

            return arr;
        }


    }
}
