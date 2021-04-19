/*Given the array of strings A,
you need to find the longest string S which is the prefix of ALL the strings in the array.
Longest common prefix for a pair of strings S1 and S2 is the longest string S which is the prefix of both S1
and S2.
For Example, longest common prefix of "abcdefgh" and "abcefgh" is "abc".*/


class Solution {
    public string longestCommonPrefix(List<string> A) {
        
        int minlen = findMinLength(A);
  
        string result = "";  
        char current;  
        for (int i = 0; i < minlen; i++)
        { 
            current = A[0][i];
  
            for (int j = 1; j < A.Count; j++) 
            {
                if (A[j][i] != current) 
                {
                    return result;
                }
            }
   
            result += current;
        } 
        return result; 
    }
    
    public int findMinLength(List<string> A){
        
        int min = int.MaxValue;
        foreach(var item in A){
        min = Math.Min(item.Length,min);   
        } 
        return min;
    }
}
