//Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
//An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
//Input: grid = [
//  ["1","1","1","1","0"],
//  ["1","1","0","1","0"],
//  ["1","1","0","0","0"],
//  ["0","0","0","0","0"]
//]
//Output: 1



public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid == null || grid.Length == 0){
            return 0;
        }
        //not as such in c#
        int rows = grid.Length;
        int columns = grid[0].Length;
        bool[,] check = new bool[rows,columns];
        int count = 0;
        for(int i = 0;i<rows;i++){
            for(int j = 0;j<columns;j++){
                if(!check[i,j] && grid[i][j]=='1'){
                    dfs(i,j,grid,check);
                    count++;
                }
            }
            
        }
        return count;
    }
    public void dfs(int i,int j,char[][] grid,bool[,] check){
        
        if(i<0 || j<0 || i>=grid.Length || j>=grid[0].Length ||
          grid[i][j]=='0' || check[i,j]){
            return;
        }
        check[i,j] = true;
        dfs(i,j+1,grid,check);
        dfs(i,j-1,grid,check);
        dfs(i+1,j,grid,check);
        dfs(i-1,j,grid,check);
         
    }
}


