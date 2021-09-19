/*
Given an m x n binary matrix mat, return the distance of the nearest 0 for each cell.
The distance between two adjacent cells is 1.
Example 1:
Input: mat = [[0,0,0],[0,1,0],[0,0,0]]
Output: [[0,0,0],[0,1,0],[0,0,0]]
Example 2:
Input: mat = [[0,0,0],[0,1,0],[1,1,1]]
Output: [[0,0,0],[0,1,0],[1,2,1]]
*/

public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
       int row = mat.Length;
       int col = mat[0].Length;
       var q = new Queue<int[]>();
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                if(mat[i][j]==0){
                    q.Enqueue(new int[]{i,j,0});
                }
                else{
                    mat[i][j] = -1;
                }
            }
        }
        while(q.Count >0){
            var temp = q.Dequeue();
            int r = temp[0],c = temp[1],closetZero = 1+ temp[2];
            if (r > 0 && mat[r - 1][c] == -1)                // top
            {
                mat[r - 1][c] = closetZero;
                q.Enqueue(new int[] { r - 1, c, closetZero });
            }
            if (r + 1 < row && mat[r + 1][c] == -1)          // bottom
            {
                mat[r + 1][c] = closetZero;
                q.Enqueue(new int[] { r + 1, c, closetZero });
            }
            if (c > 0 && mat[r][c - 1] == -1)                // left
            {
                mat[r][c - 1] = closetZero;
                q.Enqueue(new int[] { r, c - 1, closetZero });
            }
            if (c + 1 < col && mat[r][c + 1] == -1)          // right
            {
                mat[r][c + 1] = closetZero;
                q.Enqueue(new int[] { r, c + 1, closetZero });
            }
        }
        return mat;
    }
}
