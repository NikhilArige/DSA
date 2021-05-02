/*Given a string A and a dictionary of words B, add spaces in A to construct a sentence where each word is a valid dictionary word.
Return all such possible sentences.
Note : Make sure the strings are sorted in your result.
Input Format:
The first argument is a string, A.
The second argument is an array of strings, B.
Output Format:
Return a vector of strings representing the answer as described in the problem statement.
Examples:
Input 1:
    A = "b"
    B = ["aabbb"]
Output 1:
    []
Input 1:
    A = "catsanddog",
    B = ["cat", "cats", "and", "sand", "dog"]
Output 1:
    ["cat sand dog", "cats and dog"] */


class Solution {
    HashSet<string> set = new HashSet<string>();
    public List<string> wordBreak(string A, List<string> B) {
        
        foreach(var item in B){
            set.Add(item);
        }
        
        List<string> res= new List<string>();
        
        GetWords(A,A.Length,"",res);
         
        return res; 
    }
    
    private void GetWords(string A,int n,string result,List<string>res){
        
        for (int i=1; i<=n; i++)
        { 
            string prefix = A.Substring(0, i);
      
            if (set.Contains(prefix))
            { 
                if (i == n)
                { 
                    result += prefix;
                    res.Add(result);
                    return;
                }
                GetWords(A.Substring(i, n-i), n-i,result+prefix+" ",res);
            }
        }      
    } 
}
