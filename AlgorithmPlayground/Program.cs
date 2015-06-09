using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgorithmPlayground
{
    class Program
    {


        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: {0} [algorithm name]", Environment.CommandLine);
                return;
            }

            
            var name = args[0];
            var algorithm = SortAlgorithm.Create(name);

            var unSortedList = Enumerable.Range(0, 1000).OrderBy(i => Guid.NewGuid()).ToList();
            for (var i = 0; i < 1000; i++)
            {
                var values = unSortedList.ToArray();
                algorithm.Sort(values);
            }
            
            TimeSort(unSortedList, algorithm, 100000);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
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
