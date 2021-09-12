/*
Given the string s, return the size of the longest substring containing each vowel an even number of times. 
That is, 'a', 'e', 'i', 'o', and 'u' must appear an even number of times.
Example 1:
Input: s = "eleetminicoworoep"
Output: 13
Explanation: The longest substring is "leetminicowor" which contains two each of the vowels: e, i and o and zero of the vowels: a and u.
Example 2:
Input: s = "leetcodeisgreat"
Output: 5
Explanation: The longest substring is "leetc" which contains two e's.
Example 3:
Input: s = "bcbcbc"
Output: 6
Explanation: In this case, the given string "bcbcbc" is the longest because all vowels: a, e, i, o and u appear zero times.
*/

public class Solution {
    public int FindTheLongestSubstring(string s) {
        
            int res = 0;
            var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            
            var val = new Dictionary<char, int>()
            {
                {'a', 1},
                {'e', 2},
                {'i', 4},
                {'o', 8},
                {'u', 16}
            }; 
        
             var maskPosition = new Dictionary<int, int>();
             int mask = 0;
             maskPosition[0] = -1;

        for(int i=0;i<s.Length;i++){
            if (vowels.Contains(s[i]))
            {
                mask ^= val[s[i]];
            }
            if (!maskPosition.ContainsKey(mask)) { 
               maskPosition[mask] = i;
            }
            res = Math.Max(res, i - maskPosition[mask]);
        }
        
        return res;
    }
}


//getting TLE for this
public class Solution {
    public int FindTheLongestSubstring(string s) {
        
            int res = 0;
            var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            
            var count = new Dictionary<char, int>()
            {
                {'a', 0},
                {'e', 0},
                {'i', 0},
                {'o', 0},
                {'u', 0}
            }; 
        
            var key2Index = new Dictionary<string, int>()
            {
                {"a0e0i0o0u0", -1 }
            };
        
        for(int i=0;i<s.Length;i++){
            var c = s[i];
            if(vowels.Contains(c)){
                count[c]++;
            }
            string key = $"a{count['a'] % 2}e{count['e'] % 2}i{count['i'] % 2}o{count['o'] % 2}u{count['u'] % 2}";
             if (key2Index.ContainsKey(key))
                {
                    res = Math.Max(res, i - (key2Index[key]));
                }
				else
                {
                    key2Index[key] = i;
                }
            
        }
        
        return res;
    }
}
