/* Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
You may assume that the intervals were initially sorted according to their start times.
Example 1:
Given intervals [1,3],[6,9] insert and merge [2,5] would result in [1,5],[6,9].
Example 2:
Given [1,2],[3,5],[6,7],[8,10],[12,16], insert and merge [4,9] would result in [1,2],[3,10],[12,16].
This is because the new interval [4,9] overlaps with [3,5],[6,7],[8,10].
Make sure the returned intervals are also sorted. */


/**
 * Definition for an interval.
 * public class Interval {
 *     int start;
 *     int end;
 *     Interval() { start = 0; end = 0; }
 *     Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public List<Interval> insert(List<Interval> intervals, Interval newInterval) {
        
        if(intervals == null) {
             intervals = new List<Interval>();
             intervals.add(newInterval);
             return intervals;
         }
         
         else if(intervals.Count == 0){
             intervals.add(newInterval);
             return intervals;
         }
         
         Interval toInsert = newInterval;
         
         
         int i = 0;
         while(i < intervals.Count){
             
             Interval current = intervals[i]);
             // Case 1: The intervals have not crossed each other
             if(current.end < toInsert.start){
                 i++;
                 continue;
             }
            // Case 2: The intervals have crossed each other and the new interval can be inserted.
             else if(toInsert.end < current.start){
                 intervals.Insert(i, toInsert);
                 break;
             }
            // Case 3: The intervals overlapping each other
             else{
                 toInsert.start = Math.Min(toInsert.start, current.start);
                 toInsert.end = Math.Max(toInsert.end, current.end);
                 intervals.RemoveAt(i);
             }
         }
         // Case 4: Last case when i reaches end
         if(i == intervals.Count){
             intervals.Add(toInsert);
         }
             return intervals;
    }
}
