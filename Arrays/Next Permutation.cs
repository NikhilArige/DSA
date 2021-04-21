/*Implement the next permutation, which rearranges numbers into the numerically next greater permutation of numbers for a given array A of size N.
If such arrangement is not possible, it must be rearranged as the lowest possible order i.e., sorted in an ascending order.
Input 1:
    A = [1, 2, 3]
Output 1:
    [1, 3, 2]
Input 2:
    A = [3, 2, 1]
Output 2:
    [1, 2, 3]
Input 3:
    A = [1, 1, 5]
Output 3:
    [1, 5, 1]
Input 4:
    A = [20, 50, 113]
Output 4:
    [20, 113, 50] */
    
    
class Solution {
    public List<int> nextPermutation(List<int> A) {
        
        //158476531 
        int index= -1;
        int n = A.Count;
        for(int i = n-1;i>0;i--){
            if(A[i]>A[i-1]){
                index = i;
                break;
            }
        }
        if(index==-1){
            A.Reverse();
            return A;
        }
        //index = 7, num =4
        int num = A[index-1];
        int nextgreaterindex = index;
        for(int i = index;i<n;i++){
            if(A[i]>num && A[i]<=A[nextgreaterindex]){
                nextgreaterindex = i;
            }
        }
        //swapping of 4 and 5
        int temp = A[nextgreaterindex];
        A[nextgreaterindex] = A[index-1];
        A[index-1] = temp;
        //158576431
        A.Reverse(index,n-index);
        //158513467
        return A;
    }
}

