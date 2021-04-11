//You are given a set of coins S. In how many ways can you make sum N assuming you have infinite amount of each coin in the set.
//Note : Coins in set S will be unique. Expected space complexity of this problem is O(N).
//Input : S = [1, 2, 3] N = 4 Return : 4
//Explanation : The 4 possible ways are {1, 1, 1, 1},{1, 1, 2},{2, 2},{1, 3}	


class Solution {
    public int coinchange2(List<int> A, int n) {
    int m = A.Count;    
    int[] dp = new int[n + 1];
      
    dp[0] = 1;
 
    // Pick all coins one by one and
    // update the table[] values after
    // the index greater than or equal
    // to the value of the picked coin
    for(int i = 0; i < m; i++)
        for(int j = A[i]; j <= n; j++){
            dp[j] += (dp[j - A[i]])%1000007; 
        } 
    return dp[n]%1000007;
    }
}
