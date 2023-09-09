import pyTools
from random import randint

array = [9, 10, 2, 3, 8, 4, 7, 6, 5, 10, 1, 4]

print(pyTools.bubble_Sort(array))

array = [9, 10, 2, 3, 8, 4, 7, 6, 5, 10, 1, 4]
print()
print(pyTools.insertion_Sort(array))

stack = pyTools.Stack()
for i in range(0, 5):
    stack.push(randint(0, 100))

print(stack.list)

for i in range(0, 5):
    print(stack.peek())
    stack.pop()

print(stack.empty())