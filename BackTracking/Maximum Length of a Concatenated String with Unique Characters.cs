/*
You are given an array of strings arr. A string s is formed by the concatenation of a subsequence of arr that has unique characters.
Return the maximum possible length of s.
A subsequence is an array that can be derived from another array by deleting some or no elements without changing the order of the remaining elements.
Example 1:
Input: arr = ["un","iq","ue"]
Output: 4
Explanation: All the valid concatenations are:
- ""
- "un"
- "iq"
- "ue"
- "uniq" ("un" + "iq")
- "ique" ("iq" + "ue")
Maximum length is 4.
Example 2:
Input: arr = ["cha","r","act","ers"]
Output: 6
Explanation: Possible longest valid concatenations are "chaers" ("cha" + "ers") and "acters" ("act" + "ers").
Example 3:
Input: arr = ["abcdefghijklmnopqrstuvwxyz"]
Output: 26
Explanation: The only string in arr has all 26 characters.
Example 4:
Input: arr = ["aa","bb"]
Output: 0
Explanation: Both strings in arr do not have unique characters, thus there are no valid concatenations.
*/

public class Solution {
    public int MaxLength(IList<string> arr) {
        
        var ans = 0;
        GetMax(arr,"",0,ref ans);
        return ans;
    }
    
    void GetMax(IList<string> arr,string currS, int idx,ref int ans) {
        
            ans = Math.Max(ans,currS.Length);
            if(ans==26) return;
            for(int i = idx ; i<arr.Count ; i++)
            {
                var newS = arr[i]+currS;
                if(!containsDuplicate(newS))
                    GetMax(arr,newS,i+1,ref ans);
            }
        }
    
    bool containsDuplicate(string str){
        
        var ch = new int[26];
        for(int i=0;i<str.Length;i++){
            
            if(++ch[str[i]-'a'] ==2){
                return true;
            }
        }
             return false; 
    }
}
