//Given an integer array A of size N.You can pick B elements from either left or right end of the array A to get maximum sum.
//Find and return this maximum possible sum.
//NOTE: Suppose B = 4 and array A contains 10 elements then:
//You can pick first four elements or can pick last four elements or can pick 1 from front and 3 from back etc . you need to return the maximum possible sum of elements you can pick.
//A = [5, -2, 3 , 1, 2] B = 3 Output : 8
//Explanation : Pick element 5 from front and element (1, 2) from back so we get 5 + 1 + 2 = 8

class Solution {
    public int solve(List<int> A, int B) {
 
    int cur  = 0;
    int max  = 0;
    for(int i = 0; i < B; i++){
        cur += A[i]; 
    } 
    max = cur; 
    //first from last  
    int j = A.Count - 1;
 
    for(int i = B - 1; i >= 0; i--)
    {
        cur = cur +  A[j] - A[i];
        max = Math.Max(cur,
                              max);
        j--;
    } 
    return max;
    }
  
}
