using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    internal class Myfuncs
    {
        public static int MyMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static double MyMinDouble(double a, double b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static double MyAbs(double num)
        {
            if (num < 0)
            {
                return -num;
            }
            else
            {
                return num;
            }
        }
        public static double MyDist(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double sum = dx * dx + dy * dy;

            double guess = sum / 2;
            for (int i = 0; i < 10; i++)
            {
                guess = (guess + sum / guess) / 2;
            }

            return guess;
        }
        public static double Myadd(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        public static double MyDivDouble(double a, double b)
        {
            double sum = a / b;
            return sum;
        }
        public static int MyDivInt(int a, int b)
        {
            int sum = a / b;
            return sum;
        }
        public static int MyMinInt(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int MyPower(int a, int b)
        {
            int result = 1;
            int i = 0;

            while (i < b)
            {
                result = result * a;
                i++;
            }

            return result;
        }
    }
}
