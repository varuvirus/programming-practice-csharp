using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice.DynamicProgramming
{
    public class MinCostOfTickets
    {
        static int[] costs;
        static int[] memo;
        static HashSet<int> dayset;

        public static int MinimumCostOfTickets(int[] days, int[] csts)
        {
            costs = csts;
            memo = new int[366];

            for (int i = 0; i < 366; i++) { memo[i] = -1; }

            dayset = new HashSet<int>(days);

            return dp(1);
        }

        public static int dp(int i)
        {
            if (i > 365)
                return 0;

            if (memo[i] != -1)
                return memo[i];

            int ans;
            if (dayset.Contains(i))
            {
                ans = Math.Min(dp(i + 1) + costs[0],
                                   dp(i + 7) + costs[1]);
                ans = Math.Min(ans, dp(i + 30) + costs[2]);
            }
            else
            {
                ans = dp(i + 1);
            }

            memo[i] = ans;
            return ans;
        }
    }
}
