/* Given an array of integers nums and an integer k, return the total number of continuous subarrays whose sum equals to k.
Example 1:
Input: nums = [1,1,1], k = 2
Output: 2
Example 2:
Input: nums = [1,2,3], k = 3
Output: 2 */

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        
        int sum = 0,count=0;
        
        var set = new Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++){
            
            sum+=nums[i];
            if(sum==k){
                count++;
            }
            if(set.ContainsKey(sum-k)){
                count+=set[sum-k];
            }
            if(set.ContainsKey(sum)){
                set[sum]++;
            }
            else{
                set.Add(sum,1);
            } 
        } 
        return count; 
    }
}
