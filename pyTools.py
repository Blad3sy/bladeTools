# Search algorithms

def linear_Search(array, toSearch):
    for i in range(0, len(array)):
        if toSearch == array[i]:
            return True
        
    return False

def binary_Search(array, toSearch):
    left = 0
    right = len(array) - 1
    
    while right >= left:
        centre = (left + right) // 2

        if array[centre] == toSearch:
            return True

        elif array[centre] < toSearch:
            left = centre + 1

        else:
            right = centre - 1
    
    return False

# Sort algorithms

def bubble_Sort(array):
    change = True

    while change == True:
        change = False
        
        for i in range(0, len(array) - 1):
            bubbleLeft = array[i]

            if bubbleLeft > array[i+1]:
                array[i] = array[i+1]
                array[i+1] = bubbleLeft
                change = True
    
    return array

def insertion_Sort(array):
    pointer = 1
    positioner = 0

    while pointer <= len(array) - 1:       
        for i in range(0, pointer):
            if array[pointer] > array[i] and i+1 > positioner:
                positioner = i+1
            elif array[pointer] < array[i] and i < positioner:
                positioner = i

        array.insert(positioner, array.pop(pointer))
        pointer += 1
    
    return array

def merge_Sort(array):
    pass

# Data structures

class Stack():
    def __init__(self):
        self.list = []
    
    def empty(self):
        if self.list:
            return False
        else:
            return True
    
    def size(self):
        return len(self.list)
    
    def peek(self):
        return self.list[0]
    
    def push(self, toInsert):
        self.list.insert(0, toInsert)
    
    def pop(self):
        del self.list[0]