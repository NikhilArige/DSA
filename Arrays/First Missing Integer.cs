/*Given an unsorted integer array, find the first missing positive integer.
Example:
Given [1,2,0] return 3,
[3,4,-1,1] return 2,
[-8, -7, -6] returns 1
Your algorithm should run in O(n) time and use constant space.*/


//O(n) and O(n) approach
class Solution {
    public int firstMissingPositive(List<int> A) {
        int n = A.Count;
        //or boolean[] can be taken
        int[] aux = new int[n+1];
        for(int i=0;i<=n;i++){
            aux[i] = 0;
        }
        if(n==1 && A[0]!= 1){return 1;}
        if(n==1 && A[0]== 1){return 2;}
        bool allNeg = true;
        foreach(var item in A){
            if(item > 0){
                allNeg = false;
                break;
            }
        }
        if(allNeg){return 1;}
        for(int i=0;i<n;i++){
           if(A[i]>0 && A[i]<n+1){
               aux[A[i]-1] = 1;
           }  
        }
        for(int i=0;i<=n;i++){
            if(aux[i]==0){
                return i+1; 
            }
        }
         return -1;
    }
}

//O(n) approach
class Solution {
    public int firstMissingPositive(List<int> A) {
        int n = A.Count;
        
        if(n==1 && A[0]!= 1){return 1;}
        if(n==1 && A[0]== 1){return 2;}
        bool onepresent = false;
        foreach(var item in A){
            if(item == 1){
                onepresent = true;
                break;
            }
        }
        if(!onepresent){return 1;}
        for(int i=0;i<n;i++){
           if(A[i]<=0 || A[i]>n){
               A[i] = 1;
           }  
        }
        //making everything more than n
        for(int i=0;i<n;i++){
            A[(A[i]-1)%n] +=n;
        }
         
        for(int i=0;i<n;i++){
           if(A[i]<=n){
               return i+1;
           }  
        }
        //if 1 to n are present
         return n+1;
    }
}









