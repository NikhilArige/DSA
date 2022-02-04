/*
Given a binary array nums, return the maximum length of a contiguous subarray with an equal number of 0 and 1.
Example 1:
Input: nums = [0,1]
Output: 2
Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.
Example 2:
Input: nums = [0,1,0]
Output: 2
Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
*/

public class Solution {
    public int FindMaxLength(int[] nums) {
        
        var map = new Dictionary<int,int>();
        map.Add(0,-1);
        var max = 0;
        int sum = 0;
        for(int i=0;i<nums.Length;i++){
            var val = nums[i] == 0 ? -1 : 1;
            sum+= val;
            if(map.ContainsKey(sum)){
                max = Math.Max(max,i-map[sum]);
            }
            else{
                map[sum] = i;
            }
        }
        return max;
    }
}
