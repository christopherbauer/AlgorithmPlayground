using System;

namespace AlgorithmPlayground
{
    public static class SortAlgorithm
    {
        public static ISortAlgorithm Create(string name)
        {
            if (name == "quicksort")
            {
                return new QuickSortAlgorithm();
            }
            if (name == "bubblesort")
            {
                return new BubbleSortAlgorithm();
            }
            if (name == "heapsort")
            {
                return new HeapSortAlgorithm();
            }
            if (name == "binarytreesort")
            {
                return new BinaryTreeSortAlgorithm();
            }
            if (name == "mergesort")
            {
                return new NaiveMergeSortAlgorithm();
            }
            if (name == "insertionsort")
            {
                return new InsertionSort();
            }

            throw new InvalidOperationException(string.Format("{0}: Dat shit aint hurr yet", name));
        }
    }
}