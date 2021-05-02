/*Given a 2 x N grid of integer, A, choose numbers such that the sum of the numbers
is maximum and no two chosen numbers are adjacent horizontally, vertically or diagonally, and return it.
Note: You can choose more than 2 numbers.
Input Format:
The first and the only argument of input contains a 2d matrix, A.
Output Format:
Return an integer, representing the maximum possible sum.
Constraints:
1 <= N <= 20000
1 <= A[i] <= 2000
Example:
Input 1:
    A = [   [1]
            [2]    ]
Output 1:
    2
Explanation 1:
    We will choose 2.
Input 2:
    A = [   [1, 2, 3, 4]
            [2, 3, 4, 5]    ]
Output 2:
    We will choose 3 and 5. */
    

class Solution {
    public int adjacent(List<List<int>> A) { 
        int n=A[0].Count; //col count
        if(n==1){
            return Math.Max(A[0][0],A[1][0]);
        } 
        int[]dp = new int[n];
        dp[0]=Math.Max(A[0][0],A[1][0]);
        dp[1]=Math.Max(dp[0],Math.Max(A[0][1],A[1][1]));
        for(int i=2;i<n;i++)
        {
          dp[i]=Math.Max(dp[i-1],Math.Max(A[0][i],A[1][i])+dp[i-2]);
          //if not from current => dp[i-1]
          //if current => Math.Max(A[0][i],A[1][i])+dp[i-2]
        }
        return dp[n-1]; 
    }
}
