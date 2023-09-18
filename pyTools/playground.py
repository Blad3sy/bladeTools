import data_structures
from random import randint

undir = data_structures.Undirected_Graph()
undir2 = data_structures.Undirected_Graph(True)

undir.addNode("A", "DATA")
undir.addNode("B", "DATA", ["A", "C"])

undir2.addNode("A", "DATA")
undir2.addNode("B", "DATA", ["A", "C"])

print("DONE")