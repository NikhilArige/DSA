/*
Given a string s, return the maximum number of ocurrences of any substring under the following rules:
The number of unique characters in the substring must be less than or equal to maxLetters.
The substring size must be between minSize and maxSize inclusive.
Example 1:
Input: s = "aababcaab", maxLetters = 2, minSize = 3, maxSize = 4
Output: 2
Explanation: Substring "aab" has 2 ocurrences in the original string.
It satisfies the conditions, 2 unique letters and size 3 (between minSize and maxSize).
Example 2:
Input: s = "aaaa", maxLetters = 1, minSize = 3, maxSize = 3
Output: 2
Explanation: Substring "aaa" occur 2 times in the string. It can overlap.
Example 3:
Input: s = "aabcabcab", maxLetters = 2, minSize = 2, maxSize = 3
Output: 3
Example 4:
Input: s = "abcde", maxLetters = 2, minSize = 3, maxSize = 3
Output: 0
*/

public class Solution {
    public int MaxFreq(string s, int maxLetters, int minSize, int maxSize) {
     
        var map = new Dictionary<string,int>();
        var cnt = 0;
        for(int i=0;i<=s.Length-minSize;i++){
            var substr = s.Substring(i,minSize);
            if(substr.Distinct().Count()<=maxLetters)
            {
                map[substr] = map.ContainsKey(substr) ? map[substr]+1 : 1;
            }
        }
        return map.Any() ? map.Max(x=>x.Value) : 0;
        
    }
}
