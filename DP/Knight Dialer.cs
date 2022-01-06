/*
The chess knight has a unique movement, it may move two squares vertically and one square horizontally, 
or two squares horizontally and one square vertically (with both forming the shape of an L). The possible movements of chess knight are shown in this diagaram:
A chess knight can move as indicated in the chess diagram below:
We have a chess knight and a phone pad as shown below, the knight can only stand on a numeric cell (i.e. blue cell).
Given an integer n, return how many distinct phone numbers of length n we can dial.
You are allowed to place the knight on any numeric cell initially and then you should perform n - 1 jumps to dial a number of length n. All jumps should be valid knight jumps.
As the answer may be very large, return the answer modulo 109 + 7.
Example 1:
Input: n = 1
Output: 10
Explanation: We need to dial a number of length 1, so placing the knight over any numeric cell of the 10 cells is sufficient.
Example 2:
Input: n = 2
Output: 20
Explanation: All the valid number we can dial are [04, 06, 16, 18, 27, 29, 34, 38, 40, 43, 49, 60, 61, 67, 72, 76, 81, 83, 92, 94]
Example 3:
Input: n = 3131
Output: 136006598
Explanation: Please take care of the mod.
*/

public class Solution {
    public int KnightDialer(int n) {
        var fromPath = new int[][] { new int[]{ 4, 6 }, new int[] { 6, 8 }, new int[] { 7, 9 }, new int[] { 4, 8 },new int[]{ 3, 9, 0 }, new int[]{ }, new int[]{ 1, 7, 0 }, new int[]{ 2, 6 }, new int[]{ 1, 3 }, new int[]{ 2, 4 } };
        long MOD = 1000000007;

        var steps = n;  
        var possibleNumbers = 10;  //0 to 9
        var dp = new long[steps, possibleNumbers];  
        for (int col = 0; col < possibleNumbers; col++)
        {
            dp[0, col] = 1;
        }
    
    
         for (int row = 1; row < steps; row++)
            {
                for (int col = 0; col < possibleNumbers; col++)
                {
                    var possibleFromPaths = fromPath[col];
                    foreach (var path in possibleFromPaths)
                    {
                        dp[row, col] += dp[row - 1, path];
                    }
                    dp[row, col] %= MOD;
                }               
            }
            long totalSum = 0;
            for (int col = 0; col < possibleNumbers; col++)
            {
                totalSum += dp[n-1,col];
            }

            totalSum = totalSum % MOD;
		
            return (int)totalSum;
    
    }
}
