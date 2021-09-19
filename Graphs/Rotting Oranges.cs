/*
You are given an m x n grid where each cell can have one of three values:
0 representing an empty cell,
1 representing a fresh orange, or
2 representing a rotten orange.
Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.
Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.
Example 1:
Input: grid = [[2,1,1],[1,1,0],[0,1,1]]
Output: 4
Example 2:
Input: grid = [[2,1,1],[0,1,1],[1,0,1]]
Output: -1
Explanation: The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
Example 3:
Input: grid = [[0,2]]
Output: 0
Explanation: Since there are already no fresh oranges at minute 0, the answer is just 0.
*/

public class Solution {
    public int OrangesRotting(int[][] grid) {
       (int row, int column)[] directions = new (int, int)[]{ (1, 0), (0, 1), (-1, 0), (0, -1)};
        Queue<(int row, int column)> q = new Queue<(int, int)>();
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j< grid[0].Length;j++){
                if(grid[i][j] == 2){
                    q.Enqueue((i,j));
                }
            }
        }
        int min = 0;
        while(q.Count>0){
            int count = q.Count;
            for(int i=0;i<count;i++){
                
                var cell = q.Dequeue();
                foreach(var d in directions)
			    {
				    int newRow = cell.row + d.row;
				    int newColumn = cell.column + d.column;

				    if(newRow >= 0 && newColumn >= 0 && newRow < grid.Length && newColumn <grid[0].Length
				    && grid[newRow][newColumn] == 1)
				    {
					    grid[newRow][newColumn] = 2;
					    q.Enqueue((newRow, newColumn));
				    }
			    }  
                
            }
            min++;
        }
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(grid[i][j] == 1){
                    return -1;
                }
            }
        }
        min = min>0 ? min-1 : 0 ;
        return min;
        
    }
}
