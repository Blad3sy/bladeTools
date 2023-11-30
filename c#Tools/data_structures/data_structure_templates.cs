using System;
using System.Collections;
using System.Collections.Generic;

namespace data_structure_templates {
    
    interface IDStruct {
        void Clear();
        bool IsEmpty();
        void Display();
    }

    abstract class ArrayDataStructure : IDStruct {
        protected int?[] MainArray { get; set; }
        public int Length { get; private set; }

        public ArrayDataStructure(int length, int[]? starter) {
            Length = length;
            MainArray = new int?[Length];

            // I feel like I should comment what this code does as it doesn't exactly read intuitively. If the argument starter is null (which it is by default), this code 
            // generates an empty array so that no elements are added to the main array. If the starter however has a value passed into it, this code instead sequentially
            // adds the whole array to the main array as starter != null ; this leaves it as the array it was passed in as, allowing it to be iterated through as such.
            
            starter ??= Array.Empty<int>();
            for (int i = 0; i < starter.Length; i++) {
                MainArray[i] = starter[i];
            }
        }

        public void Clear() => Array.Clear(MainArray);
        public bool IsEmpty() => MainArray.All(item => !item.HasValue) || Length == 0;
        public bool IsFull() => MainArray.All(item => item.HasValue);
        public void Display() {
            foreach (var item in MainArray) {
                if(item != null) {Console.Write($"{item}, ");}
            }
            Console.WriteLine();
        }
    }

    abstract class ListDataStructure : IDStruct {
        protected List<int?> MainList { get; set; }
        public int Length { get; protected set; }

        public ListDataStructure(int?[]? starter) {
            MainList = new List<int?>();

            starter ??= Array.Empty<int?>();
            MainList.AddRange(starter);
            Length += starter.Length;
        }

        public void Clear() => MainList.Clear();
        public bool IsEmpty() => MainList.Count == 0;
        public void Display() {
            foreach (var item in MainList) {
                if(item != null) {Console.Write($"{item}, ");}
            }
            Console.WriteLine();
        }
    }

    abstract class DictionaryDataStructure : IDStruct {
        protected Dictionary<int, int?[]> MainDict { get; set; }
        public int Length { get; protected set; }

        public DictionaryDataStructure(Dictionary<int, int?[]>? starter = null) {
            MainDict = new Dictionary<int, int?[]>();
            
            starter ??= new Dictionary<int, int?[]>();
            foreach (int key in starter.Keys) {
                MainDict.Add(key, starter[key]);
            }
        }

        public void Clear() => MainDict.Clear();
        public bool IsEmpty() => MainDict.Count == 0;
        public void Display() {
            foreach (int key in MainDict.Keys) {
                Console.Write($"{key} : [{MainDict[key][0]}, {MainDict[key][1]}]");
            }
            Console.WriteLine();
        }
    }
}