//You are given an array of N integers, A1, A2 ,…, AN. Return maximum value of f(i, j) for all 1 ≤ i, j ≤ N.
//f(i, j) is defined as |A[i] - A[j]| + |i - j|, where |x| denotes absolute value of x.
//For example, A=[1, 3, -1]
//f(1, 1) = f(2, 2) = f(3, 3) = 0
//f(1, 2) = f(2, 1) = |1 - 3| + |1 - 2| = 3
//f(1, 3) = f(3, 1) = |1 - (-1)| + |1 - 3| = 4
//f(2, 3) = f(3, 2) = |3 - (-1)| + |2 - 3| = 5


class Solution {
    public int maxArr(List<int> A) {
        
        int max1 = int.MinValue ;
        int min1 = int.MaxValue ;
        int max2 = int.MinValue ;
        int min2 = int.MaxValue ;
  
        for (int i = 0; i < A.Count; i++)
        { 
            max1 = Math.Max(max1, A[i] + i);
            min1 = Math.Min(min1, A[i] + i);
            max2 = Math.Max(max2, A[i] - i);
            min2 = Math.Min(min2, A[i] - i); //or -A[i]+i ...
        }
   
        return Math.Max(max1 - min1, max2 - min2);
    }
}
