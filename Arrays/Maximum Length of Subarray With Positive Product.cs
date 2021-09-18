/* Given an array of integers nums, find the maximum length of a subarray where the product of all its elements is positive.
A subarray of an array is a consecutive sequence of zero or more values taken out of that array.
Return the maximum length of a subarray with positive product.
Example 1:
Input: nums = [1,-2,-3,4]
Output: 4
Explanation: The array nums already has a positive product of 24.
Example 2:
Input: nums = [0,1,-2,-3,-4]
Output: 3
Explanation: The longest subarray with positive product is [1,-2,-3] which has a product of 6.
Notice that we cannot include 0 in the subarray since that'll make the product 0 which is not positive.
*/
public class Solution {
    public int GetMaxLen(int[] nums) {
       int n = nums.Length;
    
    int maxpos = 0 ;
    int maxneg = 0 ;
    
    int res = 0 ;
    
    for(int i=0 ; i < n ; i++){
        
      if(nums[i] > 0 ){
          maxpos ++;
          maxneg = (maxneg > 0)?maxneg+1:0 ;
      }else if(nums[i] < 0 ){
          int temp = maxpos ;
          maxpos = (maxneg > 0 )?maxneg + 1 : 0 ;
          maxneg = temp + 1 ;
      }else{
          maxpos = 0 ;
          maxneg = 0;
      }
        res = Math.Max(res , maxpos);
}
    return res;
    }
}
