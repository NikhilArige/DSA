//Given an array A of integers, find the maximum of j - i subjected to the constraint of A[i] <= A[j].
//A = [3, 5, 4, 2]  Output = 2


class Solution {
    public int maximumGap(List<int> A) {
        
        int n = A.Count;
        if(n==1){
            return 0;
        }
        int i,j;
        int max = int.MinValue;
        int[] minarr = new int[n];
        minarr[0]=A[0];
        int[] maxarr = new int[n];
        maxarr[n-1]=A[n-1]; 
        for(i = 1;i<n;i++){
            minarr[i]=Math.Min(minarr[i-1],A[i]);    //min till now array
        }
        for(j = n-2;j>=0;j--){
            maxarr[j]=Math.Max(maxarr[j+1],A[j]);   //max till now array from right
        }
         i=0;j=0;
        while(i<n&&j<n){ 
            if(maxarr[j]>=minarr[i]){
                max=Math.Max(max,j-i);
                j++;
            }
            else{
                i++;
            } 
        } 
        return max;
    }
}

