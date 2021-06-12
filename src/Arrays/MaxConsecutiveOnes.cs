using System; 
using System.Collections.Generic; 

namespace ProgrammingPractice.Arrays
{
    public static class MaxConsecutiveOnes 
    {
        public static int FindMaxConsecutiveOnes(int[] nums) 
        {
            Console.WriteLine("Maximum consecutive ones"); 

            if(nums == null || nums.GetLength(0) == 0)
            {
                return 0; 
            }
            
            int currentCount = 0, maxCount = 0; 
            currentCount = nums[0] == 1 ? 1 : 0;
            maxCount = currentCount; 
            for(int i = 1; i < nums.GetLength(0); i++)
            {
                if(nums[i] == 1) {
                    currentCount++;                
                } else {
                    currentCount = 0; 
                }
                if(currentCount > maxCount){
                    maxCount = currentCount; 
                }
            }
        
            return maxCount; 
        }
    }
}