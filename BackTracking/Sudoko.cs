/* Write a program to solve a Sudoku puzzle by filling the empty cells.
A sudoku solution must satisfy all of the following rules:
Each of the digits 1-9 must occur exactly once in each row.
Each of the digits 1-9 must occur exactly once in each column.
Each of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.
The '.' character indicates empty cells.
Example 1:
Input: board = [["5","3",".",".","7",".",".",".","."],["6",".",".","1","9","5",".",".","."],[".","9","8",".",".",".",".","6","."],["8",".",".",".","6",".",".",".","3"],["4",".",".","8",".","3",".",".","1"],["7",".",".",".","2",".",".",".","6"],[".","6",".",".",".",".","2","8","."],[".",".",".","4","1","9",".",".","5"],[".",".",".",".","8",".",".","7","9"]]
Output: [["5","3","4","6","7","8","9","1","2"],["6","7","2","1","9","5","3","4","8"],["1","9","8","3","4","2","5","6","7"],["8","5","9","7","6","1","4","2","3"],["4","2","6","8","5","3","7","9","1"],["7","1","3","9","2","4","8","5","6"],["9","6","1","5","3","7","2","8","4"],["2","8","7","4","1","9","6","3","5"],["3","4","5","2","8","6","1","7","9"]]
Explanation: The input board is shown above and the only valid solution is shown below:
Constraints:
board.length == 9
board[i].length == 9
board[i][j] is a digit or '.'.
It is guaranteed that the input board has only one solution.*/


public class Solution {
    public void SolveSudoku(char[][] board) {
        
        solSudoku(board,9); 
    }
    
    private bool solSudoku(char[][] board, int n)
    {
        int row = -1;
        int col = -1;
        bool isEmpty = true;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == '.')
                {
                    row = i;
                    col = j;
 
                    //still missing values are there
                    isEmpty = false;
                    break;
                }
            }
            if (!isEmpty)
            {
                break;
            }
        }
 
        // all are filed
        if (isEmpty)
        {
            return true;
        }
  
        for (int num = 1; num <= n; num++)
        { 
            if (isValid(row, col,(char)(num+48),board))   //num+48 converts int 1 to char '`'
            {
                board[row][col] = (char)(num+48);
                if (solSudoku(board, n))
                { 
                    return true;
                }
                else
                { 
                    board[row][col] = '.';
                }
            }
        }
        return false;
    }
     
    
    private bool isValid(int row,int col,char ch,char[][] board){
        
        //for row
        for(int i=0;i<9;i++){
            if(board[row][i]== ch){
                return false;
            }
        }
         //for col
         for(int j=0;j<9;j++){
            if(board[j][col]== ch){
                return false;
            }
        }
        
        //for sub boxes
        int boxRowStart = row - row % 3; // 3 => size of submatrix
        int boxColStart = col - col % 3;
 
        for (int r = boxRowStart; r < boxRowStart + 3; r++)
        {
            for (int d = boxColStart; d < boxColStart + 3; d++)
            {
                if (board[r][d] == ch)
                {
                    return false;
                }
            }
        }
        
        return true;
    }
    
}
