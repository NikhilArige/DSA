/*
Given an array nums which consists of non-negative integers and an integer m, you can split the array into m non-empty continuous subarrays.
Write an algorithm to minimize the largest sum among these m subarrays.
Example 1:
Input: nums = [7,2,5,10,8], m = 2
Output: 18
Explanation:
There are four ways to split nums into two subarrays.
The best way is to split it into [7,2,5] and [10,8],
where the largest sum among the two subarrays is only 18.
Example 2:
Input: nums = [1,2,3,4,5], m = 2
Output: 9
Example 3:
Input: nums = [1,4,4], m = 3
Output: 4
*/

public class Solution {
    public int SplitArray(int[] nums, int m) {
        int lo = nums.Max();
        int hi = nums.Sum();
        int res = 0;
        
        while(lo <= hi){
            int mid = lo + (hi - lo)/2;
            if(isPossibleToSplit(nums, mid, m)){
                res = mid;
                hi = mid - 1;
            }
            else{
                lo = mid + 1;
            }
        }
        
        return res;
    }
    private bool isPossibleToSplit(int[] numsArray, int mid, int maxArrCount){
        int currSubArray = 1;
        int subArraySum = 0;
        for(int i = 0; i < numsArray.Length; i++){
            subArraySum += numsArray[i];
            if(subArraySum > mid){
                currSubArray++;
                subArraySum = numsArray[i];
            }
        }
        return currSubArray <= maxArrCount;
    }
}
