/*
You are given a string s and two integers x and y. You can perform two types of operations any number of times.
Remove substring "ab" and gain x points.
For example, when removing "ab" from "cabxbae" it becomes "cxbae".
Remove substring "ba" and gain y points.
For example, when removing "ba" from "cabxbae" it becomes "cabxe".
Return the maximum points you can gain after applying the above operations on s.
Example 1:
Input: s = "cdbcbbaaabab", x = 4, y = 5
Output: 19
Explanation:
- Remove the "ba" underlined in "cdbcbbaaabab". Now, s = "cdbcbbaaab" and 5 points are added to the score.
- Remove the "ab" underlined in "cdbcbbaaab". Now, s = "cdbcbbaa" and 4 points are added to the score.
- Remove the "ba" underlined in "cdbcbbaa". Now, s = "cdbcba" and 5 points are added to the score.
- Remove the "ba" underlined in "cdbcba". Now, s = "cdbc" and 5 points are added to the score.
Total score = 5 + 4 + 5 + 5 = 19.
Example 2:
Input: s = "aabbaaxybbaabb", x = 5, y = 4
Output: 20
*/

public class Solution {
    public int MaximumGain(string s, int x, int y) {
        
        int total = 0;
        if(x>y){
            var sb = new StringBuilder(s);
            var newsb = GetString(sb,ref total,x,'a','b');
            GetString(newsb,ref total,y,'b','a');
        }
        else{
            var sb = new StringBuilder(s);
            var newsb = GetString(sb,ref total,y,'b','a');
            GetString(newsb,ref total,x,'a','b');
        }
          return total;
    }
    
    StringBuilder GetString(StringBuilder s,ref int total,int cnt,char fc,char sc){
        
        var st = new Stack<char>();
        var sb = new StringBuilder();
        for(int i=0 ; i < s.Length; i++) 
        {
            if(st.Count > 0 && st.Peek() == fc && s[i]==sc ){
                total += cnt;
                st.Pop();
                sb.Remove(sb.Length-1,1);
            }
            else{
                st.Push(s[i]);
                sb.Append(s[i]);
            }
        }
                return sb;
    }
}
