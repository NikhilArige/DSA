/*
You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.
Return the number of combinations that make up that amount. If that amount of money cannot be made up by any combination of the coins, return 0.
You may assume that you have an infinite number of each kind of coin.
The answer is guaranteed to fit into a signed 32-bit integer.
Example 1:
Input: amount = 5, coins = [1,2,5]
Output: 4
Explanation: there are four ways to make up the amount:
5=5
5=2+2+1
5=2+1+1+1
5=1+1+1+1+1
*/

public class Solution {
    public int Change(int amount, int[] coins) {
        
        var dp = new int[coins.Length+1,amount+1];
        
        for(int i= 0;i<=amount;i++){
            dp[0,i] = 0;
        }
         for(int i= 0;i<=coins.Length;i++){
            dp[i,0] = 1;
        }
        for (int i = 1; i <= coins.Length; i++) {
            for (int j = 1; j <= amount; j++) {
                if (j - coins[i-1] >= 0) {
                    dp[i,j] = dp[i-1,j] + dp[i,j-coins[i-1]];
                }
                else {
                    dp[i,j] = dp[i-1,j];
                }
            }
        }
        
        return dp[coins.Length,amount];
    }
}



public class Solution {
    public int Change(int amount, int[] coins) {
        int[] dp = new int[amount+1];
        dp[0] = 1;
        
        for (int i = 0; i < coins.Length; i++)
            for (int j = 1; j <= amount; j++)
                if (j - coins[i] >= 0)
                    dp[j] += dp[j-coins[i]];
        
        return dp[amount];
    }
}
