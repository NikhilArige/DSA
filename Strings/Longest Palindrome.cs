/*
Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.
Letters are case sensitive, for example, "Aa" is not considered a palindrome here.
Example 1:
Input: s = "abccccdd"
Output: 7
Explanation:
One longest palindrome that can be built is "dccaccd", whose length is 7.
Example 2:
Input: s = "a"
Output: 1*/

public class Solution {
    public int LongestPalindrome(string s) {
        var map = new Dictionary<char,int>();
        foreach(var item in s){
            map[item] = map.ContainsKey(item) ? 1+map[item] : 1;
        }
        int res = 0;
        int odd = 0;
        foreach(var item in map.Values){
            if(item%2 != 0){
                odd = 1;
                res+= item-1;
            }
            else{
                res += item;
            }
        }
        return res+odd;
    }
}
