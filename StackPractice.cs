using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class StackPractice
    {
        public static void Run()
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(17);
            stk.Push(5);
            stk.Push(3);
            stk.Push(1);
            stk.Push(-9);
            //Console.WriteLine(stk);
            //Console.WriteLine(Search(stk, 17));
            //Console.WriteLine(stk);
            Console.WriteLine(StackIsSorted(stk));
        }

        public static bool Search(Stack<int> stk, int x)
        {
            // the problem - it deletes the stack!
            while (!stk.IsEmpty())
            {
                if (stk.Pop() == x)
                    return true;
            }
            return false;
        }

        public static Stack<int> CopyStack(Stack<int> stk)
        {
            Stack<int> temp = new Stack<int>();
            Stack<int> copyStack = new Stack<int>();

            while (!stk.IsEmpty())
            {
                temp.Push(stk.Pop());
            }

            while (!temp.IsEmpty())
            {
                int val = temp.Top();

                copyStack.Push(val);

                stk.Push(temp.Pop());
            }

            return copyStack;
        }

        public static bool StackIsSorted(Stack<int> s)
        {
            Stack<int> temp;
            temp = CopyStack(s);

            while (!temp.IsEmpty())
            {
               if (temp.Top() < temp.Pop())
               {
                    return false;
               }
            }

            return true;
        }
    }
}
