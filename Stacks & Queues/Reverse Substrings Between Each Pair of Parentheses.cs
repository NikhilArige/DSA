/*
You are given a string s that consists of lower case English letters and brackets.
Reverse the strings in each pair of matching parentheses, starting from the innermost one.
Your result should not contain any brackets.
Example 1:
Input: s = "(abcd)"
Output: "dcba"
Example 2:
Input: s = "(u(love)i)"
Output: "iloveu"
Explanation: The substring "love" is reversed first, then the whole string is reversed.
Example 3:
Input: s = "(ed(et(oc))el)"
Output: "leetcode"
Explanation: First, we reverse the substring "oc", then "etco", and finally, the whole string.
*/

public class Solution {
    public string ReverseParentheses(string s) {
        var st = new Stack<string>();
        string str = "";
        foreach(var ch in s){
            if(ch=='('){
                st.Push(str);
                str = "";
            }
            else if(ch==')'){
                var rev = st.Pop();
                var charr = str.ToCharArray();
                Array.Reverse(charr);
                var newstr = new string(charr);
                str = rev + newstr;
            }
            else{
                str+=ch;
            } 
        }
        return str;
    }
} 
