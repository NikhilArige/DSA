/* Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
Note that you must do this in-place without making a copy of the array.
Example 1:
Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:
Input: nums = [0]
Output: [0] */

public class Solution {
    public void MoveZeroes(int[] A) {
        
        int z = -1;
        for(int i=0;i<A.Length;i++){
            if(z==-1 && A[i]==0){
                z=i;
            }
            else if(z!=-1 && A[i]!=0){
                swap(A,z,i);
                z++;
            }
        }
        
    }
    
    private void swap(int[] A,int a,int b){
        var temp = A[a];
        A[a] = A[b];
        A[b] = temp;
    }
}
