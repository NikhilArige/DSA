//GIven three prime numbers A, B and C and an integer D.
//You need to find the first(smallest) D integers which only have A, B, C or a combination of them as their prime factors.
//A = 2; B = 3;C = 5;D = 5  Output:[2, 3, 4, 5, 6]


class Solution {
    public List<int> solve(int A, int B, int C, int D) {
        
        List<int>dp = new List<int>();
        dp.Add(1);
        int i=0,j=0,k=0;
        while(D>0){
         int x = Math.Min(dp[i]*A,Math.Min(dp[j]*B,dp[k]*C)); 
         dp.Add(x);
         if(x==(dp[i]*A)){
             i++;
         }
         if(x==(dp[j]*B)){
             j++;
         }
         if(x==(dp[k]*C)){
             k++;
         } 
         D--;
        } 
        dp.RemoveAt(0);
        return dp;
    }
}
