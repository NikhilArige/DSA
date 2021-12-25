/*
Given a string s representing a valid expression, implement a basic calculator to evaluate it, and return the result of the evaluation.
Note: You are not allowed to use any built-in function which evaluates strings as mathematical expressions, such as eval().
Example 1:
Input: s = "1 + 1"
Output: 2
Example 2:
Input: s = " 2-1 + 2 "
Output: 3
Example 3:
Input: s = "(1+(4+5+2)-3)+(6+8)"
Output: 23
Constraints:
1 <= s.length <= 3 * 105
s consists of digits, '+', '-', '(', ')', and ' '.
s represents a valid expression.
'+' is not used as a unary operation (i.e., "+1" and "+(2 + 3)" is invalid).
'-' could be used as a unary operation (i.e., "-1" and "-(2 + 3)" is valid).
There will be no two consecutive operators in the input.
Every number and running calculation will fit in a signed 32-bit integer.
*/

public class Solution {
    public int Calculate(string s) {
        
        int res = 0,sign = 1,num = 0;
        var stack = new Stack<int>();
        
        foreach(var ch in s)
        {
            if (Char.IsDigit(ch))
            {
                num = num * 10 + ch - '0';
            }
            else if(ch =='+' || ch == '-')
            {
                res +=num*sign;
                sign = ch=='+' ? 1 : -1;
                num = 0;
            }
            else if(ch=='(')
            {
                stack.Push(res);
                stack.Push(sign);
                res = 0;
                sign = 1;
                num = 0;
                
            }
            else if(ch==')')
            {
                res += sign * num;
                res *= stack.Pop();
                res += stack.Pop();
                num = 0;           
            }
        }
        
        res += num*sign;
        return res;
    }
}
