/* Given a string S and a string T, find the minimum window in S which will contain all the characters in T in linear time complexity.
Note that when the count of a character C in T is N, then the count of C in minimum window in S should be at least N.
Example :
S = "ADOBECODEBANC"
T = "ABC"
Minimum window is "BANC"
 Note:
If there is no such window in S that covers all characters in T, return the empty string ''.
If there are multiple such windows, return the first occurring minimum window ( with minimum start index ). */

class Solution {
    public string minWindow(string A, string B) {
        
        if(string.IsNullOrEmpty(A) || string.IsNullOrEmpty(B)){
            return "";
        }
         
        Dictionary<char,int> dict = new Dictionary<char,int>();
        foreach(var item in B){
            if(dict.ContainsKey(item)){
                dict[item]++;
            }
            else{
                dict[item] = 1;
            }
        }
        
        int i =0,j=0,count = dict.Count;
        int left = 0,right = A.Length-1,min=A.Length;
        bool found = false;
        
        while(j<A.Length){
           
           char endchar = A[j++];
           if(dict.ContainsKey(endchar)){
               dict[endchar]--;
               if(dict[endchar]==0){
                    count--;
                } 
           }
           if(count>0){
               continue;
           }
           //incrementing i and removing useless characters in beginning
           while(count==0){
               char startchar = A[i++];
               if(dict.ContainsKey(startchar)){
               dict[startchar]++;
               if(dict[startchar]>0){
                    count++;
                } 
              }
           } 
            
            if(j-i < min){
                left = i;
                right = j;
                min = j-i;
                found = true;
            } 
        }
        
        if(found){ 
           return A.Substring(left-1,right-left+1); 
        }
        return "";
    }
}
