using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class QuickSortAlgorithm : ISortAlgorithm
    {
        public void Sort(int[] unSortedList)
        {
            Sort(unSortedList, 0, unSortedList.Length - 1);
        }

        private void Sort(int[] unSortedList, int low, int high)
        {
            if (low < high)
            {
                var p = Partition(unSortedList, low, high);
                Sort(unSortedList, low, p - 1);
                Sort(unSortedList, p + 1, high);
            }
        }

        private static int Partition(int[] unSortedList, int low, int high)
        {
            var pivot = ChoosePivot(unSortedList, low, high);
            var pivotValue = unSortedList[pivot];

            Swap(unSortedList, high, pivot);
            
            var storedIndex = low;

            for (var i = low; i < high; i++)
            {
                if (unSortedList[i] < pivotValue)
                {
                    Swap(unSortedList, i, storedIndex);
                    storedIndex++;
                }
            }

            Swap(unSortedList,high,storedIndex);

            return storedIndex;
        }

        private static void Swap(IList<int> unSortedList, int a, int b)
        {
            var tempA = unSortedList[a];
            unSortedList[a] = unSortedList[b];
            unSortedList[b] = tempA;
        }

        private static int ChoosePivot(int[] unSortedList, int low, int high)
        {
            return (low + high) / 2;
        }
    }
}