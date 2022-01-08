/*
You are given a rows x cols matrix grid representing a field of cherries where grid[i][j] represents the number of cherries that you can collect from the (i, j) cell.
You have two robots that can collect cherries for you:
Robot #1 is located at the top-left corner (0, 0), and
Robot #2 is located at the top-right corner (0, cols - 1).
Return the maximum number of cherries collection using both robots by following the rules below:
From a cell (i, j), robots can move to cell (i + 1, j - 1), (i + 1, j), or (i + 1, j + 1).
When any robot passes through a cell, It picks up all cherries, and the cell becomes an empty cell.
When both robots stay in the same cell, only one takes the cherries.
Both robots cannot move outside of the grid at any moment.
Both robots should reach the bottom row in grid.
Example 1:
Input: grid = [[3,1,1],[2,5,1],[1,5,5],[2,1,1]]
Output: 24
Explanation: Path of robot #1 and #2 are described in color green and blue respectively.
Cherries taken by Robot #1, (3 + 2 + 5 + 2) = 12.
Cherries taken by Robot #2, (1 + 5 + 5 + 1) = 12.
Total of cherries: 12 + 12 = 24.
Example 2:
Input: grid = [[1,0,0,0,0,0,1],[2,0,0,0,0,3,0],[2,0,9,0,0,0,0],[0,3,0,5,4,0,0],[1,0,2,3,0,0,6]]
Output: 28
Explanation: Path of robot #1 and #2 are described in color green and blue respectively.
Cherries taken by Robot #1, (1 + 9 + 5 + 2) = 17.
Cherries taken by Robot #2, (1 + 3 + 4 + 3) = 11.
Total of cherries: 17 + 11 = 28.
*/


public class Solution {
    public int CherryPickup(int[][] grid) {
        
        int r = grid.Length;
        int c = grid[0].Length;
        var dp = new int[r,c,c]; 
        return GetSum(dp,grid,0,0,c-1);
    }
    
    int GetSum(int[,,] dp,int[][] grid,int r,int c1,int c2){
        if (r >= grid.Length || c1 < 0 || c2 < 0 || c1 >= grid[0].Length || c2 >= grid[0].Length) {               
            return 0 ; 
        }
        if(dp[r,c1,c2] != 0){
            return dp[r,c1,c2] == -1 ? 0 : dp[r,c1,c2];
        }
        int result = 0;
        
        int collected = grid[r][c1];
        if (c1 != c2) { 
            collected += grid[r][c2];
        }
        if(r < grid.Length-1){
            int crnt = 0; 
            for(int i=c1-1; i<= c1+1; i++)
            {
                for(int j=c2-1; j<=c2+1; j++)
                {
                    crnt = GetSum(dp,grid,r+1, i, j);
                    result = Math.Max(crnt,result);
                }
            }
        }
        dp[r,c1,c2] = collected + result;
        if(dp[r,c1,c2] == 0){
             dp[r,c1,c2] = -1 ;
        }
        return dp[r,c1,c2] == -1 ? 0 : dp[r,c1,c2];
    }
}
