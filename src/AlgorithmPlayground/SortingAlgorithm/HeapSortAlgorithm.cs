namespace AlgorithmPlayground.SortingAlgorithm
{
    public class HeapSortAlgorithm : ISortAlgorithm
    {
        private int _heapSize;

        public void Sort(int[] arr)
        {
            BuildHeap(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                SortHelpers.Swap(arr, 0, i);
                _heapSize--;
                Heapify(arr, 0);
            }
        }

        private void BuildHeap(int[] arr)
        {
            _heapSize = arr.Length - 1;
            for (int i = _heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }
        private void Heapify(int[] arr, int index)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= _heapSize && arr[left] > arr[index])
            {
                largest = left;
            }

            if (right <= _heapSize && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                SortHelpers.Swap(arr, index, largest);
                Heapify(arr, largest);
            }
        }
    }
}