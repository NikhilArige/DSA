/*
Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.
Note that after backspacing an empty text, the text will continue empty.
Example 1:
Input: s = "ab#c", t = "ad#c"
Output: true
Explanation: Both s and t become "ac".
Example 2:
Input: s = "ab##", t = "c#d#"
Output: true
Explanation: Both s and t become "".
Example 3:
Input: s = "a##c", t = "#a#c"
Output: true
Explanation: Both s and t become "c".
Example 4:
Input: s = "a#c", t = "b"
Output: false
Explanation: s becomes "c" while t becomes "b".
*/

public class Solution {
    public bool BackspaceCompare(string s, string t) {
        
        var st = new Stack<char>();
        foreach(var item in s){
            if(item != '#'){
                st.Push(item);
            }
            else{
                if(st.Count > 0){
                    st.Pop();
                }
            }
            
        }
        var news = "";
        var newt = "";
        if(st.Count > 0){
            foreach(var i in st){
                news+=i;
            }
        }
        st.Clear();
        foreach(var item in t){
            if(item != '#'){
                st.Push(item);
            }
            else{
                if(st.Count > 0){
                    st.Pop();
                }
            }
        }
        if(st.Count > 0){
            foreach(var i in st){
                newt+=i;
            }
        }
        return news==newt;
        
    }
}
