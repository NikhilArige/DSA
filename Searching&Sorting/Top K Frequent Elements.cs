/* Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
Example 1:
Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:
Input: nums = [1], k = 1
Output: [1] */

public class Solution {
    public int[] TopKFrequent(int[] A, int k) {
        var map = new Dictionary<int,int>();
        foreach(var item in A){
             map[item] = map.ContainsKey[item] ? map[item] + 1 : 1;
        }
        return map.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}
