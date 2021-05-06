/* Given an array A of integers and another non negative integer k, find if there exists 2 indices i and j such that A[i] - A[j] = k, i != j.
Example :
Input :
A : [1 5 3]
k : 2
Output : 1 as 3 - 1 = 2
Return 0 / 1 for this problem. */

class Solution {
    public int diffPossible(List<int> A, int B) {
        
        HashSet<int> set = new HashSet<int>();
        for(int i =0;i<A.Count;i++){
            set.Add(A[i]);
        }  
        for(int i=0;i<A.Count;i++){
            
            if( A[i]<B && set.Contains(B+A[i]) && (A.IndexOf(B+A[i]) != i )){ 
                return 1;
            }
            else if (A[i]>B && set.Contains(A[i]-B) && (A.IndexOf(A[i]-B) != i )){
                return 1;
            } 
        }
        return 0;
    }
}
