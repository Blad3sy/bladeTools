using System;
using System.Runtime.CompilerServices;
using sorting_algorithms;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            int[] arr = new int[59];

            Random rnd = new Random();
            for (int i = 0; i < 59; i++) {
                arr[i] = rnd.Next(0, 60);
            }

            arr = Sorting_Algorithms.MergeSort(arr);

            foreach (int item in arr) {
                Console.Write($"{item}, ");
            }
        }
    }
}