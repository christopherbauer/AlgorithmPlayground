namespace AlgorithmPlayground.SortingAlgorithm
{
    /// <summary>
    /// Worst and Average Case of O(n2)
    /// </summary>
    public class InsertionSort : ISortAlgorithm
    {
        public bool Fast { get; set; }

        public InsertionSort()
        {
            Fast = true;
        }

        public void Sort(int[] arr)
        {
            if (Fast)
            {
                for (var i = 1; i < arr.Length; i++)
                {
                    LookBackSlowly(arr, i);
                }
            }
            else
            {
                for (var i = 1; i < arr.Length; i++)
                {
                    LookBackQuickly(arr, i);
                }
            }
        }

        private static void LookBackSlowly(int[] unSortedList, int i)
        {
            if (i > 0 && unSortedList[i] < unSortedList[i - 1])
            {
                SortHelpers.Swap(unSortedList, i, i - 1);
                LookBackSlowly(unSortedList, i - 1);
            }
        }

        private static void LookBackQuickly(int[] unSortedList, int i)
        {
            for (; i > 0 && unSortedList[i] < unSortedList[i - 1]; i--)
            {
                SortHelpers.Swap(unSortedList, i, i - 1);
            }
        }
    }
}