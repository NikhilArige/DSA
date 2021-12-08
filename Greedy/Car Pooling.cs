/*
There is a car with capacity empty seats. The vehicle only drives east (i.e., it cannot turn around and drive west).
You are given the integer capacity and an array trips where trip[i] = [numPassengersi, fromi, toi] indicates 
that the ith trip has numPassengersi passengers and the locations to pick them up and drop them off are fromi and toi respectively. The locations are given as the number of kilometers due east from the car's initial location.
Return true if it is possible to pick up and drop off all passengers for all the given trips, or false otherwise.
Example 1:
Input: trips = [[2,1,5],[3,3,7]], capacity = 4
Output: false
Example 2:
Input: trips = [[2,1,5],[3,3,7]], capacity = 5
Output: true
Example 3:
Input: trips = [[2,1,5],[3,5,7]], capacity = 3
Output: true
Example 4:
Input: trips = [[3,2,7],[3,7,9],[8,3,9]], capacity = 11
Output: true
Constraints:
1 <= trips.length <= 1000
trips[i].length == 3
1 <= numPassengersi <= 100
0 <= fromi < toi <= 1000
1 <= capacity <= 105
*/

public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        
        var added = new int[1001];
        foreach(var trip in trips)
        {
            var seats = trip[0];
            added[trip[1]] += seats;
            added[trip[2]] -= seats;
        }
        foreach(var addition in added)
        {
            capacity -= addition;
            if(capacity < 0){
               return false;  
            }
        }
        return true;
        
        
//not working because of duplicates in sortedset        
//         var comparer = Comparer<int[]>.Create((a,b)=>
//                                              a[1].CompareTo(b[1]));
//         var set = new SortedSet<int[]>(comparer);
//         foreach(var item in trips){
//             set.Add(item);
//         }
//         var cap = 0;
//         var comparertwo = Comparer<(int dest,int cap)>.Create((a,b)=>
//                                              a.dest.CompareTo(b.dest));
//         var q = new SortedSet<(int dest,int cap)>(comparertwo);
//         foreach(var item in set){
//             cap += item[0];
//             if(q.Count>0){
//                while(q.Count > 0 && q.Min.dest <= item[1]) {
//                    Console.WriteLine(q.Min);
//                    cap -= q.Min.cap;
//                    q.Remove(q.Min);
//                }
//                 Console.WriteLine(q.Min);
//             }
//             q.Add((item[2],item[0])); 
//             if(cap > capacity){
//                 return false;
//             }
//         }
        
//         return true;
    }
}
