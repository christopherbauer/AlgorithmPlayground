    namespace AlgorithmPlayground
{
    public class BubbleSortAlgorithm : ISortAlgorithm
    {
        public void Sort(int[] unSortedList)
        {
            var swap = true;
            while (swap)
            {
                swap = false;

                for (var i = 0; i < unSortedList.Length - 1; i++)
                {
                    if (unSortedList[i] > unSortedList[i + 1])
                    {
                        Swap(unSortedList, i, i + 1);
                        swap = true;
                    }
                }
            }
        }

        private void Swap(int[] unSortedList, int a, int b)
        {
            var tempA = unSortedList[a];
            unSortedList[a] = unSortedList[b];
            unSortedList[b] = tempA;
        }
    }
}