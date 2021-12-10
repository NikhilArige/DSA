/*
Given a string s and an integer k, return the length of the longest substring of s such that the frequency of each character in this substring is greater than or equal to k.
Example 1:
Input: s = "aaabb", k = 3
Output: 3
Explanation: The longest substring is "aaa", as 'a' is repeated 3 times.
Example 2:
Input: s = "ababbc", k = 2
Output: 5
Explanation: The longest substring is "ababb", as 'a' is repeated 2 times and 'b' is repeated 3 times.
Constraints:
1 <= s.length <= 104
s consists of only lowercase English letters.
1 <= k <= 105
*/

public class Solution {
    public int LongestSubstring(string s, int k) {
        int[] freq = new int[26];
        int res = 0, start = 0;
        
        for(int i = 0; i < s.Length; ++i){
            freq[s[i]- 'a']++;
        } 
        
        bool valid = true;
            
        for(int end = 0; end < s.Length; ++end){
            if(freq[s[end] - 'a'] < k){
                res = Math.Max(res, LongestSubstring(s.Substring(start, end-start), k));
                valid = false;
                start = end + 1;
            }
        }
        
        return valid? s.Length : Math.Max(res, LongestSubstring(s.Substring(start,s.Length-start), k));
    }
}
