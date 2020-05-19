using System;

namespace arrayShuffle
{
    public class ArraySorted
    {
        private int numItems {get; set;}
        public int[] createdArray;

        public ArraySorted(int numItems){
            this.numItems = numItems;
        }

        public void create(){
            createdArray = new int[this.numItems];
            int size = createdArray.Length;

            for(int i=0;i<size;i++){
                createdArray[i] = i;
            }
        }

        public void shuffleArray(){
            Random ran = new Random();
            int size = createdArray.Length;
            
            for(int i=0;i<size;i++){
                swapItems(createdArray[i], createdArray[ran.Next(0, createdArray.Length - 1)]);
            }
        }

        private void swapItems(int ind, int swapInd){
            int temp;

            temp = createdArray[ind];
            createdArray[ind] = createdArray[swapInd];
            createdArray[swapInd] = temp;
        }

        // public void selectionSorting(){
        //     int[] arrayCopy = new int[this.numItems];
        //     Array.Copy(createdArray, arrayCopy, this.numItems);

        // }

        public void showArray(){
            string res = String.Join(" - ", createdArray);

            Console.Write('[');
            Console.Write(res);
            Console.Write(']');
            Console.WriteLine("\n\n");
        }
    }
}
