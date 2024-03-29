/*A robot is located at the top-left corner of an A x B grid (marked ‘Start’ in the diagram below).
The robot can only move either down or right at any point in time. 
The robot is trying to reach the bottom-right corner of the grid (marked ‘Finish’ in the diagram below).
How many possible unique paths are there?
Input : A = 2, B = 2
Output : 2
2 possible routes : (0, 0) -> (0, 1) -> (1, 1) 
              OR  : (0, 0) -> (1, 0) -> (1, 1) */
              
              
class Solution {
    public int uniquePaths(int m, int n) {
        
        int[,] dp = new int[m,n];  
  
        for (int i = 0; i < m; i++){
            dp[i, 0] = 1;
        } 
        for (int j = 0; j < n; j++){
            dp[0, j] = 1;
        } 
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++){ 
                dp[i, j] = dp[i - 1, j] + dp[i, j - 1]; 
            }
        }
        return dp[m - 1, n - 1];
    }
}

//or

class Solution {
    public int uniquePaths(int m, int n) {
        
        int[] dp = new int[n];
        dp[0] = 1;
 
        for (int i = 0; i < m; i++) {
            for (int j = 1; j < n; j++) {
                dp[j] += dp[j - 1];
            }
        }
        return dp[n - 1];
    }
}

//or

class Solution {
    public int uniquePaths(int m, int n) {
        // We have to calculate m+n-2 C n-1 here
        // which will be (m+n-2)! / (n-1)! (m-1)!
        int path = 1;
        for (int i = n; i < (m + n - 1); i++) {
            path *= i;
            path /= (i - n + 1);
        }
        return path;
    }
}

