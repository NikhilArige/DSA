/*
Given an integer array nums, reorder it such that nums[0] < nums[1] > nums[2] < nums[3]....
You may assume the input array always has a valid answer.
Example 1:
Input: nums = [1,5,1,1,6,4]
Output: [1,6,1,5,1,4]
Explanation: [1,4,1,5,1,6] is also accepted.
Example 2:
Input: nums = [1,3,2,2,3,1]
Output: [2,3,1,3,1,2]
Constraints:
1 <= nums.length <= 5 * 104
0 <= nums[i] <= 5000
It is guaranteed that there will be an answer for the given input nums.
*/


public class Solution {
    public void WiggleSort(int[] nums) {
        
        int n = nums.Length;
        var newarr = new int[n];
        Array.Copy(nums,newarr,n);
        Array.Sort(newarr);
        var last = n-1;
        for(int i=1;i<n;i+=2){
            nums[i]=newarr[last--];
        }
        for(int i=0;i<n;i+=2){
            nums[i]=newarr[last--];
        }
    }
}
