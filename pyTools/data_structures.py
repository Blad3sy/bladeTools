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
        if self.size() < self.arraySize:
            self.list.append(toInsert)
            self.topPointer += 1
        else: print("The stack is full!")
    
    def pop(self):
        if self.list:
            toReturn = self.list.pop(self.topPointer)
            self.topPointer -= 1
            return toReturn
        else: print("The stack is empty!")
    
    def peek(self):
        if self.list:
            return self.list[self.topPointer]
        else: print("The stack is empty!")
    
    def setSize(self, newSize):
        try: self.arraySize = int(newSize)
        except ValueError: print("The size was not an integer!")
    
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
    
    def peek(self):
        if self.list:
            return self.list[0]
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
            if self.endPointer == self.arraySize: self.endPointer = 0
        else: print("The queue is full!")
    
    def dequeue(self):
        if self.list:
            toReturn = self.list[self.startPointer]
            self.startPointer += 1
            if self.startPointer == self.arraySize: self.startPointer = 0
            return toReturn
        else: print("The queue is empty!")
    
    def setSize(self, newSize):
        try: self.arraySize = int(newSize)
        except ValueError: print("The size was not an integer!")

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
        self.dict = {}
        self.currentPointer = 0

    def empty(self):
        if self.dict: return False
        else: return True
    
    def size(self):
        return len(self.dict)

    def resetPointer(self):
        self.currentPointer = 0

    def nextNode(self):
        try:
            toReturn = self.dict[self.currentPointer][0]
            self.currentPointer = self.dict[self.currentPointer][1]
            return toReturn
        except KeyError: print("No entry exists for this pointer!")
    
    def addNode(self, value, pointer = None):
        if self.dict[pointer] or pointer == None:
            self.dict[self.size()] = [value, pointer]
        else: print("Your specified pointer has no destination!")
    
    def changeValue(self, newValue, index):
        try: self.dict[index][0] = newValue
        except KeyError: print("No entry exists for this index!")
    
    def changePointer(self, newPointer, index):
        try: self.dict[index][1] = newPointer
        except KeyError: print("No entry exists for this index!")
    
    def deleteNode(self, index):
        if self.dict:
            try: 
                for i in range(0, len(self.dict)):
                    if self.dict[i][1] == index:
                        self.dict[i][1] = self.dict[index][1]
                del self.dict[index]
            except KeyError: print("No entry exists for this index!")
        else: print("The linked list is empty!")
    
    def clear(self):
        self.dict = {}

class Directed_Graph():
    def __init__(self):
        self.dict = {}
    
    def empty(self):
        if self.dict: return False
        else: return True
    
    def size(self):
        return len(self.dict)
    
    def addNode(self, key, data, edges = None):
        if type(edges) == list or edges == None:
            self.dict[key] = {"edges" : edges, "data" : data}
        else: print("The edges were not in the form of a list!")
    
    def deleteNode(self, key):
        if self.dict: 
            try: del self.dict[key]
            except KeyError: print("No entry exists for this key!")
        else: print("The graph is empty!")
    
    def viewEdges(self, key):
        if self.dict: 
            try: return self.dict[key]["edges"]
            except KeyError: print("No entry exists for this key!")
        else: print("The graph is empty!")

    def viewData(self, key):
        if self.dict: 
            try: return self.dict[key]["data"]
            except KeyError: print("No entry exists for this key!")
        else: print("The graph is empty!")
    
    def changeEdges(self, key, edges):
        if type(edges) == list:
            self.dict[key]["edges"] = edges
        else: print("The edges were not in the form of a list!")
    
    def changeData(self, key, data):
        self.dict[key]["data"] = data
    
    def clear(self):
        self.dict = {}

