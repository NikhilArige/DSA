/*Say you have an array, A, for which the ith element is the price of a given stock on day i.
Design an algorithm to find the maximum profit. You may complete at most 2 transactions.
Return the maximum possible profit.
Note: You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).

Input 1: A = [1, 2, 1, 2] Output 1:2
Explanation 1: 
    Day 0 : Buy 
    Day 1 : Sell
    Day 2 : Buy
    Day 3 : Sell
Input 2: A = [7, 2, 4, 8, 7] Output 2:6
Explanation 2:
    Day 1 : Buy
    Day 3 : Sell */
    
    
   class Solution {
    public int maxProfit(List<int> prices) {
        
        int N = prices.Count;
        if(N==0){return 0;}
        if(N==1){return 0;}
        int[] left = new int[N];  
        int[] right = new int[N];
    
    int leftMin = prices[0];
    for(int i = 1; i<N; i++){
        left[i] = Math.Max(left[i-1], prices[i]-leftMin);
        leftMin = Math.Min(leftMin, prices[i]);
    }
    
    int rightMax = prices[N-1];
    for(int i = N-2; i>=0; i--){
        right[i] = Math.Max(right[i+1], rightMax-prices[i]);
        rightMax = Math.Max(rightMax, prices[i]);
    }
    
    // find max profit 
    int profit = right[0];
    for(int i = 1; i<N; i++){
        profit = Math.Max(profit, left[i-1]+right[i]); 
    }
    return profit;
    }
}


