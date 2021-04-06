//Given a string A denoting an expression. It contains the following operators ’+’, ‘-‘, ‘*’, ‘/’.
//Check whether A has redundant braces or not.
//Return 1 if A has redundant braces, else return 0.
//Note: A will be always a valid expression.

public class Solution {
    public int braces(String A) { 
        Stack<char> st = new Stack<char>(); 
        for(int i =0;i<A.Length;i++){ 
            if(A[i]==')'){ 
                char top = st.Peek();
                st.Pop();
                int result = 1;
                while(top !='('){ 
                if (top == '+' || top == '-' || top == '*' || top == '/'){
                  result = 0;     
                }
                top = st.Peek();
                    st.Pop();    
                }
                if(result == 1){
                    return 1;
                } 
            }
            else{
                st.Push(A[i]);
            } 
        }
        return 0; 
    }
}
