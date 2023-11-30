using data_structure_templates;
using System.Collections.Generic;

namespace linked_list {
    class LinkedList : DictionaryDataStructure {
        private int DefaultKey { get; set; }
        public int CurrentNode { get; private set; }
        public LinkedList(Dictionary<int, int?[]>? starter = null) : base(starter) {
            DefaultKey = 0;
            CurrentNode = 0;
        }

        public void AddNode(int value, int? key = null, int? pointer = null) {
            int nonNullKey = (key == null) ? DefaultKey : Convert.ToInt32(key);
            MainDict.Add(nonNullKey, new int?[] {value, pointer});
            Length++;
        }

        public void AddNode(int[] values, int[]? keys = null, int?[]? pointers = null) {
            // Method overload purpose : add a whole array of nodes to the Linked List

            if (keys == null) {
                keys = new int[values.Length];
                for (int i = 0; i < keys.Length; i++) {
                    keys[i] = DefaultKey;
                    DefaultKey++;
                }
            }

            pointers ??= new int?[values.Length];

            if (values.Length == keys.Length && values.Length == pointers.Length && keys.Length == pointers.Length) {
                // I'd like to comment on this. I don't like this. This is simply ridiculous. Why, Microsoft, can I not make a logic comparison between more than 2 variables?
                for (int i = 0; i < keys.Length; i++) {
                    AddNode(values[i], keys[i], pointers[i]);
                }
            }
            else { Console.WriteLine("Your value, key and pointer arrays were not all the same length!"); }
        }

        public void DeleteNode(int key) {
            if (MainDict.Remove(key)) {
                Length--;
            }
            else { Console.WriteLine("The key you entered does not exist in the Linked List!"); }
        }

        public void DeleteNode(int[] keys) {
            // Method overload purpose : delete a whole array of nodes from the Linked List

            if (keys.All(MainDict.ContainsKey)) {
                foreach (int key in keys) {
                    MainDict.Remove(key);
                    Length--;
                }
            }
            else { Console.WriteLine("A key in you entered does not exist in the Linked List!"); }
        }

        public void NextNode(bool displayValue = false) {
            if (MainDict[CurrentNode][1] != null) {
                CurrentNode = Convert.ToInt32(MainDict[CurrentNode][1]);
                if (displayValue) { Console.WriteLine(GetCurrentNodeValue()); }
            }
            else { Console.WriteLine("You tried to move to a null node!"); }
        }

        public void SetNodePointer(int key, int pointer) {
            if (MainDict.ContainsKey(key)) {
                MainDict[key][1] = pointer;
            }
            else { Console.WriteLine("You tried to set the pointer of a null node!"); }
        }

        public void SetNodePointer(int[] keys, int[] pointers) {
            // Method overload purpose : change a whole array of nodes' pointer values

            if (keys.All(MainDict.ContainsKey) && keys.Length == pointers.Length) {
                for (int i = 0; i < keys.Length; i++) {
                    MainDict[keys[i]][1] = pointers[i];
                }
            }
            else { Console.WriteLine("You tried to set the pointer of a null node! / Your key and pointer arrays were different lengths!"); }
        }

        public void ResetCurrentNode() => CurrentNode = 0;
        public int GetCurrentNodeValue() => Convert.ToInt32(MainDict[CurrentNode][0]);
    }
}