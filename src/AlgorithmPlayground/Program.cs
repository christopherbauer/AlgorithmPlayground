using System;
using System.Linq;
using AlgorithmPlayground.Services;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace AlgorithmPlayground
{
    public class BenchmarkAlgorithms
    {
        public BenchmarkAlgorithms()
        {
            UnsortedArray = new int[0];
        }

        //Use seeded random generator so the numbers are consistant
        private static Random Random => new Random(95625653);

        public int[] UnsortedArray;
        public int[] LocalArray;

        [Params(100, 1000, 10000)] public int ArraySize;

        [GlobalSetup]
        public void Setup()
        {
            UnsortedArray = Enumerable.Range(0, ArraySize).Select(i => Random.Next(0, 999999)).ToArray();
        }

        [IterationSetup]
        public void Iteration()
        {
            LocalArray = new int[UnsortedArray.Length];
            UnsortedArray.CopyTo(LocalArray,0);
        }

        [Benchmark]
        public int[] BinarySort()
        {
            var algorithm = SortAlgorithmFactory.Create(SortingAlgorithmOption.BinarySearchTreeSort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] InsertionSort()
        {
            var algorithm = SortAlgorithmFactory.Create(SortingAlgorithmOption.InsertionSort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] BubbleSort()
        {
            var algorithm = SortAlgorithmFactory.Create(SortingAlgorithmOption.Bubblesort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] HeapSort()
        {
            var algorithm = SortAlgorithmFactory.Create(SortingAlgorithmOption.Heapsort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] QuickSort()
        {
            var algorithm = SortAlgorithmFactory.Create(SortingAlgorithmOption.Quicksort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] MergeSort()
        {
            var algorithm = SortAlgorithmFactory.Create(SortingAlgorithmOption.Mergesort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }

        [Benchmark]
        public int[] LinqOrderBy()
        {
            return LocalArray.OrderBy(i => i).ToArray();
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchmarkAlgorithms>();
        }
    }
}
