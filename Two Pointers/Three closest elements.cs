//You are given 3 arrays A, B and C. All 3 of the arrays are sorted.
//Find i, j, k such that :
//max(abs(A[i] - B[j]), abs(B[j] - C[k]), abs(C[k] - A[i])) is minimized.
//Return the minimum max(abs(A[i] - B[j]), abs(B[j] - C[k]), abs(C[k] - A[i]))

 
class Solution {
    public int minimize(List<int> A, List<int> B, List<int> C) {
        
        int p=A.Count,q=B.Count,r=C.Count;
        int i=0,j=0,k=0;
        int dif = int.MaxValue;
        while(i<p && j<q && k<r){ 
            int min = Math.Min(A[i],Math.Min(B[j],C[k]));
            int max = Math.Max(A[i],Math.Max(B[j],C[k])); 
            dif = Math.Min(dif,max-min); 
            //since absolute dif is asked , it cant be negative, this will be the least
            if(dif == 0){
                break;
            } 
            if(min == A[i]){i++;}
            else if(min == B[j]){j++;}
            else{k++;} 
        } 
        return dif;
    }
}
