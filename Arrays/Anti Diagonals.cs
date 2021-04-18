/*Give a N*N square matrix, return an array of its anti-diagonals. Look at the example for more details.
Example:
Input: 	
1 2 3
4 5 6
7 8 9
Return the following :
[ 
  [1],
  [2, 4],
  [3, 5, 7],
  [6, 8],
  [9]
]*/


class Solution {
    public List<List<int>> diagonal(List<List<int>> A) {
        
        int[,] mat = new int[A.Count,A[0].Count];
        
         int N = A.Count;
         for(int i=0;i<N;i++){
             for(int j=0;j<N;j++){
              mat[i,j]=A[i][j];
             } 
         }
        List<List<int>> result = new List<List<int>>(); 
        //till big diagonal
        for (int col = 0; col < N; col++) {
            int startcol = col, startrow = 0;
            List<int> res = new List<int>();
            while (startcol >= 0 && startrow < N) {
                res.Add(mat[startrow, startcol]); 
                startcol--;
                startrow++;
            }
            result.Add(new List<int>(res));
        }
        //after big diagonal
        for (int row = 1; row < N; row++) {
            int startrow = row, startcol = N - 1;
              List<int> res = new List<int>(); 
            while (startrow < N && startcol >= 0) {
                res.Add(mat[startrow, startcol]); 
                startcol--;
                startrow++;
            }
              result.Add(new List<int>(res));
        }
        return result;
    }
}

//or

class Solution {
    public List<List<int>> diagonal(List<List<int>> A) {
        int n = A.Count;
        int N = 2 * n - 1;
        List<List<int>> result = new List<List<int>>();
        for (int i = 0; i < N; i++)
        {
            result.Add(new List<int>());
        } 
        // Push each element in the result vector
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                result[i + j].Add(A[i][j]);
        return result;
    }
}


