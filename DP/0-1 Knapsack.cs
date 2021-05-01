/*Given two integer arrays A and B of size N each which represent values and weights associated with N items respectively.
Also given an integer C which represents knapsack capacity.
Find out the maximum value subset of A such that sum of the weights of this subset is smaller than or equal to C.
NOTE:
You cannot break an item, either pick the complete item, or don’t pick it (0-1 property).
Example Input
Input 1:
 A = [60, 100, 120]
 B = [10, 20, 30]
 C = 50
Input 2:
 A = [10, 20, 30, 40]
 B = [12, 13, 15, 19]
 C = 10
Example Output
Output 1: 220
Output 2: 0
Example Explanation
Explanation 1:
 Taking items with weight 20 and 30 will give us the maximum value i.e 100 + 120 = 220
Explanation 2:
 Knapsack capacity is 10 but each item has weight greater than 10 so no items can be considered in the knapsack therefore answer is 0.*/

class Solution {     
                    //values       //weights
    public int solve(List<int> A, List<int> B, int W) {
        
        int n = A.Count; 
        
        int[,] dp = new int[n+1,W+1];
        
        for(int i=0;i<=n;i++){
            for(int w=0;w<=W;w++){
                
                if(i==0 || w==0){
                    dp[i,w] = 0;
                }
                else if (B[i-1]<=w){
                              //if not picked = dp[i-1,j]
                              //if picked = A[i-1]+dp[i-1,w-B[i-1]]
                    dp[i,w] = Math.Max(dp[i-1,w],(A[i-1]+dp[i-1,w-B[i-1]]));
                    
                }
                else{
                    dp[i,w] = dp[i-1,w];
                }
            }
        }
        return dp[n,W];
    }
}
