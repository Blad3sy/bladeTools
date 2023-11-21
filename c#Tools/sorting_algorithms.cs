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

        public static int[] InsertionSort(int[] array) {
            int nextItemPointer = 0;
            int positioner;
            int buffer;

            do {              
                positioner = 0;
                buffer = array[nextItemPointer];

                for (int i = 0; i < nextItemPointer; i++) {
                    positioner = (buffer > array[i]) ? positioner + 1 : positioner;
                }

                array = Bump(array, positioner, nextItemPointer);
                array[positioner] = buffer;

                nextItemPointer++;

            } while (nextItemPointer < array.Length);

            return array;
        }

        private static int[] Bump(int[] array, int startIndex, int endIndex) {
            int buffer1 = array[startIndex];
            int buffer2;

            for (int i = startIndex; i <= endIndex; i++) {
                buffer2 = array[i];
                array[i] = buffer1;
                buffer1 = buffer2;
            }

            return array;
        }
    }
}