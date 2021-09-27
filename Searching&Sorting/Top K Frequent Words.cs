/*
Given an array of strings words and an integer k, return the k most frequent strings.
Return the answer sorted by the frequency from highest to lowest. Sort the words with the same frequency by their lexicographical order.
Example 1:
Input: words = ["i","love","leetcode","i","love","coding"], k = 2
Output: ["i","love"]
Explanation: "i" and "love" are the two most frequent words.
Note that "i" comes before "love" due to a lower alphabetical order.
Example 2:
Input: words = ["the","day","is","sunny","the","the","the","sunny","is","is"], k = 4
Output: ["the","is","sunny","day"]
Explanation: "the", "is", "sunny" and "day" are the four most frequent words, with the number of occurrence being 4, 3, 2 and 1 respectively.
*/

public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        
        var map = new Dictionary<string,int>();
        foreach(var item in words){
            map[item] = map.ContainsKey(item) ? map[item]+1 : 1;
        }
        
        var minHeap = GetMinHeap(map, k);
        
        var res = new List<string>();
        
        for(int i = 0; i < k; i++)
        {
            res.Add(minHeap.Max.Word);
            minHeap.Remove(minHeap.Max);
        }
        
        return res;
    }
    
    private SortedSet<(string Word, int Freq)> GetMinHeap(Dictionary<string,int> freqs, int k)
        {
            var comparer = Comparer<(string Word, int Freq)>.Create((a,b) =>
                                                                   a.Freq != b.Freq ? a.Freq.CompareTo(b.Freq)
                                // if the words have the same frequency, order by word in reverse
                                // because we will be retrieving in reverse order when creating the output
                                                                   : b.Word.CompareTo(a.Word));

            var minHeap = new SortedSet<(string Word, int Freq)>(comparer);

            foreach(var kv in freqs)
            {
                minHeap.Add((kv.Key, kv.Value));

                if(minHeap.Count > k){
                    minHeap.Remove(minHeap.Min);
                }
                    
            }

            return minHeap;
        }
}
