/*
There are n computers numbered from 0 to n - 1 connected by ethernet cables connections forming a network where connections[i] = [ai, bi] 
represents a connection between computers ai and bi. Any computer can reach any other computer directly or indirectly through the network.
You are given an initial computer network connections. You can extract certain cables between two directly connected computers, 
and place them between any pair of disconnected computers to make them directly connected.
Return the minimum number of times you need to do this in order to make all the computers connected. If it is not possible, return -1.
Example 1:
Input: n = 4, connections = [[0,1],[0,2],[1,2]]
Output: 1
Explanation: Remove cable between computer 1 and 2 and place between computers 1 and 3.
Example 2:
Input: n = 6, connections = [[0,1],[0,2],[0,3],[1,2],[1,3]]
Output: 2
Example 3:
Input: n = 6, connections = [[0,1],[0,2],[0,3],[1,2]]
Output: -1
Explanation: There are not enough cables.
*/

public class Solution {
    public int MakeConnected(int n, int[][] connections) {
        
        int count = -1 ;
        if(connections.Length < n-1){
            return count;
        }
        var map = new Dictionary<int,List<int>>();
        for(int i=0;i<n;i++){
            map.Add(i,new List<int>());
        }
        foreach(var connection in connections){
            map[connection[0]].Add(connection[1]);
            map[connection[1]].Add(connection[0]);
        }
        var visited = new HashSet<int>();
        foreach(var item in map){
            if(!visited.Contains(item.Key)){
                DFS(item.Key,visited,map);
                count++;
            }
        }
        return count;
    }
    
    void DFS(int key,HashSet<int> visited,Dictionary<int,List<int>> map){
       
        visited.Add(key);
        foreach(var item in map[key]){
            if(!visited.Contains(item)){
                DFS(item,visited,map);
            }
        }
    }
}
