using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice.Strings
{
    public class AreStringCharactersUnique
    {
        /// Are characters of the string unique
        public static bool IsUnique(string input)
        {
            int[] arr = new int[128];
            for (Int16 i = 0; i < input.Length; i++)
            {
                int index = input[i];
                if (arr[index] > 0)
                {
                    return false;
                }
                else
                {
                    arr[index] = index;
                }
            }
            return true;
        }
    }
}
