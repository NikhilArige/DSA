/*
Given an array intervals where intervals[i] = [li, ri] represent the interval [li, ri), remove all intervals that are covered by another interval in the list.
The interval [a, b) is covered by the interval [c, d) if and only if c <= a and b <= d.
Return the number of remaining intervals.
Example 1:
Input: intervals = [[1,4],[3,6],[2,8]]
Output: 2
Explanation: Interval [3,6] is covered by [2,8], therefore it is removed.
Example 2:
Input: intervals = [[1,4],[2,3]]
Output: 1
Constraints:
1 <= intervals.length <= 1000
intervals[i].length == 2
0 <= li <= ri <= 105
All the given intervals are unique.
*/
      
      
public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
     
        if (intervals.Length == 0){
                return 0;
        }
        int res = 0;
        //ascending start and descending end
        Array.Sort(intervals, (i1, i2) =>  i1[0] != i2[0] ? i1[0].CompareTo(i2[0]) : i2[1].CompareTo(i1[1])); 
        
        int i = 0,end = 0;
        while(i < intervals.Length){
           
            if(intervals[i][1] > end){
                res ++;
                end = intervals[i][1];
            }
            i++;
        } 
        return res;
    }
}      
