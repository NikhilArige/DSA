/*
You are given a map of a server center, represented as a m * n integer matrix grid, where 1 means that on that cell there is a server and 0 means that it is no server. 
Two servers are said to communicate if they are on the same row or on the same column.
Return the number of servers that communicate with any other server.
Example 1:
Input: grid = [[1,0],[0,1]]
Output: 0
Explanation: No servers can communicate with others.
Example 2:
Input: grid = [[1,0],[1,1]]
Output: 3
Explanation: All three servers can communicate with at least one other server.
Example 3:
Input: grid = [[1,1,0,0],[0,0,1,0],[0,0,1,0],[0,0,0,1]]
Output: 4
Explanation: The two servers in the first row can communicate with each other. The two servers in the third column can communicate with each other. 
The server at right bottom corner can't communicate with any other server.
*/

public class Solution {
    public int CountServers(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int count = 0;
        var set = new HashSet<int>(); 
        for(int i=0;i<m;i++){
             int temp = 0;
            for(int j=0;j<n;j++){
                if(grid[i][j] == 1){
                   temp++;
                }
            }
            if(temp>1){
                    count+=temp;
                    set.Add(i);
                }
        }
        for(int j=0;j<n;j++){
            int temp = 0;
            int setCount = 0;
            for(int i=0;i<m;i++){
                if(grid[i][j] == 1 ){
                   temp++;
                   if(set.Contains(i)){
                       setCount++;
                   } 
                }
            }
             if(temp>1){
                    count+=(temp-setCount);
                }
        }
        return count;
    }
}
