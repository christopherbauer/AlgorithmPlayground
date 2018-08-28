namespace AlgorithmPlayground.SortingAlgorithm
{
    public class InsertionSort : ISortAlgorithm
    {
        public bool Fast { get; set; }

        public InsertionSort()
        {
            Fast = true;
        }

        public void Sort(int[] unSortedList)
        {
            if (Fast)
            {
                for (var i = 1; i < unSortedList.Length; i++)
                {
                    LookBackSlowly(unSortedList, i);
                }
            }
            else
            {
                for (var i = 1; i < unSortedList.Length; i++)
                {
                    LookBackQuickly(unSortedList, i);
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