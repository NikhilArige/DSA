/*
You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. 
You can perform this operation at most k times.
Return the length of the longest substring containing the same letter you can get after performing the above operations.
Example 1:
Input: s = "ABAB", k = 2
Output: 4
Explanation: Replace the two 'A's with two 'B's or vice versa.
Example 2:
Input: s = "AABABBA", k = 1
Output: 4
Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
The substring "BBBB" has the longest repeating letters, which is 4.
*/

public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLength = 0;
        int start = 0, maxCount = 0;            
        int[] count = new int[26];
        for(int end = 0; end < s.Length; end++)
        {
            count[s[end] - 'A']++;
            maxCount = Math.Max(maxCount, count[s[end] - 'A']);
            while(end - start + 1 - maxCount > k)
            {
                count[s[start] - 'A']--;
                start++;
            }
            maxLength = Math.Max(maxLength,end-start+1);           
        }
        return maxLength;
    }
}
