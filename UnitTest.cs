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

            //IntNode N2 = new IntNode(51);
            //IntNode N1 = new IntNode(3, N2);
            //IntNode N = new IntNode(42, N1);
            //N2 = null;
            //N1 = null;

            //Console.WriteLine(Print(N));
            //Console.WriteLine(N);
            //Console.WriteLine(Count(N));
            //Console.WriteLine(T1(N));
            //Console.WriteLine(T2(N));
            //Console.WriteLine(T3(N));
            //Console.WriteLine(T4(N));
            //Console.WriteLine(T5(N , 6));
            //Console.WriteLine(T6(N));

            IntNode Num9 = new IntNode(3, null);
            IntNode Num8 = new IntNode(22, Num9);
            IntNode Num7 = new IntNode(4, Num8);
            IntNode Num6 = new IntNode(4, Num7);
            IntNode Num5 = new IntNode(4, Num6);
            IntNode Num4 = new IntNode(3, Num5);
            IntNode Num3 = new IntNode(6, Num4);
            IntNode Num2 = new IntNode(6, Num3);
            IntNode Num1 = new IntNode(5, Num2);
            IntNode Num = new IntNode(4, Num1);
            Num1 = null;
            Num2 = null;
            Num3 = null;
            Num4 = null;
            Num5 = null;
            Num6 = null;
            Num7 = null;
            Num8 = null;
            Num9 = null;

            //Console.WriteLine(T2(Num, 4));
            //Console.WriteLine(T4Char(Num));
            //T5Out(Num, 6);
            //Console.WriteLine(Print(Num));
            //Console.WriteLine(Print(T6NIN(Num)));
            //Console.WriteLine(T8(Num));
            //T9(Num);
            Console.WriteLine(Print(T10(5, 4)));



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
            IntNode Temp = lst;

            while (Temp != null)
            {
                s += Temp.GetValue() + "->";
                Temp = Temp.GetNext();
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

        /////////////////////////////////////////
        /////////////////////////////////////////

        public static int T2(IntNode lst, int num)
        {
            int Count = 0;
            int max = 0;

            while (lst != null)
            {
                if (lst.GetValue() == num)
                {
                    if (Count == 0)
                    {
                        max++;
                    }

                    Count++;
                }

                else
                {
                    Count = 0;
                }

                lst = lst.GetNext();
            }

            return max;
        }

        public static char T4Char(IntNode lst)
        {
            int CountOdd = 0;
            int CountEven = 0;

            while (lst != null)
            {
                if (lst.GetValue() % 2 == 0)
                {
                    CountEven++;
                }

                else
                {
                    CountOdd++;
                }

                lst = lst.GetNext();
            }

            if (CountEven > CountOdd)
            {
                return 'z';
            }

            else if (CountOdd > CountEven)
            {
                return 'e';
            }

            return 's';
        }


        public static void T5Out(IntNode lst, int num)
        {
            while (lst.GetNext() != null)
            {
                if (lst.GetNext().GetValue() == num)
                {
                    IntNode Temp = lst.GetNext();
                    lst.SetNext(Temp.GetNext());
                    Temp.SetNext(null);
                    Temp = null;
                }

                lst = lst.GetNext();
            }
        }

        public static bool T6Ezer(IntNode lst, IntNode num)
        {
            while (lst != null)
            {
                if (lst.GetValue() == num.GetValue())
                {
                    return true;
                }

                lst = lst.GetNext();
            }

            return false;
        }

        public static void T6EzerB(IntNode lst, IntNode num)
        {
            while (lst.GetNext() != null)
            {
                lst = lst.GetNext();
            }

            lst.SetNext(new IntNode(num.GetValue()));
        }

        public static IntNode T6NIN(IntNode lst)
        {
            IntNode NewLst = new IntNode(lst.GetValue());
            lst = lst.GetNext();

            while (lst != null)
            {
                if (T6Ezer(NewLst, lst) == false)
                {
                    T6EzerB(NewLst, lst);
                }

                lst = lst.GetNext();
            }

            return NewLst;
        }

        public static bool T8(IntNode lst)
        {
            while (lst.GetNext() != null)
            {
                if (lst.GetValue() > lst.GetNext().GetValue())
                {
                    return false;
                }

                lst = lst.GetNext();
            }

            return true;
        }

        public static void T9(IntNode lst)
        {
            while (lst.GetNext() != null)
            {
                if (lst.GetValue() > lst.GetNext().GetValue())
                {
                    Console.WriteLine(lst.GetValue());
                }

                lst = lst.GetNext();
            }
        }


        public static IntNode T10(int beginner, int num)
        {
            IntNode lst = new IntNode(num);

            lst.SetValue(beginner);

            IntNode temp = lst;

            for (int i = beginner + 1; i < beginner + num; i++)
            {
                temp.SetNext(new IntNode(i));
                temp = temp.GetNext();
            }

            return lst;
        }


    }
}
