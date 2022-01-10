/*
You are given an integer array nums and an integer x. In one operation, 
you can either remove the leftmost or the rightmost element from the array nums and subtract its value from x. Note that this modifies the array for future operations.
Return the minimum number of operations to reduce x to exactly 0 if it is possible, otherwise, return -1.
Example 1:
Input: nums = [1,1,4,2,3], x = 5
Output: 2
Explanation: The optimal solution is to remove the last two elements to reduce x to zero.
Example 2:
Input: nums = [5,6,7,8,9], x = 4
Output: -1
Example 3:
Input: nums = [3,2,20,1,1,3], x = 10
Output: 5
Explanation: The optimal solution is to remove the last three elements and the first two elements (5 operations in total) to reduce x to zero.
*/

public class Solution {
    public int MinOperations(int[] nums, int x) {
        
        //find max subarray with total sum - x and return total length - subarraylength 
        var subArraytotal = nums.Sum() - x;
        if(subArraytotal < 0){
            return -1;
        }
        if(subArraytotal == 0){
            return nums.Length;
        }
        var map = new Dictionary<int,int>();
        map.Add(0,-1);
        int res = -1;
        int cur = 0;
        for(int i=0;i<nums.Length;i++){
            
            cur += nums[i];
            if(map.ContainsKey(cur-subArraytotal)){
                res = Math.Max(res,i-map[cur-subArraytotal]);
            }
            map.TryAdd(cur,i);
        }
        
        return res == -1 ? -1 : nums.Length - res;
    }
}
