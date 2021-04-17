//Implement regular expression matching with support for '.' and '*'.
//'.' Matches any single character.
//'*' Matches zero or more of the preceding element.
//The matching should cover the entire input string (not partial).
//isMatch("aa","a") → 0
//isMatch("aa","aa") → 1
//isMatch("aaa","aa") → 0
//isMatch("aa", "a*") → 1
//isMatch("aa", ".*") → 1
//isMatch("ab", ".*") → 1
//isMatch("aab", "c*a*b") → 1



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
        //for scenario like a* or a*b* or a*b*c*
         for (int j = 1; j <=n; j++) {
            if (pattern[j-1] == '*') {
                //considering 0 occurances of before element
                dp[0,j] = dp[0,j - 2];
            }
        } 
        for (int i = 1; i <= m; i++) {
          for (int j = 1; j <= n; j++) {
               
              if(pattern[j-1]==A[i-1] || pattern[j-1]=='.'){
                  dp[i,j] = dp[i-1,j-1];
              }
              else if (pattern[j-1] == '*'){
                    //considering 0 occurances of before element
                    dp[i,j] = dp[i,j - 2]; 
                    //before * value 
                    if (pattern[j-2] == '.' || pattern[j - 2] == A[i - 1]) {
                        dp[i,j] = dp[i,j] || dp[i - 1,j];
                    }
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
