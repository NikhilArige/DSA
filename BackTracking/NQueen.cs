/*
The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.
Given an integer n, return all distinct solutions to the n-queens puzzle. You may return the answer in any order.
Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.
Example 1:
Input: n = 4
Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
Explanation: There exist two distinct solutions to the 4-queens puzzle as shown above
Example 2:
Input: n = 1
Output: [["Q"]]
*/

public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        
        var res = new List<IList<string>>();
        char[][] board = new char[n][];
        for (int i = 0; i < n; i++)
        {
          board[i] = new char[n];
          Array.Fill(board[i], '.');
        } 
        
        Fill(res,board,0);
        return res;
    }
    
    void Fill(IList<IList<string>> res,char[][] board, int col)
    {
        if(col>=board.Length){
            var list = new List<string>();
        for (int i = 0; i < board.Length; i++)
        {
          var s = new string(board[i]);
          list.Add(s);
        }
        res.Add((list));
        return;
        }
        
        for(int i=0;i<board.Length;i++){
            
            if(IsSafe(board,i,col)){
                
                board[i][col] = 'Q';
                
                Fill(res,board,col+1);
                
                board[i][col]= '.';
            }
            
        }
    }
    
    
    bool IsSafe(char[][] board,int row,int col)
    {
        int i,j;
        for(i=0;i<col;i++)
        {
            if(board[row][i]=='Q'){return false;}
        }
        for(i=row,j=col;i>=0&&j>=0;i--,j--)
        {
            if(board[i][j]=='Q'){return false;}
        }
        for(i=row,j=col;i<board.Length && j>=0;i++,j--)
        {
            if(board[i][j]=='Q'){return false;}
        }
        return true;
    }
}
