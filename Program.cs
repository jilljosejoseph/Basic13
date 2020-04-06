using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {

        static void Print1To255() 
        {
            for(int i=0; i<256; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintOdds()
        {
            for (int i = 0; i <= 256; i++)
            {
                if(i%2 != 0){
                Console.WriteLine(i);
                }
            }
        }

        static void PrintSum()
        {
            int sum = 0;

            for (int i = 0; i <= 256; i++)
                {
                Console.WriteLine(i);
                sum += i;
                Console.WriteLine(sum);
                }
        
        }

        static void LoopArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

        }

        static int FindMax(int[] Array)
        {
            int max = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if(max < Array[i]){
                    max = Array[i];
                }
            }
            return max;
        }

        static void GetAverage(int[] Array){
            double average = 0;
            for (int i = 0; i < Array.Length; i++){
                average += Array[i];
            }
            average = average / Array.Length;
            Console.WriteLine(average);

        }

        static List<int> OddArray(){
            List<int> NewArray = new List<int>();
            for (int i = 0; i <= 255; i++){
                if(i%2 != 0){
                    NewArray.Add(i);
                }
            }
            foreach(int num in NewArray){
                Console.WriteLine(num);
            }
            return NewArray;

        }

        static int GreaterThanY(int[] Array, int y){
            int count = 0;
            for (int i = 0; i < Array.Length; i++){
                if(Array[i] > y){
                    count++;
                }
            }
            return count;
        }

        static void SquareArrayValues(int [] Array){
            for (int i = 0; i < Array.Length; i++){
                Array[i] = Array[i] * Array[i];
                Console.WriteLine(Array[i]);
            }

        }

        static void EliminateNegatives(int[] Array){
            for (int i = 0; i < Array.Length; i++){
                if(Array[i] < 0){
                    Array[i] = 0;
                }
            }
            foreach(int num in Array){
                Console.WriteLine(num);
            }
        }

        static void MinMaxAverage(int[] Array){
            int min = Array[0];
            int max = Array[0];
            int sum = Array[0];
            for (int i = 1; i < Array.Length; i++){
                if(Array[i] < min){
                    min = Array[i];
                }
                if(Array[i] > max){
                    max = Array[i];
                }
                sum += Array[i];
            }
            int average = sum / Array.Length;
            int [] NewArray;
            NewArray = new int[] {max, min, average};

            Console.WriteLine($"{NewArray[0]},{NewArray[1]},{NewArray[2]}");
            
        }

        static void ShiftValues(int[] Arrays){
            for (int i=0; i<Arrays.Length; i++)
            {
                if (i == Arrays.Length-1)
                {
                    Arrays[i] = 0;
                } else
                {
                    Arrays[i] = Arrays[i+1];
                }
                
                Console.WriteLine(Arrays[i]);
            }
        }

        static object[] NumToString(int[] Arrays){
            object[] newArray = new object[Arrays.Length];
            int index = 0;

            for (int i=0; i<Arrays.Length; i++)
            {
                if (Arrays[i] < 0) 
                {
                    newArray[index] = "Dojo";
                    index++;
                } else
                {
                    newArray[index] = Arrays[i];
                    index++;
                }
            }

            foreach (object aa in newArray)
            {
                Console.WriteLine(aa);
            }

            return newArray;

        }


        static void Main(string[] args)
        {
            // Print1To255();
            // PrintOdds();
            // PrintSum();
            int[] Array = {1,-2,-3,6};
            // LoopArray(Array);
            // Console.WriteLine(FindMax(Array));
            // GetAverage(Array);
            // OddArray();
            // Console.WriteLine(GreaterThanY(Array, 1));
            // SquareArrayValues(Array);
            // EliminateNegatives(Array);
            // MinMaxAverage(Array);
            // ShiftValues(Array);
            NumToString(Array);
        }
    }
}
