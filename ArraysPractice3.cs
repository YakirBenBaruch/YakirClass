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
            ArraysPractice3.T10_33();
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
    }
}
