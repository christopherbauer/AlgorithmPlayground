using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            var algorithm = SortAlgorithm.Create(SortAlgorithm.SortingAlgorithm.BinaryTreeSort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] InsertionSort()
        {
            var algorithm = SortAlgorithm.Create(SortAlgorithm.SortingAlgorithm.InsertionSort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] BubbleSort()
        {
            var algorithm = SortAlgorithm.Create(SortAlgorithm.SortingAlgorithm.Bubblesort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] HeapSort()
        {
            var algorithm = SortAlgorithm.Create(SortAlgorithm.SortingAlgorithm.Heapsort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] QuickSort()
        {
            var algorithm = SortAlgorithm.Create(SortAlgorithm.SortingAlgorithm.Quicksort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
        [Benchmark]
        public int[] MergeSort()
        {
            var algorithm = SortAlgorithm.Create(SortAlgorithm.SortingAlgorithm.Mergesort);
            algorithm.Sort(LocalArray);
            return LocalArray;
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchmarkAlgorithms>();
        }

        private static void TimeSort(List<int> unSortedList, ISortAlgorithm algorithm, int iterations)
        {
            var stopWatch = new Stopwatch();
            var unused = 0;
            var progress = iterations/100;
            int[] values = { 0 };
            for (var i = 0; i < iterations; i++)
            {
                values = unSortedList.ToArray();
                stopWatch.Start();
                algorithm.Sort(values);
                stopWatch.Stop();
                unused += values.Length;

                if (i%progress == 0)
                {
                    Console.WriteLine("{0}: {1}", i / progress, stopWatch.ElapsedMilliseconds);
                }
            }

            Console.WriteLine(unused);
            Console.WriteLine(string.Join(",", values));
            Console.WriteLine("{0}: {1}", algorithm.GetType().Name, stopWatch.ElapsedMilliseconds / (float)iterations);
        }
    }
}
