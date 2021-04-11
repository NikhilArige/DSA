//A message containing letters from A-Z is being encoded to numbers using the following mapping:
//'A' -> 1 'Z' -> 26
//Given an encoded message A containing digits, determine the total number of ways to decode it modulo 10^9 + 7.
// eg.Given encoded message "12", it could be decoded as "AB" (1, 2) or "L" (12). The number of ways decoding "12" is 2.



class Solution {
    public int numDecodings(string A) {
        int n = A.Length;
        int[] dp = new int[n+1];
        int mod = 1000000007;
        dp[0] = 1;
        dp[1] = A[0]=='0' ? 0 : 1;
        for(int i=2;i<=n;i++){
            
            int oneDigit = Convert.ToInt32(A.Substring(i-1,1)); //length 1
            int twoDigits = Convert.ToInt32(A.Substring(i-2,2)); //length 2
            if(oneDigit >= 1){
                dp[i] = (dp[i]+dp[i-1])%mod;
            }
            if(twoDigits >= 10 && twoDigits <= 26){
                dp[i] = (dp[i]+dp[i-2])%mod;
            }
        }
        return dp[n];
    }
}

