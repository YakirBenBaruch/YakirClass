using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class CssGrades
    {
        public string name;
        public int magen371;
        public int bagrut371;
        public int magen271;
        private int bagrut271;
        public int proj;
        public int Final371;
        public int Final271;

        public CssGrades(string n, int m3, int b3, int m2, int b2, int p)
        {
            name = n;
            magen371 = m3;
            bagrut371 = b3;
            magen271 = m2;
            bagrut271 = b2;
            proj = p;
        }

        public void SetBagrut271(int b2)
        {
            if (b2 >= 0 && b2 <= 1000)
            {
                bagrut271 = b2;
            }
        }
        public int GetBagrut271()
        {
            return bagrut271;
        }

        public int Calc371()
        {
            return (int)(magen371 * 0.3 + bagrut371 * 0.7 + 0.5);
        }
        public int Calc271()
        {
            return (int)(magen271 * 0.4 + bagrut271 * 0.6 + 0.5);
        }
        public int Calc3()
        {
            return (int)(0.6 * Calc371() + 0.4 * proj + 0.5);
        }
        public bool Has5()
        {
            return bagrut271 >= 55;
        }
        public int Calc5()
        {
            return (int)(Calc271() * 0.4 + Calc3() * 0.6 + 0.5);
        }
        
        public override string ToString()
        {
            string s = "";
            int Final;
            if (Has5())
            {
                s = "You got 5 units in CS!\n";
                Final = Calc5();
            }
            else
            {
                s = "You got 3 units in CS!\n";
                Final = Calc3();
            }
            s += "Your final grade is: " + Final;

            return s;
        }
    }
}
