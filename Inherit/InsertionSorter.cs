using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class InsertionSorter : Sorter
    {
        public InsertionSorter() 
        {
            SetSwapCounter(1);
            SetInd1(0);
            SetInd2(0);
        }

        public override void InsertionSorterAlg()
        {
            while (GetInd2() < GetSize())
            {
                SetInd1(GetInd2());
                SetInd2(GetInd2() + 1);
                while (GetInd1() >= 0 && swapArr(getArray(), GetSize(), GetInd1(), GetInd2()))
                {
                    SetInd1(GetInd1() - 1);
                    SetInd2(GetInd2() - 1);
                }
            }
            Console.Write("Insertion sorted array:   ");
            PrintArr(getArray());
            Console.WriteLine("Press ENTER to quit");
            Console.Read();
        }

        public void FillArrayFromConsole()
        {
            SorterFillArrayFromConsole();
        }

        public void PrintInsert()
        {
            PrintArr(getArray());
        }
    }
}
