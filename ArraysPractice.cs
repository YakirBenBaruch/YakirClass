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
            ArraysPractice.T1();
        }

        public static void T1()
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
    }
}
