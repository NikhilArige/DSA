//Given two strings A and B, find the minimum number of steps required to convert A to B. (each operation is counted as 1 step.)
//You have the following 3 operations permitted on a word:
//Insert a character
//Delete a character
//Replace a character
//Example : A = "Anshuman" B = "Antihuman" Output= 2 
//Explanation 
//   => Operation 1: Replace s with t.
//   => Operation 2: Insert i.

class Solution {
    public int minDistance(string A, string B) {
        
        int a = A.Length;
        int b = B.Length;
        
        int[,] dp = new int[a+1,b+1];
        
        for(int i=0;i<=a;i++){
            
            for(int j=0;j<=b;j++){
                
                if(i==0){
                    dp[0,j] = j;                                        //if only B is given
                }
                else if(j==0){
                    dp[i,0] = i;                                       //if only A is given
                } 
                else if(A[i-1]==B[j-1]){ 
                    dp[i,j]=dp[i-1,j-1];                               //if both chars match, take min of i-1,j-1
                }
                else{
                    dp[i,j]= 1 + min(dp[i-1,j],dp[i-1,j-1],dp[i,j-1]);   //min of remove,replace,insert
                }
            } 
        } 
       return dp[a,b]; 
    }
    
    public int min(int a,int b,int c){       
        return Math.Min(Math.Min(a,b),Math.Min(b,c));
    }
}
