/*
Given an array of intervals intervals where intervals[i] = [starti, endi], return the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.
Example 1:
Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
Output: 1
Explanation: [1,3] can be removed and the rest of the intervals are non-overlapping.
Example 2:
Input: intervals = [[1,2],[1,2],[1,2]]
Output: 2
Explanation: You need to remove two [1,2] to make the rest of the intervals non-overlapping.
*/

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if (intervals.Length == 0)
            {
                return 0;
            }
            Array.Sort(intervals, (i1, i2) =>
            {
                var cmpEnd = i1[1].CompareTo(i2[1]);
                if (cmpEnd != 0)
                {
                    return cmpEnd;
                }
                return i1[0].CompareTo(i2[0]);
            });
            int i = 0;
            int j = 1;
            int res = 0;
            while (i < intervals.Length)
            {
                int to = intervals[i][1];
                while (j < intervals.Length && intervals[j][0] < to)
                {
                    j++;
                    res++;
                }
                i = j;
                j = i + 1;
            }
            return res;
    }
}
