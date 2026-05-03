using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ExceptionServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yakir
{
    public class Program
    {
        static void Main(string[] args)
        {
            //StringPractice.UnitTests();
            //Cypher.UnitTests();
            //ArraysPractice.UnitTest();
            //ArraysPractice2.UnitTest();
            //ArraysPractice3.UnitTest();
            //ArraysPractice4.UnitTest();
            //ArraysPractice5.UnitTest();

            /*
            string str = "Hello Josh";
            string s2 = str.ToUpper();
            string s3 = str.ToLower();
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(str.CompareTo(s2));
            */


            //ClassPractice.UnitTest();
            //FootballGame.UnitTest();
            //Point.UnitTest();
            //Date.UnitTest();
            //Rational.UnitTest();
            //Passport.UnitTest();
            //Traveler.UnitTest();
            //Rectangle.UnitTest();
            //SortOfaDance.UnitTest();
            //CalclMyGrade.UnitTest();
            //Line.UnitTest();
            //Parabula.UnitTest();

            //int[,] metrix;
            //metrix = new int[3, 4];
            //int a = metrix[2, 2];
            //for (int row = 0; row < metrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < metrix.GetLength(1); col++)
            //    {
            //        Console.Write(metrix[row, col] + " \t ");
            //    }
            //    Console.WriteLine();
            //}
            Matrix.Test();
        }
    }
}
