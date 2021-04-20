/*You are given an array (zero indexed) of N non-negative integers, A0, A1 ,…, AN-1.
Find the minimum sub array Al, Al+1 ,…, Ar so if we sort(in ascending order) that sub array, then the whole array should get sorted.
If A is already sorted, output -1.
Example :
Input 1:
A = [1, 3, 2, 4, 5]
Return: [1, 2]
Input 2:
A = [1, 2, 3, 4, 5]
Return: [-1] */


class Solution {
    public List<int> subUnsort(List<int> A) {
        
        int n = A.Count;
        int left = -1;
        int right = -1;
        for(int i=0;i<n-1;i++){
            if(A[i]>A[i+1]){
                left = i; 
                break;
            }
        }
        
        for(int i=n-1;i>0;i--){
            if(A[i]<A[i-1]){
                right = i; 
                break;
            }
        } 
        List<int> result = new List<int>();
         if(left == -1 && right == -1 ){
            result.Add(-1);
            return result;
        } 
        int min=int.MaxValue;
        int max=int.MinValue; 
        for(int i=left;i<=right;i++){
          min=Math.Min(min,A[i]);
          max=Math.Max(max,A[i]);
        } 
        //expanding left side
        for(int i=0;i<left;i++){
            if(A[i]>min){
                left = i; 
                break;
            }
        }
          
        //expanding right side
        for(int i=n-1;i>=right+1;i--){
            if(A[i]<max){
                right = i; 
                break;
            }
        } 
        result.Add(left);
        result.Add(right);
        return result;
        
    }
}
