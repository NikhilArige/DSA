//Given an array ‘A’ of sorted integers and another non negative integer k, find if there exists 2 indices i and j such that A[i] - A[j] = k, i != j.
//A : [1 3 5]  k : 4   Output : 1 as 5 - 1 = 4



class Solution {
    public int diffPossible(List<int> A, int B) { 
        int n = A.Count;
        int i=0,j=0;
        while(i<n && j<n){ 
          if(i!=j && A[i]-A[j]==B){ 
              return 1;
          }
         if(A[i]-A[j]>B){
             j++;
         }    
          else{
            i++;  
          } 
        }
        return 0; 
    }
}
