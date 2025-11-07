using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ExceptionServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yakir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.Targil1();
            //Program.Targil2();
            //Program.Targil3();
            //Program.Targil4();
            //Program.Targil5();
            //Program.Targil6();
            //Program.Targil7();
            //Program.Targil8();
            //Program.Targil9();
        }

        static void Targil1()
        {
            int x, y, z;
            Console.WriteLine("Enter number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            y = int.Parse(Console.ReadLine());
            z = Myfuncs.MyMax(x, y);
            Console.WriteLine($"Biggest is {z}");
        }

        static void Targil2()
        {
            double x, y, z;
            Console.WriteLine("Enter number");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            y = double.Parse(Console.ReadLine());
            z = Myfuncs.MyMinDouble(x, y);
            Console.WriteLine($"The little is {z}");
        }

        static void Targil3()
        {
            double x, Abs;
            Console.WriteLine("Enter number");
            x = double.Parse(Console.ReadLine());
            Abs = Myfuncs.MyAbs(x);
            Console.WriteLine($"Abs num is {Abs}");
        }

        static void Targil4()
        {
            Console.WriteLine("Enter x1:");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1:");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2:");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y2:");
            double y2 = double.Parse(Console.ReadLine());

            double d = Myfuncs.MyDist(x1, y1, x2, y2);
            Console.WriteLine($"Distance = {d}");
        }

        static void Targil5()
        {
            double a, b, sum;
            sum = 0;
            Console.WriteLine("Enter number");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            b = double.Parse(Console.ReadLine());
            sum = Myfuncs.Myadd(a, b);
            Console.WriteLine(sum);
        }

        static void Targil6()
        {
            double a, b, sum;
            sum = 0;
            Console.WriteLine("Enter number");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            b = double.Parse(Console.ReadLine());
            sum = Myfuncs.MyDivDouble(a, b);
            Console.WriteLine(sum);
        }

        static void Targil7()
        {
            int a, b, sum;
            sum = 0;
            Console.WriteLine("Enter number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            b = int.Parse(Console.ReadLine());
            sum = Myfuncs.MyDivInt(a, b);
            Console.WriteLine(sum);
        }
        static void Targil8()
        {
            int x, y, z;
            Console.WriteLine("Enter number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            y = int.Parse(Console.ReadLine());
            z = Myfuncs.MyMinInt(x, y);
            Console.WriteLine($"The little is {z}");
        }

        static void Targil9()
        {
            int a, b, result;
            Console.WriteLine("Enter base number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exponent:");
            b = int.Parse(Console.ReadLine());

            result = Myfuncs.MyPower(a, b);
            Console.WriteLine(result);
        }
    }
}
