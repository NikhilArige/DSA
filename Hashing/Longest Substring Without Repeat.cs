/*Given a string,
find the length of the longest substring without repeating characters.
Example:
The longest substring without repeating letters for "abcabcbb" is "abc", which the length is 3.
For "bbbbb" the longest substring is "b", with the length of 1.*/


class Solution {
    public int lengthOfLongestSubstring(string A) { 
        Dictionary<char, int> dic = new Dictionary<char, int>(); 
        int maxlength = 0;
        //starting index of substring
        int start = 0; 
        for(int end = 0; end < A.Length; end++)
        {
          if(dic.ContainsKey(A[end]))
          { 
            // moving start index
            start = Math.Max(start, dic[A[end]] + 1);
          } 
          dic[A[end]] = end;
          maxlength = Math.Max(maxlength, end-start + 1);
        }
        return maxlength;
    }
}
