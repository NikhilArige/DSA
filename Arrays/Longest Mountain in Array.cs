/*
You may recall that an array arr is a mountain array if and only if:
arr.length >= 3
There exists some index i (0-indexed) with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
Given an integer array arr, return the length of the longest subarray, which is a mountain. Return 0 if there is no mountain subarray.
Example 1:
Input: arr = [2,1,4,7,3,2,5]
Output: 5
Explanation: The largest mountain is [1,4,7,3,2] which has length 5.
Example 2:
Input: arr = [2,2,2]
Output: 0
Explanation: There is no mountain.
*/

public class Solution {
    public int LongestMountain(int[] arr) {
        
        int n = arr.Length;
        var up = new int[n];
        var down = new int[n];
        int max = 0 ;
        for(int i=n-2;i>=0;i--){
            if(arr[i]>arr[i+1]){
                down[i] = 1 + down[i+1];
            }
        }
        for(int i=1;i<n;i++){
            if(arr[i]>arr[i-1]){
                up[i] = 1 + up[i-1];
            }
            if(up[i]>0 && down[i]>0){
                max = Math.Max(max,up[i]+down[i]+1); 
            }
        }
        return max;
    }
}


public class Solution {
    public int LongestMountain(int[] A) {
       int res = 0, up = 0, down = 0;
        
        for (int i = 1; i < A.Length; ++i) {
            if (down > 0 && A[i - 1] < A[i] || A[i - 1] == A[i]) up = down = 0;
            if (A[i - 1] < A[i]) up++;
            if (A[i - 1] > A[i]) down++;
             if(up>0 && down>0){
                res = Math.Max(res,up+down+1); 
            }
        }
        return res; 
    }
}
