using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice.Strings
{
    public class RomanNumerals
    {
        public static int RomanToInteger(string roman)
        {
            Dictionary<char, int> romanToInteger = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 },
            };

            int total = 0; 

            for(int i = 0; i < roman.Length; i++)
            {
                if(i < roman.Length - 1 && romanToInteger[roman[i]] < romanToInteger[roman[i + 1]])
                {
                    total += romanToInteger[roman[i + 1]] - romanToInteger[roman[i]];
                    i++;
                }
                else
                {
                    total += romanToInteger[roman[i]]; 
                }
            }

            return total; 
        }

        public static string IntegerToRoman(int input)
        {
            Dictionary<int, char> integerToRoman = new Dictionary<int, char>
            {
                { 1, 'I' },
                { 5, 'V'},
                { 10, 'X'},
                { 50, 'L'},
                { 100, 'C'},
                { 500, 'D' },
                { 1000, 'M' }
            };

            return ""; 
        }
    }
}
