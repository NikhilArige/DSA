Given a string A denoting a stream of lowercase alphabets. You have to make new string B.
B is formed such that we have to find first non-repeating character each time a character is inserted to the stream and append it at the end to B. If no non-repeating character is found then append '#' at the end of B.
Example Input
Input 1:
A = "abadbc"
Input 2:
A = "abcabc"
Example Output
Output 1:"aabbdd"
Output 2:"aaabc#"
Example Explanation
Explanation 1:
    "a"      -   first non repeating character 'a'
    "ab"     -   first non repeating character 'a'
    "aba"    -   first non repeating character 'b'
    "abad"   -   first non repeating character 'b'
    "abadb"  -   first non repeating character 'd'
    "abadbc" -   first non repeating character 'd'
Explanation 2:
    "a"      -   first non repeating character 'a'
    "ab"     -   first non repeating character 'a'
    "abc"    -   first non repeating character 'a'
    "abca"   -   first non repeating character 'b'
    "abcab"  -   first non repeating character 'c'
    "abcabc" -   no non repeating character so '#' */
    

using System.Text;
class Solution {
    public string solve(string A) {
        //Always use string builder for better performance
        StringBuilder result = new StringBuilder(); 
        Queue<char> q = new Queue<char>();
        int[] charCount = new int[26]; //as only small alphabets are there
        for (int i = 0; i < A.Length; i++)
        {
            char ch = A[i];
            
            q.Enqueue(ch);
            //incrementing char count 
            charCount[ch - 'a']++;
   
            while (q.Count > 0)
            {
                if (charCount[q.Peek() - 'a'] > 1)
                {
                    q.Dequeue();
                }
                else
                { 
                    result.Append(q.Peek());
                    break;
                }
            }
            if (q.Count == 0)
            {
                result.Append("#");
            }
        }
        return result.ToString();
    }
}

    
    
