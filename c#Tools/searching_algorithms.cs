namespace searching_algorithms {
    class Searching_Algorithms {
        public static bool LinearSearch(int[] array, int toSearch) {
            foreach (int item in array) {
                if (item == toSearch) {
                    return true;
                }
            }

            return false;
        }

        public static bool BinarySearch(int[] array, int toSearch) {
            int leftPointer = 0;
            int rightPointer = array.Length - 1;
            int midPointer;

            while (rightPointer >= leftPointer) {
                midPointer = (leftPointer + rightPointer) / 2;

                if (array[midPointer] == toSearch) {
                    return true;
                }
                else if (array[midPointer] < toSearch) {
                    leftPointer = midPointer + 1;
                }
                else {
                    rightPointer = midPointer - 1;
                }
            }

            return false;
        }
    }
}