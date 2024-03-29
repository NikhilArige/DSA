/* Given a circular integer array nums of length n, return the maximum possible sum of a non-empty subarray of nums.
A circular array means the end of the array connects to the beginning of the array. Formally, the next element of nums[i] is nums[(i + 1) % n] and 
the previous element of nums[i] is nums[(i - 1 + n) % n].
A subarray may only include each element of the fixed buffer nums at most once. Formally, for a subarray nums[i], nums[i + 1], ..., nums[j], 
there does not exist i <= k1, k2 <= j with k1 % n == k2 % n.
Example 1:
Input: nums = [1,-2,3,-2]
Output: 3
Explanation: Subarray [3] has maximum sum 3
Example 2:
Input: nums = [5,-3,5]
Output: 10
Explanation: Subarray [5,5] has maximum sum 5 + 5 = 10
Example 3:
Input: nums = [3,-1,2,-1]
Output: 4
Explanation: Subarray [2,-1,3] has maximum sum 2 + (-1) + 3 = 4
Example 4:
Input: nums = [3,-2,2,-3]
Output: 3
Explanation: Subarray [3] and [3,-2,2] both have maximum sum 3
Example 5:
Input: nums = [-2,-3,-1]
Output: -1
Explanation: Subarray [-1] has maximum sum -1 */

public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        
        bool allNeg = true;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>0){
                allNeg = false;        
                break;
            }
        }
        if(allNeg){
           return nums.Max(); 
        }
        int maxKadane = Kadane(nums);
        int maxsum = 0;
        for(int i=0;i<nums.Length;i++){
            maxsum += nums[i];
            nums[i] = -nums[i];
        }
        maxsum += Kadane(nums);
        return Math.Max(maxsum,maxKadane);
    }
    
    int Kadane(int[] a){
        int n = a.Length;
        int cur = 0, sum = 0;
        
        for (int i = 0; i < n; i++) {
            sum += a[i];
            if (sum < 0){
                sum = 0;
            }
            cur = Math.Max(cur,sum);
        }
        return cur;
    }
}


public class Solution {
    public int MaxSubarraySumCircular(int[] A) {
       if(A.Length == 0) return 0;
        int sum = A[0];
        int maxSoFar = A[0];
        int maxTotal = A[0];
        int minTotal = A[0];
        int minSoFar = A[0];
        for(int i = 1; i < A.Length; i++){
            int num = A[i];
            maxSoFar = Math.Max(num, maxSoFar + num);
            maxTotal = Math.Max(maxSoFar, maxTotal);
            
            minSoFar = Math.Min(num, minSoFar + num);
            minTotal = Math.Min(minTotal, minSoFar);
            
            sum += num;
        }
        if(sum == minTotal) return maxTotal;
        return Math.Max(sum - minTotal, maxTotal); 
        
    }
}







