using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class BubbleSorter : Sorter
    {
        private int ind_last;

        public BubbleSorter()
        {
            ind_last = 0;
            SetSwapCounter(1);
            SetInd1(0);
            SetInd2(1);
        }

       // public void BubbleGetArray() { }

        public void FillArrayFromConsole()
        {
            SorterFillArrayFromConsole();
        }

        public override void BubbleSorterAlg()
        {
            ind_last = GetSize() + 1; // initilize last first sorted index for buble sort: index until which sorting is done, above this index array will be sorted

            while (GetSwapCounter() >= 0)
            {
                if (GetInd1() == ind_last || GetInd1() == GetSize()) // if we compared all elements in the array, then we go to the beginning of the array 
                {                   // and start comparison cycle all over again
                    if (GetSwapCounter() == 0)  // if at the end of array there were no any swaps, then 
                    {
                        break;
                    }
                    ind_last = GetInd1() - 1; // set index to the last sorted index 
                                         // (- 1 because even after the index was already sorted, it is incremented in the end of while loop)
                    SetInd1(0);       // start comparison cycle from the beginning of the array,
                    SetInd2(1);       // meaning reset all indexes--
                    SetSwapCounter(0);
                }
                if (GetInd2() < ind_last && swapArr(getArray(), GetSize(), GetInd1(), GetInd2()))
                {
                    SetSwapCounter(GetSwapCounter()+1);
                }
                SetInd1(GetInd1()+1);
                SetInd2(GetInd2() + 1);
            }
            Console.Write("Your buble sorted array:  ");
            PrintArr(getArray());
            Console.WriteLine("Press ENTER to quit");
            Console.Read();
        }
        public void Print()
        {
            PrintArr(getArray());
        }
    }
}
