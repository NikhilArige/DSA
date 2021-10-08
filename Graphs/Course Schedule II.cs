/*
There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1.
You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.
For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
Return the ordering of courses you should take to finish all courses. If there are many valid answers,
return any of them. If it is impossible to finish all courses, return an empty array.
Example 1:
Input: numCourses = 2, prerequisites = [[1,0]]
Output: [0,1]
Explanation: There are a total of 2 courses to take. To take course 1 you should have finished course 0. So the correct course order is [0,1].
Example 2:
Input: numCourses = 4, prerequisites = [[1,0],[2,0],[3,1],[3,2]]
Output: [0,2,1,3]
Explanation: There are a total of 4 courses to take. To take course 3 you should have finished both courses 1 and 2. 
Both courses 1 and 2 should be taken after you finished course 0.
So one correct course order is [0,1,2,3]. Another correct ordering is [0,2,1,3].
*/

public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        
    var map = new Dictionary<int,List<int>>();
        for(int i=0;i<numCourses;i++){
            map.Add(i,new List<int>());
        }
        for(int i=0;i<prerequisites.Length;i++){
            map[prerequisites[i][0]].Add(prerequisites[i][1]);
        }
        
        int[] res = new int[numCourses];
        
        int[] visited = new int[numCourses];
        int ind=0;
        // 0 not visited || 1 visited & in-Stack || -1 visited and out of Stack
        foreach(var kvp in map){
            if(visited[kvp.Key]==0){
                if(DetectCycleUsingDFS(map, kvp.Key,ref ind, visited,res)){
                     return new int[0];
                }
            }
        }
        return res;
    }
    
    bool DetectCycleUsingDFS(Dictionary<int,List<int>> map, 
                             int start,ref int i, int[] visited,int[] res)
    {
        visited[start]=1;   // 1 visited & in-Stack
        
        foreach(var adjacentVertex in map[start])
            // 0 not visited, cheeck for cycle
            if(visited[adjacentVertex]==0 && DetectCycleUsingDFS(map,adjacentVertex,ref i, visited,res))
                return true;
            // cycle found return true
            else if(visited[adjacentVertex]==1)
                return true;
        visited[start]=-1;//-1 visited and out of Stack
        res[i++] = start;
        return false;
    }
}
