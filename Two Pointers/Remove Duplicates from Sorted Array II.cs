/*Given a sorted array, remove the duplicates in place such that each element can appear atmost twice and return the new length.
Do not allocate extra space for another array, you must do this in place with constant memory.
Note that even though we want you to return the new length, make sure to change the original array as well in place
For example,
Given input array A = [1,1,1,2],
Your function should return length = 3, and A is now [1,1,2].*/


public class Solution {
    public int removeDuplicates(List<int> a) {
        
        int n = A.Count;
        if(n==1){
            return 1;
        } 
        int i = 0;
        if(A[i+1] == A[i]){
                i++;
            }
        for(int j = i+1;j<n;j++){
            
            if(A[i]!=A[j]){
                i++;
                swap(A,i,j);
                if(A[j+1] == A[i]){
                        A[i+1] = A[i];   //as atmost two can be present
                        i++;
                    }
            } 
        }
        return i+1;
    }
    
    private void swap(List<int> A,int i,int j){ 
        int temp = A[i];
        A[i] = A[j];
        A[j] = temp; 
    }
}
