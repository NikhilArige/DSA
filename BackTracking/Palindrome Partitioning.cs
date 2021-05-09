/*Given a string s, partition s such that every string of the partition is a palindrome.
Return all possible palindrome partitioning of s.
For example, given s = "aab",
Return
  [
    ["a","a","b"]
    ["aa","b"],
  ] */
  
public class Solution {
	public List<List<string>> partition(string input) {
	   
	    int n = input.Count;
  
        List<List<string>> result = new List<List<string>>();
  
        List<string>res = new List<string>();
  
        getpartitions(result, res, 0, n, input);
        
        return allPart;
	    
	}
	
	private void getpartitions(List<List<string>> result,
	List<string> res, int start, int n, string input)
    {
        
        if (start >= n)
        {
            result.Add(new List<string>(res));
            return;
        }
  
  
        for (int i = start; i < n; i++)
        {
              
            if (isPalindrome(input, start, i))
            {
                  
                res.Add(input.Substring(start,i+1-start));
  
                getpartitions(result, res, i+1, n, input);
  
                res.RemoveAt(res.Count-1);
            }
        }
    } 
    
	private boolean isPalindrome(string input,  int start, int end)
    {
        while (start < end)
        {
            if (input[start++] != input[end--])
                return false;
        }
        return true;
    }
}
