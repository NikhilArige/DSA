/* Remove duplicates from Sorted Array
Given a sorted array, remove the duplicates in place such that each element appears only once and return the new length.
Note that even though we want you to return the new length, make sure to change the original array as well in place
Do not allocate extra space for another array, you must do this in place with constant memory.
Example:
Given input array A = [1,1,2],
Your function should return length = 2, and A is now [1,2]. */

public class Solution {
	public int removeDuplicates(List<int> a) {
	    
	    int n = A.Count;
	    if(n==1){
	        return 1;
	    } 
	    int i = 0;
	    for(int j = i+1;j<n;j++){
	        
	        if(A[i]!=A[j]){
	            i++;
	            swap(A,i,j);
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

//simpler one
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        foreach(var num in nums){
            if((i<1)||(num>nums[i-1])){
                nums[i++] = num;
            }
        }
        return i;
    }
}
