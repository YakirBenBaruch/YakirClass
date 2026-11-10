using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class NodeUnitTest
    {
        public static void Run()
        {
            //Node <int> Josh = new Node <int> (17);
            //Node <string> Kosh = new Node <string> ("Josh");
            //Node <Object> Bcm = new Node<object>("Josh");
            //Bcm.SetNext(new Node <Object> (17));

            /////////////////////////////////////////////////

            Node<int> lst = new Node<int>(1);
            lst.SetNext(new Node<int>(3));
            lst.GetNext().SetNext(new Node<int>(3));
            lst.GetNext().GetNext().SetNext(new Node<int>(3));
            lst.GetNext().GetNext().GetNext().SetNext(new Node<int>(5));
            lst.GetNext().GetNext().GetNext().GetNext().SetNext(new Node<int>(4));
            lst.GetNext().GetNext().GetNext().GetNext().GetNext().SetNext(new Node<int>(1));

            //Console.WriteLine("Before:");
            //Console.WriteLine(Print(lst));

            //T26(lst);

            //Console.WriteLine("After:");
            //Console.WriteLine(Print(lst));

            Console.WriteLine(T27MoveTemp(lst, ));

        }

        public static string Print(Node<string> lst)
        {
            string s = "->";
            Node<string> Temp = lst;

            while (Temp != null)
            {
                s += Temp.GetValue() + "->";
                Temp = Temp.GetNext();
            }

            s += "null";
            return s;
        }


        public static string Print(Node<int> lst)
        {
            string s = "->";
            Node<int> Temp = lst;

            while (Temp != null)
            {
                s += Temp.GetValue() + "->";
                Temp = Temp.GetNext();
            }

            s += "null";
            return s;
        }


        public static int T15a(Node<char> ch, char ch1)
        {
            int Count = 0;

            while (ch != null)
            {
                if (ch.GetValue() == ch1)
                {
                    Count++;
                }

                ch = ch.GetNext();
            }

            return Count;
        }

        public static void T15b()
        {
            Node<char> ch = null;

            Console.WriteLine("Enter a letter (* to stop)");
            char letter = char.Parse(Console.ReadLine());

            while (letter != '*')
            {
                ch = new Node<char>(letter, ch);

                letter = char.Parse(Console.ReadLine());
            }


            for (char i = 'a'; i <= 'z'; i++)
            {
                int Count = T15a(ch, i);
                Count += T15a(ch, char.ToUpper(i));

                Console.WriteLine(i + ": " + Count);
            }
        }

        public static int T18(Node<string> NameClass, string Name)
        {
            int Count = 0;

            while (NameClass != null)
            {
                if (NameClass.GetValue().Split(' ')[0] == Name)
                {
                    Count++;
                }

                NameClass = NameClass.GetNext();
            }

            return Count;
        }

        public static Node<string> T20(Node<string> Str)
        {

            Node<string> Reverse = null;

            while (Str != null)
            {
                Reverse = new Node<string>(Str.GetValue(), Reverse);

                Str = Str.GetNext();
            }

            return Reverse;
        }

        public static Node<string> T21(Node<string> Str)
        {
            Node<string> Temp = Str;

            while (Temp != null && Temp.GetNext() != null)
            {
                if (Temp.GetValue().CompareTo(Temp.GetNext().GetValue()) > 0)
                {
                    return Temp;
                }

                Temp = Temp.GetNext();
            }

            return null;
        }

        //T22
        //א) הפעולה תחזיר 1 כאשר מספר החוליות ברשימה  הוא אי זוגי , הפעולה תחזיר 2 כאשר מספר החוליות ברשימה הוא זוגי
        //ב) הפעולה תחזיר 1 כאשר מספר החוליות ברשימה הוא אי זוגי , הפעולה תחזיר 2 כאשר מספר החוליות ברשימה הוא זוגי


        public static Node<int> T24(Node<int> lst, int num)
        {
            Node<int> Temp = lst;


            while (Temp != null)
            {
                if (Temp.GetValue() == num)
                {
                    return Temp;
                }

                Temp = Temp.GetNext();
            }

            return null;
        }

        public static bool T25(Node<int> lst, int num)
        {
            int count = 1;


            while (lst.GetNext() != null)
            {
                if (lst.GetValue() == lst.GetNext().GetValue() + 1)
                {
                    count++;
                }

                if (count == num)
                {
                    return true;
                }

                lst = lst.GetNext();
            }

            return false;
        }

        public static Node<int> T26E1(Node<int> lst)
        {

            while (lst != null)
            {
                if (lst.GetValue() % 2 == 0)
                {
                    return lst;
                }

                lst = lst.GetNext();
            }

            return null;
        }

        public static Node<int> T26E2(Node<int> lst)
        {

            while (lst != null)
            {
                if (lst.GetValue() % 2 == 1)
                {
                    return lst;
                }

                lst = lst.GetNext();
            }

            return null;
        }


        public static void Swap(Node<int> p1, Node<int> p2)
        {
            int Num = p1.GetValue();

            p1.SetValue(p2.GetValue());

            p2.SetValue(Num);
        }


        public static void T26(Node<int> lst)
        {
            while (lst != null)
            {
                Node<int> Odd = T26E2(lst);

                if (Odd == null)
                {
                    return;
                }

                Node<int> Even = T26E1(Odd);

                if (Even == null)
                {
                    return;
                }

                Swap(Odd, Even);

                lst = Odd.GetNext();
            }
        }



        public static int T27Count(Node<int> lst)
        {
            if (lst == null)
                return 0;

            Node<int> Temp = lst;
            int Count = 1;

            while (Temp.GetNext() != null &&
                   Temp.GetValue() == Temp.GetNext().GetValue())
            {
                Count++;
                Temp = Temp.GetNext();
            }

            return Count;
        }

        public static Node<int> T27MoveTemp(Node<int> lst, int num)
        {
            Node<int> Temp = lst;
            int move = 0;

            while (move < num && Temp != null)
            {
                Temp = Temp.GetNext();
                move++;
            }

            return Temp;
        }

        public static Node<int> T27(Node<int> lst)
        {
            Node<int> Head = lst;
            Node<int> Temp = lst;
            Node<int> Prev = null;

            while (Temp != null)
            {
                int Count = T27Count(Temp);
                Node<int> Next = T27MoveTemp(Temp, Count);

                if (Count > 2)
                {
                    if (Prev == null)
                    {
                        Head = Next;
                    }
                    else
                    {
                        Prev.SetNext(Next);
                    }
                }
                else
                {
                    for (int i = 1; i < Count; i++)
                    {
                        Temp = Temp.GetNext();
                    }

                    Prev = Temp;
                }

                Temp = Next;
            }

            return Head;
        }
    }

    
