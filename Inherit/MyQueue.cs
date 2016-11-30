using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class MyQueue : Buffer
    {
        private int head;
        private int tail;

        public MyQueue()
        {
            head = 0;
            tail = 0;
        }

        public void Enqueue(int valueIn)
        {
            if (head < GetSize())  // check if head index is less than the array size
            {
                SetArrayVal(head, valueIn); // adding new element
                head++; // move "writing" index one ste forward
                SetCount(GetCount() + 1); // increase the size of buffer
            }
            else // if (head == sizeIn) , if head index reached the end of array
            {
                head = 0; // move the head "write index" to the beginning of the array
                SetArrayVal(head, valueIn); // add new element to the beginning of the array
                SetCount(GetCount() + 1); // increase the size of buffer
                head++; // move the head index to the 2nd cell of array, after the first one was already written
            }
        }

        public int Dequeue()
        {
            if (tail < GetSize()) // if the tail is less than the size of array
            {
                SetValue(GetArrayVal(tail));
                SetArrayVal(tail, -1); // remove element at the tail index (first index in the ring buffer)
                tail++; // move tail step forward
                SetCount(GetCount() - 1); // reduce the size of the buffer
            }
            else // if (tail == sizeIn)
            {
                tail = 0; // if last remove was at the end of the array , then set tail to the beginning of the array
                SetValue(GetArrayVal(tail));
                SetArrayVal(tail, -1);  // remove element under tail index
                SetCount(GetCount() - 1);// reduce the size of buffer
                tail++; // move tail one step forward
            }
            return GetValue();
        }
        public void QueueInit()
        {
            BufferInit();
        }

        public override bool IsFull()
        {
            if (GetCount() < GetSize())  // check if the buffer is not full yet
            {
                return false;
            }
            else
            {
                Console.WriteLine("The buffer is full.");
                return true;
            }
        }
        public override bool IsEmpty()
        {
            if (GetCount() <= GetSize() && GetCount() > 0) // check if stack is not empty already
            {
                return false;
            }
            else
            {
                Console.WriteLine("The buffer is empty.");
                return true;
            }
        }

        public override void Print()
        {
            int i = tail;
            int count_print = GetCount();
            if (count_print == 0) // if buffer is empty print [ ]
            {
                Console.Write("[ ]\n");
            }
            while (count_print > 0)
            {
                if (i < GetSize()) // if printed element is less than the maximum of the array
                {
                    if (tail == i)
                    {
                        Console.Write("[ " + GetArrayVal(i)); // print the first element sof the buffer
                        i++;
                    }
                    else if (tail != i)
                    {
                        Console.Write(", " + GetArrayVal(i)); // middle element
                        i++;
                    }
                }
                else if (i >= GetSize()) // if index exceed the size of the array
                {
                    i = 0;
                    if (tail == GetSize()) // print start position of the buffer
                    {
                        Console.Write("[ " + GetArrayVal(i));
                        i++;
                    }
                    else // print the middle elements of the buffer
                    {
                        Console.Write(", " + GetArrayVal(i));
                        i++;
                    }
                }
                count_print--; // reduce the size of printed array
                if (count_print == 0)
                {
                    Console.Write(" ]\n");
                }
            }
        }
        public override int Peek()
        {
            return GetValue();
        }
    }
}
