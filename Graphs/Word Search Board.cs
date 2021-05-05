/*Given a 2D board and a word, find if the word exists in the grid.
The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. 
The cell itself does not count as an adjacent cell.
The same letter cell may be used more than once.
Example :
Given board =
[
  ["ABCE"],
  ["SFCS"],
  ["ADEE"]
]
word = "ABCCED", -> returns 1,
word = "SEE", -> returns 1,
word = "ABCB", -> returns 1,
word = "ABFSAB" -> returns 1 
word = "ABCD" -> returns 0 */

class Solution {
    public int rows = 0;
    public int cols = 0;
    public bool exists = false;
    public int[] dx=new int[]{1,-1,0,0};
    public int[] dy=new int[]{0,0,1,-1};
    public int exist(List<string> A, string B) {
        rows = A.Count;
        cols = A[0].Length;
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                if(A[i][j]==B[0]){
                    dfs(1,i,j,A,B);
                }
            }
        } 
        if(exists){
            return 1;
        }
        else{
            return 0;
        }
    }
    
    private void dfs(int i,int x, int y,List<string>A, string B){
        
        if(exists){ 
            return;
        }
        if(i==B.Length){ 
            exists = true;
            return;
        } 
        for(int j=0;j<4;j++){ 
            int a = x+dx[j];
            int b = y+dy[j]; 
            if( a<0 || b<0 || a>=rows || b>= cols){
                continue;
            } 
            if(A[a][b]==B[i]){
                dfs(i+1,a,b,A,B);  
            }  
        }   
    }
}
