/* Given two integer arrays nums1 and nums2, return an array of their intersection. 
Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
Example 1:
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]
Example 2:
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Explanation: [9,4] is also accepted. */


public class Solution {
    public int[] Intersect(int[] A, int[] B) {
        
        int m = A.Length;
        int n = B.Length;
        Array.Sort(A);
        Array.Sort(B);
        var res = new List<int>();
         int i = 0, j = 0;
        while (i < m && j < n) {
            if (A[i] < B[j])
                i++;
            else if (B[j] < A[i])
                j++;
            else {
                res.Add(B[j++]);
                i++;
            }
        }
        return res.ToArray();
    }
}
