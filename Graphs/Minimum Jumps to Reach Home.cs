/*
A certain bug's home is on the x-axis at position x. Help them get there from position 0.
The bug jumps according to the following rules:
It can jump exactly a positions forward (to the right).
It can jump exactly b positions backward (to the left).
It cannot jump backward twice in a row.
It cannot jump to any forbidden positions.
The bug may jump forward beyond its home, but it cannot jump to positions numbered with negative integers.
Given an array of integers forbidden, where forbidden[i] means that the bug cannot jump to the position forbidden[i], and integers a, b, and x, 
return the minimum number of jumps needed for the bug to reach its home. If there is no possible sequence of jumps that lands the bug on position x, return -1.
Example 1:
Input: forbidden = [14,4,18,1,15], a = 3, b = 15, x = 9
Output: 3
Explanation: 3 jumps forward (0 -> 3 -> 6 -> 9) will get the bug home.
Example 2:
Input: forbidden = [8,3,16,6,12,20], a = 15, b = 13, x = 11
Output: -1
Example 3:
Input: forbidden = [1,6,2,14,5,17,4], a = 16, b = 9, x = 7
Output: 2
Explanation: One jump forward (0 -> 16) then one jump backward (16 -> 7) will get the bug home.
*/

public class Solution {
    public int MinimumJumps(int[] forbidden, int a, int b, int x) {
        
        var map = new HashSet<int>(forbidden);
        var set = new HashSet<(int,bool)>();
        var count = 0;
        var q = new Queue<(int,bool)>();
        q.Enqueue((0,false));
        set.Add((0,false));
        var max = Math.Max(x,forbidden.Max()) + 2* a + b;
        while(q.Any()){
            var cnt = q.Count; 
            while(cnt-- > 0){
                var cur = q.Dequeue();
                if(cur.Item1 == x){
                    return count;
                } 
                var right = cur.Item1-b;
                var left = cur.Item1+a;
                if(left > 0  && left < max && !map.Contains(left) && !set.Contains((left,false))){
                    q.Enqueue((left,false));
                    set.Add((left,false));
                }
                if(!cur.Item2 && right > 0  && right < max && !map.Contains(right) && !set.Contains((right,true))){
                    q.Enqueue((right,true));                    
                    set.Add((right,true));
                } 
            }
            
            count++;
        }
        return -1;
    }
}
