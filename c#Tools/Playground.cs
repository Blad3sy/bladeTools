using System;
using stacks;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            int?[] starter = new int?[] {1, 2, 3, 4, 5};
            int?[] pushingArray = new int?[] {6, 7, 8, 9};

            DynamicStack testStack = new(starter);
            testStack.Push(pushingArray);

            testStack.Display();

            int?[]? arr = testStack.Peek(3);

            foreach (var item in arr) {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            arr = testStack.Pop(4);

            foreach (var item in arr) {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            testStack.Display();
        }
    }
}