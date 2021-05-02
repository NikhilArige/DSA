/* Given A, B, C, find whether C is formed by the interleaving of A and B.
Input Format:*
The first argument of input contains a string, A.
The second argument of input contains a string, B.
The third argument of input contains a string, C.
Output Format:
Return an integer, 0 or 1:
    => 0 : False
    => 1 : True
Constraints:
1 <= length(A), length(B), length(C) <= 150
Examples:
Input 1:
    A = "aabcc"
    B = "dbbca"
    C = "aadbbcbcac"
Output 1: 1    
Explanation 1:
    "aa" (from A) + "dbbc" (from B) + "bc" (from A) + "a" (from B) + "c" (from A)
Input 2:
    A = "aabcc"
    B = "dbbca"
    C = "aadbbbaccc"
Output 2: 0
Explanation 2:
    It is not possible to get C by interleaving A and B. */


class Solution {
    public int isInterleave(string A, string B, string C) {
        
        int m = A.Length;
        int n = B.Length;
        int t = C.Length;
        if(m+n!=t){
            return 0;
        }
        
        bool[,] dp = new bool[m+1,n+1];
        
        for(int i=0;i<=m;i++){
            for(int j=0;j<=n;j++){
             int l = i + j -1; //position in C
                if(i == 0 && j == 0){
                    dp[i,j] = true;
                }
                //only with one string
                else if(i == 0){
                    if(C[l] == B[j-1]){
                        dp[i,j] = dp[i,j-1];
                    }
                }
                //only with one string
                else if(j == 0){
                    if(C[l] == A[i-1]){
                        dp[i,j] = dp[i-1,j];
                    }
                }   
                //either of 'em
                else{
                    bool val1 = C[l]==A[i-1]?dp[i-1,j] :false;
                    bool val2 = C[l]==B[j-1]?dp[i,j-1] :false;
                    dp[i,j] =  val1 || val2;
                }
            }
        }
        if(dp[m,n]){
            return 1;
        }
        else{
            return 0;
        }
    }
}
