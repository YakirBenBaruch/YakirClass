using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    internal class ArraysPractice5
    {
        public static void UnitTest()
        {

        }

        public static int T1(int N)
        {
            int[] arr = new int[N];
            int[] resistance = new int[N]; 
            int countR = 0 , sum = 0; ;
            double ave = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Enter the resistance for resistor {i + 1}");
                resistance[i] = int.Parse(Console.ReadLine());
                sum += resistance[i];
            }
            ave = sum / N;

        }
    }
}
