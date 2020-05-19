namespace arrayShuffle
{
    public static class SortingType
    {
        public static int itemSwaps;
        public static int sortingAttemps;
        public static int temp;
        public static int flag = 1;
        
        public static void bubbleSorting(int[] array){
            itemSwaps = 0;
            sortingAttemps = 0;
            
            while(flag != 0){
                flag = 0;
                for(int i=0;i<array.Length-1;i++){
                    if(array[i]>array[i+1]){
                        temp = array[i];
                        array[i] = array[i+1];
                        array[i+1] = temp;
                        flag++;
                        itemSwaps++;
                    }
                }
                sortingAttemps++;
            }
        }
    }
}