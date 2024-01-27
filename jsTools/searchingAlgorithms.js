function linearSearch(array, toSearch) {
    for (i = 0; i < array.length; i++) {
        if (array[i] == toSearch) {
            return true;
        }
    }
    return false;
}

function binarySearch(array, toSearch) {
    leftPointer = 0;
    rightPointer = array.length - 1;

    while (rightPointer >= leftPointer) {
        midPointer = Math.floor((leftPointer + rightPointer) / 2);

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

arr = [1, 2, 5, 7, 12, 64, 560, 1245, 124526];

console.log(binarySearch(arr, 1));
console.log(binarySearch(arr, 3));
console.log(binarySearch(arr, 12));
console.log(binarySearch(arr, 124526));