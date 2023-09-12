import pyTools
from random import randint

array = []

for i in range(0, 10000):
    array.append(randint(0, 10000))

print("NUM GEN 1")

pyTools.bubble_Sort(array)
print("BUBBLE DONE")

array = []

for i in range(0, 10000):
    array.append(randint(0, 10000))

print("NUM GEN 2")

pyTools.insertion_Sort(array)
print("INSERT DONE")

array = []

for i in range(0, 10000):
    array.append(randint(0, 10000))

print("NUM GEN 3")

print(pyTools.merge_Sort(array))
print("merge DONE")