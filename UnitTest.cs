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
            IntNode N1 = new IntNode(-17);
            IntNode N = new IntNode(17, N1);
            N1 = null;
            Console.WriteLine(N1);
            Console.WriteLine(N);
            Console.WriteLine(N.GetNext());
        }
    }
}
