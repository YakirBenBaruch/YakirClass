using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class UnitTest
    {
        public static void Run()
        {
            Test1();
        }
        public static void Test1()
        {
            IntNode N2 = new IntNode(51);
            IntNode N1 = new IntNode(3, N2);
            IntNode N = new IntNode(42, N1);
            N2 = null;
            N1 = null;

            //Console.WriteLine(N1);
            //Console.WriteLine(N);
            //Console.WriteLine(N.GetNext());

            N.GetNext().GetNext().SetNext(new IntNode(99));
            N.GetNext().GetNext().SetNext(null);

            //bool B = true;
            //IntNode Temp = N;
            //while (B)
            //{
            //    Console.WriteLine(Temp);
            //    Temp = Temp.GetNext();
            //    if (Temp == null)
            //    {
            //        B = false;
            //    }

                
            //}
        }
    }
}
