/*
Let's play the minesweeper game (Wikipedia, online game)!
You are given an m x n char matrix board representing the game board where:
'M' represents an unrevealed mine,
'E' represents an unrevealed empty square,
'B' represents a revealed blank square that has no adjacent mines (i.e., above, below, left, right, and all 4 diagonals),
digit ('1' to '8') represents how many mines are adjacent to this revealed square, and
'X' represents a revealed mine.
You are also given an integer array click where click = [clickr, clickc] represents the next click position among all the unrevealed squares ('M' or 'E').
Return the board after revealing this position according to the following rules:
If a mine 'M' is revealed, then the game is over. You should change it to 'X'.
If an empty square 'E' with no adjacent mines is revealed, then change it to a revealed blank 'B' and all of its adjacent unrevealed squares should be revealed recursively.
If an empty square 'E' with at least one adjacent mine is revealed, then change it to a digit ('1' to '8') representing the number of adjacent mines.
Return the board when no more squares will be revealed.
Example 1:
Input: board = [["E","E","E","E","E"],["E","E","M","E","E"],["E","E","E","E","E"],["E","E","E","E","E"]], click = [3,0]
Output: [["B","1","E","1","B"],["B","1","M","1","B"],["B","1","1","1","B"],["B","B","B","B","B"]]
Example 2:
Input: board = [["B","1","E","1","B"],["B","1","M","1","B"],["B","1","1","1","B"],["B","B","B","B","B"]], click = [1,2]
Output: [["B","1","E","1","B"],["B","1","X","1","B"],["B","1","1","1","B"],["B","B","B","B","B"]]
*/

public class Solution {
    
    int[] dx = new int[]{0,0,1,-1,-1,1,-1,1};
    int[] dy = new int[]{1,-1,0,0,-1,1,1,-1};
    public char[][] UpdateBoard(char[][] board, int[] click) {
        
        int row = board.Length;
        int col = board[0].Length;
        int r = click[0],c = click[1];
        if(board[r][c] == 'M' || board[r][c] == 'X'){
            board[r][c] = 'X';
            return board;
        }
        int cnt = 0;
        for(int i=0;i<8;i++){
            var newrow = r + dx[i];
            var newcol = c + dy[i];
            if(newrow>=0 && newrow < row && newcol>=0 && newcol < col 
               && board[newrow][newcol] == 'M' ){
                cnt++;
            }
        }
        
        if(cnt>0){
            board[r][c] = (char)(cnt+'0'); 
            return board;
        }
        board[r][c] = 'B';
        for(int i=0;i<8;i++){
            var newrow = r + dx[i];
            var newcol = c + dy[i];
            if(newrow>=0 && newrow < row && newcol>=0 && newcol < col 
              && board[newrow][newcol] == 'E'){
                UpdateBoard(board,new int[]{newrow,newcol});
            }
        }
        return board;
    }
}
