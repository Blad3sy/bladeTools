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
    mainArray = []
    auxArray = []
    subArray = []

    for item in array:
        mainArray.append([item])
    
    while len(mainArray) != 1:
        for i in range(0, len(mainArray) - 1, 2):
            subcounter1 = 0
            subcounter2 = 0

            for t in range(0, len(mainArray[0]) * 2):

                if subcounter1 >= len(mainArray[i]):
                    for z in range(subcounter2, len(mainArray[i+1])):
                        subArray.append(mainArray[i+1][z])
                    break

                elif subcounter2 >= len(mainArray[i+1]):
                    for z in range(subcounter1, len(mainArray[i])):
                        subArray.append(mainArray[i][z])
                    break
              
                if mainArray[i][subcounter1] < mainArray[i+1][subcounter2]:
                    subArray.append(mainArray[i][subcounter1])
                    subcounter1 += 1
                else:
                    subArray.append(mainArray[i+1][subcounter2])
                    subcounter2 += 1
            
            auxArray.append(subArray)
            subArray = []
                
        if len(mainArray) % 2:
            auxArray.append(mainArray[len(mainArray) - 1])
    
        mainArray = auxArray
        auxArray = []
    
    return mainArray[0]

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