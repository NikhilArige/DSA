//Given an integer array A of size N.
//You are also given an integer B, you need to find whether their exist a subset in A whose sum equal B.
//If there exist a subset then return 1 else return 0.
//A = [3, 34, 4, 12, 5, 2] B = 9 Output:1
//A = [3, 34, 4, 12, 5, 2] B = 30 Output:0

class Solution {
    public int solve(List<int> A, int B) {
        
        int m = A.Count();
        int n = B;
        //A elements(rows) vs numbers from 0 to B(sum)
        bool[,] dp = new bool[m+1,n+1];
        for(int i=0;i<=m;i++){
            //when sum= 0,we can form a subset-{} 
            dp[i,0]=true; 
        }
        for(int j=1;j<=n;j++){
            //when no elements are there 
            dp[0,j]=false; 
        }
        for(int i=1;i<=m;i++){
            for(int j=1;j<=n;j++){
                if(j<A[i-1]){
                 dp[i,j] = dp[i-1,j];
                }
                if (j >= A[i - 1]){
                dp[i,j] = (dp[i-1,j]  || dp[i-1,(j-A[i-1])]);
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

