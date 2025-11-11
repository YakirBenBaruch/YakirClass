using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    internal class Myfuncs
    {
        public static void UnitTests()
        {
            /*
            //Targil1_a
            Console.WriteLine(Myfuncs.Targil1_a(4, 2009));
            Console.WriteLine(Myfuncs.Targil1_a(4, 2017));
            */
            //Myfuncs.Targil1_b();

            /*
            //Targil2_a
            //Console.WriteLine(Myfuncs.Targil2_a(20, 1 , 70));
            //Console.WriteLine(Myfuncs.Targil2_a(24, 3, 70));
            */
            //Myfuncs.Targil2_b();


        }
        public static bool Targil1_a(int Month, int year)
        {
            bool b = false;
            if (Month >= 1 && Month <= 6 && year == 2009)
            {
                b = true;
            }
            return b;
        }
        public static void Targil1_b()
        {
            int countM = 0, countF = 0, month, year;
            char sex;// 'm'- male, 'f'- female
            bool b;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter year: ");
                year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter month: ");
                month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter sex: ");
                sex = char.Parse(Console.ReadLine());
                b = Myfuncs.Targil1_a(month, year);
                if (b)
                {
                    if (sex == 'm')
                    {
                        countM++;
                    }
                    else
                        countF++;
                }

            }

            Console.WriteLine("Male count " + countM);
            Console.WriteLine("feMale count " + countF);
        }


        public static int Targil2_a(int age, int licens, int speed)
        {
            if (licens < 2 && age < 24)
            {
                speed = speed - 10;
                return speed;
            }
            else
            {
                return speed;
            }
        }
        public static void Targil2_b()
        {
            int age, licens, speedLimit, speed;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter you licens");
            licens = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the limit speed");
            speedLimit = int.Parse(Console.ReadLine());
            speed = Myfuncs.Targil2_a(age, licens, speedLimit);
            Console.WriteLine($"Your limit speed is : {speed} ");
        }


    }
}
