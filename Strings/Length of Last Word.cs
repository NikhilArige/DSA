//Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
//If the last word does not exist, return 0.
//Note: A word is defined as a character sequence consists of non-space characters only.
//Example: Given s = "Hello World",
//return 5 as length("World") = 5.



class Solution {
    public int lengthOfLastWord(string A) { 
        int len = 0;
        string str = A.Trim();
        int n = str.Length-1; 
        for (int i = 0; i < str.Length; i++) {
            if (str[i] == ' ') {
                len = 0;
            }
            else {
                len++;
            }
        } 
        return len; 
    }
}
