using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Sorter
    {
        private int[] arrayA; // initialize array
        private int sizeA;
        private int swapCounter;
        private int ind1; // start sorting from thr 1st element
        private int ind2; // start comparison from the 2nd element

        public Sorter()
        {
            arrayA = null;
            sizeA = 0;
        }

        protected void SetSize(int sizeNew)
        {
            sizeA = sizeNew;
        }
        protected int GetSize()
        {
            return sizeA;
        }
        protected int[] getArray( )
        {
            return arrayA;
        }
        protected int GetSwapCounter()
        {
            return swapCounter;
        }
        protected void SetSwapCounter(int sCount)
        {
            swapCounter = sCount;
        }
        protected int GetInd1()
        {
            return ind1;
        }
        protected int GetInd2()
        {
            return ind2;
        }
        protected void SetInd1(int inx1)
        {
            ind1 = inx1;
        }
        protected void SetInd2(int inx2)
        {
            ind2 = inx2;
        }

        public virtual void Sort() { }

        protected void InitArraySort(int[] arrayNew, int sizeArray)
        {
            SetSize(sizeArray);
            arrayA = arrayNew; 
        }
        
        //protected void SorterInitArray(int[] arrayB, int sizeArray) { }
        protected bool swapArr(int[] arrayIn, int sizeIn, int inx1, int inx2)
        {
            int temp1 = 0;
            int temp2 = 0;

            if (inx1 < sizeIn && inx2 < sizeIn) // check if index is array 
            {
                if (arrayIn[inx1] > arrayIn[inx2]) // check if 1st element is greater than 2nd
                {                                  // if yes swap and return true , if no - return false
                    temp1 = arrayIn[inx1];
                    temp2 = arrayIn[inx2];
                    arrayIn[inx1] = temp2;
                    arrayIn[inx2] = temp1;
                    return true;
                }
                else                              // if 2nd element is greater than 1st one: return false, no swap
                {
                    return false;
                }
            }
            return false; // if index is larger than array size 
        }

        protected void PrintArr(int[] arrayIn)
        {
            Console.Write("[ ");
            foreach (var item in arrayIn)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("]");
        }
    }
}
