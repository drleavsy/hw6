using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class MyStack : Buffer
    {
        private int top;

        public MyStack ()
        {
            top = 0;
        }

        public override int Pop()
        {
            int ValuePop = 0;
            ValuePop = GetArrayVal(top - 1);  // save value from the top and pass it out from the method 
            SetValue(ValuePop);
            SetArrayVal(top-1, -1); // delete value 
            top--; // move top one step back
            SetCount(GetCount()-1);  // decrease the size of the stack
            return ValuePop;
        }

        public override void Push(int valueIn)
        {
            SetArrayVal(top, valueIn); // push one element
            top++; // move cursor to the top of the stack
            SetCount(GetCount() + 1);   // increase the size of stack
        }
        public override int Peek()
        {
            return GetValue();
        }

        public void StackInit()
        {
            BufferInit();
        }

        public override bool IsFull()
        {
            if (top >= GetSize()) //if stack is full
            {
                return true;
            }
            return false;
        }
        public override bool IsEmpty()
        {
            if (top <= 0) // check if stack is not empty already
            {
                return true;
            }
            return false;
        }

        public override void Print()
        {
            int count_print = GetCount();
            int i = 0;
            if (count_print == 0)
            {
                Console.Write("[ "); // beginning of the stack which is the same as 1st element in the array
            }
            while (count_print > 0)
            {
                if (i == 0)
                {
                    Console.Write("[ " + GetArrayVal(i)); // print start of the stack
                    i++;
                }
                else
                {
                    Console.Write(", " + GetArrayVal(i)); // print middle of the stack
                    i++;
                }
                count_print--; // reduce the size of the printed elements
            }
            Console.WriteLine(" ]"); // print the last element of the stack
        }
    }
}
