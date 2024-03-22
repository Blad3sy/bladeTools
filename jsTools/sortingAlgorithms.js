function bubbleSort(array) {
    let swap = true;
    let offset = 0;
    let left;

    while (swap) {
        swap = false;
        offset++;

        for (let i = 0; i < array.length - offset; i++) {
            left = array[i];

            if (left > array[i+1]) {
                array[i] = array[i+1];
                array[i+1] = left;
                swap = true;
            }
        }
    }

    return array;
}

function insertionSort(array) {
    let pointer;
    let buffer;

    for (let i = 1; i < array.length; i++) {
        pointer = i;

        while (pointer > 0 && array[pointer] < array[pointer - 1]) {
            buffer = array[pointer];
            array[pointer] = array[pointer - 1];
            array[pointer - 1] = buffer;
            pointer--;
        }
    }

    return array;
}

let arr = [124, 15, 7241, 712, 3, 88, 12, 789, 123214, 5];
let arr2 = insertionSort(arr);

for (let i = 0; i < arr2.length; i++) {
    console.log(arr2[i]);
}