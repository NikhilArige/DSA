/*
You are given an m x n integer array grid where grid[i][j] could be:
1 representing the starting square. There is exactly one starting square.
2 representing the ending square. There is exactly one ending square.
0 representing empty squares we can walk over.
-1 representing obstacles that we cannot walk over.
Return the number of 4-directional walks from the starting square to the ending square, that walk over every non-obstacle square exactly once.
Example 1:
Input: grid = [[1,0,0,0],[0,0,0,0],[0,0,2,-1]]
Output: 2
Explanation: We have the following two paths: 
1. (0,0),(0,1),(0,2),(0,3),(1,3),(1,2),(1,1),(1,0),(2,0),(2,1),(2,2)
2. (0,0),(1,0),(2,0),(2,1),(1,1),(0,1),(0,2),(0,3),(1,3),(1,2),(2,2)
Example 2:
Input: grid = [[1,0,0,0],[0,0,0,0],[0,0,0,2]]
Output: 4
Explanation: We have the following four paths: 
1. (0,0),(0,1),(0,2),(0,3),(1,3),(1,2),(1,1),(1,0),(2,0),(2,1),(2,2),(2,3)
2. (0,0),(0,1),(1,1),(1,0),(2,0),(2,1),(2,2),(1,2),(0,2),(0,3),(1,3),(2,3)
3. (0,0),(1,0),(2,0),(2,1),(2,2),(1,2),(1,1),(0,1),(0,2),(0,3),(1,3),(2,3)
4. (0,0),(1,0),(2,0),(2,1),(1,1),(0,1),(0,2),(0,3),(1,3),(1,2),(2,2),(2,3)
*/

public class Solution {
    public int UniquePathsIII(int[][] grid) {
        
        int count = 0;
        int row=0,col=0;
        int zeroes = 1;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(grid[i][j]==1){
                    row=i;col=j;
                }
                else if(grid[i][j]==0){
                    zeroes++;
                }
            }
        }
        dfs(grid,row,col,zeroes,ref count);
        
        return count;
    }
     
    void dfs(int[][] grid,int row,int col,int zeroesCount,ref int cnt){
      
        if(row<0 || row>=grid.Length || col<0 || col>=grid[0].Length || grid[row][col]==-1){
            return;
        }
        if(grid[row][col]==2){
            if(zeroesCount == 0){
                cnt++;
            }
            return;
        }
          grid[row][col] = -1;
          
          dfs(grid,row+1,col,zeroesCount-1,ref cnt);
          dfs(grid,row-1,col,zeroesCount-1,ref cnt);
          dfs(grid,row,col+1,zeroesCount-1,ref cnt);
          dfs(grid,row,col-1,zeroesCount-1,ref cnt);
        
          grid[row][col] = 0;
     }
    
}
