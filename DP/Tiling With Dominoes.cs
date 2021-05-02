/* Given an integer A you have to find the number of ways to fill a 3 x A board with 2 x 1 dominoes.
Return the answer modulo 10^9 + 7 .
Example Input
Input 1:2
Input 2:1
Example Output
Output 1: 3
Output 2: 0
Example Explanation
Explanation 1:
Following are all the 3 possible ways to fill up a 3 x 2 board.
Explanation 2:
Not a even a single way exists to completely fill the grid of size 3 x 1. */

class Solution {
    public int solve(int n) {
        
        int mod = 1000000007;
        long[] A = new long[n+1];
        long[] B = new long[n+1];
        A[0] = 1; A[1] = 0;
        B[0] = 0; B[1] = 1;
        for (int i = 2; i <= n; i++) 
        {
            A[i] = (A[i - 2] + (2 * B[i - 1])%mod)%mod; 
            B[i] = (A[i - 1] + B[i - 2])%mod; 
        }
      
        return (int)A[n]%mod;
    }
}

/*When 2*n and 2*1 is given 
public int solve(int n) {
         
        int[] A = new int[n+1]; 
        A[1] = 1; A[2] = 2;
        for (int i = 3; i <= n; i++) 
        {
            A[i] = (A[i - 1] + A[i - 2]);
        }
      
        return A[n] ;
    }
*/

