using data_structure_templates;

namespace queues {
    class StaticQueue : ArrayDataStructure {

        private int HeadPointer { get; set; }
        private int TailPointer { get; set; }
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

        public void Enqueue(int[] toEnqueue) {
            // Method overload purpose : enqueue a whole array of values to the queue

            if (MainArray.Count(item => item.HasValue) + toEnqueue.Length <= Length) {
                foreach (var item in toEnqueue) {
                    MainArray[TailPointer] = item;
                    TailPointer++;
                    TailPointer = (TailPointer >= Length) ? 0 : TailPointer; 
                }
            }
            else { Console.WriteLine("You tried to add more elements than possible!"); }
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

        public int?[]? Dequeue(int count) {
            // Method overload purpose : dequeue {count} number of items from the stack
            int?[]? returner = null;

            if (MainArray.Count(item => item.HasValue) - count >= 0) {
                returner = new int?[count];
                for (int i = 0; i < count; i++) {
                    returner[i] = MainArray[HeadPointer];
                    MainArray[HeadPointer] = null;
                    HeadPointer++;
                    HeadPointer = (HeadPointer >= Length) ? 0 : HeadPointer;
                }
            }
            else { Console.WriteLine("You tried to dequeue more elements than there are!"); }
            return returner;
        }
    }
}