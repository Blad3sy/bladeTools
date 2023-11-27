using System;
using queues;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            int[]? starter = new int[] {1, 2, 3, 4, 5};
            int[] pushingArray = new int[] {8, 9, 10};
            int[] pushingArray2 = new int[] {8, 9};

            StaticQueue testQueue = new(6, starter);

            testQueue.Dequeue(10);
            testQueue.Display();

            testQueue.Dequeue(2);
            testQueue.Dequeue(3);
            testQueue.Display();

            testQueue.Enqueue(pushingArray);
            testQueue.Display();

            testQueue.Enqueue(pushingArray2);
            testQueue.Display();

            Console.WriteLine(testQueue.Dequeue());
            testQueue.Display();

            testQueue.Enqueue(8);
            testQueue.Display();

            testQueue.Dequeue();
            testQueue.Dequeue();
            testQueue.Dequeue();
        }
    }
}