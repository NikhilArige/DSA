/*Given an array of integers A of size N and an integer B.
Array A is rotated at some pivot unknown to you beforehand.
(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2 ).
You are given a target value B to search. If found in the array, return its index, otherwise return -1.
You may assume no duplicate exists in the array.
NOTE:- Array A was sorted in non-decreasing order before rotation.
NOTE : Think about the case when there are duplicates. Does your current solution work? How does the time complexity change?*
Input Format
The first argument given is the integer array A.
The second argument given is the integer B.
Output Format
Return index of B in array A, otherwise return -1
Constraints
1 <= N <= 1000000
1 <= A[i] <= 10^9
all elements in A are disitinct.
For Example
Input 1:
    A = [4, 5, 6, 7, 0, 1, 2, 3]
    B = 4
Output 1:
    0
Explanation 1:
 Target 4 is found at index 0 in A.
Input 2:
    A = [5, 17, 100, 3]
    B = 6
Output 2:
    -1  */
    
    
    
class Solution {
    public int search(List<int> A, int B) {
        
        return Binarysearch(A, 0, A.Count - 1, B);
    }
    
    private int Binarysearch(List<int> A,int low,int high,int B){
        
        if(low>high){
            return -1;
        }
        int mid = (low+high)/2;
        if(A[mid]==B){
            return mid;
        }
        //if this half is sorted 
        if(A[low]<=A[mid]){
            
            if(A[low]<= B && B <= A[mid]){
                return Binarysearch(A,low,mid-1,B);
            }
            else{
                return Binarysearch(A,mid+1,high,B);
            }
        }
        //if this half is sorted
        else{
            if(A[mid]<= B && B <= A[high]){
                return Binarysearch(A,mid+1,high,B);
            }
            else{
                return Binarysearch(A,low,mid-1,B);
            }
        }
         
    }
}
    
