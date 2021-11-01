/*
Given an encoded string, return its decoded string.
The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times. 
Note that k is guaranteed to be a positive integer.
You may assume that the input string is always valid; No extra white spaces, square brackets are well-formed, etc.
Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k. 
For example, there won't be input like 3a or 2[4].
Example 1:
Input: s = "3[a]2[bc]"
Output: "aaabcbc"
Example 2:
Input: s = "3[a2[c]]"
Output: "accaccacc"
Example 3:
Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"
Example 4:
Input: s = "abc3[cd]xyz"
Output: "abccdcdcdxyz"
*/

public class Solution {
    public string DecodeString(string s) {
         var st=new Stack<String>();
        int i=0;
        int num=0;
        while(i<s.Length)
        {
            char ch=s[i];
            if(ch>='a' && ch<='z' || ch=='[')
            {
                if(ch=='[')
                {
                    st.Push(num.ToString());
                    num=0;
                }
                st.Push(ch.ToString());
            }
            else if(Char.IsDigit(ch))
            {
                num=num*10+ ch-'0';
            }
            else if(ch==']')
            {
                string str="";
                int number1 = 0;
                while(!int.TryParse(st.Peek(), out number1))
                {
                     string a=a=st.Pop();
                          if(a!="[")
                          {
                           str=a+str;   
                          }
                }
                int freq= Int32.Parse(st.Pop());
                string result = "";
                for(int c=0;c<freq;c++){
                    result+=str;
                }
                st.Push(result);
            }
            i++;
        }
        string R="";
        while(st.Count>0)
        {
            R=st.Pop()+R;
        }
        return R;
    }
}
