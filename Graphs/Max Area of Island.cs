/*You are given an m x n binary matrix grid. An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) 
You may assume all four edges of the grid are surrounded by water.
The area of an island is the number of cells with a value 1 in the island.
Return the maximum area of an island in grid. If there is no island, return 0.
Example 1:
Input: grid = [[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]
Output: 6
Explanation: The answer is not 11, because the island must be connected 4-directionally. */

public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        
        int max = 0;
        if(grid == null || grid.Length ==0){
            return max;
        }
        int rows = grid.Length;
        int columns = grid[0].Length;
        bool[,] check = new bool[rows,columns];
        for(int i = 0;i<rows;i++){
            for(int j = 0;j<columns;j++){
                if(!check[i,j] && grid[i][j]==1){
                    max = Math.Max(dfs(i,j,grid,check),max);
                }
            }
            
        }
        return max;
    }
    
    private int dfs(int i,int j,int[][] grid,bool[,] check){
        if(i<0 || j<0 || i>=grid.Length || j>=grid[0].Length ||
          grid[i][j]==0 || check[i,j]){
            return 0;
        }
        check[i,j] = true;
        return 1 + dfs(i,j+1,grid,check) +  dfs(i,j-1,grid,check) + dfs(i+1,j,grid,check)
                 + dfs(i-1,j,grid,check);
        
    }
    
}
