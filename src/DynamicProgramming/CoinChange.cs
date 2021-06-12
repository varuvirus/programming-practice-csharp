using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice.DynamicProgramming
{
    public class CoinChange
    {
        public static int MinimumNumberOfCoins(int amount, int[] coins)
        {
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0; 

            for (int i = 1; i <= amount; i++)
            {
                for (int c = 0; c  < coins.Length; c++)
                {                    
                    if(coins[c] <=  i)
                    {
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coins[c]]);
                    }
                }
            }

            return dp[amount] != amount + 1 ? dp[amount] : -1; 
        }

        public static int NumberOfWays(int amount, int[] coins)
        {
            int[] combinations = new int[amount + 1];
            combinations[0] = 1;

            for (int c = 0; c < coins.Length; c++)
            {
                for (int i = 1; i < combinations.Length; i++)
                {
                    if( i >= coins[c])
                    {
                        combinations[i] += combinations[i - coins[c]]; 
                    }
                }
            }

            return combinations[amount]; 
        }

        public static int NumberofWays2(int amount, int[] coins)
        {
            if (amount == 0) return 1;
            int ways = 0; 
            for (int i = 0; i < coins.Length; i++)
            {
                int current = amount - coins[i]; 
                if(current >= 0)
                {
                    ways += NumberofWays2(current, coins); 
                }
            }

            return ways; 
        }
    }
}
