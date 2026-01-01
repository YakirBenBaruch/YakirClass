using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    internal class ArraysPractice
    {
        public static void UnitTest()
        {
            //ArraysPractice.T0();
            //ArraysPractice.T10_6();
            //ArraysPractice.T10_7();
            //ArraysPractice.T10_8();
            //ArraysPractice.T_12();

        }

        public static void T0()
        {
            double[] LapTime = new double[5];
            double sum = 0, averg = 0;
            int count = 0;
            for (int i = 0; i < LapTime.Length; i++)
            {
                Console.Write("Enter your time : ");
                LapTime[i] = double.Parse(Console.ReadLine());
                sum += LapTime[i];
            }
            averg = sum / LapTime.Length;
            for (int j = 0; j < LapTime.Length; j++)
            {
                if (LapTime[j] < averg)
                {
                    count++;
                }
            }
            Console.WriteLine("Totel Below Averg : " + count);
        }

        public static void T10_6()
        {
            double[] grade = new double[5];
            double sum = 0, dis = 0, ave = 0;
            for (int i = 0; i < grade.Length; i++)
            {
                Console.WriteLine("Enter your grade");
                grade[i] = double.Parse(Console.ReadLine());
                sum += grade[i];
            }
            ave = sum / grade.Length;
            Console.WriteLine("The ave is " + ave);
            for (int j = 0; j < grade.Length; j++)
            {
                dis = Math.Abs(grade[j] - ave);
                Console.WriteLine($"The dis for grade {j} is {dis}");
            }
        }

        public static void T10_7()
        {
            int[] Num = new int[10];
            int pow = 0;
            for (int i = 0; i < Num.Length; i++)
            {
                pow = i * i;
                Console.WriteLine($"The pow of num{i} is {pow}");
            }
        }

        public static void T10_8()
        {
            int[] t = new int[5];

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > i)
                {
                    Console.WriteLine(i);
                }
            }
            for (int j = 0; j < t.Length; j++)
            {
                if (t[j] == j * 2)
                {
                    Console.WriteLine(j);
                }
            }
        }

        public static void T_12()
        {
            int num;
            Console.WriteLine("Enter num");
            num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < num / 2)
                {
                    arr[i] = 0;
                }

                else if (i >= num / 2)
                {
                    arr[i] = 1;
                }

                Console.WriteLine(arr[i]);
            }
        }
    }
}
