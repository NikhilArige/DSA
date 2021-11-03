/*
You are given a string s and an array of strings words of the same length. Return all starting indices of substring(s) in s that is a concatenation of each word in words 
exactly once, in any order, and without any intervening characters.
You can return the answer in any order.
Example 1:
Input: s = "barfoothefoobarman", words = ["foo","bar"]
Output: [0,9]
Explanation: Substrings starting at index 0 and 9 are "barfoo" and "foobar" respectively.
The output order does not matter, returning [9,0] is fine too.
Example 2:
Input: s = "wordgoodgoodgoodbestword", words = ["word","good","best","word"]
Output: []
*/

public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        
        var res = new List<int>();
        var oneword = words[0].Length;
        var allwords = oneword * words.Length;
        
        if(s.Length < allwords){
            return res;
        }
        
        var map = new Dictionary<string,int>();
        foreach(var word in words){
            map[word] = map.ContainsKey(word) ? map[word] + 1 : 1;
        }
        
        for(int i=0;i<s.Length-allwords+1;i++){
            
            var tempmap = new Dictionary<string,int>(map);
            bool isFailed = false;
            for(int j=i;j<i+allwords;j=j+oneword)
            { 
                var curstr=s.Substring(j,oneword);
                if(tempmap.ContainsKey(curstr))
                {
                    if(tempmap[curstr]>1){
                        tempmap[curstr]--;
                    }
                    else{
                        tempmap.Remove(curstr);
                    }
                }
                else
                {
                    isFailed=true;
                    break;
                }
             }
            if(!isFailed){
                res.Add(i);
            }
        }
        return res;
    }
}
