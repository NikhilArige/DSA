/*
Given an integer array nums, return the maximum result of nums[i] XOR nums[j], where 0 <= i <= j < n.
Example 1:
Input: nums = [3,10,5,25,2,8]
Output: 28
Explanation: The maximum result is 5 XOR 25 = 28.
Example 2:
Input: nums = [14,70,53,83,49,91,36,80,92,51,66,70]
Output: 127
Constraints:
1 <= nums.length <= 2 * 105
0 <= nums[i] <= 231 - 1
*/

public class Solution {
    public class Trie{
        public Trie[] Children = new Trie[2];
    }
    
    public int FindMaximumXOR(int[] nums) {
        
        var root = new Trie();
        foreach(var num in nums){
            var node = root;
            for(int i=31;i>=0;i--){
                
                int cur = (num & (1 << i)) != 0 ? 1 : 0;
                if(node.Children[cur]==null){
                    node.Children[cur] = new Trie();
                }
                node = node.Children[cur];
            }
        }
        int res = int.MinValue;
         foreach(var num in nums){
             var node = root;
             int temp = 0;
            for(int i=31;i>=0;i--){
                
                int cur = (num & (1 << i)) != 0 ? 1 : 0;
                int rev = cur == 1 ? 0 : 1;
                if(node.Children[rev]!=null){
                    temp += (1 << i);                    
                    node = node.Children[rev];  
                }
                else{
                     node = node.Children[cur];
                }
            }
            res = Math.Max(res,temp); 
        }
        
        return res;
    }
}
