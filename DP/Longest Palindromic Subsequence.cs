//Given a string A, find the common palindromic sequence ( A sequence which does not need to be contiguous and is a pallindrome), which is common in itself.
//You need to return the length of longest palindromic subsequence in A.
//A = "bebeeed" Output: 4  The longest common pallindromic subsequence is "eeee", which has a length of 4



class Solution {
    public int solve(string A) { 
        int n = A.Length;
        int[,] dp = new int[n,n];
        for(int i=0;i<n;i++){
            dp[i,i] = 1;              //if string is of length 1
        }
        for(int i=2;i<=n;i++){                         //<=n
            for(int j=0;j<n-i+1;j++){
                int k = i+j-1;
                if(i==2 && A[j]==A[k]){
                    dp[j,k] = 2;                       //if only two chars are there and they are same
                }
                else if(A[j]==A[k]){
                   dp[j,k] = dp[j+1,k-1] + 2;           //if two chars are same
                }
                else{
                    dp[j,k] = Math.Max(dp[j+1,k],dp[j,k-1]);   //normal
                }  
            } 
        }    
       return dp[0,n-1]; 
    }
}

// Take indices, string of length 1,length 2 and so on.. in matrix




