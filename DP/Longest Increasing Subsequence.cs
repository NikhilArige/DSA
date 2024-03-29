Find the longest increasing subsequence of a given array of integers, A.
In other words, find a subsequence of array in which the subsequence’s elements are in strictly increasing order, and in which the subsequence is as long as possible.
This subsequence is not necessarily contiguous, or unique.
In this case, we only care about the length of the longest increasing subsequence.
Input 1: 
A = [1, 2, 1, 5]
Output 1: 3
Explanation 1:The sequence : [1, 2, 5]
Input 2: A = [0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15]
Output 2: 6
Explanation 2:The sequence : [0, 2, 6, 9, 13, 15] or [0, 4, 6, 9, 11, 15] or [0, 4, 6, 9, 13, 15]

class Solution {
    public int lis(List<int> A) {
        int n = A.Count;
        if(n==0){return 0;}
        if(n==1){return 1;}
        int[] lis = new int[n];   
        
        for(int i=0;i<n;i++){
            lis[i] = 1; 
        }
        
        for(int i=1;i<n;i++){
            for(int j=0;j<i;j++){
              if(A[i]>A[j] && lis[j]+1>lis[i])  //COMPARE A[I] WITH A[J] AND LIS[I] WITH LIS[J]+1
              lis[i] = lis[j]+1;  
            } 
        }
        
        int max = lis[0];
         for(int i =0;i<n;i++){
          max = Math.Max(max,lis[i]);     //TAKING MAX FROM LIS[N]   
         }
        return max; 
    }
}
