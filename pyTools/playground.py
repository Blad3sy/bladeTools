import data_structures
from random import randint

linkedList = data_structures.Linked_List()

linkedList.addNode(0, 1)
linkedList.addNode(1, 2)
linkedList.addNode(2, 3)
linkedList.addNode(3, 4)
linkedList.addNode(4, 5)
linkedList.addNode(5)

print(linkedList.list)

linkedList.deleteNode(2)

print(linkedList.list)