using System; 
using System.Collections.Generic; 

namespace ProgrammingPractice.Arrays
{
    public static class TwoSum 
    {
        // Given an array of stock prices, find out best 
        // Given an array of integers, return indices of the two numbers such that they add up to a specific target. 
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        public static int[] GetTwoSum_BF(int[] nums, int target)        
        {
            int[] rval = new int[2]; 
            rval[0] = -1; 
            rval[1] = -1; 

            for(int i = 0; i < nums.GetLength(0); i++)
            {
                for(int j = i; j < nums.GetLength(0); j++)
                {
                    if(nums[i] + nums[j] == target)
                    {                
                        rval[0] = i; 
                        rval[1] = j; 
                        return rval;                     
                    }
                }
            }

            return rval; 
        }

        public static int[] GetTwoSum(int[] nums, int target)        
        {
            var dict = new Dictionary<int, int>(); 

            for(int i = 0; i < nums.GetLength(0); i++)
            {
                var diff = target - nums[i]; 
                if(dict.ContainsKey(diff)){
                    return new int[] {i, dict[diff]}; 
                } else {
                    dict.Add(nums[i], i); 
                }
            }

            return new int[] {-1, -1}; 
        }
                
    }
}