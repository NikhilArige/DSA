/*Given an string A. The only operation allowed is to insert characters in the beginning of the string.
Find how many minimum characters are needed to be inserted to make the string a palindrome string.
Input 1:
    A = "ABC"
Output 1:
    2
    Explanation 1:
        Insert 'B' at beginning, string becomes: "BABC".
        Insert 'C' at beginning, string becomes: "CBABC".

Input 2:
    A = "AACECAAAA"
Output 2:
    2
    Explanation 2:
        Insert 'A' at beginning, string becomes: "AAACECAAAA".
        Insert 'A' at beginning, string becomes: "AAAACECAAAA" */
        
        
 class Solution {
    public int solve(string A) {
        
        string rev = new string(A.ToCharArray().Reverse().ToArray());
        
        string res = A+'$'+rev;
        
        int[] lps = new int[res.Length];
        
        Filllps(lps,res,res.Length);
        
        return A.Length - lps[res.Length-1];
          
    }
     private void Filllps(int[] lps,string pat,int length){
        
        int len=0;
        int i = 1;
        //lps[0] is always 0
        lps[0] = 0;
        while(i<length){
            if(pat[i]==pat[len]){
                len++;
                lps[i]= len;
                i++;
            }
            else{
                 if (len != 0) {
                    len = lps[len - 1];       
                 }
                 else{
                    lps[i] = len;
                    i++;
                 }  
            }   
        }
         
     }  
}
