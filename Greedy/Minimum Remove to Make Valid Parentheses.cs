/*
Given a string s of '(' , ')' and lowercase English characters.
Your task is to remove the minimum number of parentheses ( '(' or ')', in any positions ) so that the resulting parentheses string is valid and return any valid string.
Formally, a parentheses string is valid if and only if:
It is the empty string, contains only lowercase characters, or
It can be written as AB (A concatenated with B), where A and B are valid strings, or
It can be written as (A), where A is a valid string.
Example 1:
Input: s = "lee(t(c)o)de)"
Output: "lee(t(c)o)de"
Explanation: "lee(t(co)de)" , "lee(t(c)ode)" would also be accepted.
Example 2:
Input: s = "a)b(c)d"
Output: "ab(c)d"
Example 3:
Input: s = "))(("
Output: ""
Explanation: An empty string is also valid.
*/

public class Solution {
    public string MinRemoveToMakeValid(string s) {
        var sb = new StringBuilder();
        int opening = 0;
        for(int i=0;i<s.Length;i++){
            if(s[i] == '('){
                opening ++;
            }
            else if(opening == 0 && s[i]==')'){
                continue;
            }
            else if(s[i]==')'){
                opening --;
            }
            sb.Append(s[i]);
        }
        if(opening == 0){
           return sb.ToString(); 
        }
        for(int i=sb.Length-1;i>=0;i--){ 
            if(opening == 0){
               return sb.ToString(); 
            }
            if(sb[i]=='(' && opening >0){
                opening--;
                sb.Remove(i,1);
            } 
        }
        
        return sb.ToString(); 
    }
}
