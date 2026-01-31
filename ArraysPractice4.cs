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
            const int DRUGS = 150;

    long[] groupSum = new long[4];          // 0:0-10, 1:11-30, 2:31-50, 3:51+
    long[] drugSum = new long[DRUGS + 1];   // 1..150

    int age = int.Parse(Console.ReadLine());   // גיל ראשון
    while (age != -1)
    {
        int drug = int.Parse(Console.ReadLine());   // מספר תרופה
        int amount = int.Parse(Console.ReadLine()); // כמות

        int g;
        if (age <= 10) g = 0;
        else if (age <= 30) g = 1;
        else if (age <= 50) g = 2;
        else g = 3;

        groupSum[g] += amount;

        if (drug >= 1 && drug <= DRUGS)
            drugSum[drug] += amount;

        age = int.Parse(Console.ReadLine()); // גיל הבא
    }

    // max
    long max = groupSum[0];
    for (int i = 1; i < 4; i++)
        if (groupSum[i] > max) max = groupSum[i];

    Console.WriteLine(max);

    // הדפסת קבוצות במקסימום (בלי bool: משתמשים במונה מודפסים)
    int printed = 0;
    for (int i = 0; i < 4; i++)
    {
        if (groupSum[i] == max)
        {
            if (printed > 0) Console.Write(", ");
            if (i == 0) Console.Write("0-10");
            else if (i == 1) Console.Write("11-30");
            else if (i == 2) Console.Write("31-50");
            else Console.Write("51+");
            printed++;
        }
    }
    Console.WriteLine();

    // תרופות שלא נצרכו (בלי bool: סופרים כמה לא נצרכו)
    int unusedCount = 0;
    for (int d = 1; d <= DRUGS; d++)
        if (drugSum[d] == 0) unusedCount++;

    if (unusedCount == 0)
    {
        Console.WriteLine("אין תרופות שלא נצרכו");
    }
    else
    {
        for (int d = 1; d <= DRUGS; d++)
            if (drugSum[d] == 0) Console.Write(d + " ");
        Console.WriteLine();
    }
        }
    }
}