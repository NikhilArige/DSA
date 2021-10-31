/*
Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
Example 1:
Input: s = "(()"
Output: 2
Explanation: The longest valid parentheses substring is "()".
Example 2:
Input: s = ")()())"
Output: 4
Explanation: The longest valid parentheses substring is "()()".
Example 3:
Input: s = ""
Output: 0
*/

public class Solution {
    public int LongestValidParentheses(string s) {
        
        var st = new Stack<int>();
        st.Push(-1);
        int max = 0;
        for(int i=0;i<s.Length;i++){
            
            if(s[i]=='('){
                st.Push(i);
            }
            else{
                
                st.Pop();
                if(st.Count==0){
                   st.Push(i); 
                }
                max = Math.Max(max,i - st.Peek());
            }
        }
        return max;
    }
}
