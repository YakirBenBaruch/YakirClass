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
            Console.WriteLine(ArraysPractice5.T2(new string[] { "Yakir", "Shlomi", "Avi", "Roni", "Moshe" }, new int[] { 50, 60, 70, 80, 90 }));
        }#

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

        public static string T2(string[] name , int[] grade)
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
    }
}
