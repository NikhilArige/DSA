//Given an integer A, how many structurally unique BST’s (binary search trees) exist that can store values 1…n?
//Input : n = 3 ; Output :5
//Explanation 1:
//   1         3     3      2      1
//    \       /     /      / \      \
//     3     2     1      1   3      2
//    /     /       \                 \
//   2     1         2                 3



class Solution {
    public int numTrees(int n) { 
        int[] dp = new int[n+1];
        dp[0] = 1;
        dp[1] = 1;
        for(int i=2; i <= n; i++){
            for(int j=0; j <i; j++){
                dp[i] += dp[j]*dp[i-j-1];   //nth Catalan number
            }
        }
        return dp[n]; 
    }
}
