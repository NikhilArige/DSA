/* Given a string s, we can transform every letter individually to be lowercase or uppercase to create another string.
Return a list of all possible strings we could create. You can return the output in any order.
Example 1:
Input: s = "a1b2"
Output: ["a1b2","a1B2","A1b2","A1B2"]
Example 2:
Input: s = "3z4"
Output: ["3z4","3Z4"]
Example 3:
Input: s = "12345"
Output: ["12345"] */

public class Solution {
    public IList<string> LetterCasePermutation(string s) {
        var res = new List<string>();
        GetPermutations("",s,res,0);
        return res;
    }
    
    void GetPermutations(string cur,string s,List<string> res,int pos){
        if(pos == s.Length){
            res.Add(cur);
            return;
        }
        if(pos>=s.Length){
            return;
        }
        else{
            if(Char.IsDigit(s[pos]))
            {
                 GetPermutations(cur+s[pos],s,res,pos+1);
            }
            else
            {
                 GetPermutations(cur+Char.ToUpper(s[pos]),s,res,pos+1);
                 GetPermutations(cur+Char.ToLower(s[pos]),s,res,pos+1);
            }
        }
    }
}
