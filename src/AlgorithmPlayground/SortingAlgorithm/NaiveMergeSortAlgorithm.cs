using System;

namespace AlgorithmPlayground.SortingAlgorithm
{
    public class NaiveMergeSortAlgorithm : ISortAlgorithm
    {
        public void Sort(int[] unSortedList)
        {
            BottomUpSort(unSortedList, new int[unSortedList.Length], unSortedList.Length);
        }

        private void BottomUpMerge(int[] source, int lo, int hi, int end, int[] destination)
        {
            var tempLeft = lo;
            var tempRight = hi;

            for (int i = lo; i < end; i++)
            {
                if (tempLeft < hi && (tempRight >= end || source[tempLeft] <= source[tempRight]))
                {
                    destination[i] = source[tempLeft];
                    tempLeft++;
                }
                else
                {
                    destination[i] = source[tempRight];
                    tempRight++;
                }
            }
        }

        private void CopyArray(int[] destination, int[] source, int n)
        {
            for (int i = 0; i < n; i++)
            {
                source[i] = destination[i];
            }
        }

        private void BottomUpSort(int[] source, int[] destination, int n)
        {
            for (int width = 1; width < n; width = 2 * width)
            {
                for (int i = 0; i < n; i = i + 2 * width)
                {
                    BottomUpMerge(source, i, Math.Min(i+width, n), Math.Min(i+2*width, n), destination);
                }
                CopyArray(destination, source, n);
            }
        }
    }
}