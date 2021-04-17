/*Given a sorted array of integers A(0 based index) of size N, find the starting and ending position of a given integar B in array A.
Your algorithm’s runtime complexity must be in the order of O(log n).
Return an array of size 2, such that first element = starting position of B in A and second element = ending position of B in A, if B is not found in A return [-1, -1].*/


class Solution {
    public List<int> searchRange(List<int> A, int B) {
 
        int first = FindFirst(A,0,A.Count-1,B);
         int second = FindLast(A,0,A.Count-1,B);
        return new List<int>{first,second};
    }
      
    private int FindFirst(List<int>A,int start, int end, int B){
        if(start<=end){
            int mid = start+(end-start)/2;
            if((mid == 0 || A[mid-1]< B) &&(A[mid]==B)){
                return mid;
            }
            else if(A[mid] > B){
                return FindFirst(A,0,mid-1,B);
            }
            else{
                return FindFirst(A,mid+1,end,B);
            }
        }
        else{
            return -1;
        }
    }
    
    private int FindLast(List<int>A,int start, int end, int B){
       if(start<=end){
            int mid = (start+end)/2;
            if((mid == A.Count-1 || A[mid+1]> B) &&(A[mid]==B)){
                return mid;
            }
            else if(A[mid] > B){
                return FindLast(A,0,mid-1,B);
            }
            else{
                return FindLast(A,mid+1,end,B);
            }
        }
        else{
            return -1;
        } 
    }
}
