//Given an array A of size N. You need to find the sum of Maximum and Minimum element in the given array.
//NOTE: You should make minimum number of comparisons.

class Solution {
    public int solve(List<int> A) {
        int n= A.Count;
        int max=int.MinValue;
        int min=int.MaxValue;
        for(int i=0;i<n;i++){
            max=Math.Max(max,A[i]);
            min=Math.Min(min,A[i]);
        }
        return max-min;
    }
}
