//You are climbing a stair case and it takes A steps to reach to the top.
//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
//Input = 2 Output = 2 Explanation :[1, 1], [2] 
//Input = 3 Output = 3 Explanation : [1 1 1], [1 2], [2 1]


class Solution {
    public int climbStairs(int n) { 
        int[]dp= new int[n+1];
        dp[0]=dp[1]=1;
        if(n==1){return 1;}
        for(int i=2;i<n+1;i++){
             dp[i]=dp[i-1]+dp[i-2];   //FIBONACCI SERIES
        }
        return dp[n];
    }
}
