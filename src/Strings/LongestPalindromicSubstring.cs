using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingPractice.Strings
{
    public static class LongestPalindromicSubstring
    {
        public static void Run(String input)
        {
            int maxLength = 0;
            Dictionary<string, bool> memo = new Dictionary<string, bool>(); 

            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i; j <= input.Length - i; j++)
                {
                    string current = input.Substring(i, j);

                    if (string.IsNullOrEmpty(current))
                        continue; 

                    Console.WriteLine(current);

                    bool isPalindrome; 
                    if (!memo.ContainsKey(current))
                    {
                        string reverse = Reverse(current);
                        isPalindrome = current == reverse;
                        memo.Add(current, isPalindrome);

                       if(!memo.ContainsKey(reverse))
                            memo.Add(reverse, isPalindrome);
                    }
                    else
                    {
                        isPalindrome = memo[current]; 
                    }
                    
                    if (isPalindrome && current.Length > maxLength)
                        maxLength = current.Length; 
                }
            }
            Console.WriteLine("Max length palindrome substring :{0}", maxLength); 
        }

        public static string Reverse(string text)
        {
            if (text == null) return null;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        /// <summary>
        /// O(n) implementation
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Run2(string input)
        {
            int start = 0, end = input.Length - 1; 

            // Pass 1: end moves backward
            while(start <= end)
            {
                if(input[start] == input[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    end--; 
                }
            }

            // Pass 2: start moving forward 
            while (start <= end)
            {
                if (input[start] == input[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    start++;
                }
            }

            return string.Empty; 
        }
    }
}
