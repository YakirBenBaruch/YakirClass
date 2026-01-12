using System;
using System.Collections.Generic;
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
            //ArraysPractice2.T10_23();
            //ArraysPractice2.T10_23_B();
            //ArraysPractice2.T10_24();
            //ArraysPractice2.T10_26();

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

        public static void T10_23()
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
            Console.WriteLine("Enter number of boys:");
            int boys = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of girls:");
            int girls = int.Parse(Console.ReadLine());

            int total = boys + girls;

            string[] names = new string[total];

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"Enter name {i + 1}:");
                names[i] = Console.ReadLine();
            }

            int shifts = 75 / 20;

            for (int k = 0; k < shifts; k++)
            {
                string first = names[0];

                for (int i = 0; i < names.Length - 1; i++)
                {
                    names[i] = names[i + 1];
                }

                names[names.Length - 1] = first;
            }

            Console.WriteLine("\nOrder after the hike:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        public static void T10_24()
        {
            Console.WriteLine("Enter number of elements:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Series in descending order:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
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
            // פלט : 4 , 5 , 6
        }
    }
}
