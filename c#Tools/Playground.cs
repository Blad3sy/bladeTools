using System;
using data_structures;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            int[] starter = new int[] {1, 2, 3, 4, 5};
            int[] pushingArray = new int[] {6, 7, 8, 9};

            StaticStack testStack = new(10, starter);
            testStack.Push(pushingArray);

            testStack.Display();

            Console.WriteLine(testStack.Peek());
            Console.WriteLine(testStack.Pop());

            testStack.Display();
        }
    }
}