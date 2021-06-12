using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice.Strings
{
    public class CommonPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null) return string.Empty;
            if (strs.Length == 0) return string.Empty;
            string commonPrefix = strs[0];
            foreach (string s in strs)
            {
                int len = Math.Min(s.Length, commonPrefix.Length);
                int i = 0;
                while (i < len)
                {
                    if (s[i] != commonPrefix[i])
                    {
                        commonPrefix = s.Substring(0, i);
                        break;
                    }
                    i++;
                }

                if (i == len)
                {
                    commonPrefix = s.Substring(0, i);
                }

            }

            return commonPrefix;

        }
    }
}
