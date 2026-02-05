using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class ArraysPractice3
    {
        public static void UnitTest()
        {
            //ArraysPractice3.T10_31();
            //ArraysPractice3.T10_33();
            //ArraysPractice3.T10_34();
            //ArraysPractice3.T10_36();
            //ArraysPractice3.T10_37();
            //ArraysPractice3.T10_38();
            //ArraysPractice3.T10_40();
            //ArraysPractice3.T10_41();
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
            int Count1 = 0, Count2 = 0, Count3 = 0, Count4 = 0, Count5 = 0, Count6 = 0;
            Console.WriteLine("Enter num");
            num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 7);
                if (arr[i] == 1)
                {
                    Count1++;
                }
                else if (arr[i] == 2)
                {
                    Count2++;
                }
                else if (arr[i] == 3)
                {
                    Count3++;
                }
                else if (arr[i] == 4)
                {
                    Count4++;
                }
                else if (arr[i] == 5)
                {
                    Count5++;
                }
                else if (arr[i] == 6)
                {
                    Count6++;
                }
            }
            Console.WriteLine($"1 appeared {Count1} times");
            Console.WriteLine($"2 appeared {Count2} times");
            Console.WriteLine($"3 appeared {Count3} times");
            Console.WriteLine($"4 appeared {Count4} times");
            Console.WriteLine($"5 appeared {Count5} times");
            Console.WriteLine($"6 appeared {Count6} times");
        }

        public static void T10_38()
        {
            int children = 6;
            int[] arr = new int[children];
            int[] counts = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 7);
                counts[arr[i] - 1]++;
            }
            for (int j = 0; j < counts.Length; j++)
            {
                Console.WriteLine($"{j + 1} appeared {counts[j]} times");
            }
        }

        public static void T10_40()
        {
            int num;
            string Color;
            Console.WriteLine("Enter num");
            num = int.Parse(Console.ReadLine());
            string[] arr = new string[num];
            int[] count = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter color for player {i + 1}");
                Color = Console.ReadLine();
                arr[i] = Color;
            }

            Random rnd = new Random();

            Console.WriteLine("Press ENTER to draw a color. Type Q then ENTER to quit.");
            string input = Console.ReadLine();

            while (input != "Q" && input != "q")
            {
                if (input == "")
                {
                    int index = rnd.Next(num);
                    Console.WriteLine(arr[index]);
                    count[index]++;
                }

                Console.WriteLine("Press ENTER to draw a color. Type Q then ENTER to quit.");
                input = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Final counts:");

            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine($"{arr[j]}: {count[j]}");
            }
        }

        public static void T10_41()
        {
            int[] sum = new int[4];
            int rounds;

            Console.WriteLine("Enter num of rounds");
            rounds = int.Parse(Console.ReadLine());

            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"Round {i + 1}:");

                Console.Write("Player in position 1 (1-4): ");
                int p1 = int.Parse(Console.ReadLine());

                Console.Write("Player in position 2 (1-4): ");
                int p2 = int.Parse(Console.ReadLine());

                Console.Write("Player in position 3 (1-4): ");
                int p3 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                sum[p1 - 1] += 7;
                sum[p2 - 1] += 3;
                for (int player = 1; player <= 4; player++)
                {
                    if (player != p1 && player != p2 && player != p3)
                    {
                        sum[player - 1] -= 4;
                    }
                }

            }

            int maxPoints = sum[0];
            int winner = 1;

            for (int i = 1; i < sum.Length; i++)
            {
                if (sum[i] > maxPoints)
                {
                    maxPoints = sum[i];
                    winner = i + 1;
                }
            }
            Console.WriteLine($"The winner is player {winner} with {maxPoints} points");
        }

        public static void T10_42()
        {
            int[] movieCount = new int[6];   
            int[] copySum = new int[6];

            int code;
            Console.WriteLine("Enter code");
            code = int.Parse(Console.ReadLine());

            while (code != 0)
            {
                int department = code / 1000;   
                int copies = code % 10;

                movieCount[department - 1]++;
                copySum[department - 1] += copies;

                Console.WriteLine("Enter code");
                code = int.Parse(Console.ReadLine());
            }

            int maxMovies = movieCount[0];
            int maxMoviesDept = 1;

            int maxCopies = copySum[0];
            int maxCopiesDept = 1;

            for (int i = 1; i < 6; i++)
            {
                if (movieCount[i] > maxMovies)
                {
                    maxMovies = movieCount[i];
                    maxMoviesDept = i + 1;
                }

                if (copySum[i] > maxCopies)
                {
                    maxCopies = copySum[i];
                    maxCopiesDept = i + 1;
                }
            }

            Console.WriteLine($"Department with most movies: {maxMoviesDept}");
            Console.WriteLine($"Department with most copies: {maxCopiesDept}");
        }

    }
}