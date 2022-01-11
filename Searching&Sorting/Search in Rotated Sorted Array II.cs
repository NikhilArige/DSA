/*
There is an integer array nums sorted in non-decreasing order (not necessarily with distinct values).
Before being passed to your function, nums is rotated at an unknown pivot index k (0 <= k < nums.length) 
such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,4,4,5,6,6,7] 
might be rotated at pivot index 5 and become [4,5,6,6,7,0,1,2,4,4].
Given the array nums after the rotation and an integer target, return true if target is in nums, or false if it is not in nums.
You must decrease the overall operation steps as much as possible.
Example 1:
Input: nums = [2,5,6,0,0,1,2], target = 0
Output: true
Example 2:
Input: nums = [2,5,6,0,0,1,2], target = 3
Output: false
*/

public class Solution {
    public bool Search(int[] A, int B) {
        
        return BS(A,0,A.Length-1,B) != -1; 
        
    }
    
    int BS(int[] A,int low,int high,int B){
        if(low>high){
            return -1;
        }
        int mid=(low+high)/2;
        if(A[mid]==B){
            return mid;
        }
        
        //only extra condition eg: 1,0,1,1,1
        if(A[low] == A[mid]){
           low++; 
            return BS(A,low,high,B);
        }
        //if this half is sorted 
        else if(A[low]<=A[mid]){
            
            if(A[low]<= B && B <= A[mid]){
                return BS(A,low,mid-1,B);
            }
            else{
                return BS(A,mid+1,high,B);
            }
        }
        //if this half is sorted
        else{
          
            if(A[mid]<= B && B <= A[high]){
                return BS(A,mid+1,high,B);
            }
            else{
                return BS(A,low,mid-1,B);
            }
        }}
}
