/* Given two strings s and p, return an array of all the start indices of p's anagrams in s. You may return the answer in any order.
Example 1:
Input: s = "cbaebabacd", p = "abc"
Output: [0,6]
Explanation:
The substring with start index = 0 is "cba", which is an anagram of "abc".
The substring with start index = 6 is "bac", which is an anagram of "abc".
Example 2:
Input: s = "abab", p = "ab"
Output: [0,1,2]
Explanation:
The substring with start index = 0 is "ab", which is an anagram of "ab".
The substring with start index = 1 is "ba", which is an anagram of "ab".
The substring with start index = 2 is "ab", which is an anagram of "ab". */

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        
        var pcount = new char[256];
        var scount = new char[256];
        var result = new List<int>();
        int m = p.Length;
        int n = s.Length;
        if(m>n){
            return result;
        }
        for(int i=0;i<m;i++){
            pcount[p[i]]++;
            scount[s[i]]++;
        } 
        for(int i=m;i<n;i++){
           if(compare(pcount,scount)){
               result.Add(i-m);
           }
            
        scount[s[i]]++; 
        // Removing the first character of previous window
        scount[s[i-m]]--;
        } 
         if (compare(pcount,scount))
        {
            //for last window
            result.Add(n-m);
        }
        return result;
    }
    
    private bool compare(char[] a,char[] b){
        
        for(int i = 0;i<256;i++){
            
            if(a[i]!=b[i]){
                return false;
            }
        }
        return true;
    }
}
 
