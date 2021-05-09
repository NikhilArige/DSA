/*Given a collection of intervals, merge all overlapping intervals.
For example:
Given [1,3],[2,6],[8,10],[15,18],
return [1,6],[8,10],[15,18].
Make sure the returned intervals are sorted. */


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
    public List<Interval> merge(List<Interval> intervals) {
        
           if(intervals.Count == 1 || intervals.Count == 0){
               return intervals;
           }  
           // Sorting the intervals according to their starting point 
            intervals.Sort(delegate(Interval c1, Interval c2) { return c1.start.CompareTo(c2.start); });
	       //or	intervals = intervals.OrderBy(x=>x.start).ToList();
         int i = 0;
   
          while( i < intervals.Count - 1) {
              if(intervals[i].end >= intervals[i+1].start ) {
                   intervals[i].end  = Math.Max(intervals[i].end , intervals[i+1].end);
                   intervals.RemoveAt(i+1);
              }
             else 
                 i++; 
          } 
       return intervals;
    }
}
