//Find the contiguous subarray within an array, A of length N which has the largest sum.
//You are given a one dimensional array that may contain both positive and negative integers, find the sum of contiguous subarray of numbers which has the largest sum.
//For example, if the given array is {-2, -5, 6, -2, -3, 1, 5, -6}, then the maximum subarray sum is 7.
class Solution {
    public int maxSubArray(List<int> A) {
        int n = A.Count;
        if(A.Count == 1){return A[0];}
        
        int max = int.MinValue;
        int sum = 0;
        bool allNeg = true;
        for(int i=0;i<n;i++){
            if(A[i]>0){
                allNeg = false;         //Check if all are negative
                break;
            }
        }
        int min = int.MinValue;
        for(int i =0;i<n;i++){
            sum += A[i];
            min = Math.Max(min,A[i]);
            max = Math.Max(sum,max);
            if(sum < 0){
                sum = 0;
            }
        }
        
        if(allNeg){
            return min;
        }
        else{ 
            return max;
        }
         
    }
}
