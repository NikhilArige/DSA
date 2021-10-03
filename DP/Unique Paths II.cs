/*
A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
Now consider if some obstacles are added to the grids. How many unique paths would there be?
An obstacle and space is marked as 1 and 0 respectively in the grid.
Example 1:
Input: obstacleGrid = [[0,0,0],[0,1,0],[0,0,0]]
Output: 2
Explanation: There is one obstacle in the middle of the 3x3 grid above.
There are two ways to reach the bottom-right corner:
1. Right -> Right -> Down -> Down
2. Down -> Down -> Right -> Right
Example 2:
Input: obstacleGrid = [[0,1],[0,0]]
Output: 1
*/

public class Solution {
    public int UniquePathsWithObstacles(int[][] A) {
        
        var m = A.Length;
        var n = A[0].Length;
        var dp = new int[m,n];
        if(A[0][0]==1 || A[m-1][n-1]==1) return 0;
        dp[0,0] = 1;
        for(int i=1;i<n;i++){ 
            dp[0,i] = (A[0][i]==1) ? 0 : dp[0,i-1] ;
        }
         for(int i=1;i<m;i++){
             dp[i,0] = (A[i][0]==1) ? 0 : dp[i-1,0] ;
        }
        for(int i=1;i<m;i++){
            for(int j=1;j<n;j++){
                if(A[i][j] != 1){
                   dp[i,j] = dp[i-1,j]+dp[i,j-1]; 
                }
            }
        }
        return dp[m-1,n-1];
    }
}
