/*Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
You must write an algorithm that runs in O(n) time and without using the division operation.
Example 1:
Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:
Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0] */

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var left = new int[n];
        var right = new int[n];
        left[0] = 1;
        right[n-1] = 1;
        for(int i=1;i<n;i++){
            left[i] = left[i-1]*nums[i-1];
        }
         for(int i=n-2;i>=0;i--){
            right[i] = right[i+1]*nums[i+1];
        }
        var result = new int[n];
        for(int i=0;i<n;i++){
            result[i] = left[i]*right[i];
        }
        return result;
    }
}

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
         if (nums == null || nums.Length == 0)
                return null;

            int[] result = new int[nums.Length];
            int temp = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = temp;
                temp *= nums[i];
            }

            temp = 1;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] *= temp;
                temp *= nums[i];
            }

            return result;
    }
}
 
