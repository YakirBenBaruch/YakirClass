using System;
using System.Collections.Generic;
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

        public void T16a(Node<char> ch)
        {

        }
    }
}
