namespace AlgorithmPlayground
{
    public class HeapSortAlgorithm : ISortAlgorithm
    {
        public void Sort(int[] unSortedList)
        {
            Heapify(unSortedList, unSortedList.Length);

            var end = unSortedList.Length - 1;
            while (end > 0)
            {
                SortHelpers.Swap(unSortedList, end, 0);
                end--;
                SiftDown(unSortedList, 0, end);
            }
        }

        private void Heapify(int[] unSortedList, int length)
        {
            var start = (length - 2)/2;
            while (start >= 0)
            {
                SiftDown(unSortedList, start, length);
                start--;
            }
        }

        private void SiftDown(int[] unSortedList, int start, int length)
        {
            var root = start;

            while (root*2 + 1 <= length)
            {
                var child = root*2 + 1;
                var swap = root;

                if (unSortedList[swap] < unSortedList[child])
                {
                    swap = child;
                }
                if (child + 1 < length && unSortedList[swap] < unSortedList[child + 1])
                {
                    swap = child + 1;
                }
                if (swap == root)
                {
                    return;
                }
                SortHelpers.Swap(unSortedList, root, swap);
                root = swap;
            }
        }
    }
}