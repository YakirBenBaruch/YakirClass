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

            Stack<int> stk2 = new Stack<int>();
            stk2.Push(17);
            stk2.Push(12);
            stk2.Push(-9);
            stk2.Push(3);
            stk2.Push(1);

            Console.WriteLine("Starter Stck : ");
            Console.WriteLine(stk);
            Console.WriteLine();

            Console.WriteLine("After : ");
            //Console.WriteLine(stk);
            //Console.WriteLine(Search(stk, 17));
            //Console.WriteLine(stk);
            //Console.WriteLine(StackIsSorted(stk));
            //Circularmovement(stk);
            //Console.WriteLine(stk);
            Console.WriteLine(StucksIsEqual(stk, stk2));
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

        public static bool StackIsSorted(Stack<int> stk)
        {
            Stack<int> temp;
            temp = CopyStack(stk);

            while (!temp.IsEmpty())
            {
                int val = temp.Pop();

                if (!temp.IsEmpty() && temp.Top() < val)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Circularmovement(Stack<int> stk)
        {
            int val = stk.Pop();
            Stack<int> temp = new Stack<int>();

            while (!stk.IsEmpty())
            {
                temp.Push(stk.Pop());
            }

            stk.Push(val);

            while (!temp.IsEmpty())
            {
                stk.Push(temp.Pop());
            }
        }

        public static string BackBack(Stack<string> stk , string str)
        {
            if (str == "Back")
            {
                return stk.Top();
            }

            else
            {
                int x;
                Console.WriteLine("Enter a number ");
                x = int.Parse(Console.ReadLine());

                for (int i = 0; !stk.IsEmpty() && i < x; i++)
                {
                    stk.Pop();
                }

                return stk.Top();
            }
        }

        public static bool StucksIsEqual(Stack<int> stk1, Stack<int> stk2)
        {
            Stack<int> temp = stk2;

            for (int i = 0; !stk1.IsEmpty(); i++)
            {
                for (int j = 0; !temp.IsEmpty(); j++)
                {
                   if (stk1.Top() != temp.Top())
                    {
                        temp.Pop();
                    }

                    stk1.Pop();

                    temp = stk2;
                }
            }

            if (stk1.IsEmpty())
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
