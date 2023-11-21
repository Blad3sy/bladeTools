using System.Collections;

namespace sorting_algorithms {
    class Sorting_Algorithms {
        public static int[] BubbleSort(int[] array) {
            bool swapped;
            int buffer;

            do {
                swapped = false;

                for (int i = 0; i < array.Length - 1; i++) {
                    if (array[i] > array[i+1]) {
                        buffer = array[i];
                        array[i] = array[i+1];
                        array[i+1] = buffer;
                        swapped = true;
                    }
                }
            } while (swapped);

            return array;
        }
    }
}