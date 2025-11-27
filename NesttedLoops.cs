using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    internal class NesttedLoops
    {
        public static void UnitTests()
        {
            //NesttedLoops.targil7_66a();
            //NesttedLoops.targil7_66b();
            //NesttedLoops.targil7_66c();
            //NesttedLoops.targil7_66d();
            //NesttedLoops.Targil7_67a();
            //NesttedLoops.Targil7_67b();
            //NesttedLoops.Targil7_67c();
            //NesttedLoops.Targil7_67d();
            //NesttedLoops.Targil7_67e();
            //NesttedLoops.Targil7_67f();
            //NesttedLoops.Targil7_67g();
            //NesttedLoops.Targil7_67h();
            //NesttedLoops.Targil7_68();
            //NesttedLoops.Targil7_69();
            //NesttedLoops.Targil7_70();
            //NesttedLoops.Targil47();
            //NesttedLoops.Targil48();
        }
        public static void targil7_66a()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            //פלט:ריבוע
        }
        public static void targil7_66b()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            //פלט:משולש 
        }
        public static void targil7_66c()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
            /*
            פלט:12345
            12345
            12345
            12345
            12345
            */
        }
        public static void targil7_66d()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write("*");
                Console.WriteLine();
            }
            //פלט:משולש הפוך

        }
        public static void Targil7_67a()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
        public static void Targil7_67b()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
        public static void Targil7_67c()
        {
            /*
            for (int i = 2; i <= 5; i++)
            {
                for (int j = 6; j >= i; j--)
                    Console.Write("*");
                Console.WriteLine();
            }
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            */
            for (int i = 1; i <= 10; i++)
            {
                int stars;

                if (i <= 4)
                {
                    stars = 7 - i;
                }
                else
                {
                    stars = i - 4;
                }
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Targil7_67d()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }
        public static void Targil7_67e()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i);
                Console.WriteLine();
            }
        }
        public static void Targil7_67f()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Targil7_67g()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i);
                Console.WriteLine();
            }
        }
        public static void Targil7_67h()
        {
            for (int i = 1; i < 6; i++)
            {
                int k = 6 - i;
                for (int j = 0; j < k; j++)
                    Console.Write(i);
                Console.WriteLine();
            }

        }
        public static void Targil7_68()
        {
            int STUDENT_NUM = 40;
            int GRADE_NUM = 20;
            double grade;
            double sum;
            sum = 0;
            double average = 0;
            for (int i = 1; i <= STUDENT_NUM; i++)
            {
                for (int j = 1; j <= GRADE_NUM; j++)
                {
                    Console.WriteLine("Enter next student grade: ");
                    grade = int.Parse(Console.ReadLine());
                    sum = sum + grade;
                }
                Console.WriteLine(sum / 20);
            }
        }
        public static void Targil7_69()
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int max = -1;
            for (int i = 0; i < num; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                int count = 0;
                while (digit != -1)
                {
                    count++;
                    digit = int.Parse(Console.ReadLine());
                }
                if (count > max)
                {
                    max = count;
                }
            }
            Console.WriteLine(max);
        }
        public static void Targil7_70()
        {
            double sum , sal = 0, min = 0, minLastSal = 0, num;
            Console.WriteLine("How many workers ?");
            num = double.Parse(Console.ReadLine());

            for (int j = 0; j < num; j++)
            {
                sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter your salery");
                    sal = double.Parse(Console.ReadLine());
                    sum += sal;
                }
                Console.WriteLine("=============== Next ===============");

                if (j == 0)
                    min = sum;
                else if (sum < min)
                {
                    min = sum;
                    minLastSal = sal;
                }
            }
            Console.WriteLine("minLastSal : " + minLastSal);
        }

        public static void Targil47()
        {
            int price, sum = 0, maxsum = 0;
            for (int i = 1; i <= 3; i++)
            {
                sum = 0;
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("Shop number " + i);
                    Console.WriteLine("Enter the price for one pen");
                    price = int.Parse(Console.ReadLine());
                    sum += price;
                }
                Console.WriteLine();
                if (sum > maxsum)
                {
                    maxsum = sum;
                }
            }
            Console.WriteLine(maxsum);
        }

        public static void Targil48()
        {
            int grade, sum = 0;
            double avg = 0, minsum = 0;
            for (int i = 1; i <= 3; i++)
            {
                sum = 0;
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("Enter you grade in the test");
                    grade = int.Parse(Console.ReadLine());
                    sum += grade;
                    avg = sum / j;
                }
                Console.WriteLine();
                if (avg < minsum)
                {
                    avg = minsum;
                }
            }
            Console.WriteLine(avg);
        }
    }
}