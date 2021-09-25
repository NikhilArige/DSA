/*
You are given two lists of closed intervals, firstList and secondList, where firstList[i] = [starti, endi] and secondList[j] = [startj, endj]. Each list of intervals is pairwise disjoint and in sorted order.
Return the intersection of these two interval lists.
A closed interval [a, b] (with a <= b) denotes the set of real numbers x with a <= x <= b.
The intersection of two closed intervals is a set of real numbers that are either empty or represented as a closed interval. 
For example, the intersection of [1, 3] and [2, 4] is [2, 3].
Example 1:
Input: firstList = [[0,2],[5,10],[13,23],[24,25]], secondList = [[1,5],[8,12],[15,24],[25,26]]
Output: [[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]
Example 2:
Input: firstList = [[1,3],[5,9]], secondList = []
Output: []
Example 3:
Input: firstList = [], secondList = [[4,8],[10,12]]
Output: []
Example 4:
Input: firstList = [[1,7]], secondList = [[3,10]]
Output: [[3,7]]
*/

public class Solution {
    public int[][] IntervalIntersection(int[][] a, int[][] b) {
            
            var res = new List<int[]>();

            int i = 0;
            int j = 0;

            while (i != a.Length && j != b.Length)
            {
                var intervalA = a[i];
                var intervalB = b[j];

                if (intervalB[0] > intervalA[1])
                {
                    i++;
                    continue;
                }

                if (intervalB[1] < intervalA[0])
                {
                    j++;
                    continue;
                }

                res.Add(new int[]
                {
                    Math.Max(intervalA[0], intervalB[0]),
                    Math.Min(intervalA[1], intervalB[1])
                });

                if (intervalA[1] < intervalB[1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return res.ToArray();
    }
}
