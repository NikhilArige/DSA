/* An integer array is called arithmetic if it consists of at least three elements and if the difference between any two consecutive elements is the same.
For example, [1,3,5,7,9], [7,7,7,7], and [3,-1,-5,-9] are arithmetic sequences.
Given an integer array nums, return the number of arithmetic subarrays of nums.
A subarray is a contiguous subsequence of the array.
Example 1:
Input: nums = [1,2,3,4]
Output: 3
Explanation: We have 3 arithmetic slices in nums: [1, 2, 3], [2, 3, 4] and [1,2,3,4] itself.
Example 2:
Input: nums = [1]
Output: 0 */

public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        int res = 0,cur = 0;
        for(int i=2;i<nums.Length;i++){
            if(nums[i]-nums[i-1] == nums[i-1] - nums[i-2]){
                cur++;
                res += cur;
            }
            else{
                cur = 0;
            }
        }
        return res;
    }
}
