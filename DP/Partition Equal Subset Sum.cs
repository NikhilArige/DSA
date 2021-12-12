/*
Given a non-empty array nums containing only positive integers, find if the array can be partitioned into two subsets such that the sum of elements in both subsets is equal.
Example 1:
Input: nums = [1,5,11,5]
Output: true
Explanation: The array can be partitioned as [1, 5, 5] and [11].
Example 2:
Input: nums = [1,2,3,5]
Output: false
Explanation: The array cannot be partitioned into equal sum subsets.
*/

public class Solution {
    public bool CanPartition(int[] nums) {
        var sum = (nums.Sum());
        if(sum%2!=0){
            return false;
        }
        sum/= 2;
        var dp = new bool[nums.Length+1,1+sum];
        for(int i=0;i<=nums.Length;i++){
            for(int j=0;j<=sum;j++){
                if(i==0 || j==0){
                    dp[i,j] = false;
                }
                else if(j<nums[i-1]){
                    dp[i,j] = dp[i-1,j];
                }
                else if(j==nums[i-1]){
                    dp[i,j] = true;
                }
                else{
                    dp[i,j] = dp[i-1,j] || dp[i-1,j-nums[i-1]];
                }
            }
        }
        return dp[nums.Length,sum];
    }
}
