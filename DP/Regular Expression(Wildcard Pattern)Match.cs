/Implement wildcard pattern matching with support for ‘?’ and ‘*’ for strings A and B.
//’?’ : Matches any single character.
//‘*’ : Matches any sequence of characters (including the empty sequence).
//The matching should cover the entire input string (not partial).
//Input :A = "aa",B = "a"  Output:0
//Input :A = "aa",B = "aa" Output:1
//Input :A = "aa" B = "*"  Output:1
//Input :A = "aa",B = "a*" Output:1
//Input: A = "ab",B = "?*" Output:1

class Solution {
    public int isMatch(string A, string pattern) {
        
        int m = A.Length;
        int n = pattern.Length;
        
        bool[,] dp = new bool[m+1,n+1];
        
        //filling with false
         for (int i = 0; i < m + 1; i++){
            for (int j = 0; j < n + 1; j++){
                dp[i, j] = false;
            }
         } 
        //empty string can match with empty pattern
        dp[0,0] = true;
        //only if first character is '*', it can be true with empty string
        // if(pattern[0]=='*'){
        //     dp[0,1] = true;
        // }  this wrong as pattern can be ***
        for (int j = 1; j <= n; j++)
            if (pattern[j - 1] == '*'){
                dp[0, j] = dp[0, j - 1];
            }
        for
        (int i = 1; i <= m; i++) {
          for (int j = 1; j <= n; j++) {
               
              if(pattern[j-1]==A[i-1] || pattern[j-1]=='?'){
                  dp[i,j] = dp[i-1,j-1];
              }
              else if (pattern[j-1] == '*'){
                    dp[i,j] = dp[i-1,j] || dp[i,j-1];
                }
          }
        }
        if(dp[m,n]){
            return 1;
        }
        else{
            return 0;
        }
    }
}
