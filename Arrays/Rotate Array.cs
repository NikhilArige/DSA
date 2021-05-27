/* Given an array, rotate the array to the right by k steps, where k is non-negative.
Example 1:
Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:
Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100] */

public class Solution {
    public void Rotate(int[] A, int k) {
        
        int n = A.Length;
        k = k % n;
        reverse(A,0,n-1);
        reverse(A,0,k-1);
        reverse(A,k,n-1);
        
    }
    
    private void reverse(int[] A,int start, int end){
        while (start < end) {
            int temp = A[start];
            A[start] = A[end];
            A[end] = temp;
            start++;
            end--;
        }
    }
}

//getting TLE for this 
public class Solution {
    public void Rotate(int[] A, int k) {
        
        int n = A.Length;
        k = k % n;
        int gcd = g_c_d(k,n);
        
     //   for(int i=0;i<gcd;i++){    //left rotate
        for(int i=n-1;i>=gcd;i--){   //right rotate 
            int temp = A[i];
            int j = i ;
             while (true) {
                int d = j + k;
                if (d >= n){
                   d = d - n;
                }
                if (d == i){
                    break;
                }
                A[j] = A[d];
                j = d;
            }
            A[j] = temp;
        }
    }
    
    private int g_c_d(int a, int b){
        
        if(b==0){
            return a;
        }
        return g_c_d(b,a % b);
    }
}

