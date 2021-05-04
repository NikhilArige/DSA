/*Given N x M character matrix A of O's and X's, where O = white, X = black.
Return the number of black shapes. A black shape consists of one or more adjacent Xs (diagonals not included)
Input 1:
    A = [ OOOXOOO
          OOXXOXO
          OXOOOXO  ]
Output 1:
    3
Explanation:
    3 shapes are  :
    (i)    X
         X X
    (ii)
          X
    (iii)
          X
          X
Note: we are looking for connected shapes here. */

class Solution {
    public int black(List<string> A) {
        int rows = A.Count;
        int cols = A[0].Length;
        bool[,] visited= new bool[rows,cols];
        int count = 0;
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                if(!visited[i,j] && A[i][j]=='X'){
                    dfs(visited,A,i,j);
                    count++;
                }
            }
        }
        return count;
    }
    
    private void dfs(bool[,] visited,List<string> A,int i,int j){
        
        if(i<0 || i>=A.Count || j<0 || j>=A[0].Length || 
            visited[i,j] || A[i][j]!='X'){
                return;
            }
        visited[i,j] = true;
       dfs(visited,A,i+1,j);
       dfs(visited,A,i,j+1);
       dfs(visited,A,i-1,j);
       dfs(visited,A,i,j-1); 
    }
}
