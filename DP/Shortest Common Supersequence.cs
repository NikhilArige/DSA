/*
Given two strings str1 and str2, return the shortest string that has both str1 and str2 as subsequences. If there are multiple valid strings, return any of them.
A string s is a subsequence of string t if deleting some number of characters from t (possibly 0) results in the string s.
Example 1:
Input: str1 = "abac", str2 = "cab"
Output: "cabac"
Explanation: 
str1 = "abac" is a subsequence of "cabac" because we can delete the first "c".
str2 = "cab" is a subsequence of "cabac" because we can delete the last "ac".
The answer provided is the shortest such string that satisfies these properties.
Example 2:
Input: str1 = "aaaaaaaa", str2 = "aaaaaaaa"
Output: "aaaaaaaa"
*/

 public class Solution {
    public string ShortestCommonSupersequence(string str1, string str2) {
        int m = str1.Length;
        int n = str2.Length; 
        //dp to find longest LCS 
        var dp = new int[m+1,n+1];
        int i,j;
        for(i=0;i<=m;i++){
            for(j=0;j<=n;j++){
                
                if((i==0) || (j==0)){
                    dp[i,j] = 0;
                }
                else if(str1[i-1] == str2[j-1]){
                    dp[i,j] = 1 + dp[i-1,j-1];
                }
                else{
                    dp[i,j] = Math.Max(dp[i-1,j],dp[i,j-1]);
                }
            }
        } 
        i=m;
        j=n;
        var sb = new StringBuilder(); 
        while(i>0 && j>0){
            if(str1[i-1] == str2[j-1]){ 
                sb.Append(str1[i-1]);
                i--;
                j--;
            }
            else{
                if(dp[i,j-1] > dp[i-1,j]){
                   sb.Append(str2[j-1]);  
                    j--;
                }
                else if(dp[i-1,j] >= dp[i,j-1]){
                    sb.Append(str1[i-1]);
                    i--;
                }
            }
        }        
        while(i > 0){
           sb.Append(str1[i-1]); 
            i--;
        }
        while(j > 0){
           sb.Append(str2[j-1]);
            j--;
        }
        
        return new string(sb.ToString().Reverse().ToArray());
    }
}
