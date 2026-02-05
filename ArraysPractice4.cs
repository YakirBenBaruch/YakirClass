using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class ArraysPractice4
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
            int[] ageGroups = new int[4];
            int[] drugCounters = new int[150];

            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            while (age != -1)
            {
                int drugNumber = int.Parse(Console.ReadLine());
                int amount = int.Parse(Console.ReadLine());

                drugCounters[drugNumber - 1] += amount;

                if (age <= 10)
                {
                    ageGroups[0] += amount;
                }
                else if (age <= 30)
                {
                    ageGroups[1] += amount;
                }
                else if (age <= 50)
                {
                    ageGroups[2] += amount;
                }
                else
                {
                    ageGroups[3] += amount;
                }

                age = int.Parse(Console.ReadLine());
            }

            int max = ageGroups[0];
            for (int i = 1; i < 4; i++)
                if (ageGroups[i] > max)
                {
                    max = ageGroups[i];
                }

            Console.WriteLine("Age groups with the highest consumption:");
            if (ageGroups[0] == max)
            {
                Console.WriteLine("Ages 0–10");
            }

            if (ageGroups[1] == max)
            {
                Console.WriteLine("Ages 11–30");
            }

            if (ageGroups[2] == max)
            {
                Console.WriteLine("Ages 31–50");
            }

            if (ageGroups[3] == max)
            {
                Console.WriteLine("Ages 51 and up");
            }
            Console.WriteLine("Medications not consumed at all: ");
            for (int i = 0; i < 150; i++)
            {
                if (drugCounters[i] == 0)
                {
                    Console.WriteLine(i + 1);
                }

            }
            //ג:תבנית מערך מונה,מערך סכום,מקסימום.
        }

        public static void T5()
        {
            int[] rooms = { 14, 11, 10, 8, -1, 6, -1, 2, 0, 13, 4, -1, 15, 1, 7, 5 };
            int startroom = 3;
            int currentroom = startroom;
            while (rooms[currentroom] != -1)
            {
                currentroom = rooms[currentroom];
            }
            Console.WriteLine(currentroom);
        }
    }
}