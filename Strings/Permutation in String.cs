/* 
Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
In other words, return true if one of s1's permutations is the substring of s2.
Example 1:
Input: s1 = "ab", s2 = "eidbaooo"
Output: true
Explanation: s2 contains one permutation of s1 ("ba").
Example 2:
Input: s1 = "ab", s2 = "eidboaoo"
Output: false
*/

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var cnt1 = new int[26];
        var cnt2 = new int[26];
        foreach(var item in s1){
            cnt1[item - 'a']++;
        }
        
        int j = 0;
        for(int i=0;i<s2.Length;i++){
            
            cnt2[s2[i]-'a']++;
            if(i-j+1 == s1.Length){
                
                if(cnt1.SequenceEqual(cnt2)){
                    return true;
                }
                cnt2[s2[j]-'a']--;
                j++;
            }
        }
        return false;
    }
}
