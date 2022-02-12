/*
Given a string s consisting only of characters a, b and c.
Return the number of substrings containing at least one occurrence of all these characters a, b and c.
Example 1:
Input: s = "abcabc"
Output: 10
Explanation: The substrings containing at least one occurrence of the characters a, b and c are "abc", "abca", "abcab", "abcabc", "bca", "bcab", "bcabc", "cab", "cabc" and "abc" (again). 
Example 2:
Input: s = "aaacb"
Output: 3
Explanation: The substrings containing at least one occurrence of the characters a, b and c are "aaacb", "aacb" and "acb". 
*/

public class Solution {
    public int NumberOfSubstrings(string s) {
        
        var lastEncounter = new int[3]{-1,-1,-1};
        int res = 0;
        for(int i=0;i<s.Length;i++){
        
            lastEncounter[s[i]-'a'] = i;
            res += 1 + lastEncounter.Min();
            
        }
        return res;
    }
}
