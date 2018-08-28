using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPlayground.SortingAlgorithm
{
    public class QuickSortAlgorithm : ISortAlgorithm
    {
        public void Sort(int[] unSortedList)
        {
            QuickSort(unSortedList, 0, unSortedList.Length - 1);
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int pivot = arr[(left + right) / 2];
            while (i < j)
            {
                while (arr[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (arr[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    SortHelpers.Swap(arr, i, j);

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(arr, left, j);
            }
            if (i < right)
            {
                QuickSort(arr, i, right);
            }
        }

//This implementation performs 2x-3x worse then mergesort...        
//        private static void QuickSort(int[] arr, int l, int r)
//        {
//            if (l >= r)
//            {
//                return;
//            }
//
//            int cnt = l;
//            for (int i = l; i <= r; i++)
//            {
//                if (arr[i] <= arr[r])
//                {
//                    SortHelpers.Swap(arr, cnt, i);
//
//                    cnt++;
//                }
//            }
//
//            QuickSort(arr, l, cnt - 2);
//            QuickSort(arr, cnt, r);
//        }
    }
}