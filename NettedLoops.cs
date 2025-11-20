using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    internal class NettedLoops
    {
        public static void UnitTests()
        {
            //NettedLoops.Targil1();
            //NettedLoops.Targil2();
        }
        public static void Targil1()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Targil2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Targil3()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}