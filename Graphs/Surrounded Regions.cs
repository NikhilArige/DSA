/* Given an m x n matrix board containing 'X' and 'O', capture all regions that are 4-directionally surrounded by 'X'.
A region is captured by flipping all 'O's into 'X's in that surrounded region.
Example 1:
Input: board = [["X","X","X","X"],["X","O","O","X"],["X","X","O","X"],["X","O","X","X"]]
Output: [["X","X","X","X"],["X","X","X","X"],["X","X","X","X"],["X","O","X","X"]]
Explanation: Surrounded regions should not be on the border, which means that any 'O' on the border of the board are not flipped to 'X'.
Any 'O' that is not on the border and it is not connected to an 'O' on the border will be flipped to 'X'. 
Two cells are connected if they are adjacent cells connected horizontally or vertically.
Example 2:
Input: board = [["X"]]
Output: [["X"]] */

public class Solution {
    public void Solve(char[][] board) {
        for(int i=0;i<board.Length;i++){
            if(board[i][0] == 'O') dfs(board,i,0);
            if(board[i][board[0].Length-1] == 'O') dfs(board,i,board[0].Length-1);
        }
        for(int j=0;j<board[0].Length;j++){
            if(board[0][j] == 'O') dfs(board,0,j);
            if(board[board.Length-1][j] == 'O') dfs(board,board.Length-1,j); 
        }
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[0].Length;j++){
                if(board[i][j] == 'O'){
                   board[i][j] = 'X' ;
                }
                if(board[i][j] == '#'){
                   board[i][j] = 'O' ;
                }
            }
        }
    }
    
    void dfs(char[][] board,int r,int c){
        
        if(r<0 || r>=board.Length || c<0 || c>=board[0].Length){
            return;
        }
        if(board[r][c] == 'O'){
           board[r][c] = '#'; 
        }
        if(r>0 && board[r-1][c] == 'O'){
            dfs(board,r-1,c);
        }
        if(c>0 && board[r][c-1] == 'O'){
            dfs(board,r,c-1);
        }
        if(c<board[0].Length-1 && board[r][c+1] == 'O'){
            dfs(board,r,c+1);
        } 
        if(r<board.Length-1 && board[r+1][c] == 'O'){
            dfs(board,r+1,c);
        }
        
    }
}

 
