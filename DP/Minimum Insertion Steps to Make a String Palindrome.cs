/*
Given a string s. In one step you can insert any character at any index of the string.
Return the minimum number of steps to make s palindrome.
A Palindrome String is one that reads the same backward as well as forward.
Example 1:
Input: s = "zzazz"
Output: 0
Explanation: The string "zzazz" is already palindrome we don't need any insertions.
Example 2:
Input: s = "mbadm"
Output: 2
Explanation: String can be "mbdadbm" or "mdbabdm".
Example 3:
Input: s = "leetcode"
Output: 5
Explanation: Inserting 5 characters the string becomes "leetcodocteel"
*/

public class Solution {
    public int MinInsertions(string word1) {
        //find LPS and remove it from length of s
        var word2 = new string(word1.Reverse().ToArray());
        //LPS can be found by LCS of word1 and reverse of word1
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
        return m-dp[m,n];
    }
}
