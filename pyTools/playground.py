import data_structures
from random import randint

linkedList = data_structures.Linked_List()

linkedList.addNode(0, 1)
linkedList.addNode(1, 2)
linkedList.addNode(2, 3)
linkedList.addNode(3, 4)
linkedList.addNode(4, 5)
linkedList.addNode(5)

print(linkedList.dict)

for i in range(0, linkedList.size()):
    print(linkedList.nextNode())

linkedList.deleteNode(2)
linkedList.resetPointer()

print(linkedList.dict)

for i in range(0, linkedList.size()):
    print(linkedList.nextNode())

test = data_structures.Static_Queue()
test.setSize("A")