/* Given an integer array nums, find three numbers whose product is maximum and return the maximum product.
Example 1:
Input: nums = [1,2,3]
Output: 6
Example 2:
Input: nums = [1,2,3,4]
Output: 24
Example 3:
Input: nums = [-1,-2,-3]
Output: -6 */

public class Solution {
    public int MaximumProduct(int[] s) {
        Array.Sort(s);
        int n = s.Length;
        int r = s[n-1]*s[n-2]*s[n-3];
        int l = s[0]*s[1]*s[n-1];
        return Math.Max(l,r);
    }
}


// Time O(n) 
public class Solution {
    public int MaximumProduct(int[] nums) {
        int min1, min2, max1, max2, max3;
        min1 = min2 = int.MaxValue;
        max1 = max2 = max3 = int.MinValue;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]<min1)
            {
                min2 = min1;
                min1 = nums[i];
            }
            else if(nums[i]<min2)
                min2 = nums[i];
            
            if(nums[i]>max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = nums[i];
            }
            else if(nums[i]>max2)
            {
                max3 = max2;
                max2 = nums[i];
            }
            else if(nums[i]>max3)
                max3 = nums[i];
        }
        return Math.Max(min1*min2*max1 , max1*max2*max3);
    }
}
