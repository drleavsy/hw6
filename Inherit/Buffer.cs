using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Buffer
    {
        private int sizeA;
        private int count; // 
        private int value; //
        private int[] arrayA;

        public Buffer()
        {
            sizeA = 0;
            count = 0; // 
            value = 0; //
            arrayA = null;
        }

        public void SetSize( int sizeIn )
        {
            sizeA = sizeIn;
        }

        public int GetSize()
        {
            return sizeA;
        }

        public void SetCount(int countIn)
        {
            count = countIn;
        }

        public int GetCount()
        {
            return count;
        }

        public void SetValue(int valueIn)
        {
            value = valueIn;
        }

        public int GetValue()
        {
            return value;
        }

        public void SetArray(int [] arrayIn)
        {
            arrayA = arrayIn;
        }

        public int [] GetArray()
        {
            return arrayA;
        }
        public int GetArrayVal (int inx)
        {
            return arrayA[inx];
        }
        public void SetArrayVal(int inx , int valNew)
        {
            arrayA[inx] = valNew;
        }

        virtual public bool IsFull() { return false; }
        virtual public bool IsEmpty()   { return false; }

        virtual public void Print() { }

        protected void BufferInit()
        {
            int sizeIn = 0;
            Console.Write("Please write the buffer size: ");
            // read the size of array from user input
            while (!(int.TryParse(Console.ReadLine(), out sizeIn)))
            {
                Console.Write("Please write the stack size: ");
            }
            arrayA = new int[sizeIn];
            sizeA = sizeIn;
            for (int i = 0; i < sizeIn; i++)
            {
                arrayA[i] = -1;
            }
        }
    }
}
