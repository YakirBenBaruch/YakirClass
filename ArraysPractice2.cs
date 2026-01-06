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
            if (Kobia >= Index[Pos + Kobia -1])
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
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i + 1] = arr[i];
            }
            //א. איברי המערך בסוף התוכנית יהיו שווים לערך הראשון במקום הראשון

            //ב

        }
    }
}
