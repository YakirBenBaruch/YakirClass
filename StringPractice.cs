using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                if (s == str)
                {
                    b = true;
                }
            }
            return b;
        }
    }
}