//Given a string A, find length of the longest repeating sub-sequence such that the two subsequence don’t have same string character at same position,
//i.e., any i’th character in the two subsequences shouldn’t have the same index in the original string.
//NOTE: Sub-sequence length should be greater than or equal to 2.
// A = "abab" Output : 1 

class Solution {
    public int anytwo(string A) {
        int n = A.Length; 
        int[,] dp = new int[n+1,n+1];
        
        for(int i=0;i<=n;i++){ 
            for(int j=0;j<=n;j++){
                
                if(i==0 || j==0){ 
                    dp[i,j]=0;               
                }
                //same as LCS except i!=j
                else if(A[i-1]==A[j-1] && (i!=j)){    
                    dp[i,j]= 1 + dp[i-1,j-1];
                }
                else{
                    dp[i,j] = Math.Max(dp[i-1,j],dp[i,j-1]);     
                }  
            }    
        }
        if (dp[n,n]>1){       //dp[n,n]=max LRS
            return 1;
        }
        else{
            return 0;
        }

    }
}
