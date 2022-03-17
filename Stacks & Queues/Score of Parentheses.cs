/*
Given a balanced parentheses string s, return the score of the string.
The score of a balanced parentheses string is based on the following rule:
"()" has score 1.
AB has score A + B, where A and B are balanced parentheses strings.
(A) has score 2 * A, where A is a balanced parentheses string.
Example 1:
Input: s = "()"
Output: 1
Example 2:
Input: s = "(())"
Output: 2
Example 3:
Input: s = "()()"
Output: 2
*/

public class Solution {
    public int ScoreOfParentheses(string s) { 
        var stack = new Stack<int>();
        int cur = 0;
        foreach(var c in s) {
            if (c == '(') {
                stack.Push(cur);
                cur = 0;
            } 
            else {
                cur = stack.Pop() + Math.Max(cur * 2, 1);
            }
        }
        return cur;
    }
}
