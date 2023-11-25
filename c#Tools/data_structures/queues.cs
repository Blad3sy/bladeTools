using data_structure_templates;

namespace queues {
    class StaticQueue : ArrayDataStructure {

        public int HeadPointer { get; set; }
        public int TailPointer { get; set; }
        public StaticQueue(int length, int[]? starter = null) : base(length, starter) {
            HeadPointer = 0;
            TailPointer = (starter == null) ? 0 : starter.Length;
        }

        public void Enqueue(int toEnqueue) {
            TailPointer = (TailPointer >= Length) ? 0 : TailPointer;

            if (!IsFull()) {
                MainArray[TailPointer] = toEnqueue;
                TailPointer++;
            }
            else { Console.WriteLine("The queue is full!"); }
        }

        public int? Dequeue() {
            int? returner = null;
            HeadPointer = (HeadPointer >= Length) ? 0 : HeadPointer;

            if (!IsEmpty()) {
                returner = MainArray[HeadPointer];
                MainArray[HeadPointer] = null;
                HeadPointer++;
            }
            else { Console.WriteLine("The queue is empty!"); }
            return returner;
        }
    }
}