/*
Given a string s that contains parentheses and letters, remove the minimum number of invalid parentheses to make the input string valid.
Return all the possible results. You may return the answer in any order.
Example 1:
Input: s = "()())()"
Output: ["(())()","()()()"]
Example 2:
Input: s = "(a)())()"
Output: ["(a())()","(a)()()"]
Example 3:
Input: s = ")("
Output: [""]
*/

public class Solution {
    List<string> res;
    public IList<string> RemoveInvalidParentheses(string s) {
        res = new List<string>();
        var minRem = getMin(s); 
        UpdateList(s,minRem.l,minRem.r,0);
        return res.ToList();
    }
    
    void UpdateList(string s,int l,int r,int start){  
        if(l == 0 && r == 0){ 
            if(IsValid(s)){
                res.Add(s);
            }
            return;
        }
         
        for(int i=start;i<s.Length;i++){
            
            if (i != start && s[i - 1] == s[i])
            {
                continue;
            }
            if(s[i] == '(' && l > 0){
               var newstr = s.Remove(i,1);
               UpdateList(newstr,l-1,r,i); 
            } 
            if(s[i] == ')' && r > 0){
               var newstr = s.Remove(i,1);
               UpdateList(newstr,l,r-1,i); 
            } 
        }
    }
    
    (int l,int r) getMin(string s){ 
        int opening = 0;
        int closing = 0;
        foreach(var ch in s){ 
            if(ch==')'){
                 if(opening > 0){
                     opening --;
                 } 
                 else if(opening == 0){
                     closing ++;
                 }
            }
            else if(ch == '('){
                opening ++;
            }
        }
        return (opening,closing);
    }
    
    bool IsValid(string s)
    {
        int count = 0;
        foreach(char c in s)
        {
            if (c == '(') count++;
            if (c == ')') count--;
            if (count < 0)
            {
                return false;
            }
        }
        return count == 0;
    }
}
