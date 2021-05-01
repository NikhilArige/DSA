/* Given a 2D binary matrix A of size  N x M  find the area of maximum size square sub-matrix with all 1's.
Example Input
Input 1:
 A = [

        [0, 1, 1, 0, 1],

        [1, 1, 0, 1, 0],

        [0, 1, 1, 1, 0],

        [1, 1, 1, 1, 0],

        [1, 1, 1, 1, 1],

        [0, 0, 0, 0, 0]
     ]
Input 2:
A = [

       [1, 1],
       [1, 1]
     ]
Example Output
Output 1:
 9
Output 2:
 4
Example Explanation
Explanation 1:
 Consider the below binary matrix.
 The area of the square is 3 * 3 = 9
Explanation 2:
The given matrix is the largest size square possible so area will be 2 * 2 = 4 */


class Solution {
    public int solve(List<List<int>> A) {
        
        int r = A.Count;
        int c = A[0].Count;
        int[,] dp = new int[r,c];
        
        for(int i=0;i<c;i++){
            dp[0,i] = A[0][i];
        }
        for(int j=0;j<r;j++){
            dp[j,0] = A[j][0];
        }
        
        int max = int.MinValue;
         
        for(int i=1;i<r;i++){
            for(int j=1;j<c;j++){
                
                if(A[i][j] == 1){
                   dp[i,j] = min(dp[i,j-1],dp[i-1,j],dp[i-1,j-1]) + 1;
                }
                else{
                    dp[i,j] = 0;
                }
                max = Math.Max(max,dp[i,j]);
            }
        }
        
        return max*max;
    }
     
    private int min(int a,int b,int c){
        
        return Math.Min((Math.Min(a,b)),(Math.Min(b,c)));
        
    }
}


