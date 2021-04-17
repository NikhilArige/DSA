//Given an integer array A containing N integers.
//You need to divide the array A into two subsets S1 and S2 such that the absolute difference between their sums is minimum.
//Find and return this minimum possible absolute difference.
//NOTE:
//Subsets can contain elements from A in any order (not necessary to be contiguous).
//Each element of A should belong to any one subset S1 or S2, not both.
//It may be possible that one subset remains empty.
//A = [1, 6, 11, 5] Output:1
//Explanation:
//Subset1 = {1, 5, 6}, sum of Subset1 = 12
//Subset2 = {11}, sum of Subset2 = 11


class Solution {
    public int solve(List<int> A) {
        //solve as such in subset sum problem 
        int m = A.Count;
        int maxsum = 0;
        //n is max sum 
        foreach(var item in A){
            maxsum+=item;
        }
        int n = maxsum/2;
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
        //till here, we have table for subset sum till maxsum/2
        // now we need to consider and take min of maxsum-2(value of sum here if(dp[i,j])) till maxsum/2
        // Reason : consider, s1 and s2 as two subsets, we need to find min(Abs(s1-s2))
        //s1+s2 will be equal to maxsum , in order it to be min, s1 and s2 should be bery closer
        //now assume, s1 and s2 are equal which is best case, maxsum-2s1 will be ans
        int s1 = 0; 
        for(int i=n;i>=0;i--){
            if(dp[m,i]){
             s1 = i;                  //coming  from right 
             break;
            }
           //m means last row
        }
        int s2 = maxsum - s1;
        return Math.Abs(s2 - s1);
    }
}
