/*Given a binary matrix A of size N x M.
Cells which contain 1 are called filled cell and cell that contain 0 are called empty cell.
Two cells are said to be connected if they are adjacent to each other horizontally, vertically, or diagonally.
If one or more filled cells are also connected, they form a region. Find the length of the largest region.Input Format
First argument is a 2D binary matrix Aof size  N x M.
Example Input
Input 1:
 A = [  [0, 0, 1, 1, 0]
        [1, 0, 1, 1, 0]
        [0, 1, 0, 0, 0]
        [0, 0, 0, 0, 1]
    ]
Input 2:
 A = [  [1, 1, 1]
        [0, 0, 1]
    ]
Example Output
Output 1:6
Output 2:4
Example Explanation
Explanation 1:
 The largest region is denoted by red color in the matrix:
    00110
    10110
    01000
    00001
Explanation 2:
 The largest region is:
    111
    001 */

class Solution {
    public int solve(List<List<int>> A) {
        
        int rows = A.Count;
        int cols = A[0].Count;
        bool[,] visited = new bool[rows,cols];
        int res = int.MinValue;
        int val = 0;
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                if(A[i][j]== 1 && !visited[i,j]){
                    dfs(A,visited,i,j,ref val); 
                    res = Math.Max(res,val);
                    val = 0;
                }
            }
        }
        return res;
    }
    
    private void dfs(List<List<int>> A,bool[,] visited,int i,int j,ref int val){
        
        if(i<0 || j<0 || i>=A.Count || j>=A[0].Count || visited[i,j] || A[i][j]!=1){
            return;
        }
        visited[i,j]=true;
        val = val+1;
        dfs(A,visited,i+1,j,ref val);
        dfs(A,visited,i,j+1,ref val);
        dfs(A,visited,i-1,j,ref val);
        dfs(A,visited,i,j-1,ref val);
        dfs(A,visited,i+1,j+1,ref val);
        dfs(A,visited,i-1,j-1,ref val);
        dfs(A,visited,i+1,j-1,ref val);
        dfs(A,visited,i-1,j+1,ref val);
        
    }
}



