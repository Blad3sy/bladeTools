using System;
using queues;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            int[]? starter = new int[] {1, 2, 3, 4, 5};
            // int[] pushingArray = new int[] {6, 7, 8, 9};

            StaticQueue testQueue = new(6);

            testQueue.Display();

            testQueue.Enqueue(6);
            testQueue.Enqueue(7);
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