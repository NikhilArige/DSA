/*Given a string A of parantheses ‘(‘ or ‘)’.
The task is to find minimum number of parentheses ‘(‘ or ‘)’ (at any positions) we must add to make the resulting parentheses string valid.
A = "((("
Output :3 */


class Solution {
    public int solve(string A) {
        
        Stack<char> st = new Stack<char>();
        int n=A.Length;
        int count = 0;
        for(int i=0;i<n;i++){
            if(A[i]=='('){
                st.Push(A[i]);
            }
            else{
                if(st.Count>0){
                    st.Pop();
                }
                else{
                    count++;
                }
            }
        }
        return count+st.Count; // case like )(
    }
}
