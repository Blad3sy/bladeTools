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

        public static int[] MergeSort(int[] array) {
            int[][] completeArray = new int[array.Length][];

            for (int i = 0; i < array.Length; i++) {
              completeArray[i] = new int[] {array[i]};  
            }

            while (completeArray.Length > 1) {
                for (int i = 0; i < completeArray.Length; i += 2) {
                    if (i+1 < completeArray.Length) {
                        completeArray[i] = Merge(completeArray[i], completeArray[i+1]);
                        completeArray[i+1] = Array.Empty<int>();
                    }
                }

                completeArray = ArrayClean(completeArray);
            }

            return completeArray[0];
        }

        private static int[] Merge(int[] array1, int[] array2) {
            int[] completeArray = new int[array1.Length + array2.Length];
            int array1Pointer = 0;
            int array2Pointer = 0;

            int iterator = 0;

            while (array1Pointer < array1.Length && array2Pointer < array2.Length) {
                if (array1[array1Pointer] < array2[array2Pointer]) {
                    completeArray[iterator] = array1[array1Pointer];
                    array1Pointer++;
                }
                else {
                    completeArray[iterator] = array2[array2Pointer];
                    array2Pointer++;
                }

                iterator++;
            }

            if (array1Pointer >= array1.Length) {
                for (int i = iterator; i < completeArray.Length; i++) {
                    completeArray[i] = array2[array2Pointer];
                    array2Pointer++;
                }
            }
            else {
                for (int i = iterator; i < completeArray.Length; i++) {
                    completeArray[i] = array1[array1Pointer];
                    array1Pointer++;
                }
            }

            return completeArray;
        }

        private static int[][] ArrayClean(int[][] array) {
            int adder = array.Length % 2;
            int[][] newray = new int[array.Length / 2 + adder][];

            for (int i = 0; i < newray.Length; i++) {
                newray[i] = array[i*2];
            }

            if (adder == 1) {
                newray[^1] = array[^1];
            }
            return newray;
        }
    }
}