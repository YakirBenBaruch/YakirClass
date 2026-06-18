using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Recursion
    {
        public static int Count(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            return 1 + Count(num / 10);
        }

        public static void UnitTest()
        {
            int number = 1717;
            int digitCount = Count(number);
            Console.WriteLine($"The number of digits in {number} is: {digitCount}");
        }
    }
}
