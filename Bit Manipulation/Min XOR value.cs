//Given an integer array A of N integers, find the pair of integers in the array which have minimum XOR value. Report the minimum XOR value.


class Solution {
    public int findMinXor(List<int> A) {
        
        A.Sort();
        int result = int.MaxValue; 
        for(int i = 0;i<A.Count-1;i++){ 
            result = Math.Min(result,A[i]^A[i+1]); 
        } 
        return result;
    }
}
