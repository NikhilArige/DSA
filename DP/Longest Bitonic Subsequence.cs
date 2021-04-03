//Given an 1D integer array A of length N, find the length of longest subsequence which is first increasing then decreasing.
//Input = [1, 11, 2, 10, 4, 5, 2, 1] Output = 6 Reason : [1 2 10 4 2 1] is the longest sequence.

class Solution {
    public int longestSubsequenceLength(List<int> A) {
        
        int n = A.Count;
        if(n==0){return 0;}
        if(n==1){return 1;}
        int[] lis = new int[n];             //contains longest increasing subsequence
        int[] lds = new int[n];             //contains longest decreasing subsequence
        
        for(int i=0;i<n;i++){
            lis[i] = 1;
            lds[i] = 1;
        }
        
        for(int i=1;i<n;i++){
            for(int j=0;j<i;j++){
              if(A[i]>A[j] && lis[j]+1>lis[i])      
              lis[i] = lis[j]+1;                             //updating lis
            } 
        }
        
        for(int i=n-2;i>=0;i--){
            for(int j=n-1;j>i;j--){
              if(A[i]>A[j] && lds[j]+1>lds[i])  
              lds[i] = lds[j]+1;                            //updating lds
            } 
        }
        
        int max = lis[0]+lds[1]-1;
        
        for(int i=0;i<n;i++){
        max = Math.Max(max,lis[i]+lds[i]-1);            //taking max of (lis[i]+lds[i]-1)
        } 
        return max; 
    }
}
