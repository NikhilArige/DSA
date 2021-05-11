/*Given an array of integers A of size N in which ith element is the price of the stock on day i.
You can complete atmost B transactions.
Find the maximum profit you can achieve.
NOTE: You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
Example Input
Input 1:
 A = [2, 4, 1]
 B = 2
Input 2:
 A = [3, 2, 6, 5, 0, 3]
 B = 2
Example Output
Output 1: 2
Output 2: 7
Example Explanation
Explanation 1:
 Buy on day 1 (price = 2) and sell on day 2 (price = 4), 
 Profit = 4 - 2 = 2
Explanation 2:
 Buy on day 2 (price = 2) and sell on day 3 (price = 6), profit = 6 - 2 = 4.
 Then buy on day 5 (price = 0) and sell on day 6 (price = 3), profit = 3 - 0 = 3. */
 
 class Solution {
    public int solve(List<int> prices, int K) {
        
        
        if (K == 0 || prices.Count == 0) {
            return 0;
        }
        
        //if K increase number of days
        K =  Math.Min(K,prices.Count);
        
        int[,] T = new int[K+1,prices.Count];

        for (int i = 1; i <= K; i++) {
            int maxDiff = -prices[0];//-prices[0] is useful in i=1,j=1 first tranction
            for (int j = 1; j < prices.Count; j++) {
                T[i,j] = Math.Max(T[i,j-1], prices[j] + maxDiff);
                maxDiff = Math.Max(maxDiff, T[i-1,j] - prices[j]);
            }
        } 
        return T[K,prices.Count-1];
    } 
}
