using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Rational
    {
        private int numerator;
        private int denom;

        public Rational(int x, int y)
        {
            if (y == 0)
            {
                this.numerator = 0;
                this.denom = 1;
            }
            else
            {
                this.numerator = x;
                this.denom = y;
            }
        }

        public Rational(Rational other) : this(other.numerator, other.denom)
        {
            this.numerator = other.numerator;
            this.denom = other.denom;
        }

        public int GetNumerator()
        {
            return this.numerator;
        }

        public int GetDenom()
        {
            return this.denom;
        }

        public bool IsEqual(Rational num)
        {
            return this.numerator * num.denom ==
                   this.denom * num.numerator;
        }

        public Rational Multiply(Rational num)
        {
            int newNum = this.numerator * num.numerator;
            int newDen = this.denom * num.denom;

            return new Rational(newNum, newDen);
        }

        public Rational Divide(Rational num)
        {
            int newNum = this.numerator * num.denom;
            int newDen = this.denom * num.numerator;

            if (num.numerator == 0)
            {
                return null;
            }

            return new Rational(newNum, newDen);
        }

        public override string ToString()
        {
            return numerator + "/" + denom;
        }

        public static void UnitTest()
        {
            Console.WriteLine("========== Rational UnitTest ==========");

            // 1) בנייה + Get
            Rational r1 = new Rational(1, 2);
            Console.WriteLine("---- Test 1: Constructor + Get ----");
            Console.WriteLine(r1.ToString());                 // 1/2
            Console.WriteLine(r1.GetNumerator());            // 1
            Console.WriteLine(r1.GetDenom());                // 2
            Console.WriteLine();

            // 2) מכנה 0 (לפי הקוד שלך הופך ל-0/1)
            Rational rBad = new Rational(7, 0);
            Console.WriteLine("---- Test 2: Denom=0 handling ----");
            Console.WriteLine(rBad.ToString());              // 0/1
            Console.WriteLine();

            // 3) IsEqual - שברים שקולים (1/2 == 2/4)
            Rational r2 = new Rational(2, 4);
            Console.WriteLine("---- Test 3: IsEqual (equivalent fractions) ----");
            Console.WriteLine(r1.IsEqual(r2));               // true
            Console.WriteLine();

            // 4) IsEqual - לא שקולים
            Rational r3 = new Rational(3, 4);
            Console.WriteLine("---- Test 4: IsEqual (not equal) ----");
            Console.WriteLine(r1.IsEqual(r3));               // false
            Console.WriteLine();

            // 5) Multiply
            // (1/2) * (3/4) = 3/8
            Console.WriteLine("---- Test 5: Multiply ----");
            Rational mul = r1.Multiply(r3);
            Console.WriteLine(mul.ToString());               // 3/8
            Console.WriteLine();

            // 6) Divide
            // (1/2) / (3/4) = (1/2) * (4/3) = 4/6
            Console.WriteLine("---- Test 6: Divide ----");
            Rational div = r1.Divide(r3);
            Console.WriteLine(div.ToString());               // 4/6 (לא מצומצם כי לא דרשו צמצום)
            Console.WriteLine();

            // 7) Divide by zero (num.numerator == 0) => null
            Console.WriteLine("---- Test 7: Divide by zero rational ----");
            Rational zero = new Rational(0, 5);
            Rational divZero = r1.Divide(zero);
            Console.WriteLine(divZero == null);              // true
            Console.WriteLine();

            // 8) סימנים (מינוס)
            // (-1/2) == (1/-2) לפי כפל מוצלב => true
            Console.WriteLine("---- Test 8: Negative sign equality ----");
            Rational rn1 = new Rational(-1, 2);
            Rational rn2 = new Rational(1, -2);
            Console.WriteLine(rn1.IsEqual(rn2));             // true
            Console.WriteLine();
        }
    }
}
