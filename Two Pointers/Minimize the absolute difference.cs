/*Given three sorted arrays A, B and Cof not necessarily same sizes.
Calculate the minimum absolute difference between the maximum and minimum number from the triplet a, b, c such that a, b, c belongs arrays A, B, C respectively.
i.e. minimize | max(a,b,c) - min(a,b,c) |.
Example :
Input:
A : [ 1, 4, 5, 8, 10 ]
B : [ 6, 9, 15 ]
C : [ 2, 3, 6, 6 ]
Output: 1
Explanation: We get the minimum difference for a=5, b=6, c=6 as | max(a,b,c) - min(a,b,c) | = |6-5| = 1. */


class Solution {
    public int solve(List<int> A, List<int> B, List<int> C) {
        
        int i, j, k;
       
        i = A.Count - 1;
        j = B.Count - 1;
        k = C.Count - 1;
        
        int dif = int.MaxValue;
       
       while(i>=0 && j>=0 && k>=0){ 
            int min = mini(A[i],B[j],C[k]);
            int max = maxi(A[i],B[j],C[k]);; 
            dif = Math.Min(dif,max-min);  
            if(dif == 0){
                break;
            } 
            if(max == A[i]){i--;}
            else if(max == B[j]){j--;}
            else{k--;} 
        } 
        return dif;
    }
    
    private int maxi(int a,int b,int c){
        return Math.Max(a,Math.Max(b,c)); 
    }
    
    private int mini(int a,int b,int c){
        return Math.Min(a,Math.Min(b,c)); 
    }
}
