using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    internal class ArraysPractice4
    {
        public static void UnitTest()
        {
            //ArraysPractice4.T1();
            //ArraysPractice4.T2();
            //ArraysPractice4.T3();
        }

        public static void T1()
        {
            int[] type = new int[3];
            int[] SumPoints = new int[5];
            int points = 0;
            int player;
            int max = 0;
            int maxType = 0;
            int counts = 0;
            Console.WriteLine("Enter player");
            player = int.Parse(Console.ReadLine());

            while (player != 0)
            {
                Console.WriteLine("Enter his points");
                points = int.Parse(Console.ReadLine());
                counts += points;
                type[points - 1]++;
                SumPoints[player - 1] += points;
                if (SumPoints[player - 1] > max)
                {
                    max = SumPoints[player - 1];
                }
                if (type[points - 1] > maxType)
                {
                    maxType = type[points - 1];
                }
                Console.WriteLine("Enter player");
                player = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(max);
            Console.WriteLine(points);
            Console.WriteLine(maxType);
            for (int i = 0; i < SumPoints.Length; i++)
            {
                if (SumPoints[i] == 0)
                {
                    Console.WriteLine(SumPoints[i]);
                }

            }
        }

        public static void T2()
        {
            int[] arr = new int[8];
            int[] counts = new int[2];
            int element;
            for (int i = 0; i < arr.Length; i++)
            {
                element = arr[i];
                counts[element % 2]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine(counts[i]);
            }
            // א. פלט : 3 5
            // ב. 10 , 70 , 56 , 58 , 34 , 12, 34 , 79 , 97 , 35
            // ג. : מטרת התוכנית היא לספור כמה מספרים זוגיים ואי זוגיים יש במערך ואחרכך להציג אותם
        }

        public static void T3()
        {
            char c;
            int[] counts = new int[26];
            Console.WriteLine("Enter char");
            c = char.Parse(Console.ReadLine());
            counts[c - 'a']++;
            while (c != '*')
            {
                Console.WriteLine("Enter char");
                c = char.Parse(Console.ReadLine());
                counts[c - 'a']++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine(counts[i]);
            }
        }

        public static void T4()
        {
            int[] arr = new int[10];
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine(avg);
        }
    }
}