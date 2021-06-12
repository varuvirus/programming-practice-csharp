using System; 
using System.Collections.Generic; 

namespace ProgrammingPractice.Arrays
{
    public static class Generic 
    {
        public static void Print2dArray(){
            
            var arr = GetRandomArray(10, 10, 2);
            
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }

        /// Check if all the neighbors are 1. 
        public static void CheckNeighbors()
        {
            int[,] arr = GetRandomArray(10, 10, 2);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i); 
                for(int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(j + "\t"); 
                    if(i == 0)
                    {
                    }
                    if (j == 0)
                    {                    
                    }
                    if(i == arr.GetLength(0) - 1)
                    {
                    }
                    if(j == arr.GetLength(1) - 1)
                    {
                    }
                    if(arr[i-1, j-1] == 1
                        && arr[i+1, j-1] == 1
                        && arr[i-1, j+1] == 1
                        && arr[i+1, j+1] == 1
                    )
                    {
                        Console.WriteLine(arr[i, j]); 
                    }
                }
            }
        }

        private static int[,] GetRandomArray(int rows, int cols, int highLimit)
        {
            int[,] rval = new int[rows, cols];
            var rand = new Random(); 
            for(int i = 0; i < rval.GetLength(0); i++) 
            {                
                for(int j = 0; j < rval.GetLength(1); j++) 
                {
                    rval[i,j] = rand.Next(highLimit); 
                }
            }
            return rval; 
        }        
    }
}