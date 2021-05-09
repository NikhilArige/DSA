/* You are given a string, S, and a list of words, L, that are all of the same length.
Find all starting indices of substring(s) in S that is a concatenation of each word in L exactly once and without any intervening characters.
Example :
S: "barfoothefoobarman"
L: ["foo", "bar"]
You should return the indices: [0,9].
(order does not matter). */



class Solution {
    public List<int> findSubstring(string A, List<string> B) {
        
            var res = new List<int>();
            
            if (B.Count == 0 ||  A.Length == 0)
            {
                return res;
            }

            var lookup = new Dictionary<string, int>();
            var length = B[0].Length; 
            
            foreach (var word in B)
            {
                if (!lookup.ContainsKey(word))
                {
                    lookup.Add(word, 0);
                }

                lookup[word]++;
            }

            for(var i = 0; i < A.Length; i++)
            {
                var lookupCopy = new Dictionary<string,int>(lookup);

                var j = i;
 
                while (j+length <= A.Length)
                {
                     
                    var word = A.Substring(j, length);

                    if (lookupCopy.ContainsKey(word))
                    {
                        lookupCopy[word]--;

                        if (lookupCopy[word] == 0)
                        {
                            lookupCopy.Remove(word);
                        }

                        j += length;
                    }
                    else
                    {
                        break;
                    }
                }

                // All the words matched!  
                if (lookupCopy.Count == 0)
                {
                    res.Add(i);
                }
            }

            return res;
    }
}
