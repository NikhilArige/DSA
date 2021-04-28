/*Given an array with n objects colored red, white or blue,
sort them so that objects of the same color are adjacent, with the colors in the order red, white and blue.
Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
Note: Using library sort function is not allowed.
Example :
Input : [0 1 2 0 1 2]
Modify array so that it becomes : [0 0 1 1 2 2] */


public class Solution {
	public void sortColors(List<int> a) {
	    
	        int n = a.Count;
            int high = n-1;
            int low = 0, mid = 0;
            while(mid<=high){
                switch(a[mid]){
                    case 0: swap(a, low, mid);
                            low++;
                            mid++;
                            break;
                    case 1: mid++; 
                            break;
                    case 2: swap(a, mid, high);
                            high--;
                            break; 
                }
            }
	}
	
	private void swap(List<int> A,int i,int j){ 
	    int temp = A[i];
	    A[i] = A[j];
	    A[j] = temp; 
	}
}
