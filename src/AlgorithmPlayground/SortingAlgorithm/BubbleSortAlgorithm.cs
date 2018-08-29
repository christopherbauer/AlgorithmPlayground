﻿    namespace AlgorithmPlayground.SortingAlgorithm
{
    public class BubbleSortAlgorithm : ISortAlgorithm
    {
        public void Sort(int[] arr)
        {
            var swap = true;
            while (swap)
            {
                swap = false;

                for (var i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        SortHelpers.Swap(arr, i, i + 1);
                        swap = true;
                    }
                }
            }
        }
    }
}