class Undirected_Graph(Directed_Graph):
    def __init__(self, ignoreInvalidEdges = False):
        super().__init__()
        self.ignoreInvalidEdges = ignoreInvalidEdges

    def addNode(self, key, data, edges = []):
        if type(edges) == list:
            self.dict[key] = {"edges" : edges, "data" : data}
        else: print("The edges were not in the form of a list!")

        keys = self.dict.keys()

        for i in range(0, len(edges)):
            if edges[i] in keys: self.dict[key]["edges"].append(edges[i])
            else: 
                if not self.ignoreInvalidEdges: print("A node you referenced in your edges does not exist!")

    def deleteNode(self, key):
        if self.dict: 
            try:
                keys = self.dict.keys() 
                for akey in keys:
                    for i in len(self.dict[akey]["edges"]):
                        if self.dict[akey]["edges"][i] in self.dict[key]["edges"]:
                            del self.dict[akey]["edges"][i]            
                del self.dict[key]                 
            except KeyError: print("A key was used for an invalid node!")
        else: print("The graph is empty!")
    
    def updateEdges(self):

        # when adding graph traversal PLEASE FOR THE LOVE OF GOD check this function

        keys = self.dict.keys()

        for key in keys:
            for item in self.dict[key]["edges"]:
                try: self.dict[item]["edges"].append(key)
                except KeyError: 
                    if not self.ignoreInvalidEdges: print(f"A node you referenced in the edges of value {key} does not exist!")
    
    def changeEdges(self, key, edges):
        if type(edges) == list:
            self.dict[key]["edges"] = edges
        else: print("The edges were not in the form of a list!")
        self.updateEdges()

class Weighted_Graph(Directed_Graph):
    def __init__():
        super().__init__()
    
    # The change here is rather miniscule - I have simply changed the intended data type of the edges from a LIST to a DICTIONARY
    # I have done this with the intended purpose of edge weight being input in the format of {"Edge": Edge weight, etc...}
    # Future code designed traverse Graphs will include algorithms utilizing the weight here, my current focus is on creating the data structure

    def addNode(self, key, data, edges = None):
        if type(edges) == dict or edges == None:
            self.dict[key] = {"edges" : edges, "data" : data}
        else: print("The edges were not in the form of a dictionary!")
    
    def changeEdges(self, key, edges):
        if type(edges) == dict:
            self.dict[key]["edges"] = edges
        else: print("The edges were not in the form of a dictionary!")
    
class Weighted_Undirected_Graph(Undirected_Graph):
    def __init__():
        super().__init__()
    
    # My notes on Weighted_Graph (Lines 249-251) also apply here. This code is different to Unidirected_Graph in the same way that Weighted_Graph is different to Directed_Graph

    def addNode(self, key, data, edges = []):
        if type(edges) == dict:
            self.dict[key] = {"edges" : edges, "data" : data}
        else: print("The edges were not in the form of a dictionary!")

        keys = self.dict.keys()
        edgeKeys = edges.keys()

        for eKey in edgeKeys:
            if edges[eKey] in keys: self.dict[key]["edges"][eKey] = edges[eKey]
            else: 
                if not self.ignoreInvalidEdges: print("A node you referenced in your edges does not exist!")
    
    def updateEdges(self):

        # When I get around the adding the code to traverse the graph I for sure am gonna check this shit
        # because i'm accounting for functionality I haven't added yet and it's probably broken, ah well

        # i'll probably reprogram everything in this function because this entire function sucks so bad

        keys = self.dict.keys()

        for key in keys:
            edgeKeys = self.dict[key]["edges"].keys()
            for eKey in edgeKeys:
                if eKey in keys: self.dict[eKey]["edges"][key] = self.dict[eKey]["edges"]["edgeWeight"]
                else: 
                    if not self.ignoreInvalidEdges: print("A node you referenced in your edges does not exist!")

    def changeEdges(self, key, edges):
        if type(edges) == dict:
            self.dict[key]["edges"] = edges
        else: print("The edges were not in the form of a dictionary!")
        self.updateEdges()