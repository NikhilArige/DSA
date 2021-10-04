/*
Given an array of non-negative integers nums, you are initially positioned at the first index of the array.
Each element in the array represents your maximum jump length at that position.
Your goal is to reach the last index in the minimum number of jumps.
You can assume that you can always reach the last index.
Example 1:
Input: nums = [2,3,1,1,4]
Output: 2
Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:
Input: nums = [2,3,0,1,4]
Output: 2
*/

public class Solution {
    public int Jump(int[] nums) {
        
        int len = nums.Length;
        if (len == 0 || len == 1){
            return 0; 
        }
        int current = 0, to = 0, maxTo = 0, steps = 0;
        while (current <= to) {
            steps++;
            while (current <= to) {
                maxTo = Math.Max(maxTo, nums[current] + current);
                if (maxTo >= len-1){                                  //bfs kind of soln
                  return steps;  
                } 
                current++;
            }
            to = maxTo;
        }
        
        return -1;
    }
}
