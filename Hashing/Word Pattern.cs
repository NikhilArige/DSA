/*
Given a pattern and a string s, find if s follows the same pattern.
Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
Example 1:
Input: pattern = "abba", s = "dog cat cat dog"
Output: true
Example 2:
Input: pattern = "abba", s = "dog cat cat fish"
Output: false
*/

public class Solution {
    public bool WordPattern(string pattern, string s) {
        var map = new Dictionary<char,string>();
        var str = s.Split(' ');
        if(str.Length != pattern.Length){
            return false;
        }
        for(int i=0;i<pattern.Length;i++){
            if(map.ContainsKey(pattern[i])){
                if (map[pattern[i]] != str[i]){
                     return false;
                }
            }
		    else if (map.ContainsValue(str[i])){
                return false;
            }
            else{
                map.Add(pattern[i],str[i]);
            }
        }
        return true;
    }
}
