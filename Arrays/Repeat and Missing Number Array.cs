//You are given a read only array of n integers from 1 to n.
//Each integer appears exactly once except A which appears twice and B which is missing.
//Return A and B.
//Note: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
//Note that in your output A should precede B.


class Solution {
    //need to take everything as long
    public List<int> repeatedNumber(List<int> A) {
        long n = A.Count;
        long Sum_N = n * (n + 1L) / 2L;
        long Sum_NSq = n * (n + 1L) *  (2L * n + 1L) / 6L;
        long missingNumber = 0, repeating = 0;
        for (int i = 0; i < n; i++) 
        {
            Sum_N -= (long)A[i];
            Sum_NSq -= (long)(A[i]) * (long)(A[i]);
        }
        missingNumber = (Sum_N + Sum_NSq /Sum_N) / 2L;
        repeating = missingNumber - Sum_N;
        List<int> ans = new List<int>();
        ans.Add(((int)repeating));
        ans.Add((int)missingNumber);
        return ans;
    }
}
