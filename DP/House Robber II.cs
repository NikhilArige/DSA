/*
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed. 
All houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. Meanwhile, adjacent houses have a security system connected,
and it will automatically contact the police if two adjacent houses were broken into on the same night.
Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.
Example 1:
Input: nums = [2,3,2]
Output: 3
Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), because they are adjacent houses.
Example 2:
Input: nums = [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
Total amount you can rob = 1 + 3 = 4.
Example 3:
Input: nums = [1,2,3]
Output: 3
*/

public class Solution {
    public int Rob(int[] nums) {
         int len = nums.Length;
        if (len == 0)
            return 0;
        if (len == 1)
            return nums[0];
        
       return Math.Max(Rob(nums, 0, len-2), Rob(nums, 1, len-1));
    }
    
    private int Rob(int[] arr, int left, int right) {
        if (left == right)
            return arr[left];
        
        int[] dp = new int[arr.Length];
        dp[left] = arr[left];
        dp[left+1] = Math.Max(arr[left], arr[left+1]);
        
        for (int i = left+2; i <= right; i++)
            dp[i] = Math.Max(arr[i] + dp[i-2], dp[i-1]);

        return dp[right];
    }
}
