/*Given a sorted array of integers A(0 based index) of size N, find the starting and ending position of a given integar B in array A.
Your algorithm’s runtime complexity must be in the order of O(log n).
Return an array of size 2, such that first element = starting position of B in A and second element = ending position of B in A, if B is not found in A return [-1, -1].
Input Format
The first argument given is the integer array A.
The second argument given is the integer B.
Output Format
Return an array of size 2, such that first element = starting position of B in A and second element = ending position of B in A, if B is not found in A return [-1, -1].
Constraints
1 <= N <= 10^6
1 <= A[i], B <= 10^9
For Example
Input 1:
    A = [5, 7, 7, 8, 8, 10]
    B = 8
Output 1:
    [3, 4]
Explanation 1:
    First occurence of 8 in A is at index 3
    Second occurence of 8 in A is at index 4
    ans = [3, 4]
Input 2:
    A = [5, 17, 100, 111]
    B = 3
Output 2:
    [-1, -1] */
    
    
class Solution {
    public List<int> searchRange(List<int> A, int B) {
 
        int first = FindFirst(A,0,A.Count-1,B);
         int second = FindLast(A,0,A.Count-1,B);
        return new List<int>{first,second};
    }
      
    private int FindFirst(List<int>A,int start, int end, int B){
        while(start<=end){
            int mid = (start+end)/2;
            if((mid == 0 || B> A[mid-1]) && (A[mid]==B)){
                return mid;
            }
            else if(A[mid] < B){
                start = mid+1;
            }
            else{
                end = mid-1;
            }
        }
        return -1;
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
  
