//Given an integer array A of size N.
//You need to check that whether there exist a element which is strictly greater than all the elements on left of it and strictly smaller than all the elements on right of it.
//If it exists return 1 else return 0.
//NOTE:Do not consider the corner elements i.e A[0] and A[N-1] as the answer.
//A = [5, 1, 4, 3, 6, 8, 10, 7, 9] Output :1
//A[4] = 6 is the element we are looking for.All elements on left of A[4] are smaller than it and all elements on right are greater.


class Solution {
    public int perfectPeak(List<int> A) {
        int n=A.Count;
        int leftmax = int.MinValue; 
        for(int i = 1;i<n-1;i++){
            leftmax = Math.Max(leftmax,A[i-1]);
            if(A[i]>leftmax){
                int rightmin = A[i+1];
                for(int j=i+1;j<n-1;j++){ 
                    rightmin = Math.Min(rightmin,A[j+1]); 
                }
                if(rightmin>A[i]){
                    return 1;
                }
            } 
        } 
        return 0;
    }
}

//or
//take two arrays and fill with min and max,and then checking each would give result
