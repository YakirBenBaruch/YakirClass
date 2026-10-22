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

            Node<int> lst = new Node<int>(3);
            lst.SetNext(new Node<int>(8));
            lst.GetNext().SetNext(new Node<int>(7));
            lst.GetNext().GetNext().SetNext(new Node<int>(2));
            lst.GetNext().GetNext().GetNext().SetNext(new Node<int>(5));
            lst.GetNext().GetNext().GetNext().GetNext().SetNext(new Node<int>(4));

            //Console.WriteLine("Before:");
            //Console.WriteLine(Print(lst));

            //T26(lst);

            //Console.WriteLine("After:");
            //Console.WriteLine(Print(lst));

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

        public static Node<int> T27(Node<int> lst)
        {
            Node<int> Temp = lst;

            while (lst != null)
            {
                if (lst.GetValue() != lst.GetNext().GetValue() && lst.GetNext().GetValue() != lst.GetNext().GetNext().GetValue())
                {

                }

            }
        }
    }
}
