using data_structure_templates;

namespace stacks {
    class StaticStack : ArrayDataStructure {
        private int TopPointer { get; set; }
        public StaticStack(int length, int[]? starter = null) : base(length, starter) { 
            TopPointer = (starter == null) ? 0 : starter.Length;
        }

        public void Push(int toPush) {
            if (TopPointer < Length){
                MainArray[TopPointer] = toPush;
                TopPointer++;
            }
            else { Console.WriteLine("Stack is full!"); }
        }

        public void Push(int[] toPush) {
            // Method overload purpose : push a whole array of values to the stack
            
            if (TopPointer + toPush.Length - 1 < Length){
                for (int i = 0; i < toPush.Length; i++) {
                    MainArray[TopPointer] = toPush[i];
                    TopPointer++;
                }
            }
            else { Console.WriteLine("Not enough space to push full array!"); }
        }

        public int? Pop() {
            int? returner = null;
            if (TopPointer - 1 >= 0) {
                returner = MainArray[TopPointer - 1];
                MainArray[TopPointer - 1] = null;
                TopPointer--;
            }
            else { Console.WriteLine("Stack is empty!"); }
            return returner;
        }

        public int?[]? Pop(int count) {
            // Method overload purpose : pop {count} number of items from the stack
            int?[]? returner = null;

            if (TopPointer - 1 - count >= 0) {
                returner = new int?[count];

                for (int i = 0; i < count; i++) {
                    returner[i] = MainArray[TopPointer - 1];
                    MainArray[TopPointer - 1] = null;
                    TopPointer--;
                }
            }
            else { Console.WriteLine("You tried to remove more elements than there are!"); }
            return returner;
        }

        public int? Peek() {
            if (TopPointer - 1 >= 0) {
                return MainArray[TopPointer - 1];
            }
            else { Console.Write("Stack is empty!");}
            return null;
        }

        public int?[]? Peek(int count) {
            // Method overload purpose : get {count} number of items from the stack
            int?[]? returnerArray = null;

            if (TopPointer - 1 - count >= 0) {
                returnerArray = new int?[count];

                for (int i = 0; i < count; i++) {
                    returnerArray[i] = MainArray[TopPointer - 1 - i];
                }
            }
            return returnerArray; 
        }
    }

    class DynamicStack : ListDataStructure {
        private int TopPointer { get; set; }

        public DynamicStack(int?[]? starter = null) : base(starter) {
            TopPointer = (starter == null) ? 0 : starter.Length;
        }

        public void Push(int toPush) {
            MainList.Add(toPush);
            TopPointer++;
            Length++;
        }

        public void Push(int?[] toPush) {
            // Method overload purpose : push a whole array of values to the stack

            MainList.AddRange(toPush);
            TopPointer += toPush.Length;
            Length += toPush.Length;
        }

        public int? Pop() {
            int? returner = null;

            if (TopPointer - 1 >= 0) {
                returner = MainList[TopPointer - 1];
                MainList[TopPointer - 1] = null;
                TopPointer--;
                Length--;
            }
            else { Console.WriteLine("The stack is empty!"); }

            return returner;
        }

        public int?[]? Pop(int count) {
            // Method overload purpose : pop {count} number of items from the stack
            int?[]? returner = null;

            if (TopPointer - 1 - count >= 0) {
                returner = new int?[count];

                for (int i = 0; i < count; i++) {
                    returner[i] = MainList[TopPointer - 1];
                    MainList[TopPointer - 1] = null;
                    TopPointer--;
                    Length--;
                } 
            }
            else { Console.WriteLine("You tried to remove more elements than there are!"); }

            return returner;
        }

        public int? Peek() {
            if (TopPointer - 1 >= 0) {
                return MainList[TopPointer - 1];
            }
            else { Console.WriteLine("The stack is empty!"); }

            return null;
        }

        public int?[]? Peek(int count) {
            int?[]? returner = null;

            if (TopPointer - 1 - count >- 0) {
                returner = new int?[count];

                for (int i = 0; i < count; i++) {
                    returner[i] = MainList[TopPointer - 1 - i];
                }
            }
            return returner;
        }
    }
}