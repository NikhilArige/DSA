/*Given a sorted array A and a target value B, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
You may assume no duplicates in the array.
**Example Input**
Input 1:
A = [1, 3, 5, 6]
B = 5
Input 2:
A = [1, 3, 5, 6]
B = 2
**Example Output**
Output 1: 2
Output 2: 1
**Example Explanation**
Explanation 1:
5 is found at index 2.
Explanation 2:
2 will be inserted ar index 1. */



public class Solution {
	public int searchInsert(List<int> a, int b) {
	    
	    int n = a.Count;
	    int l = 0,r = n-1;
	    while(l<=r){
	      
	      int mid = (l+r)/2;
	      
            if(a[mid]==b){
              return mid;  
            } 
            else if(a[mid]<b){
              l = mid+1;  
            } 
            else{
             r = mid-1;   
            }    
	    }
	    //when l<=r, l will be at the position where b could be
	    return l;
	}
}



public class Solution {
    public int SearchInsert(int[] A, int B) {
        if(A[0]>B){
            return 0;
        }
        if(A[A.Length-1]<B){
            return A.Length;
        }
        return BS(A,0,A.Length-1,B);
    }
    
    int BS(int[] A,int l,int r,int B){
        int result = -1;
        while(l<=r){
            int mid = (l+r)/2;
             if(A[mid]==B){
                 result = mid;
                 break;
             }
            else if(A[mid]<B){
                result = mid+1;
                l = mid+1;
            }
            else{
                result = mid;
                r = mid-1;
            }
        }
        return result;
    }
}
