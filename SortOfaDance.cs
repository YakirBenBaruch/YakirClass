using System;

namespace Yakir
{
    public class SortOfaDance
    {
        //א) הסרטון מדגים לנו מערך לא ממוין ובמהלך הסרטון נוצר לנו אלגוריתם שממין את המערךל והופך את המערך למערך ממוין מהגדול לקטן.
        public static int[] Dance(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
            return arr;
        }

        public static void UnitTest()
        {
            int[] arr = { 5, 3, 8, 4, 2 };
            int[] result = Dance(arr);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();

            int[] arr2 = { 10, 1, 5, 3, 7 };
            int[] result2 = Dance(arr2);
            for (int i = 0; i < result2.Length; i++)
            {
                Console.Write(result2[i] + " ");
            }
        }
    }
}