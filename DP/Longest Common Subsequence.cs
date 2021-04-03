//Given two strings A and B. Find the longest common sequence ( A sequence which does not need to be contiguous), which is common in both the strings.
//You need to return the length of such longest common subsequence.
//A = "abbcdgf" B = "bbadcgf"  Output = 5;  The longest common subsequence is "bbcgf", which has a length of 5

class Solution {
    public int solve(string A, string B) {
        
        int m = A.Length;
        int n = B.Length;
        int[,] dp = new int[m+1,n+1];
        
        for(int i=0;i<=m;i++){ 
            for(int j=0;j<=n;j++){
                
                if(i==0 || j==0){ 
                    dp[i,j]=0;                                    //if only one string is there
                }
                else if(A[i-1]==B[j-1]){
                    dp[i,j]= 1 + dp[i-1,j-1];                     //if both chars are equal 
                }
                else{
                    dp[i,j] = Math.Max(dp[i-1,j],dp[i,j-1]);     //else
                }  
            }    
        }
        return dp[m,n];
    }
}

