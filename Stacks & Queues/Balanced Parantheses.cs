//Given a string A consisting only of '(' and ')'.
//You need to find whether parantheses in A is balanced or not ,if it is balanced then return 1 else return 0.


class Solution {
    public int solve(string A) {
        int n = A.Length;
        if(n==1 && A[0]==')'){return 0;}
        Stack<char> st = new Stack<char>();
        int cnt =0;
        for(int i=0;i<n;i++){
           if(A[i]=='('){
               st.Push(A[i]);
           }
           else if(st.Count >0){
               st.Pop();
           }
           else{
               cnt++;           //if A is like '))'
           }
        }
        int res = (st.Count>0 || cnt > 0) ? 0 : 1;
        return res;
    }
}
