/*
Given a string s, return the lexicographically smallest subsequence of s that contains all the distinct characters of s exactly once.
Example 1:
Input: s = "bcabc"
Output: "abc"
Example 2:
Input: s = "cbacdcbc"
Output: "acdb"
*/

public class Solution {
    public string SmallestSubsequence(string s) {
        
        var st = new Stack<char>();
        var lastSeen = new Dictionary<char,int>();
        var seen = new HashSet<char>();
        for(int i=0;i<s.Length;i++){
            lastSeen[s[i]] = i;
        }
        for(int i=0;i<s.Length;i++){
         
            if(!seen.Contains(s[i])){
                 
                while(st.Any() && st.Peek() > s[i] && lastSeen[st.Peek()] > i)
                {
                    seen.Remove(st.Pop());
                }
                seen.Add(s[i]);
                st.Push(s[i]);
            }
            
        }
        
        var res = new List<char>();
        while(st.Any()){
            res.Add(st.Pop());
        }
        res.Reverse(); 
        return new string(res.ToArray());
    }
}
