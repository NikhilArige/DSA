/*
Given a string s which represents an expression, evaluate this expression and return its value. 
The integer division should truncate toward zero.
You may assume that the given expression is always valid. All intermediate results will be in the range of [-231, 231 - 1].
Note: You are not allowed to use any built-in function which evaluates strings as mathematical expressions, such as eval().
Example 1:
Input: s = "3+2*2"
Output: 7
Example 2:
Input: s = " 3/2 "
Output: 1
Example 3:
Input: s = " 3+5 / 2 "
Output: 5
Constraints:
1 <= s.length <= 3 * 105
s consists of integers and operators ('+', '-', '*', '/') separated by some number of spaces.
s represents a valid expression.
All the integers in the expression are non-negative integers in the range [0, 231 - 1].
The answer is guaranteed to fit in a 32-bit integer.
*/

public class Solution {
    public int Calculate(string s) {
        
        var stack = new Stack<int>();
        char op = '+';
        int num = 0;
        for(int i=0;i<=s.Length;i++){
            char ch = i < s.Length ? s[i] : '+';  //last char
            if (ch == ' '){
               continue;
            }
            if (char.IsNumber(ch))
            {
                num = num * 10 + (ch - '0');
            }
            else
            {
                if (op == '+') stack.Push(num);
                if (op == '-') stack.Push(-num);
                if (op == '*') stack.Push(stack.Pop() * num);
                if (op == '/') stack.Push(stack.Pop() / num);
                
                op = ch;
                num = 0;
            }
        } 
        return stack.Sum();
    }
}
