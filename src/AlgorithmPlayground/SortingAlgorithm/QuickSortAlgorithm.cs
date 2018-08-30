using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPlayground.SortingAlgorithm
{
    public class QuickSortAlgorithm : ISortAlgorithm
    {
        public void Sort(int[] arr)
        {
            Quicksort(arr, 0, arr.Length - 1);
        }

        private void Quicksort(int[] numbers, int left, int right)
        {
            int i = left, j = right;
            int pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i] < pivot)
                {
                    i++;
                }

                while (numbers[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;

                    i++;
                    j--;
                }

            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(numbers, left, j);
            }

            if (i < right)
            {
                Quicksort(numbers, i, right);
            }
        }
        /*
         * var quickSort = function(a){
  if (a.length == 0) return [];
  var left = [], right = [], pivot = a[0];
  for (var i = 1; i < a.length; i++) {
    a[i] < pivot ? left.push(a[i]) : right.push(a[i]);
  }
  return quickSort(left).concat(pivot, quickSort(right));
}
         */
    }
}