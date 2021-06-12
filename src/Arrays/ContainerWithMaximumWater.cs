using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice.Arrays
{
    public class ContainerWithMaximumWater
    {
        public static int Run(int[] arr) 
        {
            int maxArea = 0, start = 0, end = arr.Length - 1; 

            while(start < end)
            {
                int width = end - start; 
                int height = Math.Min(arr[start], arr[end]);
                int area = height * width;

                if (area > maxArea)
                    maxArea = area;

                if (arr[start] < arr[end])
                {
                    start++;
                }
                else
                {
                    end--; 
                }
            }

            return maxArea; 
        }
    }
}
