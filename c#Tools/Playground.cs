using System;
using linked_list;

namespace Playground {
    class Playground {
        static void Main(string[] args) {
            // TESTING REGIME

            /*
            - starter ✓
            - !starter ✓

            - AddNode (key = null, pointer = null) ✓
            - AddNode (key = !null, pointer = null) ✓
            - AddNode (key = null, pointer = !null) ✓
            - AddNode (key = !null, pointer = !null) ✓

            - AddNode (keys = null, pointers = null) ✓
            - AddNode (keys = !null, pointers = null) ✓
            - AddNode (keys = null, pointers = !null) ✓
            - AddNode (keys = !null, pointers = !null) ✓
            - AddNode (values.Length != keys.Length) ✓
            - AddNode (values.Length != pointers.Length) ✓
            - AddNode (keys.Length != pointers.Length) ✓

            - DeleteNode (key !exists) ✓
            - DeleteNode (key exists) ✓

            - DeleteNode (allkeys !exist) ✓
            - DeleteNode (somekeys !exist) ✓
            - DeleteNode (allkeys exist) ✓

            - NextNode (to null node) ✓
            - NextNode (to null node, displayValue = true) ✓
            - NextNode (!to null node) ✓
            - NextNode (!to null node, displayValue = true) ✓

            - SetNodePointer (key !exists) ✓
            - SetNodePointer (key exists) ✓

            - SetNodePointer (allkeys !exist) ✓
            - SetNodePointer (somekeys !exist) ✓
            - SetNodePointer (allkeys exist, keys.Length != pointers.Length) ✓
            - SetNodePointer (allkeys exist, keys.Length = pointers.Length) ✓

            - ResetCurrentNode ✓
            - GetCurrentNodeValue ✓

            */

            Dictionary<int, int?[]> testStarter = new() {
                {0, new int?[] {1, 1}},
                {1, new int?[] {1, 2}},
                {2, new int?[] {1, 3}},
                {3, new int?[] {1, null}},
            };

            LinkedList testLL1 = new(testStarter);
            LinkedList testLL2 = new();

            // testLL1.Display();
            // Console.WriteLine(testLL1.Length);
            // testLL2.Display();
            // Console.WriteLine(testLL2.Length);

            testLL2.AddNode(1);
            testLL2.AddNode(1, key: 2);
            testLL2.AddNode(1, pointer: 2);
            testLL2.AddNode(1, key: 4, pointer: 20);
            // testLL2.Display();

            int?[] keys = new int?[] {0, 1, 2, 3, 4};
            int?[] keys2 = new int?[] {5, 6, 7, 8, 9};
            int[] values = new int[] {1, 2, 3, 4, 5};
            int?[] pointers = new int?[] {1, 2, 3, 4, 0};

            testLL2.Clear();
            testLL2.ResetDefaultKey();

            testLL2.AddNode(values, keys: keys);
            // testLL2.Display();
            testLL2.AddNode(values, keys: keys2, pointers: pointers);
            // testLL2.Display();
            testLL2.AddNode(values);
            // testLL2.Display();
            testLL2.AddNode(values, pointers: pointers);
            // testLL2.Display();

            /* testLL2.DeleteNode(32);
            testLL2.Display();
            testLL2.DeleteNode(1);
            testLL2.Display();

            int[] nonrealKeysToDelete = new int[] {23, 45, 124, 32};
            int[] somerealKeysToDelete = new int[] {1, 2, 23, 53, 87};
            int[] allrealKeysToDelete = new int[] {1, 2, 3, 4, 5};

            testLL2.Display();
            testLL2.DeleteNode(nonrealKeysToDelete);
            testLL2.Display();
            testLL2.DeleteNode(somerealKeysToDelete);
            testLL2.Display();
            testLL2.DeleteNode(allrealKeysToDelete);
            testLL2.Display(); */

            testLL2.Clear();
            testLL2.ResetDefaultKey();

            pointers = new int?[] {1, 2, null, 4, 0};
            testLL2.AddNode(values, pointers: pointers);
            /* testLL2.Display();

            Console.WriteLine(testLL2.CurrentNode);
            testLL2.NextNode();
            Console.WriteLine(testLL2.CurrentNode);s
            testLL2.NextNode(true);
            Console.WriteLine(testLL2.CurrentNode);
            testLL2.NextNode();
            Console.WriteLine(testLL2.CurrentNode);
            testLL2.NextNode(true);
            Console.WriteLine(testLL2.CurrentNode);
            Console.WriteLine(testLL2.GetCurrentNodeValue());

            testLL2.SetNodePointer(23, 0);
            testLL2.Display();
            testLL2.SetNodePointer(3, 23);
            testLL2.Display(); */

            int[] setPointersTest = new int[] {0, 1, 2};
            int[] setPointersTestFail = new int[] {0, 423, 2};
            int[] setPointersTestFail2 = new int[] {42, 423, 232};

            int[] setPointersTestPointers = new int[] {4, 5, 6};

            testLL2.Display();
            testLL2.SetNodePointer(setPointersTestFail2, setPointersTestPointers);
            testLL2.Display();
            testLL2.SetNodePointer(setPointersTestFail, setPointersTestPointers);
            testLL2.Display();
            testLL2.SetNodePointer(setPointersTest, setPointersTestPointers);
            testLL2.Display();

            // Done testing!!
        }
    }
}