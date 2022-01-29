/*
Given an array of integers nums and an integer k. A continuous subarray is called nice if there are k odd numbers on it.
Return the number of nice sub-arrays.
Example 1:
Input: nums = [1,1,2,1,1], k = 3
Output: 2
Explanation: The only sub-arrays with 3 odd numbers are [1,1,2,1] and [1,2,1,1].
Example 2:
Input: nums = [2,4,6], k = 1
Output: 0
Explanation: There is no odd numbers in the array.
Example 3:
Input: nums = [2,2,2,1,2,2,1,2,2,2], k = 2
Output: 16
*/

public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        
        for(int i=0;i<nums.Length;i++){
            if(nums[i]%2 == 0){
                nums[i] = 0;
            }
            else{
                nums[i] = 1;
            }
        }
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
