//Given a string A, partition A such that every substring of the partition is a palindrome.
//Return the minimum cuts needed for a palindrome partitioning of A.


class Solution {
    public int minCut(string a) {
        int[] cut = new int[a.Length];
        bool[,] palindrome = new bool[a.Length, a.Length]; 
        // we can calculate the minimum cut while finding all palindromic substring. 
        //If we find all palindromic substring 1st and then we calculate minimum cut, time complexity will reduce to O(n2). 
        for (int i = 0; i < a.Length; i++)
        {
            int minCut = i;
            for (int j = 0; j <= i; j++)
            {
                if (a[i] == a[j] && (i - j < 2 ||
                                     palindrome[j + 1, i - 1]))
                {
                    palindrome[j, i] = true;
                    minCut = Math.Min(minCut, j == 0 ? 0 : (cut[j - 1] + 1));
                }
            }
            cut[i] = minCut;
        }
        return cut[a.Length - 1];
    }
}
