//Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
//Example:
//"A man, a plan, a canal: Panama" is a palindrome.
//"race a car" is not a palindrome.
//Return 0 / 1 ( 0 for false, 1 for true ) for this problem



class Solution {
    public int isPalindrome(string A) { 
        //char.isletter checks for letter 
        //char.isnumber checks for number
        string s = new String(A.Where(c => Char.IsLetter(c) || Char.IsNumber(c)).ToArray());
        s=s.ToLower();
         bool isPalin = true;
        int start = 0,end=s.Length-1;
        while(start<end){
          if(s[start]!=s[end]){
              isPalin = false;
              break;
          }
          start++;
          end--; 
        }
        if(isPalin){
        return 1;}
        else{
            return 0;
        } 
    }
}
