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

class Static_Stack():
    def __init__(self):
        self.list = []
        self.arraySize = 10
        self.topPointer = 0
    
    def empty(self):
        if self.list: return False
        else: return True
    
    def size(self):
        return len(self.list)
    
    def push(self, toInsert):
        if self.size < self.arraySize:
            self.list.append(toInsert)
            self.topPointer 
        else: print("The stack is full!")
    
    def pop(self):
        if self.list:
            toReturn = self.list(self.topPointer)
            self.topPointer -= 1
            return toReturn
        else: print("The stack is empty!")
    
    def setSize(self, newSize):
        self.arraySize = newSize
    
    def clear(self):
        self.list = []

class Dynamic_Stack():
    def __init__(self):
        self.list = []
    
    def empty(self):
        if self.list: return False
        else: return True
    
    def size(self):
        return len(self.list)
    
    def push(self, toInsert):
        self.list.insert(0, toInsert)
    
    def pop(self):
        if self.list:
            return self.list.pop(0)
        else: print("The stack is empty!")
    
    def clear(self):
        self.list = []

class Static_Queue():
    def __init__(self):
        self.list = []
        self.arraySize = 10
        self.startPointer = 0
        self.endPointer = 0
    
    def empty(self):
        if self.list: return False
        else: return True
    
    def size(self):
        return len(self.list)
    
    def enqueue(self, toEnqueue):
        if self.size() < self.arraySize:
            self.list.append(toEnqueue)
            self.endPointer += 1
            if self.endPointer == 10: self.endPointer = 0
        else: print("The queue is full!")
    
    def dequeue(self):
        if self.list:
            toReturn = self.list.pop(self.startPointer)
            self.startPointer += 1
            if self.startPointer == 10: self.startPointer = 0

            return toReturn
        else: print("The queue is empty!")
    
    def setSize(self, newSize):
        self.arraySize = newSize

    def clear(self):
        self.list = []

class Dynamic_Queue():
    def __init__(self):
        self.list = []
    
    def empty(self):
        if self.list: return False
        else: return True
    
    def size(self):
        return len(self.list)
    
    def enqueue(self, toEnqueue):
        self.list.insert(0, toEnqueue)
    
    def dequeue(self):
        if self.list:
            return self.list.pop(-1)
        else: print("The queue is empty!")
    
    def clear(self):
        self.list = []

