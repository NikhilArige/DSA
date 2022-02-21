/*
Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.
Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.
Example 1:
Input: s = "abciiidef", k = 3
Output: 3
Explanation: The substring "iii" contains 3 vowel letters.
Example 2:
Input: s = "aeiou", k = 2
Output: 2
Explanation: Any substring of length 2 contains 2 vowels.
*/

public class Solution {
    public int MaxVowels(string s, int k) {
        
        var vowels = new HashSet<char>(){'a','e','i','o','u'};
        int cur = 0;
        int res = 0;
        for(int i=0;i<k;i++){
            if(vowels.Contains(s[i])){
                cur++;
            }
        }
        res = Math.Max(res,cur);
        for(int i=k;i<s.Length;i++){
            if(vowels.Contains(s[i-k])){
                cur--;
            }
            if(vowels.Contains(s[i])){
                cur++;
            }
            res = Math.Max(res,cur);
        }
        return res;
    }
}
