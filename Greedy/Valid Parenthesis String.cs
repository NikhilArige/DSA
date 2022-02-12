/*
Given a string s containing only three types of characters: '(', ')' and '*', return true if s is valid.
The following rules define a valid string:
Any left parenthesis '(' must have a corresponding right parenthesis ')'.
Any right parenthesis ')' must have a corresponding left parenthesis '('.
Left parenthesis '(' must go before the corresponding right parenthesis ')'.
'*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string "".
Example 1:
Input: s = "()"
Output: true
Example 2:
Input: s = "(*)"
Output: true
Example 3:
Input: s = "(*))"
Output: true
*/

public class Solution {
    public bool CheckValidString(string s) {
        
       // For "(",  cmin = 1 and cmax = 1.
       // F0r "(*(",  cmin = 1 and cmax = 3. 
        
       int cmin = 0, cmax = 0;
        for (int i = 0; i < s.Length; ++i) {
            char c = s[i];
            if (c == '(') {
                cmax++;
                cmin++;
            } else if (c == ')') {
                cmax--;
                cmin = Math.Max(cmin - 1, 0);
            } else {
                cmax++;
                cmin = Math.Max(cmin - 1, 0);
            }
            if (cmax < 0) return false;
        }
        return cmin == 0;
    }
}
