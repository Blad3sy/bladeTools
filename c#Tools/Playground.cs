using System;
using sorting_algorithms;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            int[] arr = new int[] { 10, 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            arr = Sorting_Algorithms.BubbleSort(arr);

            foreach (int item in arr) {
                Console.Write($"{item}, ");
            }
        }
    }
}