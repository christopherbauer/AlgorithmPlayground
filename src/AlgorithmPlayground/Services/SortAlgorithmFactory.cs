using System;
using AlgorithmPlayground.SortingAlgorithm;

namespace AlgorithmPlayground.Services
{
    public static class SortAlgorithmFactory
    {
        //Micro optimization - don't punish benchmark for algo initialization
        private static readonly QuickSortAlgorithm QuickSortAlgorithm = new QuickSortAlgorithm();
        private static readonly BinarySearchTreeSortAlgorithm BinarySearchTreeSortAlgorithm = new BinarySearchTreeSortAlgorithm();
        private static readonly BubbleSortAlgorithm BubbleSortAlgorithm = new BubbleSortAlgorithm();
        private static readonly HeapSortAlgorithm HeapSortAlgorithm = new HeapSortAlgorithm();
        private static readonly NaiveMergeSortAlgorithm NaiveMergeSortAlgorithm = new NaiveMergeSortAlgorithm();
        private static readonly InsertionSort InsertionSort = new InsertionSort();

        public static ISortAlgorithm Create(SortingAlgorithmOption algorithm)
        {
            switch (algorithm)
            {
                case SortingAlgorithmOption.Quicksort:
                    return QuickSortAlgorithm;
                case SortingAlgorithmOption.BinarySearchTreeSort:
                    return BinarySearchTreeSortAlgorithm;
                case SortingAlgorithmOption.Bubblesort:
                    return BubbleSortAlgorithm;
                case SortingAlgorithmOption.Heapsort:
                    return HeapSortAlgorithm;
                case SortingAlgorithmOption.Mergesort:
                    return NaiveMergeSortAlgorithm;
                case SortingAlgorithmOption.InsertionSort:
                    return InsertionSort;
                default:
                    throw new InvalidOperationException(
                        $"{Enum.GetName(typeof(SortingAlgorithmOption), algorithm)}: Method not implemented");

            }
        }
    }
}