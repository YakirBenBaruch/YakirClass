using System;

namespace Yakir
{
    public class SortOfaDance
    {
        public static int[] Dance(int[] arr)
        {
           for ( int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            return arr;
        }

        public static void UnitTest()
        {
            int[] arr = { 5, 3, 8, 4, 2 };
            int[] result = Dance(arr);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}