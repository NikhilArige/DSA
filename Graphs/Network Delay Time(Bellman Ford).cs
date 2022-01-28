/*
You are given a network of n nodes, labeled from 1 to n. You are also given times, a list of travel times as directed edges times[i] = (ui, vi, wi), 
where ui is the source node, vi is the target node, and wi is the time it takes for a signal to travel from source to target.
We will send a signal from a given node k. Return the time it takes for all the n nodes to receive the signal. 
If it is impossible for all the n nodes to receive the signal, return -1.
Example 1:
Input: times = [[2,1,1],[2,3,1],[3,4,1]], n = 4, k = 2
Output: 2
Example 2:
Input: times = [[1,2,1]], n = 2, k = 1
Output: 1
Example 3:
Input: times = [[1,2,1]], n = 2, k = 2
Output: -1
*/

public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        
        var map = new Dictionary<int,int>();
        for(int i=1;i<=n;i++){
            map.Add(i,int.MaxValue);
        }
        map[k] = 0;
        for(int i=0;i<n-1;i++){
            bool isRelaxed = false;
            foreach(var time in times){
                var u = time[0];
                var v = time[1];
                var t = time[2];
                if(map[u] != int.MaxValue && map[v] > map[u] + t){
                    map[v] = map[u] + t;
                    isRelaxed = true;
                }
            }
            if(!isRelaxed){
                break;
            }
        }
        var max = map.Values.Max();
        return max == int.MaxValue ? -1 : max;
    }
}
