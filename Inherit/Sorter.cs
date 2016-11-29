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

        public virtual void BubbleSorterAlg() { }
        public virtual void InsertionSorterAlg() { }

        protected void updateArray(int[] arrayNew, int sizeArray)
        {
            arrayA = new int[sizeArray];

            sizeA = sizeArray;

            for (int i = 0; i < sizeArray; i++)
            {
                arrayA[i] = arrayNew[i];
            }
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
        // read array from console
        protected void SorterFillArrayFromConsole()
        {
            string input;
            int i = 0;
            int elem = 0;
            int sizeIn = 0;

            //Random rnd = new Random();
            // read the size of array
            Console.Write("Please write the array size: ");
            // read the size of array from user input
            while (!(int.TryParse(Console.ReadLine(), out sizeIn)))
            {
                Console.WriteLine("Please enter proper array size again: ");
            }
            int[] arrayIn = new int[sizeIn];
            // read from console 1-by-1 separated by ENTER
            Console.WriteLine("Please enter array's elements one-by-one: ");
            while (i < sizeIn)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out elem))
                {
                    arrayIn[i] = elem;
                    i++;
                }
                else
                {
                    Console.WriteLine("Enter the proper array element #", i, " again: ");
                }
            }
            updateArray(arrayIn, sizeIn);
            Console.Write("The array before sorting: ");
            PrintArr(arrayIn);
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
