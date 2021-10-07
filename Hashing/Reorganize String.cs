/*
Given a string s, rearrange the characters of s so that any two adjacent characters are not the same.
Return any possible rearrangement of s or return "" if not possible.
Example 1:
Input: s = "aab"
Output: "aba"
Example 2:
Input: s = "aaab"
Output: ""
*/

public class Solution {
    public string ReorganizeString(string s) {
        int n = s.Length;
        
        var map = new Dictionary<char,int>();
        foreach(var item in s){
            map[item] = map.ContainsKey(item) ? map[item] + 1 : 1;
        }
        
        var set = map.OrderByDescending(v => v.Value);
        
        if(set.First().Value > ((n+1)/2)){
            return "";
        }
        
        int ind = 0;
        var ch = new char[n];
        foreach(var item in set){
            
            int val = item.Value;
            for(int i=0;i<val;i++){
                
                if(ind < n){
                    ch[ind] = item.Key;
                    ind+=2;
                }
                else if(ch[0]!=item.Key){
                    ind = 1;
                    ch[ind] = item.Key;
                    ind+=2;
                }
                else{
                    return "";
                }
            }
        }
        
        return new string(ch);
    }
}
