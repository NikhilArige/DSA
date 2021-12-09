/*
Given a string s. Return all the words vertically in the same order in which they appear in s.
Words are returned as a list of strings, complete with spaces when is necessary. (Trailing spaces are not allowed).
Each word would be put on only one column and that in one column there will be only one word.
Example 1:
Input: s = "HOW ARE YOU"
Output: ["HAY","ORO","WEU"]
Explanation: Each word is printed vertically. 
 "HAY"
 "ORO"
 "WEU"
Example 2:
Input: s = "TO BE OR NOT TO BE"
Output: ["TBONTB","OEROOE","   T"]
Explanation: Trailing spaces is not allowed. 
"TBONTB"
"OEROOE"
"   T"
Example 3:
Input: s = "CONTEST IS COMING"
Output: ["CIC","OSO","N M","T I","E N","S G","T"]
*/

public class Solution {
    public IList<string> PrintVertically(string s) {
        
        var st = s.Split(' ');
        var maxlength = 0 ;
        foreach(var item in st){
            maxlength = Math.Max(maxlength,item.Length);
        }
        var res = new List<StringBuilder>();
        for(int i=0;i<maxlength;i++){
            res.Add(new StringBuilder());
        }
        for(int i=0;i<st.Length;i++){
            for(int j=0;j<res.Count;j++){
                if(j>=st[i].Length){
                    res[j].Append(" ");
                }
                else{
                   res[j].Append(st[i][j]); 
                }
            }
        }
        var result = new List<string>();
            
        res.ForEach(x=> result.Add(x.ToString().TrimEnd()));
        return result;
    }
}
