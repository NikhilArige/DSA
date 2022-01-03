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
    


public class Solution {
    public int MaxProfit(int[] prices) {
        
        var oneBuy = int.MaxValue;
        var oneBuyAndSell = 0;
        var twoBuy = int.MaxValue;
        var twoBuyAndSell = 0;
        for(int i=0;i<prices.Length;i++)
        {
            var curPrice = prices[i];
            oneBuy = Math.Min(oneBuy,curPrice);
            oneBuyAndSell = Math.Max(oneBuyAndSell,curPrice-oneBuy);
            twoBuy = Math.Min(twoBuy, curPrice - oneBuyAndSell);
            twoBuyAndSell = Math.Max(twoBuyAndSell, curPrice - twoBuy); 
        }
        return twoBuyAndSell;
    }
}
    



    class Solution {
    public int maxProfit(List<int> price) {
        
        int n = price.Count;
        if(n==0){return 0;} 
        
        int[] profit = new int[n];
        for (int i = 0; i < n; i++){
            profit[i] = 0;
        }
 
        /* Get the maximum profit with only
        one transaction allowed. After this
        loop, profit[i] contains maximum
        profit from price[i..n-1] using at
        most one trans. */
        int max_price = price[n - 1];
 
        for (int i = n - 2; i >= 0; i--) {
 
            // max_price has maximum of
            // price[i..n-1]
            max_price=Math.Max(price[i],max_price); 
            // we can get profit[i] by taking
            // maximum of:
            // a) previous maximum, i.e.,
            // profit[i+1]
            // b) profit by buying at price[i]
            // and selling at max_price
            profit[i] = Math.Max(profit[i + 1],
                                 max_price - price[i]);
        }
 
        /* Get the maximum profit with two
        transactions allowed After this loop,
        profit[n-1] contains the result */
        int min_price = price[0];
 
        for (int i = 1; i < n; i++) {
 
            // min_price is minimum price in
            // price[0..i]
             min_price=Math.Max(price[i],min_price); 
 
            // Maximum profit is maximum of:
            // a) previous maximum, i.e.,
            // profit[i-1]
            // b) (Buy, Sell) at (min_price,
            // price[i]) and add profit of
            // other trans. stored in
            // profit[i]
            profit[i] = Math.Max(
                profit[i - 1],
                profit[i] + (price[i] - min_price));
        }
        int result = profit[n - 1];
 
        return result;
    }
}

