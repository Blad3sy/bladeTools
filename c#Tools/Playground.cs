using System;
using System.Runtime.CompilerServices;
using System.Threading;
using sorting_algorithms;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            int[] arr = new int[60];

            Random rnd = new Random();
            for (int i = 0; i < 60; i++) {
                arr[i] = rnd.Next(0, 60);
            }

            arr = Sorting_Algorithms.InsertionSort(arr);

            foreach (int item in arr) {
                Console.Write($"{item}, ");
            }
        }
    }
}