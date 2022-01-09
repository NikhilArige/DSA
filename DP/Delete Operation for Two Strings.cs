/*
Given two strings word1 and word2, return the minimum number of steps required to make word1 and word2 the same.
In one step, you can delete exactly one character in either string.
Example 1:
Input: word1 = "sea", word2 = "eat"
Output: 2
Explanation: You need one step to make "sea" to "ea" and another step to make "eat" to "ea".
Example 2:
Input: word1 = "leetcode", word2 = "etco"
Output: 4
*/

public class Solution {
    public int MinDistance(string word1, string word2) {
        
        int m = word1.Length;
        int n = word2.Length;
        
        //dp to find longest LCS 
        var dp = new int[m+1,n+1];
        for(int i=0;i<=m;i++){
            for(int j=0;j<=n;j++){
                
                if((i==0) || (j==0)){
                    dp[i,j] = 0;
                }
                else if(word1[i-1] == word2[j-1]){
                    dp[i,j] = 1 + dp[i-1,j-1];
                }
                else{
                    dp[i,j] = Math.Max(dp[i-1,j],dp[i,j-1]);
                }
            }
        }
        
        var lcs = dp[m,n];
        return m - lcs + n - lcs;
    }
}
