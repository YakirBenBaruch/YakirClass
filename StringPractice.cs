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
            Console.WriteLine(StringPractice.Targil6_b("hello"));
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
            if (c >= 'a' && c <= 'z')
            {
                c = (char)(c - 32);
            }
            return c;
        }

        public static string Targil6_b(string c)
        {
            char s = ' ';
            if (s >= 'a' && s <= 'z')
            {

                s = (char)(s - 32);
                c += s;
            }
            return c;
        }
    }
}