using System;
using System.Runtime.ExceptionServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yakir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Targil1();
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
    }
}
