/* Given a string s, return the first non-repeating character in it and return its index. If it does not exist, return -1.
Example 1:
Input: s = "leetcode"
Output: 0
Example 2:
Input: s = "loveleetcode"
Output: 2
Example 3:
Input: s = "aabb"
Output: -1  */

public class Solution {
    public int FirstUniqChar(string s) {
        
        var set = new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++){
            
            if(set.ContainsKey(s[i])){
                set[s[i]]++;
            }
            else{
                set.Add(s[i],1);
            }
        }
        for(int i=0;i<s.Length;i++){
            if(set[s[i]]==1){
                return i;
            }
        }
        return -1;
    }
}
