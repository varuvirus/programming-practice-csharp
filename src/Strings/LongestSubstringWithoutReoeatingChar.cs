using System; 
using System.Collections.Generic; 

namespace ProgrammingPractice.Strings
{
    public static class LongestSubstringWithoutReoeatingChar
    {
        public static int LongestSubStringWithOutRepeatingCharacters(string input)
        {
            var dict = new Dictionary<char, int>(); 
            int maxLength = 0, startIndex = 0; 

            for (int i = 0; i < input.Length; i++)
            {
                if(dict.ContainsKey(input[i]))
                {
                    startIndex = startIndex > dict[input[i]] + 1
                                    ? startIndex
                                    : dict[input[i]] + 1;

                    dict[input[i]] = i;                     
                }
                else
                {
                    dict.Add(input[i], i); 
                }
                maxLength = ((i - startIndex) + 1) > maxLength 
                            ?  ((i - startIndex) + 1)
                            : maxLength; 
            }

            return maxLength; 
        }
    }
}