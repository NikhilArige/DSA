//Given an one-dimensional unsorted array A containing N integers.
//You are also given an integer B, find if there exists a pair of elements in the array whose difference is B.
//Return 1 if any such pair exists else return 0.
// A = [-10, 20] B = 30   Pair (20, -10) gives a difference of 30 i.e 20 - (-10) => 20 + 10 => 30


class Solution {
    public int solve(List<int> A, int B) {
        int sum = 0;
        int n = A.Count;
        A.Sort();
         int i = 0, j = 0;             //both starts from beginning
        while (i < n && j < n)
        {
            if (i != j && A[j] - A[i] == B)
            { 
                return 1;
            }
            else if (A[j] - A[i] < B)
                j++;                  //no decrementing
            else
                i++;
        }
        return 0;
    }
}
