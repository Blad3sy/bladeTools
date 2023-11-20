using System;
using searching_algorithms;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            Console.WriteLine(Searching_Algorithms.BinarySearch(arr, 15));
            Console.WriteLine(Searching_Algorithms.LinearSearch(arr, 15));
        }
    }
}