/*
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
Example 1:
Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
Example 2:
Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
Constraints:
1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in non-decreasing order.
Follow up: Squaring each element and sorting the new array is very trivial, could you find an O(n) solution using a different approach?
*/

public class Solution {
    public int[] SortedSquares(int[] A) {
            
            var result = new int[A.Length];
            int start = 0;
            int end = A.Length - 1;
            int i = end;
            while (start<=end)
            {
                if (A[start]*A[start]>A[end]*A[end])
                {
                    result[i--] = A[start] * A[start];
                    start++;
                }
                else
                {
                    result[i--] = A[end] * A[end];
                    end--;
                }
            }
            return result;
    }
}



