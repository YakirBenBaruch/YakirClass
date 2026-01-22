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
            //ArraysPractice.T10_12();
            //ArraysPractice.T10_13();
            //ArraysPractice.T10_17();
            //ArraysPractice.T10_18();

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

        public static void T10_12()
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

        public static void T10_13()
        {
            int[] arr = new int[100];
            //א. בודק האם ערך המערך במקום הסידורי מתחלק ב5 ללא שארית
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            //ב. בודק האם המספר הסידורי מתחלק ב5 ללא שארית

            //ג
            for (int i = 0; i < arr.Length; i += 5)
            {

            }
        }

        public static void T10_17()
        {
            int[] arr = new int[100];
            int position = 0;
            int counter = 0;
            //א
            if (arr[position] == arr[position - 1])
            {
                Console.WriteLine("previous one is equal");
            }

            if (arr[position] == arr[position + 1])
            {
                Console.WriteLine("next one is equal");
            }
            //בודק האם הערך שווה לערך הקודם 

            //ב
            for (int i = 0; i < 10; i++)
            {
                if (arr[position] == arr[position + i])
                {
                    counter = counter + 1;
                    Console.WriteLine(counter);
                }
            }
            //האם הערך שווה לערך פלוס מספרו הסידורי בלולאה

            //ג
            for (int i = 0; i < 20; i++)
            {
                if (arr[position] < arr[position + i])
                {
                    Console.WriteLine(position + i);
                }
            }

            //ד
            for (int i = 1; i <= 20; i++)
            {
                if (arr[position] < arr[position + i])
                {
                    if (arr[position + i] - arr[position] == i)
                    {
                        Console.WriteLine(position + i);
                    }
                  
                }
            }
        }

        public static void T10_18()
        {
            char[] c = new char[20];
            int Count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Enter char");
                c[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < c.Length - 1; i++)
            {
                if (c[c.Length - 1] == c[i] && c[i + 1] == c[c.Length - 2])
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }
    }
}
