/*You are given a string S, and you have to find all the amazing substrings of S.
Amazing Substring is one that starts with a vowel (a, e, i, o, u, A, E, I, O, U).
Input
Only argument given is string S.
Output
Return a single integer X mod 10003, here X is number of Amazing Substrings in given string.
Input:ABEC
Output:6
Explanation
	Amazing substrings of given string are :
	1. A
	2. AB
	3. ABE
	4. ABEC
	5. E
	6. EC
	here number of substrings are 6 and 6 % 10003 = 6. */
  

class Solution {
    public int solve(string A) {
        int n = A.Length;
        int res = 0;
        for(int i=0;i<n;i++){
            
            var val = A[i];
            if(val == 'A' || val == 'E' || val == 'I' || val == 'O' || val == 'U' ||
            val == 'a' || val == 'e' ||val == 'i' ||val == 'o' ||val == 'u'){
                res+= (n-i);
            }
        }
        return res%10003;
    }
}
