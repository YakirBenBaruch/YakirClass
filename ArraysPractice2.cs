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
            ArraysPractice2.T10_23();
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
            int People;
            Console.WriteLine("Enter num of people");
            People = int.Parse(Console.ReadLine());
            int[] Num = new int[People];
            string[] name = new string[People];
            for (int i = 20; i <= 75; i += 20)
            {
                for (int j = 0; j < Num.Length; j++)
                {
                    name[j] = Console.ReadLine();
                }
            }

        }
    }
}
