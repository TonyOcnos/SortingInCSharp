﻿using System;
using System.Diagnostics;

namespace arrayShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            ArraySorted array1 = new ArraySorted(100);
            Stopwatch sw1 = new Stopwatch();
            TimeSpan timeSpan;  

            array1.create();
            array1.shuffleArray();
            array1.showArray();

            sw1.Start();
            SortingType.bubbleSorting(array1.createdArray);
            sw1.Stop();

            array1.showArray();

            timeSpan = sw1.Elapsed;
            Console.WriteLine("Sorting: Bubble Sort");
            Console.WriteLine($"Attemps: {SortingType.sortingAttemps}");
            Console.WriteLine($"Swaps: {SortingType.itemSwaps}");
            Console.WriteLine($"Time elapsed: {timeSpan.TotalMilliseconds} ms");
        }
    }
}