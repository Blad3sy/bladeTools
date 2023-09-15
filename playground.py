import pyTools

queue = pyTools.Queue()

for i in range(0, 11):
    queue.enqueue(i)

print(queue.list)
print(queue.dequeue())
print(queue.list)