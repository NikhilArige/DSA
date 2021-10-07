/*
There is an m x n rectangular island that borders both the Pacific Ocean and Atlantic Ocean.
The Pacific Ocean touches the island's left and top edges, and the Atlantic Ocean touches the island's right and bottom edges.
The island is partitioned into a grid of square cells. 
You are given an m x n integer matrix heights where heights[r][c] represents the height above sea level of the cell at coordinate (r, c).
The island receives a lot of rain, and the rain water can flow to neighboring cells directly north, south, east,
and west if the neighboring cell's height is less than or equal to the current cell's height. Water can flow from any cell adjacent to an ocean into the ocean.
Return a 2D list of grid coordinates result where result[i] = [ri, ci] denotes that rain water can flow from cell (ri, ci) to both the Pacific and Atlantic oceans.
Example 1:
Input: heights = [[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]
Output: [[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]
Example 2:
Input: heights = [[2,1],[1,2]]
Output: [[0,0],[0,1],[1,0],[1,1]]
*/

public class Solution {
    
    int[] dx = new int[]{0,1,0,-1};    
    int[] dy = new int[]{1,0,-1,0};

    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        
        var res = new List<IList<int>>();
        int row = heights.Length;
        int col = heights[0].Length;
        var pacific = new bool[row,col];
        var atlantic = new bool[row,col];
        
        for(int i=0;i<col;i++){
           dfs(0,i,heights,pacific,int.MinValue);
           dfs(row-1,i,heights,atlantic,int.MinValue);
        }
        
        for(int i=0;i<row;i++){
           dfs(i,0,heights,pacific,int.MinValue);
           dfs(i,col-1,heights,atlantic,int.MinValue);
        }
        
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                if(pacific[i,j] && atlantic[i,j]){
                    res.Add(new List<int>{i,j});
                }
            }
        }
        return res;
    }
    
    void dfs(int r,int c,int[][] heights,bool[,] ocean,int prev){
        if(r<0 || r>=heights.Length || c<0 || c>=heights[0].Length 
           || heights[r][c]< prev || ocean[r,c] ){
            return;
        }
         ocean[r,c] = true;
        for(int i=0;i<4;i++){
            dfs(r+dx[i],c+dy[i],heights,ocean,heights[r][c]);
        }
    }
}
