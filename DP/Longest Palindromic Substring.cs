/*Given a string S, find the longest palindromic substring in S.
Substring of string S:
S[i...j] where 0 <= i <= j < len(S)
Palindrome string:
A string which reads the same backwards. More formally, S is palindrome if reverse(S) = S.
Incase of conflict, return the substring which occurs first ( with the least starting index ).
Example :
Input : "aaaabaaa"
Output : "aaabaaa" */



class Solution {
    public string longestPalindrome(string A) {
        
        int max = 1; //for one character
        int n = A.Length;
        if(n==1){
            return A;
        }
        bool[,] dp = new bool[n,n];
        for(int i=0;i<n;i++){
            dp[i,i] = true;
            //only one string
        }
        int start = 0;
 
        for (int i = 0; i < n - 1; ++i) {
            if (A[i] == A[i + 1]) {
                dp[i,i+1] = true;
                start = i;
                max = 2;
            }
        }
        
        for(int l=3;l<=n;l++){
            for(int i=0;i<n-l+1;i++){ 
                int j = l+i-1;
                if (A[i] == A[j] && dp[i+1,j-1] ) {
                    dp[i, j] = true;
                    if (l > max) {
                        start = i;
                        max = l;
                    }
                }
            }
        } 
        
         return A.Substring(start,max);
    }
}


public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
        if(n<2){
            return s;
        }
        (int start, int end) max = (0, 0);
        for(int i=0;i<n-1;i++){
            if (s[i] == s[i + 1])
                {
                    var res = LongestPalindrome(s, i, i + 1);
                    max = res.end - res.start > max.end - max.start ? res : max;
                }

                if (i + 2 < s.Length && s[i] == s[i + 2])
                {
                    var res = LongestPalindrome(s, i, i + 2);
                    max = res.end - res.start > max.end - max.start ? res : max;
                }
        }
        return (max.start == 0 && max.end == 0) ? 
                s[0].ToString() : s.Substring(max.start, max.end - max.start + 1);       
    }
    
    private (int start, int end) LongestPalindrome(string s, int start, int end)
        { 
            while (start >= 0 && end < s.Length && s[start] == s[end])
            {
                start--;
                end++;
            }

            return (start + 1, end - 1);
        }
}
