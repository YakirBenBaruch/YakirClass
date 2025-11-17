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

            /*
            //Targil3_a
            Console.WriteLine(Myfuncs.Targil3_a(10, 1300));
            Console.WriteLine(Myfuncs.Targil3_a(3, 1300));
            */
            //Myfuncs.Targil3_b();

            /*
            //Targil4_a
            Console.WriteLine(Myfuncs.Targil4_a(15));
            Console.WriteLine(Myfuncs.Targil4_a(20));
            */
            //Myfuncs.Targil4_b();

            /*
            Console.WriteLine(Myfuncs.Targil5_a(91, 93, 99));
            Console.WriteLine(Myfuncs.Targil5_a(88, 93, 99));
            */
            //Myfuncs.Targil5_b();

            //Targil6_a
            //Console.WriteLine(Myfuncs.Targil6_a(3));
            //Myfuncs.Targil6_b();

            //Targil8_a
            /*
            Console.WriteLine(Myfuncs.Targil8_a("male", "male"));
            Console.WriteLine(Myfuncs.Targil8_a("male", "femle"));
            */
            //Myfuncs.Targil8_b();

            //Targil10_a
            /*
            Console.WriteLine(Myfuncs.elapsedTime(1354 , 1454));
            */
            //Myfuncs.Targil10_b();



            //Myfuncs.Targil14_c();
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

        public static int Targil3_a(int Clubmembership, int AmountShoppingforMonth)
        {
            int shislup = 0;
            if (Clubmembership > 3 && Clubmembership < 8 && AmountShoppingforMonth > 1200)
            {
                shislup = Clubmembership * 50;
            }
            else if (Clubmembership > 3 && Clubmembership > 8 && AmountShoppingforMonth > 1200)
            {
                shislup = Clubmembership * 100;
            }

            return shislup;
        }
        static void Targil3_b()
        {
            int Clubmembership, AmountShoppingforMonth, shislup, sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter Club Membership (number of years): ");
                Clubmembership = int.Parse(Console.ReadLine());

                Console.Write("Enter Amount of Shopping for the Month: ");
                AmountShoppingforMonth = int.Parse(Console.ReadLine());

                shislup = Myfuncs.Targil3_a(Clubmembership, AmountShoppingforMonth);
                Console.WriteLine($"Your shi slip is : {shislup}");

                sum += shislup;
            }
            Console.WriteLine($"\nTotal discount for all the clients: {sum}");
        }

        public static bool Targil4_a(int age)
        {
            bool B = false;
            if (age >= 15 && age <= 18)
            {
                B = true;
            }
            return B;
        }
        static void Targil4_b()
        {
            int age, hour, countA;
            bool b = false;
            countA = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter your age");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter you hour you listn");
                hour = int.Parse(Console.ReadLine());
                if (hour > 3)
                {
                    if (b = Myfuncs.Targil4_a(age))
                    {
                        countA++;
                    }
                }
            }
            Console.WriteLine(countA);
        }

        public static int Targil5_a(int a, int b, int c)
        {
            int count = 0;

            if (a > 90)
            {
                count++;
            }

            if (b > 90)
            {
                count++;
            }

            if (c > 90)
            {
                count++;
            }

            return count;
        }
        static void Targil5_b()
        {
            int n, a, b, c, allowCount = 0;
            string name;

            Console.WriteLine("Enter number of students:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter grade 1: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter grade 2: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter grade 3: ");
                c = int.Parse(Console.ReadLine());

                int countAbove90 = Targil5_a(a, b, c);
                if (countAbove90 == 3)
                {
                    Console.WriteLine($"{name} is allowed to enter the competition.");
                    allowCount++;
                }
            }
            Console.WriteLine($"Total students allowed: {allowCount}");
        }

        static bool Targil6_a(int a)
        {

            int sum = 0;
            int price;
            for (int i = 1; i <= a; i++)
            {
                price = int.Parse(Console.ReadLine());
                sum += price;
            }
            return sum > 150;
        }
        static void Targil6_b()
        {
            int price, prod, countF = 0;
            bool b = true;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter your prod");
                prod = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter thr price for each prod");
                b = Myfuncs.Targil6_a(prod);
                if (b == false)
                {
                    countF++;
                }
            }
            Console.WriteLine($"people {countF} need to pay a fee");
        }

        public static char Targil8_a(string twin1, string twin2)
        {

            if (twin1 == "female" && twin2 == "female")
            {
                return 'f';
            }
            if (twin1 == "male" && twin2 == "male")
            {
                return 'm';
            }
            return 'v';
        }
        static void Targil8_b()
        {
            int MALES = 0, FEMALES = 0, EQUAL = 0;
            string t1, t2;
            char result;

            for (int i = 1; i <= 1371; i++)
            {
                Console.WriteLine("Enter first twin (male/female):");
                t1 = Console.ReadLine();

                Console.WriteLine("Enter second twin (male/female):");
                t2 = Console.ReadLine();

                result = Myfuncs.Targil8_a(t1, t2);

                if (result == 'm')
                {
                    MALES++;
                }
                else if (result == 'f')
                {
                    FEMALES++;
                }
                else
                {
                    EQUAL++;
                }
            }

            if (MALES > FEMALES && MALES > EQUAL)
            {
                Console.WriteLine("MALES occurred the most.");
            }
            else if (FEMALES > MALES && FEMALES > EQUAL)
            {
                Console.WriteLine("FEMALES occurred the most.");
            }
            else if (EQUAL > MALES && EQUAL > FEMALES)
            {
                Console.WriteLine("EQUAL (mixed) occurred the most.");
            }
            else
            {
                Console.WriteLine("There is a tie between categories.");
            }
        }

        public static int elapsedTime(int first, int second)
        {
            int firstHours = first / 100;
            int firstMinutes = first % 100;
            int firstTotal = firstHours * 60 + firstMinutes;

            int secondHours = second / 100;
            int secondMinutes = second % 100;
            int secondTotal = secondHours * 60 + secondMinutes;


            return secondTotal - firstTotal;
        }

        public static void Targil10_b()
        {
            int runnerNumber;
            int startTime;
            int finishTime;
            int runTime;
            int shortestTime;
            Console.WriteLine("Enter runner number:");
            runnerNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter start time (hhmm):");
            startTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter finish time (hhmm):");
            finishTime = int.Parse(Console.ReadLine());
            shortestTime = finishTime;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter runner number:");
                runnerNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter start time (hhmm):");
                startTime = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter finish time (hhmm):");
                finishTime = int.Parse(Console.ReadLine());

                runTime = elapsedTime(startTime, finishTime);

                if (runTime < shortestTime)
                {
                    shortestTime = runTime;
                }
            }
            Console.WriteLine($"Shortest running time: {shortestTime} minutes");
        }




        public static int Targil14_a(int num, int digit)
        {
            int count = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit == digit)
                    count++;
                num /= 10;
            }
            return count;
        }

        public static int Targil14_b(int num, int numDigit)
        {
            int minDigit = 10;

            for (int d = 0; d <= 9; d++)
            {
                int count = Myfuncs.Targil14_a(num, d);
                if (count == numDigit && d < minDigit)
                    minDigit = d;
            }


            return (minDigit == 10) ? -1 : minDigit;
        }
        public static void Targil14_c()
        {
            int totalCalls = 0;

            Console.WriteLine("Enter numbers representing calls (0 to finish):");

            while (true)
            {
                Console.Write("\nEnter call number (or 0 to exit): ");
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                    break;

                totalCalls++;


                int maxCount = 0;
                for (int d = 0; d <= 9; d++)
                {
                    int count = Myfuncs.Targil14_a(num, d);
                    if (count > maxCount)
                        maxCount = count;
                }


                int chosenDigit =  Myfuncs.Targil14_b(num, maxCount);

                if (chosenDigit >= 1 && chosenDigit <= 8)
                    Console.WriteLine($"The call has been transferred to a representative {chosenDigit}");
                else
                    Console.WriteLine("No suitable representative found (digit out of range 1-8)");
            }

            Console.WriteLine($"\n\"Total calls handled : {totalCalls}");
        }
    }
}