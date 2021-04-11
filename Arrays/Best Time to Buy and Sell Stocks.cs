//Say you have an array, A, for which the ith element is the price of a given stock on day i.Design an algorithm to find the maximum profit.
//You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).

 
class Solution {
    public int maxProfit(List<int> A) {
        int n = A.Count;
        int profit = 0;
        for(int i=1;i<n;i++){ 
         if(A[i]>A[i-1]){
             profit+=(A[i]-A[i-1]);
         } 
        }
        return profit;
    }
}
