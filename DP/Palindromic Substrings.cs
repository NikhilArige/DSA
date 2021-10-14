/*
Given a string s, return the number of palindromic substrings in it.
A string is a palindrome when it reads the same backward as forward.
A substring is a contiguous sequence of characters within the string.
Example 1:
Input: s = "abc"
Output: 3
Explanation: Three palindromic strings: "a", "b", "c".
Example 2:
Input: s = "aaa"
Output: 6
Explanation: Six palindromic strings: "a", "a", "a", "aa", "aa", "aaa".
*/

public class Solution {
    public int CountSubstrings(string s) {
        
        var n = s.Length;
        var dp = new bool[n,n];
        int cnt = 0;
        for(int l=0;l<n;l++){
            for(int row=0,col=l;col<n;row++,col++){
                if(l==0){
                    dp[row,col] = true;
                }
                else if(l==1 && s[row]==s[col]){
                    dp[row,col] = true;
                }
                else if(s[row]==s[col]){
                    dp[row,col] = dp[row+1,col-1];   
                }
                
                if(dp[row,col]){
                    cnt++;
                }
            }
        }
        return cnt;
    }
}
