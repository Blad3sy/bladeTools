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

class Linked_List():
    def __init__(self):
        self.list = []
        self.currentPointer = 0

    def empty(self):
        if self.list: return False
        else: return True
    
    def size(self):
        return len(self.list)

    def nextNode(self):
        toReturn = self.list[self.currentPointer][0]
        self.currentPointer = self.list[self.currentPointer][1]
        return toReturn
    
    def addNode(self, value, pointer = None):
        self.list.append([value, pointer])
    
    def deleteNode(self, index):
        for i in range(0, len(self.list)):
            if self.list[i][1] == index:
                self.list[i][1] = self.list[index][1]
        
        del self.list[index]
    
    def clear(self):
        self.list = []