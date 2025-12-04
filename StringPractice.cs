using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Yakir
{
    internal class StringPractice
    {
        public static void UnitTests()
        {
            //Console.WriteLine(StringPractice.Targil0("Hello I am Josh amd I am 17 years old"));
            //Console.WriteLine(StringPractice.Targil1("Hello World", 'a'));
            //Console.WriteLine(StringPractice.Targil2("Hello World" , "tgggg lllll"));
            //Console.WriteLine(StringPractice.Targil3("Hello World", "Hello World"));
            //Console.WriteLine(StringPractice.Targil4("Yakir" , "Yakir"));
            //Console.WriteLine(StringPractice.Targil5("hello"));
            //Console.WriteLine(StringPractice.Targil6_a('r'));
            //Console.WriteLine(StringPractice.Targil6_b("hello"));
            //Console.WriteLine(StringPractice.Targil7('a', "maya"));
            //Console.WriteLine(StringPractice.Targil8('a', "maya"));
            //Console.WriteLine(StringPractice.Targil9("HELLO" , "HELL"));
        }

        public static int Targil0(string s)
        {
            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        public static bool Targil1(string s, char c)
        {
            bool b = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    b = true;
                }
            }
            return b;
        }

        public static bool Targil2(string s, string str)
        {
            bool b = false;
            if (s.Length == str.Length)
            {
                b = true;
            }
            return b;
        }

        public static bool Targil3(string s, string str)
        {
            bool b = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length == str.Length && s[i] == str[i])
                {
                    b = true;
                }
            }
            return b;
        }

        public static string Targil4(string s, string str)
        {
            string letter;
            Console.WriteLine("Write down the letter body");
            letter = Console.ReadLine();
            string allletter = "Hello " + s + "\n" + letter + "\n" + "Best Regards," + "\n" + str;
            return allletter;
        }

        public static string Targil5(string s)
        {
            string str = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                str += s[i];
            }
            return str;
        }

        public static char Targil6_a(Char c)
        {
            int a = 'a' - 'A';
            if (c >= 'a' && c <= 'z')
            {
                c = (char)(c - a);
            }
            return c;
        }

        public static string Targil6_b(string s)
        {
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                str += StringPractice.Targil6_a(s[i]);
            }
            return str;
        }

        public static int Targil7(char c, string s)
        {
            c = StringPractice.Targil6_a(c);
            int Count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char ch = StringPractice.Targil6_a(s[i]);
                if (ch == c)
                {
                    Count++;
                }
            }
            return Count;
        }

        public static int Targil8(char c, string s)
        {
            int a = 0;
            bool b = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i] && b == true)
                {
                    b = false;
                    a = i;
                }
            }
            return a;
        }

        public static bool Targil9(string s, string str)
        {
            int count = 0;
            bool b = false;

            if (str.Length > s.Length)
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (s[i] == str[i])
                {
                    count++;
                }
            }

            if (count == str.Length)
            {
                b = true;
            }

            return b;
        }
    }
}