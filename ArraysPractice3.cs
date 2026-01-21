using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    internal class ArraysPractice3
    {
        public static void UnitTest()
        {
            //ArraysPractice3.T10_31();
            //ArraysPractice3.T10_33();
            //ArraysPractice3.T10_34();
            //ArraysPractice3.T10_36();
            //ArraysPractice3.T10_37();

        }

        public static void T10_31()
        {
            int student;
            Console.WriteLine("Enter num of student");
            student = int.Parse(Console.ReadLine());

            int[] class1 = new int[student];
            int[] grade1 = new int[student];
            int[] grade2 = new int[student];
            int[] finelGrade = new int[student];

            for (int i = 0; i < class1.Length; i++)
            {
                Console.WriteLine($"Enter your one grade for student {i + 1} ");
                grade1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter your second grade for student {i + 1} ");
                grade2[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < finelGrade.Length; j++)
            {
                if (grade1[j] > grade2[j])
                {
                    finelGrade[j] = grade1[j];
                }

                else
                {
                    finelGrade[j] = grade2[j];
                }

                Console.WriteLine($" First grade for studenu {j} is {grade1[j]} the second grade is {grade2[j]} and the final grade is {finelGrade[j]}");
            }
        }

        public static void T10_33()
        {
            int num, CountE = 0, CountO = 0, E = 0, O = 0;
            Console.WriteLine("Enter num");
            num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int[] even, odd;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    CountE++;
                }
                else if (arr[i] % 2 == 1)
                {
                    CountO++;
                }
            }

            even = new int[CountE];
            odd = new int[CountO];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[i] = arr[i];
                    E++;
                }
                else if (arr[i] % 2 == 1)
                {
                    odd[i] = arr[i];
                    O++;
                }
                Console.WriteLine(even[i]);
                Console.WriteLine(odd[i]);
            }
        }

        public static void T10_34()
        {
            int[] arr1 = { 36, 8, 9, 73, 11, 3, 4 };
            int[] arr2 = { 4, 77, 8, 15, 12 };

            int[] arr3 = new int[arr1.Length];
            int index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[index] = arr1[i];
                        index++;
                    }
                }
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }

        public static void T10_36()
        {
            int students;
            int Count1 = 0, Count2 = 0, Count3 = 0, Count4 = 0;
            char vote;

            Console.WriteLine("Enter number of students:");
            students = int.Parse(Console.ReadLine());
            int[] arr = new int[students];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}, enter your vote (1-4):");
                vote = char.Parse(Console.ReadLine());

                if (vote == '1')
                {
                    Count1++;
                }
                else if (vote == '2')
                {
                    Count2++;
                }
                else if (vote == '3')
                {
                    Count3++;
                }
                else if (vote == '4')
                {
                    Count4++;
                }
            }

            int max = Count1;
            string winner = "Roti";

            if (Count2 > max)
            {
                max = Count2;
                winner = "Ali";
            }
            else if (Count3 > max)
            {
                max = Count3;
                winner = "Aviv";
            }
            else if (Count4 > max)
            {
                max = Count4;
                winner = "Ofir";
            }

            Console.WriteLine($"The winner is: {winner}");
        }

        public static void T10_37()
        {
            int num;
            Console.WriteLine("Enter a positive number:");
            num = int.Parse(Console.ReadLine());
            int[] count = new int[6];

            while (num > 0)
            {
                int digit = num % 10;
                if (digit >= 1 && digit <= 6)
                {
                    count[digit - 1]++;
                }
                num = num / 10;
            }

            Console.WriteLine("Dice results:");
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {count[i]}");
            }
        }

        public static void T10_38()
        {
            int[] count = new int[6];
            Random rnd = new Random();
            int roll = 0;

            while (count[roll - 1] != 2)
            {
                roll = rnd.Next(1, 7);
                count[roll - 1]++;
            }

            Console.WriteLine("The winning number is: " + roll);
        }

        public static void T10_40()
        {
            Console.WriteLine("Enter number of players:");
            int n = int.Parse(Console.ReadLine());

            string[] colors = new string[n];
            int[] count = new int[n];


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter color for player {i + 1}:");
                colors[i] = Console.ReadLine();
            }

            Random rnd = new Random();
            string input;

            Console.WriteLine("Press Enter to roll a color, Q to quit");

            input = Console.ReadLine();
            while (input != "Q")
            {
                int index = rnd.Next(0, n);
                count[index]++;

                Console.WriteLine("Rolled color: " + colors[index]);

                input = Console.ReadLine();
            }


            int maxIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (count[i] > count[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine("Most frequent color: " + colors[maxIndex]);


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(colors[i] + ": " + count[i]);
            }
        }

        public static void T10_41()
        {
            int[] points = new int[4];

            Console.WriteLine("Enter number of rounds:");
            int rounds = int.Parse(Console.ReadLine());

            for (int r = 1; r <= rounds; r++)
            {
                Console.WriteLine($"Round {r} - enter 1st place player (1-4):");
                int first = int.Parse(Console.ReadLine());

                Console.WriteLine($"Round {r} - enter 2nd place player (1-4):");
                int second = int.Parse(Console.ReadLine());

                Console.WriteLine($"Round {r} - enter 3rd place player (1-4):");
                int third = int.Parse(Console.ReadLine());


                points[first - 1] += 7;
                points[second - 1] += 3;



                for (int p = 1; p <= 4; p++)
                {
                    if (p != first && p != second && p != third)
                    {
                        points[p - 1] -= 4;
                    }
                }
            }


            int winner = 1;
            for (int i = 2; i <= 4; i++)
            {
                if (points[i - 1] > points[winner - 1])
                {
                    winner = i;
                }
            }

            Console.WriteLine("Winner player number: " + winner);
        }


    }
}
