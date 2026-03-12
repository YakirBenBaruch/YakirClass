using System;

namespace Yakir
{
    public class Rational
    {
        private int x;
        private int y;

        public Rational(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Rational(Rational Other) : this(Other.x, Other.y)
        {
            this.x = Other.x;
            this.y = Other.y;
        }

        public Rational (int num)
        {
            this.x = num;
            this.y = 1;
        }

        public int GetDecimal()
        {
            return this.x / this.y;
        }

        public void Reduction()
        {
            int min = x;
            if (y < min)
            {
                min = y;
            }

            int gcd = 1;

            for (int i = 1; i <= min; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    gcd = i;
                }
            }
            x = x / gcd;
            y = y / gcd;
        }

        public int GetNumerator()
        {
            return this.x;
        }

        public int GetDenom()
        {
            return this.y;
        }

        public bool IsEqual(Rational num)
        {
            return this.x * num.GetDenom() == this.y * num.GetNumerator();
        }

        public Rational Multiply(Rational num)
        {
            int newX = this.x * num.GetNumerator();
            int newY = this.y * num.GetDenom();
            return new Rational(newX, newY);
        }

        public Rational Divide(Rational num)
        {
            if (num.GetNumerator() == 0)
            {
                return null;
            }

            int newX = this.x * num.GetDenom();
            int newY = this.y * num.GetNumerator();
            return new Rational(newX, newY);
        }

        public double ToDecimal()
        {
            return (double)this.x / this.y;
        }
        
        public override string ToString()
        {
            return "<" + this.x + ">/<" + this.y + ">";
        }
    }
}