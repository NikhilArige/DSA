/*
There are n cities. Some of them are connected, while some are not. If city a is connected directly with city b, and city b is connected directly with city c, 
then city a is connected indirectly with city c.
A province is a group of directly or indirectly connected cities and no other cities outside of the group.
You are given an n x n matrix isConnected where isConnected[i][j] = 1 if the ith city and the jth city are directly connected, and isConnected[i][j] = 0 otherwise.
Return the total number of provinces.
Example 1:
Input: isConnected = [[1,1,0],[1,1,0],[0,0,1]]
Output: 2
Example 2:
Input: isConnected = [[1,0,0],[0,1,0],[0,0,1]]
Output: 3
*/

public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        var visited = new bool[isConnected.Length];
        int cnt = 0;
        for(int i=0;i<isConnected.Length;i++){
            if(!visited[i]){
                visited[i] = true;
                dfs(isConnected,visited,i);
                cnt++;
            }
        }
        return cnt;
    }
    
    void dfs(int[][] M,bool[] visited,int row){
        for(int i=0;i<M.Length;i++){
            if(M[row][i]==1 && !visited[i]){
                visited[i] = true;
			    dfs(M, visited,i);
            }
        }
    }
}
