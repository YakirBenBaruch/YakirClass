using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class CssGrades
    {
        private string name;
        private int magen371;
        private int bagrut371;
        private int magen271;
        private int bagrut271;
        private int proj;

        public CssGrades(string name, int magen371, int bagrut371, int magen271, int bagrut271, int proj)
        {
            this.name = name;
            this.magen371 = magen371;
            this.bagrut371 = bagrut371;
            this.magen271 = magen271;
            this.bagrut271 = bagrut271;
            this.proj = proj;
        }

        public void SetBagrut271(int b2)
        {
            if (b2 >= 0 && b2 <= 100)
            {
                this.bagrut271 = b2;
            }
        }
        public int GetBagrut271()
        {
            return this.bagrut271;
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
