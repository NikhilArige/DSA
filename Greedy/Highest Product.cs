//Given an array A, of N integers A.
//Return the highest product possible by multiplying 3 numbers from the array.
//Input :A = [0, -1, 3, 100, 70, 50] Output :350000   Explanation :70 * 50 * 100 = 350000

class Solution {
    public int maxp3(List<int> A) { 
        A.Sort();
        int n = A.Count;
        int posmax = A[n-1]*A[n-2]*A[n-3];
        int negmax = A[0]*A[1]*A[n-1];
        return Math.Max(posmax,negmax);   
    }
}

//or
//Take max 3 and min 2 by traversing and do
