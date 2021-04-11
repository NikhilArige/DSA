//Say you have an array, A, for which the ith element is the price of a given stock on day i.
//If you were only permitted to complete at most one transaction (i.e, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
//Return the maximum possible profit.
// A = [1, 4, 5, 2, 4]  Output:4

class Solution {
    public int maxProfit(List<int> A) {
        int n = A.Count;
        if(n==0){return 0;}
        int mintillNow = A[0];
        int profit = 0;
        for(int i=1;i<A.Count;i++){
            mintillNow = Math.Min(mintillNow,A[i]);
            profit = Math.Max(profit,A[i]-mintillNow); 
        } 
        return profit;
    }
}


