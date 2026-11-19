using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Stack<T>
    {
        private Node<T> head;
        public Stack() { this.head = null; }

        public bool IsEmpty() { return head == null; }

        public void Push(T value) { head = new Node<T>(value, head); }

        public T Pop()
        {
            Node<T> temp = head;
            this.head = temp.GetNext();
            temp.SetNext(null);
            return temp.GetValue();
        }

        public T Top() { return this.head.GetValue(); }

        public override string ToString()
        {
            string str = "[";
            Node<T> temp = this.head;
            if (temp != null)
            {
                while (temp.GetNext() != null)
                {
                    str += temp.GetValue().ToString() + ",";
                    temp = temp.GetNext();
                }
                str += temp.GetValue().ToString();
            }
            str += "]";
            return str;
        }
    }
}
