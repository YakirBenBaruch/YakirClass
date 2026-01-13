using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    internal class ArraysPractice2
    {
        public static void UnitTest()
        {
            //ArraysPractice2.T10_19();
            //ArraysPractice2.T10_23_A();
            //ArraysPractice2.T10_23_B();

            /*
            int[] arr = [1, 2, 3, 4, 5 , 6];
            ArraysPractice2.T10_24(arr);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[arr.Length - i - 1]);
            }
            */

            //ArraysPractice2.T10_26();
            //ArraysPractice2.T10_28();
        }

        public static void T10_19()
        {
            int Pos, Kobia;
            int[] Index = new int[25];
            Console.WriteLine("Enter bord");
            for (int i = 0; i < Index.Length; i++)
            {
                Index[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter your pos 10 - 15");
            Pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num of the Kobia");
            Kobia = int.Parse(Console.ReadLine());
            if (Kobia >= Index[Pos + Kobia - 1])
            {
                Pos += Kobia;
            }
            else
            {
                Pos = Pos - Kobia;
            }
            Console.WriteLine(Pos);
        }

        public static void T10_22()
        {
            /*
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i + 1] = arr[i];
            }
            //א. איברי המערך בסוף התוכנית יהיו שווים לערך הראשון במקום הראשון
            */

            //ב
            int[] arr = new int[10];

            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = last;
        }

        public static void T10_23_A()
        {
            Console.WriteLine("Enter num of students:");
            int num = int.Parse(Console.ReadLine());

            string[] names = new string[num];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter name of student {i + 1}:");
                names[i] = Console.ReadLine();
            }

            int shifts = 75 / 20;

            for (int k = 0; k < shifts; k++)
            {
                string first = names[0];

                for (int j = 0; j < names.Length - 1; j++)
                {
                    names[j] = names[j + 1];
                }

                names[names.Length - 1] = first;
            }

            Console.WriteLine("\nOrder after the hike:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        public static void T10_23_B()
        {
            int girls, boys;
            Console.WriteLine("Enter num of girls and boys");
            girls = int.Parse(Console.ReadLine());
            boys = int.Parse(Console.ReadLine());
            int[] girl = new int[girls];
            int[] total = new int[boys + girls + 4];
            for (int i = total.Length - 4; i < total.Length - boys - 5; i--)
            {

            }
        }

        public static void T10_24(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        public static void T10_26()
        {
            int[] arr = new int[8];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((i == arr[i]) || (i == arr[i + 1]))
                {
                    Console.WriteLine(i);
                }
            }
            // א. פלט : 4 , 5 , 6

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == (10 * i))
                {
                    arr[i] = arr[i] + 1;
                }
                else
                {
                    arr[i] = arr[i] - 1;
                }
            }
            // { 9, 19, 39, 31, 3, 4, 6, 5 }

            //ג
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1];
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i] * 2;
            }

            for (int i = 0; i * 2 < arr.Length; i++)
            {
                arr[i] = arr[i * 2];
            }
        }

        public static void T10_28()
        {
            double[] arr = new double[50];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (double)i / 2 + 0.5;
                Console.WriteLine(arr[i]);
            }
            //הטעיות היו שהייתה חריגה מגבולת המערך שהיה תנאי בלולאה שהיא ציהיה עד האורך של המחרוזת כפול 2 ולכן יש חריגה בגבולת המערך
            //הטעות השנייה היא שהייתה היא שחילקנו שני מספרים שלמים ויימנו את החילוק במשתנה ממשי אז הפכתי את אחד המשתנים לממשי ואז הוספתי 0.5 כדי שזה יתחיל מ0.5 ולא מ - 0
        }
        //T29
        //א. 0 3 , 1 18 , 5 4
        //ב. כדי לא לצאת מגבולות המערך צריך שיתקיים i+2 ≤ n-1, כלומר i ≤ n-3, ולכן הלולאה חייבת לרוץ עד i < n-2.
        //אם היה i<n, אז עבור i = n - 2 או i = n - 1 הייתה גישה ל־a[n] או a[n + 1]
    }
}