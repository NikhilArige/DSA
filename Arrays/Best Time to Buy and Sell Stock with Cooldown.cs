/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.
Find the maximum profit you can achieve. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times) 
with the following restrictions:
After you sell your stock, you cannot buy stock on the next day (i.e., cooldown one day).
Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).
Example 1:
Input: prices = [1,2,3,0,2]
Output: 3
Explanation: transactions = [buy, sell, cooldown, buy, sell]
Example 2:
Input: prices = [1]
Output: 0
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        
        var buyingPoint = -prices[0];
        var sellingPoint = 0;
        var coolingPoint = 0;
        for(int i=1;i<prices.Length;i++)
        {
            var newbuyingPoint = 0;
            var newsellingPoint = 0;
            var newcoolingPoint = 0;
            newbuyingPoint = Math.Max(buyingPoint,-prices[i]+coolingPoint);
            newsellingPoint = Math.Max(sellingPoint,prices[i]+buyingPoint);
            newcoolingPoint = Math.Max(coolingPoint,sellingPoint);
            
            buyingPoint = newbuyingPoint;
            sellingPoint = newsellingPoint;
            coolingPoint = newcoolingPoint;
            
        }
        return sellingPoint;
    }
}
