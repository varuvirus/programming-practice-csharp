using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice.Strings
{
    public class IsSubString
    {
        /// Is one string substring ofthe other
        public static bool IsSubStr1(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                return false;
            }
            else if (s1.Length > s2.Length)
            {
                return IsSubStr1(s1, s2);
            }
            else if (s1.Length == s2.Length)
            {
                return s1 == s2;
            }
            else
            {
                return IsSubStrng(s2, s1);
            }
        }

        private static bool IsSubStrng(string s1, string s2)
        {
            bool isMatch = false;
            int i = 0, j = 0;

            Console.WriteLine("i\tj\ts1[i]\ts2[j]");

            while (i < s1.Length && j < s2.Length)
            {
                Console.WriteLine(i + "\t" + j + "\t" + s1[i] + "\t" + s2[j]);

                if (s1[i] == s2[j])
                {
                    j++;
                    isMatch = true;
                }
                else
                {
                    j = 0;
                    isMatch = false;
                }
                i++;
            }

            return isMatch;
        }
    }
}
