/*
Given an n x n binary matrix grid, return the length of the shortest clear path in the matrix. If there is no clear path, return -1.
A clear path in a binary matrix is a path from the top-left cell (i.e., (0, 0)) to the bottom-right cell (i.e., (n - 1, n - 1)) such that:
All the visited cells of the path are 0.
All the adjacent cells of the path are 8-directionally connected (i.e., they are different and they share an edge or a corner).
The length of a clear path is the number of visited cells of this path.
Example 1:
Input: grid = [[0,1],[1,0]]
Output: 2
Example 2:
Input: grid = [[0,0,0],[1,1,0],[1,1,0]]
Output: 4
Example 3:
Input: grid = [[1,0,0],[1,1,0],[1,1,0]]
Output: -1
*/

public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        var dir = new (int x,int y)[]{(0,1),(0,-1),(1,0),(-1,0),(-1,-1),(1,-1),(1,1),(-1,1)};
        int n = grid.Length;
        if(grid[0][0] == 1){return -1;} 
        var q = new Queue<(int x,int y)>();
        q.Enqueue((0,0)); 
        int res = 1;
        while(q.Any()){
            var cnt = q.Count;
            while(cnt-- > 0){
                var cur = q.Dequeue();
                if(cur.x == n-1 && cur.y== n-1){
                    return res;
                }
                foreach(var i in dir){
                    var newx = cur.x + i.x;
                    var newy = cur.y + i.y;
                    if(newx >=0 && newx < n && newy>=0 && newy < n && grid[newx][newy] == 0){
                        q.Enqueue((newx,newy));
                        grid[newx][newy] = -1;
                    }
                }
            }
            res++;
        }
        return -1;
    }
}
