/* Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses of length 2*n.
For example, given n = 3, a solution set is:
"((()))", "(()())", "(())()", "()(())", "()()()"
Make sure the returned list of strings are sorted. */


class Solution {
    public List<string> generateParenthesis(int A) {
        
        List<string> res = new List<string>(); 
        GetParenthesis(A,0,0,res,"");
        
        return res;
    }
    
    private void GetParenthesis(int A,int open,int close,List<string> res,string s){
     
        if(s.Length>2*A){
            return;
        } 
        if(s.Length==2*A && open==close){
            res.Add(s);
        }
        if(close>open){
            return;
        }
        //just to decrease recursion stack, can be obtained wihtout open<A check also
        if(open<A){
                 GetParenthesis(A,open+1,close,res,s+"(");
        }
         if(close<A){
                 GetParenthesis(A,open,close+1,res,s+")");
        } 
    }
}
