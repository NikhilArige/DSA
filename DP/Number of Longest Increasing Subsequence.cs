/*
Given an integer array nums, return the number of longest increasing subsequences.
Notice that the sequence has to be strictly increasing.
Example 1:
Input: nums = [1,3,5,4,7]
Output: 2
Explanation: The two longest increasing subsequences are [1, 3, 4, 7] and [1, 3, 5, 7].
Example 2:
Input: nums = [2,2,2,2,2]
Output: 5
Explanation: The length of longest continuous increasing subsequence is 1, and there are 5 subsequences' length is 1, so output 5.
*/

public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        
        var dp = new int[nums.Length];
        var count = new int[nums.Length];
        Array.Fill(dp,1);
        Array.Fill(count,1);
        int max = 1; 
        for(int i=1;i<nums.Length;i++){
            for(int j=0;j<i;j++){
                if(nums[i] > nums[j]){
                    if(dp[i] < dp[j]+1){
                        dp[i] = dp[j] + 1;
                        count[i] = count[j];
                    }
                    else if(dp[i] == dp[j]+1){ 
                        count[i] += count[j];
                    }
                } 
            }
            max = Math.Max(max,dp[i]);
        }
        int res = 0;
        for(int i=0;i<nums.Length;i++){
            if(dp[i] == max){
                res+=count[i];
            }
        }
        return res;
    }
}
