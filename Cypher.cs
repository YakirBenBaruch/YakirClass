using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Cypher
    {
        public static void UnitTests()
        {
            //Console.WriteLine(Cypher.Key(27));
            //Console.WriteLine(Cypher.Lettar('y'));
            //Console.WriteLine(Cypher.cypher(26 ,"AbCdZ"));
        }

        //הצפנת קיסר
        public static int Key(int key)
        {
            if (key > 26)
            {
                return key % 26;
            }
            return key;

        }

        public static char Lettar(char c)
        {
            int diff = 'a' - 'A';
            if (c >= 'a' && c <= 'z')
            {
                c = (char)(c - diff);
            }
            return c;
        }

        public static char Cplus1(char c)
        {
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                if (c == 'Z')
                {
                    c = 'A';
                }
                else if (c == 'z')
                {
                    c = 'a';
                }
                else
                {
                    c = (char)(c + 1);
                }
            }
            return c;
        }

        public static string cypher(int key, string s)
        {
            string str = "";
            key = Cypher.Key(key);

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                c = Cypher.Lettar(c);
                for (int j = 0; j < key; j++)
                {
                    c = Cypher.Cplus1(c);
                }

                str += c;
            }
            return str;
        }

        //הצפנת ערבול
        public static string HirbulCypher(string s)
        {
            string str = "";
            for (int i = 0; i < s.Length; i = i + 2)
            {

                if (i == s.Length - 1)
                {
                    str = str + s[i];
                }
                else
                {
                    str = str + s[i + 1];
                    str = str + s[i];
                }
            }
            return str;

        }
    }
}
