/*
You are given an array nums consisting of non-negative integers. You are also given a queries array, where queries[i] = [xi, mi].
The answer to the ith query is the maximum bitwise XOR value of xi and any element of nums that does not exceed mi. 
In other words, the answer is max(nums[j] XOR xi) for all j such that nums[j] <= mi. If all elements in nums are larger than mi, then the answer is -1.
Return an integer array answer where answer.length == queries.length and answer[i] is the answer to the ith query.
Example 1:
Input: nums = [0,1,2,3,4], queries = [[3,1],[1,3],[5,6]]
Output: [3,3,7]
Explanation:
1) 0 and 1 are the only two integers not greater than 1. 0 XOR 3 = 3 and 1 XOR 3 = 2. The larger of the two is 3.
2) 1 XOR 2 = 3.
3) 5 XOR 2 = 7.
Example 2:
Input: nums = [5,2,4,6,6,3], queries = [[12,4],[8,1],[6,3]]
Output: [15,-1,5]
*/

public class Solution {
    public class Trie{
        public Trie[] Children = new Trie[2];
        public int prefixValue;
    }
    public int[] MaximizeXor(int[] nums, int[][] queries) { 
        var root = new Trie();
        Array.Sort(nums);
        var map = new Dictionary<int[],int>();
        for(int i=0;i<queries.Length;i++){
            map.Add(queries[i],i);
        }
        Array.Sort<int[]>(queries,(a,b)=>a[1].CompareTo(b[1]));
        var res = new int[queries.Length];
        int index = 0;
        foreach(var query in queries){
            int max = query[1];
            while (index < nums.Length && nums[index] <= max) {
                Insert(nums[index],root);
                index++;
            }
            int tempAns = -1;
            if (index != 0) {
                tempAns = GetMax(query[0],root);
            }
             res[map[query]] = tempAns;
        } 
         
        return res;
    }
        public void Insert(int num,Trie node){
            for(int i=31;i>=0;i--){ 
                int cur = (num & (1 << i)) != 0 ? 1 : 0;
                if(node.Children[cur]==null){
                    node.Children[cur] = new Trie();
                }
                node = node.Children[cur];
            }
            node.prefixValue = num;
        }
        public int GetMax(int num,Trie node){
            for(int i=31;i>=0;i--){
                int cur = (num & (1 << i)) != 0 ? 1 : 0;
                int rev = cur == 1 ? 0 : 1;
                if(node.Children[rev]!=null){
                    node = node.Children[rev];  
                }
                else{ 
                     node = node.Children[cur];
                }
            }
           return node.prefixValue ^ num; 
        }
}
