import sorting_algorithms
from timing import Timer
from random import randint

def genArray(length, lowerbound, upperbound):
    arr = []

    for i in range(length):
        arr.append(randint(lowerbound, upperbound))
    
    return arr

print("Sorting 15000 numbers between 0 and 1000000...")
timer = Timer(True)

sorting_algorithms.bubble_Sort(genArray(15000, 0, 1000000))
print("Bubble sort - ", end = "")
timer.lapTimer()
sorting_algorithms.insertion_Sort(genArray(15000, 0, 1000000))
print("Insertion sort - ", end = "")
timer.lapTimer()
sorting_algorithms.merge_Sort(genArray(15000, 0, 1000000))
print("Merge sort - ", end = "")
timer.lapTimer()
sorted(genArray(15000, 0, 1000000))
print("Inbuilt sort - ", end = "")
timer.finishTimer()