public static bool T30Check(Node<int> lst, int n)
        {
            Node<int> Last = lst;
            int Count = 1;

            while (Count < n && Last != null)
            {
                Last = Last.GetNext();
                Count++;
            }

            if (Last == null)
                return false;

            Node<int> Left = lst;

            for (int i = 0; i < n / 2; i++)
            {
                Node<int> Right = lst;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    Right = Right.GetNext();
                }

                if (Left.GetValue() != Right.GetValue())
                    return false;

                Left = Left.GetNext();
            }

            return true;
        }

        public static bool IsPalindrom(Node<int> lst, int n)
        {
            if (n <= 0)
                return false;

            Node<int> Temp = lst;

            while (Temp != null)
            {
                if (T30Check(Temp, n))
                    return true;

                Temp = Temp.GetNext();
            }

            return false;
        }


        public static int LongestPalindrom(Node<int> lst)
        {
            Node<int> Temp = lst;
            int Length = 0;

            while (Temp != null)
            {
                Length++;
                Temp = Temp.GetNext();
            }

            while (Length > 1)
            {
                if (IsPalindrom(lst, Length))
                    return Length;

                Length--;
            }

            return 1;
        }


        public static bool T31Contains(Node<int> lst, int num)
        {
            Node<int> Temp = lst;

            while (Temp != null)
            {
                if (Temp.GetValue() == num)
                    return true;

                Temp = Temp.GetNext();
            }

            return false;
        }

        public static Node<int> T31(Node<int> lis1, Node<int> lis2)
        {
            Node<int> Result = null;
            Node<int> Last = null;
            Node<int> Temp1 = lis1;

            while (Temp1 != null)
            {
                Node<int> Temp2 = lis2;
                bool Found = false;

                while (Temp2 != null && !Found)
                {
                    if (Temp1.GetValue() == Temp2.GetValue())
                        Found = true;

                    Temp2 = Temp2.GetNext();
                }

                if (Found && !T31Contains(Result, Temp1.GetValue()))
                {
                    Node<int> NewNode =
                        new Node<int>(Temp1.GetValue());

                    if (Result == null)
                        Result = NewNode;
                    else
                        Last.SetNext(NewNode);

                    Last = NewNode;
                }

                Temp1 = Temp1.GetNext();
            }

            return Result;
        }


        public static Node<int> T34Reverse(Node<int> lst)
        {
            Node<int> Temp = lst;
            Node<int> Result = null;

            while (Temp != null)
            {
                Node<int> NewNode =
                    new Node<int>(Temp.GetValue());

                NewNode.SetNext(Result);
                Result = NewNode;

                Temp = Temp.GetNext();
            }

            return Result;
        }

        public static Node<int> T34(Node<int> lis1, Node<int> lis2)
        {
            Node<int> Temp1 = T34Reverse(lis1);
            Node<int> Temp2 = T34Reverse(lis2);

            Node<int> Result = null;
            int Carry = 0;

            while (Temp1 != null || Temp2 != null || Carry != 0)
            {
                int Sum = Carry;

                if (Temp1 != null)
                {
                    Sum += Temp1.GetValue();
                    Temp1 = Temp1.GetNext();
                }

                if (Temp2 != null)
                {
                    Sum += Temp2.GetValue();
                    Temp2 = Temp2.GetNext();
                }

                int Digit = Sum % 10;
                Carry = Sum / 10;

                Node<int> NewNode = new Node<int>(Digit);
                NewNode.SetNext(Result);
                Result = NewNode;
            }

            if (Result == null)
                Result = new Node<int>(0);

            return Result;
        }


        public static Node<int> T39(Node<int> lis1, Node<int> lis2)
        {
            Node<int> Temp1 = lis1;
            Node<int> Temp2 = lis2;

            Node<int> Result = null;
            Node<int> Last = null;

            while (Temp1 != null && Temp2 != null)
            {
                if (Temp1.GetValue() == Temp2.GetValue())
                {
                    Node<int> NewNode =
                        new Node<int>(Temp1.GetValue());

                    if (Result == null)
                        Result = NewNode;
                    else
                        Last.SetNext(NewNode);

                    Last = NewNode;

                    Temp1 = Temp1.GetNext();
                    Temp2 = Temp2.GetNext();
                }
                else
                {
                    if (Temp1.GetValue() < Temp2.GetValue())
                        Temp1 = Temp1.GetNext();
                    else
                        Temp2 = Temp2.GetNext();
                }
            }

            return Result;
        }

        public static int T43(Node<int> lst)
        {
            if (lst == null)
                return 0;

            int Count = T43(lst.GetNext());

            if (lst.GetValue() % 2 == 0)
                Count++;

            return Count;
        }


        public static void T44(Node<int> lst)
        {
            if (lst == null || lst.GetNext() == null)
                return;

            Console.WriteLine(lst.GetNext().GetValue());

            T44(lst.GetNext().GetNext());
        }

        public class DiceRoll
    {
        private int First;
        private int Second;

        public DiceRoll(int first, int second)
        {
            First = first;
            Second = second;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetSecond()
        {
            return Second;
        }


        public static int T47(Node<DiceRoll> lst)
        {
            int MaxCount = -1;
            int MaxNumber = 1;

            for (int num = 1; num <= 6; num++)
            {
                int Count = 0;
                Node<DiceRoll> Temp = lst;

                while (Temp != null)
                {
                    if (Temp.GetValue().GetFirst() == num)
                        Count++;

                    if (Temp.GetValue().GetSecond() == num)
                        Count++;

                    Temp = Temp.GetNext();
                }

                if (Count > MaxCount)
                {
                    MaxCount = Count;
                    MaxNumber = num;
                }
            }

            return MaxNumber;
        }


    }
}
