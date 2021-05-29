/* Given two strings s and t, return true if t is an anagram of s, and false otherwise.
Example 1:
Input: s = "anagram", t = "nagaram"
Output: true
Example 2:
Input: s = "rat", t = "car"
Output: false */

public class Solution {
    public bool IsAnagram(string s, string t) {
        
        int len1 = s.Length;
        int len2 = t.Length;
        if(len1 != len2){
            return false;
        }
        var a = new int[26];
        var b = new int[26];
        for(int i=0;i<len1;i++){
            a[s[i]-'a']++;
            b[t[i]-'a']++;
        }
        if(compare(a,b)){
            return true;
        }
        return false;
    }
    
    private bool compare(int[] a,int[] b){
        
        for(int i=0;i<26;i++){
            if(a[i]!=b[i]){
                return false;
            }
        }
        return true;
    }
}
