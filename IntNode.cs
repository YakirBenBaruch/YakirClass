using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class IntNode
    {
        private int Value;
        private IntNode Next;

        public IntNode(int Value)
        {
            this.Value = Value;
            this.Next = null;
        }

        public IntNode(int Value, IntNode Next)
        {
            this.Value = Value;
            this.Next = Next;
        }

        public int GetValue()
        {
            return this.Value;
        }

        public IntNode GetNext()
        {
            return this.Next;
        }

        public int SetValue(int Value)
        {
            this.Value = Value;
            return this.Value;
        }

        public IntNode SetNext(IntNode Next)
        {
            this.Next = Next;
            return this.Next;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
