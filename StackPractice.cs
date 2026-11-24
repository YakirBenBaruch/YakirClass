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
            //stk.Push(-10);
            //stk.Push(-11);
            //stk.Push(-12);
            //stk.Push(11);
            //stk.Push(10);
            //stk.Push(9);
            //stk.Push(6);
            //stk.Push(7);
            //stk.Push(8);

            Stack<int> stk2 = new Stack<int>();
            stk2.Push(17);
            stk2.Push(5);
            stk2.Push(3);
            stk2.Push(1);
            stk2.Push(-9);

            Stack<string> stkString = new Stack<string>();
            stkString.Push("a");
            stkString.Push("b");
            stkString.Push("c");
            stkString.Push("d");
            stkString.Push("e");
            stkString.Push("f");
            stkString.Push("g");
            //string s = "Back";

            Console.WriteLine("Starter Stck : ");
            Console.WriteLine(stk);
            //Console.WriteLine(stkString);
            Console.WriteLine();

            Console.WriteLine("After : ");
            //Console.WriteLine(stk);
            //Console.WriteLine(Search(stk, 17));
            //Console.WriteLine(stk);
            //Console.WriteLine(StackIsSorted(stk));
            //Circularmovement(stk);
            //Console.WriteLine(stk);
            //Console.WriteLine(BackBack(stkString, s));
            //Console.WriteLine(stkString);
            //Console.WriteLine(StucksIsEqual(stk, stk2));
            //Console.WriteLine(StucksIsEqualRecursion(stk, stk2));
            //SortedstackUpandDown(stk);
        }



        public static bool Search(Stack<int> stk, int num)
        {
            Stack<int> temp = CopyStack(stk);

            while (!temp.IsEmpty())
            {
                if (temp.Pop() == num)
                {
                    return true;
                }
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

        public static string BackBack(Stack<string> stk, string str)
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
            Stack<int> temp1 = CopyStack(stk1);
            Stack<int> temp2 = CopyStack(stk2);

            while (!temp1.IsEmpty() && !temp2.IsEmpty())
            {
                if (!Search(stk2, temp1.Pop()))
                {
                    return false;
                }

                temp2.Pop();
            }

            if (!temp1.IsEmpty() || !temp2.IsEmpty())
            {
                return false;
            }

            return true;
        }

        public static bool SearchInStuck(Stack<int> stk, int num)
        {
            Stack<int> temp = CopyStack(stk);
            while (!temp.IsEmpty())
            {
                if (temp.Pop() == num)
                {
                    return true;
                }
            }
            return false;
        }
        //סיבוכיות O(n^2)

        public static bool SearchInStuckRecursion(Stack<int> stk, int num)
        {
            if (stk.IsEmpty())
            {
                return false;
            }

            int val = stk.Pop();

            if (val == num)
            {
                return true;
            }

            return SearchInStuckRecursion(stk, num);
        }
        //סיבוכיות O(n)

        public static bool StucksIsEqualRecursion(Stack<int> stk, Stack<int> stk2)
        {
            if (stk.Top() != stk2.Top())
            {
                return false;
            }

            int val = stk.Pop();
            int val2 = stk2.Pop();

            if (stk.IsEmpty() && stk2.IsEmpty())
            {
                return true;
            }

            return StucksIsEqualRecursion(stk, stk2);
        }

        public static void SortedstackUpandDown(Stack<int> stk)
        {
            Stack<int> temp = stk;

            int countUp = 0;
            int countDown = 0;
            int val = temp.Pop();
            while (!stk.IsEmpty())
            {
                if (val < temp.Top())
                {
                    countDown++;
                    val = temp.Pop();
                }

                else if (val > temp.Top())
                {
                    countUp++;
                    val = temp.Pop();
                }
            }

            if (countUp < countDown)
            {
                Console.WriteLine("The longest srike is countDown");
            }

            if (countUp > countDown)
            {
                Console.WriteLine("The longest srike is countUp");
            }
            
        }
    }
}
