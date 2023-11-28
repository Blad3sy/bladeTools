using System;
using queues;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            int?[]? starter = new int?[] {1, 2, 3, 4, 5};
            int?[] pushingArray = new int?[] {8, 9, 10};
            int?[] pushingArray2 = new int?[] {8, 9};

            DynamicQueue testQueue = new(starter);

            testQueue.Dequeue(10); // Attempts to take more elements than present (ER)
            testQueue.Display();

            Console.WriteLine(testQueue.Dequeue()); // Takes 1 element
            testQueue.Dequeue(3); // Takes 3 elements
            testQueue.Display();

            testQueue.Enqueue(pushingArray); // Adds 3 elements
            testQueue.Display();

            testQueue.Enqueue(pushingArray2); // Adds 2 elements
            testQueue.Display();

            Console.WriteLine(testQueue.Dequeue()); // Takes 1 Element
            testQueue.Display();

            testQueue.Enqueue(8); // Adds 1 element
            testQueue.Display();
        }
    }
}