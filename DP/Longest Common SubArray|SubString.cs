/*
Given two integer arrays nums1 and nums2, return the maximum length of a subarray that appears in both arrays.
Example 1:
Input: nums1 = [1,2,3,2,1], nums2 = [3,2,1,4,7]
Output: 3
Explanation: The repeated subarray with maximum length is [3,2,1].
Example 2:
Input: nums1 = [0,0,0,0,0], nums2 = [0,0,0,0,0]
Output: 5
*/

public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        var dp = new int[m+1,n+1];
        int max = int.MinValue;
        for(int i=0;i<=m;i++){
            for(int j=0;j<=n;j++){
                if(i==0 || j==0){
                    dp[i,j] = 0;
                }
                else if(nums1[i-1] != nums2[j-1]){
                    dp[i,j] = 0;
                }
                else{
                    dp[i,j] = 1 + dp[i-1,j-1];
                }
                max = Math.Max(max,dp[i,j]);
            }
        }
        return max;
    }
}
