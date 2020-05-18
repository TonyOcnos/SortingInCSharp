﻿using System;

namespace arrayShuffle
{
    public class ArraySorted
    {
        private int numItems {get; set;}
        private int[] createdArray;

        public int itemSwaps;
        public int sortingAttemps;

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

        public void bubbleSorting(){
            int temp;
            int flag = 1;
            itemSwaps = 0;
            sortingAttemps = 0;

            while(flag != 0){
                flag = 0;
                for(int i=0;i<createdArray.Length-1;i++){
                    if(createdArray[i]>createdArray[i+1]){
                        temp = createdArray[i];
                        createdArray[i] = createdArray[i+1];
                        createdArray[i+1] = temp;
                        flag++;
                        itemSwaps++;
                    }
                }
                sortingAttemps++;
            }
        }

        public void showArray(){
            string res = String.Join(" - ", createdArray);

            Console.Write('[');
            Console.Write(res);
            Console.Write(']');
            Console.WriteLine("\n\n");
        }
    }
}