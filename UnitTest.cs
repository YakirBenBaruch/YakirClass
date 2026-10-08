using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Yakir
{
    public class UnitTest
    {
        public static void Run()
        {
            //Test1();

            IntNode N2 = new IntNode(51);
            IntNode N1 = new IntNode(3, N2);
            IntNode N = new IntNode(42, N1);
            N2 = null;
            N1 = null;

            //Console.WriteLine(Print(N));
            //Console.WriteLine(N);
            //Console.WriteLine(Count(N));
            //Console.WriteLine(T1(N));
            //Console.WriteLine(T2(N));
            //Console.WriteLine(T3(N));
            //Console.WriteLine(T4(N));
            //Console.WriteLine(T5(N , 6));
            //Console.WriteLine(T6(N));


        }
        public static void Test1()
        {
            IntNode N2 = new IntNode(51);
            IntNode N1 = new IntNode(3, N2);
            IntNode N = new IntNode(42, N1);
            N2 = null;
            N1 = null;

            Console.WriteLine(N1);
            Console.WriteLine(N);
            Console.WriteLine(N.GetNext());

            N.GetNext().GetNext().SetNext(new IntNode(99));
            N.GetNext().GetNext().SetNext(null);

            bool B = true;
            IntNode Temp = N;
            while (B)
            {
                Console.WriteLine(Temp);
                Temp = Temp.GetNext();
                if (Temp == null)
                {
                    B = false;
                }


            }
        }

        public static string Print(IntNode lst)
        {
            string s = "->";
            bool B = true;
            IntNode Temp = lst;

            while (B)
            {
                s += lst.ToString() + "->";
                Temp = Temp.GetNext();

                if (Temp == null)
                {
                    B = false;
                }
            }

            s += "null";
            return s;
        }

        public static int Count(IntNode lst)
        {
            int count = 0;

            while (lst != null)
            {
                count++;
                lst = lst.GetNext();
            }
            return count;
        }

        public static int T1(IntNode lst)
        {
            int Sum = 0;

            while (lst != null)
            {
                Sum += lst.GetValue();
                lst = lst.GetNext();
            }
            return Sum;

        }

        public static int T2(IntNode lst)
        {
            int Count = 0;

            while (lst != null)
            {
                if (lst.GetValue() % 2 == 1)
                {
                    Count++;
                }

                lst = lst.GetNext();
            }

            return Count;
        }

        public static int T3(IntNode lst)
        {
            int SumEven = 0;
            int SumOdd = 0;

            while (lst != null)
            {
                if (lst.GetValue() % 2 == 1)
                {
                    SumOdd += lst.GetValue();
                }

                else
                {
                    SumEven += lst.GetValue();
                }

                lst = lst.GetNext();
            }

            int SumTotal = SumEven - SumOdd;

            return Math.Abs(SumTotal);
        }

        public static bool T4(IntNode lst)
        {
            int CoumtP = 0;
            int CountN = 0;

            while (lst != null)
            {
                if (lst.GetValue() > 0)
                {
                    CoumtP++;
                }

                else
                {
                    CountN++;
                }

                lst = lst.GetNext();
            }

            if (CoumtP >= CountN)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool T5(IntNode lst, int N)
        {
            while (lst != null)
            {
                if (lst.GetValue() == N)
                {
                    return true;
                }

                lst = lst.GetNext();
            }

            return false;
        }

        public static bool T6(IntNode lst)
        {
            while (lst != null)
            {
                if (lst.GetValue() < lst.GetNext().GetValue())
                {
                    return false;
                }

                lst = lst.GetNext();
            }

            return true;
        }
    }
}
