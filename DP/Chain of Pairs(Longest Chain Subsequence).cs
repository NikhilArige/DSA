/* Given a N * 2 array A where (A[i][0], A[i][1]) represents the ith pair.
In every pair, the first number is always smaller than the second number.
A pair (c, d) can follow another pair (a, b) if b < c , similarly in this way a chain of pairs can be formed.
Find the length of the longest chain subsequence which can be formed from a given set of pairs.
Example Input
Input 1:
 A = [  [5, 24]
        [39, 60]
        [15, 28]
        [27, 40]
        [50, 90]
     ]
Input 2:
A = [   [10, 20]
        [1, 2]
     ]
Example Output
Output 1:3
Output 2:1
Example Explanation
Explanation 1:
 Longest chain that can be formed is of length 3, and the chain is [ [5, 24], [27, 40], [50, 90] ]
Explanation 2:
 Longest chain that can be formed is of length 1, and the chain is [ [1, 2] ] or [ [10, 20] ] */
 
 class Solution {
    //similar to LIS problem
    public int solve(List<List<int>> A) {
        
        int n = A.Count;
        if(n==0){return 0;}
        if(n==1){return 1;}
        int[] lis = new int[n];   
        
        for(int i=0;i<n;i++){
            lis[i] = 1; 
        }
        
        for(int i=1;i<n;i++){
            for(int j=0;j<i;j++){
              if(A[i][0]>A[j][1] && lis[j]+1>lis[i])  
              lis[i] = lis[j]+1;  
            } 
        }
        
        int max = lis[0];
         for(int i =0;i<n;i++){
          max = Math.Max(max,lis[i]);     
         }
        return max;  
    }
}
