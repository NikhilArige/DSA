/* According to Wikipedia's article: "The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970."
The board is made up of an m x n grid of cells, where each cell has an initial state: live (represented by a 1) or dead (represented by a 0). 
Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using the following four rules (taken from the above Wikipedia article):
Any live cell with fewer than two live neighbors dies as if caused by under-population.
Any live cell with two or three live neighbors lives on to the next generation.
Any live cell with more than three live neighbors dies, as if by over-population.
Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
The next state is created by applying the above rules simultaneously to every cell in the current state, where births and deaths occur simultaneously. 
Given the current state of the m x n grid board, return the next state.
Example 1:
Input: board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]
Output: [[0,0,0],[1,0,1],[0,1,1],[0,1,0]]
Example 2:
Input: board = [[1,1],[1,0]]
Output: [[1,1],[1,1]] */


public class Solution { 
    public void GameOfLife(int[][] board) {
        int[] dx = { 0, 1, -1, 1, 0, 1, -1, -1 };
        int[] dy = { -1, 0, 0, 1, 1, -1, 1, -1 }; 
        
        int m = board.Length;
        int n = board[0].Length;
        
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                int liveCount = 0;
                for(int k=0;k<8;k++){
                    int a = i+dx[k];
                    int b = j+dy[k];
                    if (a >= 0 && a < m && b >= 0 && b < n)
                        {
                            if (board[a][b] == 1 || board[a][b] == 3)
                            {
                                liveCount++;
                            }
                        }
                }
                
                //2 - dead to live
                //3 - live to dead
                
                 if (board[i][j] == 0) {
                        if (liveCount == 3){
                            board[i][j] = 2;
                        }
                        continue;
                    }

                    if (liveCount < 2){
                        board[i][j] = 3;
                        continue;
                    }

                    if (liveCount > 3)  {
                        board[i][j] = 3;
                    }
            }
        }
        
        for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == 2)
                    {
                        board[i][j] = 1;
                        continue;
                    }

                    if (board[i][j] == 3)
                    {
                        board[i][j] = 0;
                        continue;
                    }
                }
            }
    }
}

