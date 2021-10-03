/*
You are given a string s. We want to partition the string into as many parts as possible so that each letter appears in at most one part.
Return a list of integers representing the size of these parts.
Example 1:
Input: s = "ababcbacadefegdehijhklij"
Output: [9,7,8]
Explanation:
The partition is "ababcbaca", "defegde", "hijhklij".
This is a partition so that each letter appears in at most one part.
A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.
Example 2:
Input: s = "eccbbbbdec"
Output: [10]
*/

public class Solution {
    public IList<int> PartitionLabels(string s) {
        
        var ch = new int[26];
        foreach(var item in s){
            ch[item-'a']++;
        }
        var res = new List<int>();
        var cur = new HashSet<char>();
        int startIndex = 0;
        for(int i=0;i<s.Length;i++){
            cur.Add(s[i]);
            ch[s[i]-'a']--;
            if(ch[s[i]-'a'] == 0){
                cur.Remove(s[i]);
            }
            if(cur.Count == 0){
                res.Add(i-startIndex+1);
                startIndex=i+1;
            }
        }
        return res;
    }
}
