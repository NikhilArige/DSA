//Given a sorted array A containing N integers both positive and negative.
//You need to create another array containing the squares of all the elements in A and return it in non-decreasing order.Try to this in O(N) time.
//A = [-6, -3, -1, 2, 4, 5]  Output :[1, 4, 9, 16, 25, 36]


class Solution {
    public List<int> solve(List<int> A) {
        int n = A.Count;
        int l = 0;
        int r = n-1;
        int[] resultarray = new int[n];
        for(int i = n-1;i>=0;i--){
            if(Math.Abs(A[l])>A[r]){
            resultarray[i]=A[l]*A[l];
            l++;
            }
            else{
                resultarray[i]=A[r]*A[r];
            r--;
            } 
        }
        List<int> result = new List<int>();
        for(int i =0;i<n;i++){
            result.Add(resultarray[i]);
        } 
        return result;
    }
}
