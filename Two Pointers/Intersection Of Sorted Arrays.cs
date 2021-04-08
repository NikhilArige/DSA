//Find the intersection of two sorted arrays. OR in other words,Given 2 sorted arrays, find all the elements which occur in both the arrays.
//A : [1 2 3 3 4 5 6]  B : [3 3 5] Output : [3 3 5]


class Solution {
    public List<int> intersect(List<int> A, List<int> B) {
        List<int> result = new List<int>();
        int m = A.Count;
        int n = B.Count;
        int i = 0,j=0;
        while(i<m && j< n){
           if(A[i]==B[j]){
               result.Add(A[i]);
               i++;
               j++;
           } 
           else if(A[i]<B[j]){
               i++;
           }
           else{
               j++;
           } 
        } 
        return result;
    }
}
