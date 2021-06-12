using System; 
using System.Collections.Generic; 

namespace ProgrammingPractice.Recursion
{
    public class PhoneDialPadCombinations
    {
        public PhoneDialPadCombinations()
        {
        }

        public void GetPhoneDialPadCombinationStrings(string digits)
        {
            Dictionary<char, char[]> dialPad = new Dictionary<char, char[]>(); 

            dialPad.Add('2', new char[] {'a', 'b', 'c'});    
            dialPad.Add('3', new char[] {'d', 'e', 'f'});
            dialPad.Add('4', new char[] {'g', 'h', 'i'}); 
            dialPad.Add('5', new char[] {'j', 'k', 'l'}); 
            dialPad.Add('6', new char[] {'m', 'n', 'o'}); 
            dialPad.Add('7', new char[] {'p', 'q', 'r', 's'}); 
            dialPad.Add('8', new char[] {'t', 'u', 'v'}); 
            dialPad.Add('9', new char[] {'w', 'x', 'y', 'z'});

            var rval = new List<string>();
            GetCombinationStrings(dialPad, digits, "", rval);

            foreach (var item in rval)
            {
                Console.WriteLine(item); 
            }
        }

        public void GetCombinationStrings(
            Dictionary<char, char[]> dialPad, 
            string digits, 
            string prefix,
            List<string> rval)
        {
            if(digits.Length == 0)
            {
                rval.Add(prefix); 
                return;
            } 
            char c = digits[0];             
            foreach(char ch in dialPad[c])
            {
                prefix += ch; 
                GetCombinationStrings(dialPad, digits.Substring(1), prefix, rval);  
                prefix = prefix.Substring(0, prefix.Length - 1);                
            }
        }
    }
}