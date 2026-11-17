
using System;

namespace Yakir
{
    public class SortServices
    {
        public static void SortAscending(IComparable[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        IComparable temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void SortDescending(IComparable[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) < 0)
                    {
                        IComparable temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void UnitTest()
        {
            IComparable[] numbers1 = { 4, 1, 3, 2 };

            SortAscending(numbers1);

            Console.WriteLine("SortAscending: " +
                ((int)numbers1[0] == 1 &&
                 (int)numbers1[1] == 2 &&
                 (int)numbers1[2] == 3 &&
                 (int)numbers1[3] == 4));

            IComparable[] numbers2 = { 4, 1, 3, 2 };

            SortDescending(numbers2);

            Console.WriteLine("SortDescending: " +
                ((int)numbers2[0] == 4 &&
                 (int)numbers2[1] == 3 &&
                 (int)numbers2[2] == 2 &&
                 (int)numbers2[3] == 1));

            IComparable[] equal = { 3, 3, 3 };

            SortAscending(equal);

            Console.WriteLine("Equal values: " +
                ((int)equal[0] == 3 &&
                 (int)equal[1] == 3 &&
                 (int)equal[2] == 3));

            IComparable[] single = { 10 };

            SortDescending(single);

            Console.WriteLine("Single value: " + ((int)single[0] == 10));

            IComparable[] empty = new IComparable[0];

            SortAscending(empty);

            Console.WriteLine("Empty array: " + (empty.Length == 0));
        }
    }
}
