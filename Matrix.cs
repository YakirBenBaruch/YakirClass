using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Matrix
    {
        private static Random rnd = new Random();

        public static void RandomGrades(int[,] grades)
        {
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    grades[row, col] = rnd.Next(55, 101);
                }
            }
        }
        public static int[,] RandomGrades(int r, int c)
        {
            int[,] grades = new int[r, c];
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    grades[row, col] = rnd.Next(55, 101);
                }
            }
            return grades;
        }


        public static void Print(int[,] grades)
        {
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    Console.Write(grades[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }

        // ממוצע כללי של כל הציונים בכל המבחנים
        public static double Avrg(int[,] grades)
        {
            int sum = 0;
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    sum += grades[row, col];
                }
            }
            return (double)sum / grades.Length;
        }

        // ממוצע ציונים לתלמיד - שורה קבועה
        public static double RowAvrg(int[,] grades, int row)
        {
            int sum = 0;
            for (int col = 0; col < grades.GetLength(1); col++)
            {
                sum += grades[row, col];
            }
            return (double)sum / grades.GetLength(1);
        }

        // ממוצע כיתתי למבחן - עמודה קבועה
        public static double ColAvrg(int[,] grades, int col)
        {
            int sum = 0;
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                sum += grades[row, col];
            }
            return (double)sum / grades.GetLength(0);
        }

        public static int T9a(int[,] arr, int row, int col)
        {
            int SumRow = 0;
            int SumCol = 0;

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                SumRow += arr[row, i];
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                SumCol += arr[i, col];
            }
            if (SumRow == SumCol)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int T9b(int[,] arr)
        {
            int count = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (T9a(arr, row, col) == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static bool CheckPlace(int[,] arr, int row, int col)
        {
            int sumUp = 0;
            int sumDown = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sumUp += arr[i, j];
                }
            }

            for (int i = row + 1; i < arr.GetLength(0); i++)
            {
                for (int j = col + 1; j < arr.GetLength(1); j++)
                {
                    sumDown += arr[i, j];
                }
            }

            if (sumUp > sumDown)
                return true;

            return false;
        }

        // סעיף ב
        public static void PrintPlaces(int[,] arr)
        {
            for (int i = 1; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < arr.GetLength(1) - 1; j++)
                {
                    if (CheckPlace(arr, i, j) == true)
                    {
                        Console.WriteLine("[" + i + "," + j + "]");
                    }
                }
            }
        }

        public static bool IsAlternating(int[,] mat, int i, int j)
        {
            if (i + 2 >= 36 || j + 2 >= 52)
            {
                return false;
            }

            if (mat[i, j] != mat[i + 1, j + 1] &&
                mat[i + 1, j + 1] != mat[i + 2, j + 2])
            {
                return true;
            }

            return false;
        }


        public static int IsUniform(int[,] mat, int i, int j)
        {
            if (i + 2 >= 36 || j + 2 >= 52)
            {
                return 0;
            }

            if (mat[i, j] == 1 &&
                mat[i + 1, j + 1] == 1 &&
                mat[i + 2, j + 2] == 1)
            {
                return 1;
            }

            return 0;
        }

        public static int CountUniform(int[,] mat)
        {
            int count = 0;

            for (int i = 0; i < 36; i++)
            {
                for (int j = 0; j < 52; j++)
                {
                    count = count + IsUniform(mat, i, j);
                }
            }

            return count;
        }

        public static int IsDescendingRow(int[,] arr, int row, int j, int k)
        {
            for (int col = j; col < k; col++)
            {
                if (arr[row, col] <= arr[row, col + 1])
                {
                    return 0;
                }
            }

            return 1;
        }


        public static int CountDescendingRows(int[,] arr, int j, int k)
        {
            int count = 0;

            for (int row = 0; row < 32; row++)
            {
                count = count + IsDescendingRow(arr, row, j, k);
            }

            return count;
        }

        public static int IsPositiveRow(int[,] arr, int i)
        {
            for (int j = 0; j < 45; j++)
            {
                if (arr[i, j] <= 0)
                {
                    return 0;
                }
            }

            return 1;
        }


        public static int IsPositiveCol(int[,] arr, int j)
        {
            for (int i = 0; i < 42; i++)
            {
                if (arr[i, j] <= 0)
                {
                    return 0;
                }
            }

            return 1;
        }


        public static void CheckPositiveRowsArray(int[,] arr)
        {
            int countRows = 0;
            int countCols = 0;

            for (int i = 0; i < 42; i++)
            {
                countRows = countRows + IsPositiveRow(arr, i);
            }

            for (int j = 0; j < 45; j++)
            {
                countCols = countCols + IsPositiveCol(arr, j);
            }

            if (countRows > countCols)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        public static int Place(int[,] arr, int x)
        {
            int count = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == x)
                    {
                        return count;
                    }

                    count++;
                }
            }

            return -1;
        }


        public static void PrintAndCount(int[,] arr, int num1, int num2)
        {
            int count = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (count >= num1 && count <= num2)
                    {
                        Console.Write(arr[i, j] + " ");
                    }

                    count++;
                }
            }
        }
        public static void Test()
        {
            //  מערך דו ממדי עם תשע-עשר תלמידים וארבע ציונים לכל תלמיד
            int[,] grd = new int[19, 4];
            Matrix.RandomGrades(grd);
            Console.WriteLine("-------------------------------");
            Matrix.Print(grd);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(Matrix.Avrg(grd));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Row student #3 avrg is: " + Matrix.RowAvrg(grd, 2));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Col Test #2 avrg is: " + Matrix.ColAvrg(grd, 1));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("----- T9b -----");

            int[,] arrT9 = new int[36, 52];

            arrT9[0, 0] = 1;
            arrT9[1, 1] = 1;
            arrT9[2, 2] = 1;

            Console.WriteLine("T9b: " + T9b(arrT9));


            Console.WriteLine("----- CheckPlace -----");

            int[,] arrPlaceCheck =
            {
        { 10, 10, 1, 1 },
        { 10, 10, 1, 1 },
        { 1, 1, 1, 1 },
        { 1, 1, 1, 1 }
    };

            Console.WriteLine(CheckPlace(arrPlaceCheck, 2, 2));


            Console.WriteLine("----- PrintPlaces -----");

            PrintPlaces(arrPlaceCheck);


            Console.WriteLine("----- IsAlternating -----");

            int[,] matAlt = new int[36, 52];

            matAlt[0, 0] = 1;
            matAlt[1, 1] = 0;
            matAlt[2, 2] = 1;

            Console.WriteLine(IsAlternating(matAlt, 0, 0));


            Console.WriteLine("----- IsUniform -----");

            int[,] matUniform = new int[36, 52];

            matUniform[0, 0] = 1;
            matUniform[1, 1] = 1;
            matUniform[2, 2] = 1;

            Console.WriteLine(IsUniform(matUniform, 0, 0));


            Console.WriteLine("----- CountUniform -----");

            Console.WriteLine(CountUniform(matUniform));


            Console.WriteLine("----- IsDescendingRow -----");

            int[,] arrDesc = new int[32, 5];

            arrDesc[0, 0] = 9;
            arrDesc[0, 1] = 7;
            arrDesc[0, 2] = 5;
            arrDesc[0, 3] = 3;
            arrDesc[0, 4] = 1;

            Console.WriteLine(IsDescendingRow(arrDesc, 0, 0, 4));


            Console.WriteLine("----- CountDescendingRows -----");

            int[,] arrDescRows = new int[32, 5];

            for (int i = 0; i < 32; i++)
            {
                arrDescRows[i, 0] = 9;
                arrDescRows[i, 1] = 7;
                arrDescRows[i, 2] = 5;
                arrDescRows[i, 3] = 3;
                arrDescRows[i, 4] = 1;
            }

            Console.WriteLine(CountDescendingRows(arrDescRows, 0, 4));


            Console.WriteLine("----- IsPositiveRow -----");

            int[,] arrPositive = new int[42, 45];

            for (int i = 0; i < 42; i++)
            {
                for (int j = 0; j < 45; j++)
                {
                    arrPositive[i, j] = 1;
                }
            }

            Console.WriteLine(IsPositiveRow(arrPositive, 0));


            Console.WriteLine("----- IsPositiveCol -----");

            Console.WriteLine(IsPositiveCol(arrPositive, 0));


            Console.WriteLine("----- CheckPositiveRowsArray -----");

            CheckPositiveRowsArray(arrPositive);


            Console.WriteLine("----- Place -----");

            int[,] arrPlace =
            {
        { 39, 72, 3, 8, 0, 2, 54 },
        { 18, 16, 13, 47, 41, 87, 65 },
        { 34, 78, 37, 99, 97, 46, 56 },
        { 51, 50, 12, 31, 58, 63, 18 },
        { 23, 4, 11, 26, 83, 25, 67 }
    };

            Console.WriteLine(Place(arrPlace, 13));
            Console.WriteLine(Place(arrPlace, 100));


            Console.WriteLine("----- PrintAndCount -----");

            PrintAndCount(arrPlace, 19, 29);

            Console.WriteLine();
        }
    }
}
