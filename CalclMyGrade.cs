using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class CalclMyGrade
    {
        public static void UnitTest()
        {
            //Console.WriteLine(Clac371(90, 95));
            //Console.WriteLine(Clac371(90, 94));
            Console.WriteLine(Calc3(67, 80));
            Console.WriteLine(Calc3(68, 80));
        }
        public static int Clac371(int Magen371, int Bagrut371)
        {
            return (int)(Magen371 * 0.3 + Bagrut371 * 0.7 + 0.5);
        }
        public static int Calc3(int Final371, int Proj)
        {
            return (int)(0.6 * Final371 + 0.4 * Proj + 0.5);
        }

    }
}
