using System;

namespace AlgorithmPlayground
{
    public static partial class SortAlgorithm
    {
        //Micro optimization - don't punish benchmark for algo initialization
        private static readonly QuickSortAlgorithm QuickSortAlgorithm = new QuickSortAlgorithm();
        private static readonly BinaryTreeSortAlgorithm BinaryTreeSortAlgorithm = new BinaryTreeSortAlgorithm();
        private static readonly BubbleSortAlgorithm BubbleSortAlgorithm = new BubbleSortAlgorithm();
        private static readonly HeapSortAlgorithm HeapSortAlgorithm = new HeapSortAlgorithm();
        private static readonly NaiveMergeSortAlgorithm NaiveMergeSortAlgorithm = new NaiveMergeSortAlgorithm();
        private static readonly InsertionSort InsertionSort = new InsertionSort();

        public static ISortAlgorithm Create(SortingAlgorithm algorithm)
        {
            switch (algorithm)
            {
                case SortingAlgorithm.Quicksort:
                    return QuickSortAlgorithm;
                case SortingAlgorithm.BinaryTreeSort:
                    return BinaryTreeSortAlgorithm;
                case SortingAlgorithm.Bubblesort:
                    return BubbleSortAlgorithm;
                case SortingAlgorithm.Heapsort:
                    return HeapSortAlgorithm;
                case SortingAlgorithm.Mergesort:
                    return NaiveMergeSortAlgorithm;
                case SortingAlgorithm.InsertionSort:
                    return InsertionSort;
                default:
                    throw new InvalidOperationException(string.Format("{0}: Method not implemented", Enum.GetName(typeof(SortingAlgorithm),algorithm)));

            }
        }
    }
}