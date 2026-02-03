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
            //Console.WriteLine(Calc3(67, 80));
            //Console.WriteLine(Calc3(68, 80));
        }
        private static int Calc371(int Magen371, int Bagrut371)
        {
            return (int)(Magen371 * 0.3 + Bagrut371 * 0.7 + 0.5);
        }
        private static int Calc3(int Final371, int Proj)
        {
            return (int)(0.6 * Final371 + 0.4 * Proj + 0.5);
        }
        private static int Calc271(int Magen271, int Bagrut271)
        {
            return (int)(Magen271 * 0.4 + Bagrut271 * 0.6 + 0.5);
        }
        private static bool Has5(int Bagrut271)
        {
            return Bagrut271 >= 55;
        }
        private static int Calc5(int Final271, int Final3)
        {
            return (int)(Final271 * 0.4 + Final3 * 0.6 + 0.5);
        }
        public static string FinalString(int Magen371, int Bagrut371, int Magen271, int Bagrut271, int Proj)
        {
            string s = "";
            int F371 = Calc371(Magen371, Bagrut371);
            int F3 = Calc3(F371, Proj);
            int Final;
            if (Has5(Bagrut271))
            {
                s = "You got 5 in CS !\n";
                int F271 = Calc271(Magen271, Bagrut271);
                Final = Calc5(F271, F3);
            }
            else
            {
                s = "You got 3 units on CS ! \n";

            }
        }
    }
}
